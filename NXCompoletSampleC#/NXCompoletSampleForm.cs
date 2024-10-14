using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using OMRON.Compolet.CIP;

namespace NXCompoletSample
{
    public partial class NXCompoletSampleForm : Form
    {
        public NXCompoletSampleForm()
        {
            InitializeComponent();
            this.radioPeerAddress.Checked = true;
        }

        #region Communication Tab Event Functions
        private void cmbConnectionType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cmbConnectionType.SelectedIndex == 0)
            {
                this.nxCompolet1.ConnectionType = ConnectionType.UCMM;
            }
            else
            {
                this.nxCompolet1.ConnectionType = ConnectionType.Class3;
            }
        }

        private void radioPeerAddress_CheckedChanged(object sender, System.EventArgs e)
        {
            this.labelPortNo.Enabled = this.radioPeerAddress.Checked;
            this.numPortNo.Enabled = this.radioPeerAddress.Checked;
            this.labelIPAddress.Enabled = this.radioPeerAddress.Checked;
            this.txtIPAddress.Enabled = this.radioPeerAddress.Checked;
            this.labelRoutePath.Enabled = !this.radioPeerAddress.Checked;
            this.txtRoutePath.Enabled = !this.radioPeerAddress.Checked;

            this.nxCompolet1.UseRoutePath = !this.radioPeerAddress.Checked;
        }

        private void numPortNo_ValueChanged(object sender, System.EventArgs e)
        {
            this.nxCompolet1.LocalPort = (int)this.numPortNo.Value;
        }

        private void txtIPAddress_TextChanged(object sender, System.EventArgs e)
        {
            this.nxCompolet1.PeerAddress = this.txtIPAddress.Text;
        }

        private void txtRoutePath_TextChanged(object sender, System.EventArgs e)
        {
            this.nxCompolet1.RoutePath = this.txtRoutePath.Text;
        }

        private void chkActive_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.nxCompolet1.Active = this.chkActive.Checked;
                this.btnEventLog.Enabled = this.chkActive.Checked;
                if (this.chkActive.Checked)
                {
                    if (!this.nxCompolet1.IsConnected)
                    {
                        if (this.radioPeerAddress.Checked)
                        {
                            MessageBox.Show("Connection failed !" + System.Environment.NewLine + "Please check PeerAddress.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Connection failed !" + System.Environment.NewLine + "Please check RoutePath.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        this.nxCompolet1.Active = false;
                        this.chkActive.Checked = false;
                        this.btnEventLog.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.nxCompolet1.Active = false;
                this.chkActive.Checked = false;
                this.btnEventLog.Enabled = false;
            }
        }

        private void btnGetCommunication_Click(object sender, System.EventArgs e)
        {
            if (this.radioPeerAddress.Checked)
            {
                this.listViewOfEachValue.Items[2].SubItems[1].Text = this.nxCompolet1.LocalPort.ToString();
                this.listViewOfEachValue.Items[3].SubItems[1].Text = this.nxCompolet1.PeerAddress;
                this.listViewOfEachValue.Items[4].SubItems[1].Text = string.Empty;
                this.listViewOfEachValue.Items[5].SubItems[1].Text = string.Empty;
            }
            else if (this.radioRoutePath.Checked)
            {
                this.listViewOfEachValue.Items[5].SubItems[1].Text = this.nxCompolet1.RoutePath;
                this.listViewOfEachValue.Items[2].SubItems[1].Text = string.Empty;
                this.listViewOfEachValue.Items[3].SubItems[1].Text = string.Empty;
            }

            this.listViewOfEachValue.Items[0].SubItems[1].Text = this.nxCompolet1.Active.ToString();
            this.listViewOfEachValue.Items[1].SubItems[1].Text = this.nxCompolet1.ConnectionType.ToString();
            this.listViewOfEachValue.Items[4].SubItems[1].Text = this.nxCompolet1.UseRoutePath.ToString();
            this.listViewOfEachValue.Items[6].SubItems[1].Text = this.nxCompolet1.IsConnected.ToString();
            this.listViewOfEachValue.Items[7].SubItems[1].Text = this.nxCompolet1.TypeName;
            this.listViewOfEachValue.Items[8].SubItems[1].Text = this.nxCompolet1.DontFragment.ToString();
        }
        #endregion

        #region Controller Tab Event Functions
        private void btnGetUnitName_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.txtUnitName.Text = this.nxCompolet1.UnitName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetUnitName_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.nxCompolet1.UnitName = this.txtUnitName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetClock_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.txtClock.Text = this.nxCompolet1.Clock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetClock_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.nxCompolet1.Clock = DateTime.Parse(this.txtClock.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetStatus_Click(object sender, System.EventArgs e)
        {
            try
            {
                switch (this.nxCompolet1.RunMode)
                {
                    case NXCompolet.RunModeTypes.Program:
                        this.cmbRunMode.SelectedIndex = 0;
                        break;
                    case NXCompolet.RunModeTypes.Run:
                        this.cmbRunMode.SelectedIndex = 1;
                        break;
                }

                switch (this.nxCompolet1.RunStatus)
                {
                    case 0x00:
                        this.cmbRunStatus.SelectedIndex = 0;
                        break;
                    case 0x01:
                        this.cmbRunStatus.SelectedIndex = 1;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetStatus_Click(object sender, System.EventArgs e)
        {
            try
            {
                switch (this.cmbRunMode.Text)
                {
                    case "Program":
                        this.nxCompolet1.RunMode = NXCompolet.RunModeTypes.Program;
                        break;
                    case "Run":
                        this.nxCompolet1.RunMode = NXCompolet.RunModeTypes.Run;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetMessageTimeLimit_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.txtReceiveTimeLimit.Text = this.nxCompolet1.ReceiveTimeLimit.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetMessageTimeLimit_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.nxCompolet1.ReceiveTimeLimit = long.Parse(this.txtReceiveTimeLimit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetHeartBeatTimer_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.txtTimerInterval.Text = Convert.ToString((double)this.nxCompolet1.HeartBeatTimer / 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetHeartBeat_Click(object sender, System.EventArgs e)
        {

            try
            {
                this.nxCompolet1.HeartBeatTimer = (int)(double.Parse(this.txtTimerInterval.Text) * 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nxCompolet1_OnHeartBeatTimer(object sender, System.EventArgs e)
        {
            try
            {
                DateTime date = (DateTime)this.nxCompolet1.ReadVariable("_CurrentTime");
                this.txtCurrentTime.Text = date.ToLongTimeString();
            }
            catch (Exception ex)
            {
                this.txtCurrentTime.Text = ex.Message;
            }
        }

        private void btnGetPlcEncoding_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.cmbPlcEncodingName.Text = this.nxCompolet1.PlcEncoding.WebName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetPlcEncoding_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.nxCompolet1.PlcEncoding = System.Text.Encoding.GetEncoding(this.cmbPlcEncodingName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Statistics Tab Event Functions

        private void btnGetLatestExecuteTime_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time = this.nxCompolet1.LatestExecuteTime;
                this.txtLatestExecuteTime.Text = time != DateTime.MinValue ? time.ToString("HH:mm:ss.fff") : "---";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearLatestExecuteTime_Click(object sender, EventArgs e)
        {
            try
            {
                this.nxCompolet1.ClearLatestExecuteTime();
                btnGetLatestExecuteTime_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetMaxExecuteTimeSpan_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtMaxExecuteTimeSpan.Text = this.nxCompolet1.MaxExecuteTimeSpan.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearMaxExecuteTimeSpan_Click(object sender, EventArgs e)
        {
            try
            {
                this.nxCompolet1.ClearMaxExecuteTimeSpan();
                btnGetMaxExecuteTimeSpan_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetExecuteStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                List<ExecutionTimeStatistics> list = new List<ExecutionTimeStatistics>();
                foreach (StatisticsTargetType targetType in Enum.GetValues(typeof(StatisticsTargetType)))
                {
                    list.Add(this.nxCompolet1.GetExecutionTimeStatistics(targetType));
                }

                this.dataGridViewExecuteStatistics.DataSource = list.ToArray();
                this.dataGridViewExecuteStatistics.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearExecuteStatistics_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExecuteStatistics.SelectedCells.Count < 1)
            {
                return;
            }

            ExecutionTimeStatistics[] ary = this.dataGridViewExecuteStatistics.DataSource as ExecutionTimeStatistics[];
            if (ary == null)
            {
                return;
            }

            int rowIndex = this.dataGridViewExecuteStatistics.SelectedCells[0].RowIndex;
            if (rowIndex < 0 || ary.Length <= rowIndex)
            {
                return;
            }

            try
            {
                this.nxCompolet1.ClearExecutionTimeStatistics(ary[rowIndex].TargetType);
                btnGetExecuteStatistics_Click(sender, e);
                this.dataGridViewExecuteStatistics.CurrentCell = this.dataGridViewExecuteStatistics[0, rowIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAllClearExecuteStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                this.nxCompolet1.ClearExecutionTimeStatistics();
                btnGetExecuteStatistics_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion //Statistics Tab Event Functions

        #region TagTable Variables Event Functions
        private void listViewOfVariableNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.listViewOfVariableNames.SelectedItems.Count == 0)
            {
                return;
            }
            if (this.listViewOfVariableNames.SelectedItems.Count == 1)
            {
                this.txtVariableName.Text = this.listViewOfVariableNames.SelectedItems[0].Text;
                this.txtBinaryVariableName.Text = this.listViewOfVariableNames.SelectedItems[0].Text;
            }
            else
            {
                string[] varlist = new string[this.listViewOfVariableNames.SelectedItems.Count];
                string variables = string.Empty;
                for (int i = 0; i < this.listViewOfVariableNames.SelectedItems.Count; i++)
                {
                    varlist[i] = this.listViewOfVariableNames.SelectedItems[i].Text;
                    variables += varlist[i] + ",";
                }
                variables = variables.TrimEnd(',');
                this.txtVariableName.Text = variables;
                this.txtBinaryVariableName.Text = variables;
            }
            this.txtValue.Text = string.Empty;
            this.txtBinaryValue.Text = string.Empty;
        }

        private void btnGetVaiable_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.listViewOfVariableNames.Items.Clear();
                String[] vars = null;
                if (this.chkSystemVariable.Checked)
                {
                    vars = this.nxCompolet1.SystemVariableNames;
                }
                else
                {
                    vars = this.nxCompolet1.VariableNames;
                }

                foreach (string var in vars)
                {
                    String accessablePath = this.GetAccessablePath(var);
                    this.DisplayVariableInfomation(accessablePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadVariableMultiple_Click(object sender, System.EventArgs e)
        {
            try
            {
                string[] varlist = this.txtVariableName.Text.Replace(" ", String.Empty).Split(',');

                Hashtable retVals = this.nxCompolet1.ReadVariableMultiple(varlist);
                if (retVals == null)
                {
                    throw new NotSupportedException();
                }

                string multival = string.Empty;
                for (int index = 0; index < varlist.Length; index++)
                {
                    string varName = varlist[index];
                    object val = retVals[varName];
                    string valStr = this.GetValueOfVariables(val);
                    if (this.listViewOfVariableNames.SelectedItems.Count > index)
                    {
                        UpdateVariableValue(this.listViewOfVariableNames.SelectedItems[index], varlist[index], valStr);
                    }
                    multival += valStr + ",";
                }
                multival = multival.TrimEnd(',');
                this.txtValue.Text = multival;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadVariable_Click(object sender, System.EventArgs e)
        {
            try
            {
                string varname = this.txtVariableName.Text;
                object obj = this.nxCompolet1.ReadVariable(varname);
                if (obj == null)
                {
                    throw new NotSupportedException();
                }

                VariableInfo info = this.nxCompolet1.GetVariableInfo(varname);
                string str = this.GetValueOfVariables(obj);
                if (this.listViewOfVariableNames.SelectedItems.Count > 0)
                {
                    UpdateVariableValue(this.listViewOfVariableNames.SelectedItems[0], varname, str);
                }
                this.txtValue.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWriteVariable_Click(object sender, System.EventArgs e)
        {
            try
            {
                // write
                //--------------------------------------------------------------------------------
                string valWrite = this.txtVariableName.Text;
                if (valWrite.StartsWith("_"))
                {
                    MessageBox.Show("The SystemVariable can not write!");
                    return;
                }
                object val = this.RemoveBrackets(this.txtValue.Text);
                if (this.nxCompolet1.GetVariableInfo(this.txtVariableName.Text).Type == VariableType.STRUCT)
                {
                    val = this.ObjectToByteArray(val);
                }
                this.nxCompolet1.WriteVariable(this.txtVariableName.Text, val);

                // read
                this.btnReadVariable_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadRawDataMultiple_Click(object sender, System.EventArgs e)
        {
            try
            {
                string[] varlist = this.txtBinaryVariableName.Text.Replace(" ", String.Empty).Split(',');

                Hashtable retVals = this.nxCompolet1.ReadRawDataMultiple(varlist);
                string multival = string.Empty;
                for (int index = 0; index < varlist.Length; index++)
                {
                    string varName = varlist[index];
                    string val = this.ByteArrayToString(retVals[varName] as byte[]);

                    if (this.listViewOfVariableNames.SelectedItems.Count > index)
                    {
                        UpdateVariableValue(this.listViewOfVariableNames.SelectedItems[index], varlist[index], val);
                    }
                    multival += val + ",";
                }
                multival = multival.TrimEnd(',');
                this.txtBinaryValue.Text = multival;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadRaw_Click(object sender, System.EventArgs e)
        {
            try
            {
                string varname = this.txtBinaryVariableName.Text;
                object obj = this.nxCompolet1.ReadRawData(varname);
                VariableInfo info = this.nxCompolet1.GetVariableInfo(varname);
                string val = this.ByteArrayToString(obj as byte[]);

                if (this.listViewOfVariableNames.SelectedItems.Count > 0)
                {
                    UpdateVariableValue(this.listViewOfVariableNames.SelectedItems[0], varname, val);
                }
                this.txtBinaryValue.Text = val;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWriteRaw_Click(object sender, System.EventArgs e)
        {
            try
            {
                // write
                if (this.txtBinaryVariableName.Text.StartsWith("_"))
                {
                    MessageBox.Show("The SystemVariable can not write!");
                    return;
                }
                byte[] val = this.StringToByteArray(this.txtBinaryValue.Text.Replace("-", string.Empty));
                this.nxCompolet1.WriteRawData(this.txtBinaryVariableName.Text, val);

                // read
                this.btnReadRaw_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkDoNotFragment_CheckedChanged(object sender, System.EventArgs e)
        {
            this.nxCompolet1.DontFragment = this.chkDoNotFragment.Checked;
        }
        #endregion

        #region Helper Functions
        private void DisplayVariableInfomation(string str)
        {
            ListViewItem item = this.listViewOfVariableNames.Items.Add(str);
            VariableInfo info = this.nxCompolet1.GetVariableInfo(str);
            if (info.IsArray)
            {
                string text = info.Type.ToString();
                foreach (long num in info.NumberOfElements)
                {
                    text += "[" + num.ToString() + "]";
                }
                item.SubItems.Add(text);
            }
            else
            {
                item.SubItems.Add(info.Type.ToString());
            }
            item.SubItems.Add(string.Empty);
        }

        private void UpdateVariableValue(ListViewItem item, string variableName, string value)
        {
            if (item.SubItems[0].Text == variableName)
            {
                while (item.SubItems.Count < 3)
                {
                    item.SubItems.Add(string.Empty);
                }
                item.SubItems[2].Text = value;
            }
        }

        private bool IsMustElementAccess(VariableInfo info)
        {
            bool toReturn = false;
            if (info.IsArray)
            {
                if (info.Type == VariableType.STRING || info.Type == VariableType.UNION)
                {
                    toReturn = true;
                }
            }

            return toReturn;
        }

        private bool IsMustMemberAccess(VariableInfo info)
        {
            bool toReturn = false;

            if (info.Type == VariableType.UNION)
            {
                toReturn = true;
            }

            return toReturn;
        }

        private String GetAccessablePath(String path)
        {
            String newPath = String.Empty;
            newPath += path;
            VariableInfo info = this.nxCompolet1.GetVariableInfo(path);
            if (this.IsMustElementAccess(info))
            {
                // get only first element
                for (int i = 0; i < info.Dimension; i++)
                {
                    newPath += "[" + info.StartArrayElements[i].ToString() + "]";
                }
                return this.GetAccessablePath(newPath);
            }
            else if (this.IsMustMemberAccess(info))
            {
                // get only first member
                newPath += "." + info.StructMembers[0].Name;
                return this.GetAccessablePath(newPath);
            }
            else
            {
                return newPath;
            }
        }

        private string GetValueOfVariables(object val)
        {
            string valStr = string.Empty;
            if (val.GetType().IsArray)
            {
                Array valArray = val as Array;
                if (valArray.Rank == 1)
                {
                    valStr += "[";
                    foreach (object a in valArray)
                    {
                        valStr += this.GetValueString(a) + ",";
                    }
                    valStr = valStr.TrimEnd(',');
                    valStr += "]";
                }
                else if (valArray.Rank == 2)
                {
                    for (int i = 0; i <= valArray.GetUpperBound(0); i++)
                    {
                        valStr += "[";
                        for (int j = 0; j <= valArray.GetUpperBound(1); j++)
                        {
                            valStr += this.GetValueString(valArray.GetValue(i, j)) + ",";
                        }
                        valStr = valStr.TrimEnd(',');
                        valStr += "]";
                    }
                }
                else if (valArray.Rank == 3)
                {
                    for (int i = 0; i <= valArray.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= valArray.GetUpperBound(1); j++)
                        {
                            valStr += "[";
                            for (int z = 0; z <= valArray.GetUpperBound(2); z++)
                            {
                                valStr += this.GetValueString(valArray.GetValue(i, j, z)) + ",";
                            }
                            valStr = valStr.TrimEnd(',');
                            valStr += "]";
                        }
                    }
                }
            }
            else
            {
                valStr = this.GetValueString(val);
            }
            return valStr;
        }

        private string GetValueString(object val)
        {
            if (val is float || val is double)
            {
                return string.Format("{0:R}", val);
            }
            else
            {
                return val.ToString();
            }
        }

        private object RemoveBrackets(string val)
        {
            object obj = string.Empty;
            if (val.IndexOf("[") >= 0)
            {
                string str = val.Trim('[', ']');
                str = str.Replace("][", ",");
                obj = str.Split(',');
            }
            else
            {
                obj = val;
            }
            return obj;
        }

        private string ByteArrayToString(byte[] ba)
        {
            if (ba.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                return BitConverter.ToString(ba);
            }
        }

        private byte[] StringToByteArray(string hex)
        {
            if (hex == String.Empty)
            {
                return new Byte[0];
            }
            int byteNumber = hex.Length / 2;
            byte[] bytes = new byte[byteNumber];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        private byte[] ObjectToByteArray(object obj)
        {
            if (obj is Array)
            {
                Array arr = obj as Array;
                Byte[] bin = new Byte[arr.Length];
                for (int i = 0; i < bin.Length; i++)
                {
                    bin[i] = Convert.ToByte(arr.GetValue(i));
                }
                return bin;
            }
            else
            {
                return new Byte[1] { Convert.ToByte(obj) };
            }
        }
        #endregion

        #region EventLog Functions
        private void btnEventLog_Click(object sender, EventArgs e)
        {
            using (Form form = new EventLogs.EventLogForm(this.nxCompolet1))
            {
                form.ShowDialog(this);
            }
        }
        #endregion
    }
}
