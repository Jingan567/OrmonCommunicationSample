using System;
using System.Collections.Generic;
using System.Threading;

using OMRON.Compolet.CIP;

namespace ReadVariableSample
{
    /// <summary>
    /// Samples for maintaining connection survival.
    /// </summary>
    /// <remarks>
    /// This program is an implementation example to prevent Class 3 from being disconnected after a certain time.
    /// </remarks>
    public class KeepAliveSample : IDisposable
    {
        /// <summary>
        /// The Information of used by DoWork method .
        /// </summary>
        public class DeviceInfo
        {
            public DeviceInfo(string ipAddress, IEnumerable<string> variableNames, int intervalMilliseconds, int receiveTimeoutMilliseconds)
            {
                IpAddress = ipAddress;
                VariableNames = variableNames;
                IntervalMilliseconds = intervalMilliseconds;
                ReceiveTimeoutMilliseconds = receiveTimeoutMilliseconds;
            }

            public readonly string IpAddress;
            public readonly IEnumerable<string> VariableNames;
            public readonly int IntervalMilliseconds;
            public readonly int ReceiveTimeoutMilliseconds;
        }

        /// <summary>
        /// Asynchronous processing status type.
        /// </summary>
        public enum MonitoringStatusType
        {
            /// <summary>
            /// Stopped state.
            /// </summary>
            Stop = 0,

            /// <summary>
            /// Running state.
            /// </summary>
            Run = 1,

            /// <summary>
            /// State to stop from running.
            /// </summary>
            Stopping = 2,
        }

        /// <summary>
        /// Current asynchronous processing status.
        /// </summary>
        public MonitoringStatusType MonitorStatus { get { return monitorStatus; } }

        /// <summary>
        /// Start asynchronous processing.
        /// </summary>
        /// <param name="deviceInfos"></param>
        public void RunWorkerAsync(List<DeviceInfo> deviceInfos)
        {
            lock (syncMonitorStatus)
            {
                switch (monitorStatus)
                {
                    case MonitoringStatusType.Run:
                        return;

                    case MonitoringStatusType.Stopping:
                        throw new InvalidOperationException();
                }

                monitorStatus = MonitoringStatusType.Run;
                foreach (DeviceInfo deviceInfo in deviceInfos)
                {
                    Thread th = new Thread(new ParameterizedThreadStart(StartWork));
                    th.IsBackground = true;
                    th.Start(deviceInfo);
                }
            }
        }

        /// <summary>
        /// Stop asynchronous processing.
        /// </summary>
        public void CancelAsync()
        {
            lock (syncMonitorStatus)
            {
                if (monitorStatus == MonitoringStatusType.Run)
                {
                    monitorStatus = MonitoringStatusType.Stopping;
                }
            }
        }

        /// <summary>
        /// Asynchronous thread function.
        /// </summary>
        /// <param name="args"></param>
        private void StartWork(object args)
        {
            Interlocked.Increment(ref countOfWorker);
            try
            {
                DoWork(args as DeviceInfo);
            }
            finally
            {
                Interlocked.Decrement(ref countOfWorker);
                lock (syncMonitorStatus)
                {
                    if (Interlocked.Read(ref countOfWorker) < 1)
                    {
                        monitorStatus = MonitoringStatusType.Stop;
                    }
                }
            }
        }

        /// <summary>
        /// Create and initialize compolet.
        /// </summary>
        /// <param name="deviceInfo"></param>
        /// <returns></returns>
        private static CommonCompolet CreateCompolet(DeviceInfo deviceInfo)
        {
            CommonCompolet compolet = new CommonCompolet();
            compolet.PeerAddress = deviceInfo.IpAddress;
            compolet.LocalPort = 2;
            compolet.ConnectionType = ConnectionType.Class3;
            compolet.ReceiveTimeLimit = deviceInfo.ReceiveTimeoutMilliseconds;
            return compolet;
        }

        private MonitoringStatusType monitorStatus = MonitoringStatusType.Stop;
        private readonly object syncMonitorStatus = new object();
        private long countOfWorker = 0;

        #region Dispose pattern

        ~KeepAliveSample()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this.monitorStatus == MonitoringStatusType.Run)
                CancelAsync();

