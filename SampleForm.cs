using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using OMRON.Compolet.CIP;
using OMRON.CIP.Messaging;

namespace ReadVariableSample
{
    /// <summary>
    /// Form class for executing sample source code.
    /// </summary>
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();

            this.captionText = this.Text;

            this.txtTargetDevice.Text = string.Join("\r\n", new string[] {
                "192.168.250.1,varname1",
                "192.168.250.2,varname2",
            });

            Application.Idle += new EventHandler(Application_Idle);
        }

        private readonly string captionText;

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (worker != null)
            {
                worker.Dispose();
                worker = null;
            }
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (!this.IsDisposed && this.Visible)
            {
                KeepAliveSample.MonitoringStatusType type = worker == null ? KeepAliveSample.MonitoringStatusType.Stop : worker.MonitorStatus;
                switch (type)
                {
                    case KeepAliveSample.MonitoringStatusType.Run:
                        this.Text = this.captionText + " [Running]";
                        this.btnRun.Text = "Stop";
                        this.pnlInput.Enabled = false;
                        this.btnRun.Enabled = true;
                        break;
                    case KeepAliveSample.MonitoringStatusType.Stop:
                        this.Text = this.captionText + " [Stop]";
                        this.btnRun.Text = "Run";
                        this.pnlInput.Enabled = true;
                        this.btnRun.Enabled = true;
                        if (worker != null)
                        {
                            worker.Dispose();
                            worker = null;
                        }
                        break;
                    case KeepAliveSample.MonitoringStatusType.Stopping:
                        this.Text = this.captionText + " [Wait for stop...]";
                        this.btnRun.Text = "Stop";
                        this.pnlInput.Enabled = false;
                        this.btnRun.Enabled = false;
                        break;
                }
            }
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            ClearOutputMessage();
        }

        private KeepAliveSample worker;

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (worker != null)
            {
                worker.CancelAsync();
                return;
            }

            List<KeepAliveSample.DeviceInfo> testData = GetTestData();
            if (testData == null) return;

            using (CIPPortCompolet port = new CIPPortCompolet())
            {
                bool isPortOpen = false;
                try
                {
                    isPortOpen = port.IsOpened(2);
                    if (!isPortOpen)
                    {
                        port.Open(2);
                        isPortOpen = port.IsOpened(2);
                    }
                }
                catch
                {
                }

                if (!isPortOpen)
                {
                    MessageBox.Show("LocalPort can not open.");
                    return;
                }
            }

            worker = new KeepAliveSample();
            worker.NotifyKeepAlive += new EventHandler(worker_NotifyKeepAlive);
            worker.NotifyReadVariableSuccess += new EventHandler<KeepAliveSample.NotifyReadVariableSuccessArgs>(worker_NotifyReadVariableSuccess);
            worker.NotifyReadVariableError += new EventHandler<KeepAliveSample.NotifyReadVariableErrorArgs>(worker_NotifyReadVariableError);

            outputMessage = new StringBuilder();
            UpdateOutputMessage();
            worker.RunWorkerAsync(testData);
        }

        private List<KeepAliveSample.DeviceInfo> GetTestData()
        {
            string[] lines = this.txtTargetDevice.Lines;
            if (lines == null || lines.Length < 1)
            {
                MessageBox.Show("Input data is empty.");
                return null;
            }

            int intervalMilliSeconds;
            if (!int.TryParse(this.txtIntervalMilliseconds.Text, out intervalMilliSeconds) || intervalMilliSeconds < 0)
            {
                MessageBox.Show("Invalid interval milliseconds.");
                return null;
            }

            int receiveTimeoutMilliSeconds;
            if (!int.TryParse(this.txtReceiveTimeoutMilliSeconds.Text, out receiveTimeoutMilliSeconds) || receiveTimeoutMilliSeconds < 2000)
            {
                MessageBox.Show("Invalid interval milliseconds.");
                return null;
            }

            Dictionary<string, List<string>> variableTable = new Dictionary<string, List<string>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] ss = lines[i].Split(',');
                if (ss.Length < 2)
                {
                    MessageBox.Show(string.Format("Input data is not csv : line {0}.", i));
                    return null;
                }

                string ipAddress = ss[0].Trim();
                System.Net.IPAddress address;
                if (!System.Net.IPAddress.TryParse(ipAddress, out address) || address.ToString() != ipAddress)
                {
                    MessageBox.Show(string.Format("IPAddres is invalid format : line {0}.", i));
                    return null;
                }

                List<string> variables;
                if (!variableTable.TryGetValue(ipAddress, out variables))
                {
                    variables = new List<string>();
                    variableTable.Add(ipAddress, variables);
                }

                for (int j = 1; j < ss.Length; j++)
                {
                    string varname = ss[j].Trim();
                    if (varname != string.Empty)
                        variables.Add(varname);
                }
            }

            List<KeepAliveSample.DeviceInfo> args = new List<KeepAliveSample.DeviceInfo>();
            foreach (KeyValuePair<string, List<string>> pair in variableTable)
            {
                if (!Ping.Test(pair.Key, 1000))
                {
                    MessageBox.Show(string.Format("IPAddres {0} does not reply ping message.", pair.Key));
                    return null;
                }

                args.Add(new KeepAliveSample.DeviceInfo(pair.Key, pair.Value, intervalMilliSeconds, receiveTimeoutMilliSeconds));
            }

            return args;
        }

        private StringBuilder outputMessage;
        private readonly object lockOutputMessage = new object();
        private int LimitMessageSize = 100000;

        private void UpdateOutputMessage()
        {
            string message;
            lock (lockOutputMessage)
            {
                message = outputMessage.ToString();
            }
            this.txtOutput.Text = message;
            this.txtOutput.SelectionStart = message.Length;
            this.txtOutput.ScrollToCaret();
        }

        private void ClearOutputMessage()
        {
            lock (lockOutputMessage)
            {
                outputMessage = new StringBuilder();
                UpdateOutputMessage();
            }
        }

        private void worker_NotifyReadVariableSuccess(object sender, KeepAliveSample.NotifyReadVariableSuccessArgs e)
        {
            if (!chkOutputSuccess.Checked) return;

            lock (lockOutputMessage)
            {
                if (LimitMessageSize < outputMessage.Length)
                {
                    outputMessage.AppendLine("-- stop logging caused by too many message.");
                    worker.NotifyReadVariableSuccess -= worker_NotifyReadVariableSuccess;
                }
                else
                {
                    outputMessage.AppendLine(string.Format("[{0:HH:mm:ss}] {1}: {2}: Success! (value={3})", DateTime.Now, e.IpAddress, e.VariableName, e.Value));
                }
            }

            this.BeginInvoke((MethodInvoker)UpdateOutputMessage);
        }

        private void worker_NotifyReadVariableError(object sender, KeepAliveSample.NotifyReadVariableErrorArgs e)
        {
            if (!chkOutputError.Checked) return;

            lock (lockOutputMessage)
            {
                if (LimitMessageSize < outputMessage.Length)
                {
                    outputMessage.AppendLine("-- stop logging caused by too many message.");
                    worker.NotifyReadVariableError -= worker_NotifyReadVariableError;
                }
                else
                {
                    outputMessage.AppendLine(string.Format("[{0:HH:mm:ss}] {1}: {2}: {3}: from({4:HH:mm:ss}) - to({5:HH:mm:ss}): {6}",
                        DateTime.Now,
                        e.IpAddress,
                        e.VariableName,
                        e.OccuredException.GetType().FullName,
                        e.StartTime,
                        e.ErrorOccuredTime,
                        GetErrorMessage(e.OccuredException)));
                }
            }

            this.BeginInvoke((MethodInvoker)UpdateOutputMessage);
        }

        private string GetErrorMessage(Exception e)
        {
            CIPReplyStatus status = CIPReplyStatus.Create(e);
            if (status == null)
            {
                return e.Message;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("GeneralStatus(" + status.GeneralStatus.ToString("X02") + ") ");
            if (0 < status.AdditionalStatus.Length)
            {
                sb.AppendFormat("AdditionalStatus{0:X04}", status.AdditionalStatus[0]);
                for (int i = 1; i < status.AdditionalStatus.Length; i++)
                {
                    sb.AppendFormat(" {0:X04}", status.AdditionalStatus[i]);
                }

                sb.Append("} ");
            }

            sb.Append(e.Message);
            return sb.ToString();
        }

        private void worker_NotifyKeepAlive(object sender, EventArgs e)
        {
            if (!chkOutputKeepAlive.Checked) return;

            lock (lockOutputMessage)
            {
                if (LimitMessageSize < outputMessage.Length)
                {
                    outputMessage.AppendLine("-- stop logging caused by too many message.");
                    KeepAliveSample keepAlive = worker as KeepAliveSample;
                    if (keepAlive != null)
                    {
                        keepAlive.NotifyKeepAlive -= worker_NotifyKeepAlive;
                    }
                }
                else
                {
                    outputMessage.AppendLine(string.Format("[{0:HH:mm:ss}] {1}: ----- KeepAlive! ----- ", DateTime.Now, (sender as CommonCompolet).PeerAddress));
                }
            }

            this.BeginInvoke((MethodInvoker)UpdateOutputMessage);
        }
    }
}