            while (this.monitorStatus != MonitoringStatusType.Stop)
                Thread.Sleep(10);
        }

        #endregion //Dispose pattern

        #region Event of ReadVariable result.

        /// <summary>
        /// The information of success result.
        /// </summary>
        public class NotifyReadVariableSuccessArgs : EventArgs
        {
            public NotifyReadVariableSuccessArgs(string ipAddress, string variableName, string value)
            {
                this.IpAddress = ipAddress;
                this.VariableName = variableName;
                this.Value = value;
            }

            public readonly string IpAddress;
            public readonly string VariableName;
            public readonly string Value;
        }

        /// <summary>
        /// Event of success.
        /// </summary>
        public event EventHandler<NotifyReadVariableSuccessArgs> NotifyReadVariableSuccess;

        /// <summary>
        /// OnNotifyReadVariableSuccess
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="variableName"></param>
        /// <param name="value"></param>
        private void OnNotifyReadVariableSuccess(string ipAddress, string variableName, string value)
        {
            if (NotifyReadVariableSuccess != null)
            {
                NotifyReadVariableSuccess(ipAddress, new NotifyReadVariableSuccessArgs(ipAddress, variableName, value));
            }
        }

        /// <summary>
        /// The information of error result.
        /// </summary>
        public class NotifyReadVariableErrorArgs : System.EventArgs
        {
            public NotifyReadVariableErrorArgs(string ipAddress, string variableName, Exception e, DateTime startTime, DateTime errorOccuredTime)
            {
                this.IpAddress = ipAddress;
                this.VariableName = variableName;
                this.OccuredException = e;
                this.StartTime = startTime;
                this.ErrorOccuredTime = errorOccuredTime;
            }

            public readonly string IpAddress;
            public readonly string VariableName;
            public readonly Exception OccuredException;
            public readonly DateTime StartTime;
            public readonly DateTime ErrorOccuredTime;
        }

        /// <summary>
        /// Event of error.
        /// </summary>
        public event EventHandler<NotifyReadVariableErrorArgs> NotifyReadVariableError;

        /// <summary>
        /// OnNotifyReadVariableError
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="variableName"></param>
        /// <param name="e"></param>
        /// <param name="startTime"></param>
        /// <param name="errorOccuredTime"></param>
        private void OnNotifyReadVariableError(string ipAddress, string variableName, Exception e, DateTime startTime, DateTime errorOccuredTime)
        {
            if (NotifyReadVariableError != null)
            {
                NotifyReadVariableError(ipAddress, new NotifyReadVariableErrorArgs(ipAddress, variableName, e, startTime, errorOccuredTime));
            }
        }

        #endregion //Event of ReadVariable error.

        #region KeepAlive

        public event EventHandler NotifyKeepAlive;

        private KeepAliveWorker currentKeepAlive;
        private readonly object syncKeepAliveObject = new object();
        private readonly Dictionary<CommonCompolet, object> keepAliveTargets = new Dictionary<CommonCompolet, object>(); // It is better to use HashSet if it is more than .NET Framework 4.0

        private class KeepAliveWorker
        {
            public KeepAliveWorker(KeepAliveSample sender)
            {
                caller = sender;
            }

            public void Execute()
            {
                if (status == StatusType.Init)
                {
                    Thread th = new Thread(new ThreadStart(this.KeepAliveProc));
                    th.IsBackground = true;
                    th.Start();
                    status = StatusType.Execute;
                }
            }         

            public void RequestCancel()
            {
                if (status == StatusType.Execute)
                {
                    status = StatusType.Cancelling;
                }
            }

            private enum StatusType
            {
                Init,
                Execute,
                Cancelling,
            }

            private KeepAliveSample caller;
            private StatusType status = StatusType.Init;

            /// <summary>
            /// KeepAlive thread processing.
            /// </summary>
            private void KeepAliveProc()
            {
                while (status == StatusType.Execute)
                {
                    CommonCompolet[] compolets;
                    lock (caller.syncKeepAliveObject)
                    {
                        compolets = new CommonCompolet[caller.keepAliveTargets.Keys.Count];
                        caller.keepAliveTargets.Keys.CopyTo(compolets, 0);
                    }

                    Thread.Sleep(10);
                    foreach (CommonCompolet compolet in compolets)
                    {
                        if (status != StatusType.Execute) break;

                        bool needUpdate = false;
                        DateTime latestExecuteTime;
                        lock (caller.syncKeepAliveObject)
                        {
                            latestExecuteTime = compolet.LatestExecuteTime;
                            if ((latestExecuteTime != DateTime.MinValue)
                                && (5000 < (DateTime.Now - latestExecuteTime).TotalMilliseconds))
                            {
                                needUpdate = true;
                            }
                        }

                        if (!needUpdate) continue;

                        try
                        {
                            lock (compolet)
                            {
                                compolet.ExecuteCommunication();
                            }

                            if (caller.NotifyKeepAlive != null && latestExecuteTime < compolet.LatestExecuteTime)
                            {
                                caller.NotifyKeepAlive(compolet, EventArgs.Empty);
                            }
                        }
                        catch
                        {
                            // do nothing.
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Start keep alive for compolet.
        /// </summary>
        /// <param name="compolet"></param>
        private void StartKeepAlive(CommonCompolet compolet)
        {
            lock (syncKeepAliveObject)
            {
                keepAliveTargets.Add(compolet, null);
                if (currentKeepAlive == null)
                {
                    currentKeepAlive = new KeepAliveWorker(this);
                    currentKeepAlive.Execute();
                }
            }
        }

        /// <summary>
        /// Stop keep alive for compolet.
        /// </summary>
        /// <param name="compolet"></param>
        private void StopKeepAlive(CommonCompolet compolet)
        {
            lock (syncKeepAliveObject)
            {
                keepAliveTargets.Remove(compolet);
                if (keepAliveTargets.Count < 1 && currentKeepAlive != null)
                {
                    currentKeepAlive.RequestCancel();
                    currentKeepAlive = null;
                }
            }
        }

        #endregion //KeepAlive

        private readonly object syncOpenObject = new object();

        /// <summary>
        /// Asynchronous processing.
        /// </summary>
        /// <param name="deviceInfo"></param>
        private void DoWork(DeviceInfo deviceInfo)
        {
            while (monitorStatus == MonitoringStatusType.Run)
            {
                using (CommonCompolet compolet = CreateCompolet(deviceInfo))
                {
                    lock (syncOpenObject)
                    {
                        compolet.Active = true;
                    }

                    if (10000 <= deviceInfo.IntervalMilliseconds)
                    {
                        StartKeepAlive(compolet);
                    }

                    try
                    {
                        while (monitorStatus == MonitoringStatusType.Run)
                        {
                            bool isLoop = true;

                            foreach (string varName in deviceInfo.VariableNames)
                            {
                                bool canRetry = true;

                            RETRY:
                                DateTime startTime = DateTime.Now;
                                try
                                {
                                    object value;
                                    lock (compolet)
                                    {
                                        value = compolet.ReadVariable(varName);
                                    }
                                    OnNotifyReadVariableSuccess(deviceInfo.IpAddress, varName, value != null? value.ToString(): string.Empty);
                                }
                                catch (OMRON.CIP.Messaging.CIPMessageTimeOutException e)
                                {
                                    OnNotifyReadVariableError(deviceInfo.IpAddress, varName, e, startTime, DateTime.Now);
                                    if (!Ping.Test(deviceInfo.IpAddress, 1000))
                                    {
                                        isLoop = false;
                                        break;
                                    }
                                    if (canRetry)
                                    {
                                        canRetry = false;
                                        goto RETRY;
                                    }
                                }
                                catch (Exception e)
                                {
                                    OnNotifyReadVariableError(deviceInfo.IpAddress, varName, e, startTime, DateTime.Now);
                                }
                            }

                            if (!isLoop)
                                break;

                            if (0 < deviceInfo.IntervalMilliseconds)
                            {
                                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                                int elapsed = 0;
                                watch.Start();
                                while ((MonitorStatus == MonitoringStatusType.Run) && (elapsed < deviceInfo.IntervalMilliseconds))
                                {
                                    Thread.Sleep(Math.Min(20, deviceInfo.IntervalMilliseconds - elapsed));
                                    elapsed = (int)watch.ElapsedMilliseconds;
                                }
                            }
                        }
                    }
                    finally
                    {
                        StopKeepAlive(compolet);
                    }

                    lock (compolet)
                    {
                        compolet.Active = false;
                    }

                    while (monitorStatus == MonitoringStatusType.Run && !Ping.Test(deviceInfo.IpAddress, 1000))
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Test with PING command
    /// </summary>
    public static class Ping
    {
        public static bool Test(string ipAddress, int timeout)
        {
            using (System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping())
            {
                try
                {
                    return ping.Send(ipAddress, timeout).Status == System.Net.NetworkInformation.IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
