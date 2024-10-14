namespace NXCompoletSample
{
    partial class NXCompoletSampleForm
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            this.nxCompolet1.Active = false;
            base.Dispose(disposing);
        }
 
        #region Windows Form Designer Codes

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Active",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ConnectionType",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "LocalPort",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "PeerAddress",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "UseRoutePath",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "RoutePath",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "IsConnected",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "TypeName",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "DoNotFragment",
            ""}, -1);
            this.tabNXCompolet = new System.Windows.Forms.TabControl();
            this.tabPageCommunication = new System.Windows.Forms.TabPage();
            this.btnEventLog = new System.Windows.Forms.Button();
            this.btnGetCommunication = new System.Windows.Forms.Button();
            this.listViewOfEachValue = new System.Windows.Forms.ListView();
            this.variableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variableValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.labelConnectionType = new System.Windows.Forms.Label();
            this.radioRoutePath = new System.Windows.Forms.RadioButton();
            this.groupBoxRoutePath = new System.Windows.Forms.GroupBox();
            this.txtRoutePath = new System.Windows.Forms.TextBox();
            this.labelRoutePath = new System.Windows.Forms.Label();
            this.radioPeerAddress = new System.Windows.Forms.RadioButton();
            this.groupBoxPeerAddress = new System.Windows.Forms.GroupBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.labelPortNo = new System.Windows.Forms.Label();
            this.numPortNo = new System.Windows.Forms.NumericUpDown();
            this.tabPageController = new System.Windows.Forms.TabPage();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.btnSetStatus = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.cmbRunStatus = new System.Windows.Forms.ComboBox();
            this.labelRunStatus = new System.Windows.Forms.Label();
            this.cmbRunMode = new System.Windows.Forms.ComboBox();
            this.labelRunMode = new System.Windows.Forms.Label();
            this.groupBoxClock = new System.Windows.Forms.GroupBox();
            this.btnSetClock = new System.Windows.Forms.Button();
            this.btnGetClock = new System.Windows.Forms.Button();
            this.txtClock = new System.Windows.Forms.TextBox();
            this.groupBoxUnitName = new System.Windows.Forms.GroupBox();
            this.btnSetUnitName = new System.Windows.Forms.Button();
            this.btnGetUnitName = new System.Windows.Forms.Button();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.tabPageOption = new System.Windows.Forms.TabPage();
            this.groupBoxPlcEncoding = new System.Windows.Forms.GroupBox();
            this.btnSetPlcEncoding = new System.Windows.Forms.Button();
            this.btnGetPlcEncoding = new System.Windows.Forms.Button();
            this.cmbPlcEncodingName = new System.Windows.Forms.ComboBox();
            this.groupBoxHeartBeat = new System.Windows.Forms.GroupBox();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.btnSetHeartBeat = new System.Windows.Forms.Button();
            this.btnGetHeartBeatTimer = new System.Windows.Forms.Button();
            this.labelSEC = new System.Windows.Forms.Label();
            this.txtTimerInterval = new System.Windows.Forms.TextBox();
            this.labelHeartBeatTimer = new System.Windows.Forms.Label();
            this.groupBoxMessageTimeLimit = new System.Windows.Forms.GroupBox();
            this.btnSetMessageTimeLimit = new System.Windows.Forms.Button();
            this.btnGetMessageTimeLimit = new System.Windows.Forms.Button();
            this.labelMS = new System.Windows.Forms.Label();
            this.txtReceiveTimeLimit = new System.Windows.Forms.TextBox();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.grpExecuteStatistics = new System.Windows.Forms.GroupBox();
            this.dataGridViewExecuteStatistics = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetExecuteStatistics = new System.Windows.Forms.Button();
            this.btnAllClearExecuteStatistics = new System.Windows.Forms.Button();
            this.btnClearExecuteStatistics = new System.Windows.Forms.Button();
            this.grpLatestExecuteTime = new System.Windows.Forms.GroupBox();
            this.btnClearLatestExecuteTime = new System.Windows.Forms.Button();
            this.btnGetLatestExecuteTime = new System.Windows.Forms.Button();
            this.txtLatestExecuteTime = new System.Windows.Forms.TextBox();
            this.grpMaxExecuteTimeSpan = new System.Windows.Forms.GroupBox();
            this.btnClearMaxExecuteTimeSpan = new System.Windows.Forms.Button();
            this.btnGetMaxExecuteTimeSpan = new System.Windows.Forms.Button();
            this.txtMaxExecuteTimeSpan = new System.Windows.Forms.TextBox();
            this.chkDoNotFragment = new System.Windows.Forms.CheckBox();
            this.groupBoxTagTableVariables = new System.Windows.Forms.GroupBox();
            this.groupBoxBinaryVariableEdit = new System.Windows.Forms.GroupBox();
            this.btnWriteRaw = new System.Windows.Forms.Button();
            this.btnReadRaw = new System.Windows.Forms.Button();
            this.txtBinaryValue = new System.Windows.Forms.TextBox();
            this.labelValueOfBinary = new System.Windows.Forms.Label();
            this.btnReadRawDataMultiple = new System.Windows.Forms.Button();
            this.txtBinaryVariableName = new System.Windows.Forms.TextBox();
            this.labelNameForUseBinary = new System.Windows.Forms.Label();
            this.groupBoxVariableEdit = new System.Windows.Forms.GroupBox();
            this.btnWriteVariable = new System.Windows.Forms.Button();
            this.btnReadVariable = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.btnReadVariableMultiple = new System.Windows.Forms.Button();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnGetVaiable = new System.Windows.Forms.Button();
            this.chkSystemVariable = new System.Windows.Forms.CheckBox();
            this.listViewOfVariableNames = new System.Windows.Forms.ListView();
            this.variableNameOfTagTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variableTypeOfTagTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variableValueOfTagTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNXCompolet.SuspendLayout();
            this.tabPageCommunication.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxRoutePath.SuspendLayout();
            this.groupBoxPeerAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortNo)).BeginInit();
            this.tabPageController.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxClock.SuspendLayout();
            this.groupBoxUnitName.SuspendLayout();
            this.tabPageOption.SuspendLayout();
            this.groupBoxPlcEncoding.SuspendLayout();
            this.groupBoxHeartBeat.SuspendLayout();
            this.groupBoxMessageTimeLimit.SuspendLayout();
            this.tabPageStatistics.SuspendLayout();
            this.grpExecuteStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecuteStatistics)).BeginInit();
            this.grpLatestExecuteTime.SuspendLayout();
            this.grpMaxExecuteTimeSpan.SuspendLayout();
            this.groupBoxTagTableVariables.SuspendLayout();
            this.groupBoxBinaryVariableEdit.SuspendLayout();
            this.groupBoxVariableEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNXCompolet
            // 
            this.tabNXCompolet.Controls.Add(this.tabPageCommunication);
            this.tabNXCompolet.Controls.Add(this.tabPageController);
            this.tabNXCompolet.Controls.Add(this.tabPageOption);
            this.tabNXCompolet.Controls.Add(this.tabPageStatistics);
            this.tabNXCompolet.ItemSize = new System.Drawing.Size(90, 17);
            this.tabNXCompolet.Location = new System.Drawing.Point(13, 12);
            this.tabNXCompolet.Name = "tabNXCompolet";
            this.tabNXCompolet.SelectedIndex = 0;
            this.tabNXCompolet.Size = new System.Drawing.Size(539, 612);
            this.tabNXCompolet.TabIndex = 0;
            // 
            // tabPageCommunication
            // 
            this.tabPageCommunication.Controls.Add(this.btnEventLog);
            this.tabPageCommunication.Controls.Add(this.btnGetCommunication);
            this.tabPageCommunication.Controls.Add(this.listViewOfEachValue);
            this.tabPageCommunication.Controls.Add(this.chkActive);
            this.tabPageCommunication.Controls.Add(this.groupBoxConnection);
            this.tabPageCommunication.Location = new System.Drawing.Point(4, 21);
            this.tabPageCommunication.Name = "tabPageCommunication";
            this.tabPageCommunication.Size = new System.Drawing.Size(531, 587);
            this.tabPageCommunication.TabIndex = 0;
            this.tabPageCommunication.Text = "Communication";
            // 
            // btnEventLog
            // 
            this.btnEventLog.Enabled = false;
            this.btnEventLog.Location = new System.Drawing.Point(342, 266);
            this.btnEventLog.Name = "btnEventLog";
            this.btnEventLog.Size = new System.Drawing.Size(144, 34);
            this.btnEventLog.TabIndex = 2;
            this.btnEventLog.Text = "Event Log";
            this.btnEventLog.UseVisualStyleBackColor = true;
            this.btnEventLog.Click += new System.EventHandler(this.btnEventLog_Click);
            // 
            // btnGetCommunication
            // 
            this.btnGetCommunication.Location = new System.Drawing.Point(371, 528);
            this.btnGetCommunication.Name = "btnGetCommunication";
            this.btnGetCommunication.Size = new System.Drawing.Size(120, 34);
            this.btnGetCommunication.TabIndex = 4;
            this.btnGetCommunication.Text = "Get";
            this.btnGetCommunication.Click += new System.EventHandler(this.btnGetCommunication_Click);
            // 
            // listViewOfEachValue
            // 
            this.listViewOfEachValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.variableName,
            this.variableValue});
            this.listViewOfEachValue.FullRowSelect = true;
            this.listViewOfEachValue.GridLines = true;
            this.listViewOfEachValue.HideSelection = false;
            this.listViewOfEachValue.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listViewOfEachValue.Location = new System.Drawing.Point(26, 312);
            this.listViewOfEachValue.Name = "listViewOfEachValue";
            this.listViewOfEachValue.Size = new System.Drawing.Size(478, 210);
            this.listViewOfEachValue.TabIndex = 3;
            this.listViewOfEachValue.UseCompatibleStateImageBehavior = false;
            this.listViewOfEachValue.View = System.Windows.Forms.View.Details;
            // 
            // variableName
            // 
            this.variableName.Text = "Name";
            this.variableName.Width = 120;
            // 
            // variableValue
            // 
            this.variableValue.Text = "Value";
            this.variableValue.Width = 100;
            // 
            // chkActive
            // 
            this.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkActive.Location = new System.Drawing.Point(26, 276);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(113, 24);
            this.chkActive.TabIndex = 1;
            this.chkActive.Text = "Active";
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.cmbConnectionType);
            this.groupBoxConnection.Controls.Add(this.labelConnectionType);
            this.groupBoxConnection.Controls.Add(this.radioRoutePath);
            this.groupBoxConnection.Controls.Add(this.groupBoxRoutePath);
            this.groupBoxConnection.Controls.Add(this.radioPeerAddress);
            this.groupBoxConnection.Controls.Add(this.groupBoxPeerAddress);
            this.groupBoxConnection.Location = new System.Drawing.Point(13, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(491, 252);
            this.groupBoxConnection.TabIndex = 0;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.Items.AddRange(new object[] {
            "UCMM",
            "Class3"});
            this.cmbConnectionType.Location = new System.Drawing.Point(205, 24);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(192, 23);
            this.cmbConnectionType.TabIndex = 1;
            this.cmbConnectionType.Text = "UCMM";
            this.cmbConnectionType.SelectedIndexChanged += new System.EventHandler(this.cmbConnectionType_SelectedIndexChanged);
            // 
            // labelConnectionType
            // 
            this.labelConnectionType.Location = new System.Drawing.Point(38, 24);
            this.labelConnectionType.Name = "labelConnectionType";
            this.labelConnectionType.Size = new System.Drawing.Size(154, 24);
            this.labelConnectionType.TabIndex = 0;
            this.labelConnectionType.Text = "ConnectionType";
            // 
            // radioRoutePath
            // 
            this.radioRoutePath.Location = new System.Drawing.Point(51, 168);
            this.radioRoutePath.Name = "radioRoutePath";
            this.radioRoutePath.Size = new System.Drawing.Size(128, 24);
            this.radioRoutePath.TabIndex = 4;
            this.radioRoutePath.Text = "RoutePath";
            // 
            // groupBoxRoutePath
            // 
            this.groupBoxRoutePath.Controls.Add(this.txtRoutePath);
            this.groupBoxRoutePath.Controls.Add(this.labelRoutePath);
            this.groupBoxRoutePath.Location = new System.Drawing.Point(38, 168);
            this.groupBoxRoutePath.Name = "groupBoxRoutePath";
            this.groupBoxRoutePath.Size = new System.Drawing.Size(436, 60);
            this.groupBoxRoutePath.TabIndex = 5;
            this.groupBoxRoutePath.TabStop = false;
            // 
            // txtRoutePath
            // 
            this.txtRoutePath.Location = new System.Drawing.Point(166, 24);
            this.txtRoutePath.Name = "txtRoutePath";
            this.txtRoutePath.Size = new System.Drawing.Size(260, 25);
            this.txtRoutePath.TabIndex = 1;
            this.txtRoutePath.Text = "2%192.168.250.1";
            this.txtRoutePath.TextChanged += new System.EventHandler(this.txtRoutePath_TextChanged);
            // 
            // labelRoutePath
            // 
            this.labelRoutePath.Location = new System.Drawing.Point(38, 28);
            this.labelRoutePath.Name = "labelRoutePath";
            this.labelRoutePath.Size = new System.Drawing.Size(103, 24);
            this.labelRoutePath.TabIndex = 0;
            this.labelRoutePath.Text = "RoutePath:";
            // 
            // radioPeerAddress
            // 
            this.radioPeerAddress.Location = new System.Drawing.Point(51, 60);
            this.radioPeerAddress.Name = "radioPeerAddress";
            this.radioPeerAddress.Size = new System.Drawing.Size(154, 24);
            this.radioPeerAddress.TabIndex = 2;
            this.radioPeerAddress.TabStop = true;
            this.radioPeerAddress.Text = "PeerAddress";
            this.radioPeerAddress.CheckedChanged += new System.EventHandler(this.radioPeerAddress_CheckedChanged);
            // 
            // groupBoxPeerAddress
            // 
            this.groupBoxPeerAddress.Controls.Add(this.txtIPAddress);
            this.groupBoxPeerAddress.Controls.Add(this.labelIPAddress);
            this.groupBoxPeerAddress.Controls.Add(this.labelPortNo);
            this.groupBoxPeerAddress.Controls.Add(this.numPortNo);
            this.groupBoxPeerAddress.Location = new System.Drawing.Point(38, 60);
            this.groupBoxPeerAddress.Name = "groupBoxPeerAddress";
            this.groupBoxPeerAddress.Size = new System.Drawing.Size(436, 96);
            this.groupBoxPeerAddress.TabIndex = 3;
            this.groupBoxPeerAddress.TabStop = false;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(166, 58);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(189, 25);
            this.txtIPAddress.TabIndex = 3;
            this.txtIPAddress.Text = "192.168.250.1";
            this.txtIPAddress.TextChanged += new System.EventHandler(this.txtIPAddress_TextChanged);
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.Location = new System.Drawing.Point(38, 63);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(103, 24);
            this.labelIPAddress.TabIndex = 2;
            this.labelIPAddress.Text = "IP Address:";
            // 
            // labelPortNo
            // 
            this.labelPortNo.Location = new System.Drawing.Point(38, 27);
            this.labelPortNo.Name = "labelPortNo";
            this.labelPortNo.Size = new System.Drawing.Size(77, 24);
            this.labelPortNo.TabIndex = 0;
            this.labelPortNo.Text = "Port No";
            // 
            // numPortNo
            // 
            this.numPortNo.Location = new System.Drawing.Point(166, 24);
            this.numPortNo.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numPortNo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPortNo.Name = "numPortNo";
            this.numPortNo.Size = new System.Drawing.Size(192, 25);
            this.numPortNo.TabIndex = 1;
            this.numPortNo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPortNo.ValueChanged += new System.EventHandler(this.numPortNo_ValueChanged);
            this.numPortNo.Leave += new System.EventHandler(this.numPortNo_ValueChanged);
            // 
            // tabPageController
            // 
            this.tabPageController.Controls.Add(this.groupBoxStatus);
            this.tabPageController.Controls.Add(this.groupBoxClock);
            this.tabPageController.Controls.Add(this.groupBoxUnitName);
            this.tabPageController.Location = new System.Drawing.Point(4, 21);
            this.tabPageController.Name = "tabPageController";
            this.tabPageController.Size = new System.Drawing.Size(531, 587);
            this.tabPageController.TabIndex = 1;
            this.tabPageController.Text = "Controller";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.btnSetStatus);
            this.groupBoxStatus.Controls.Add(this.btnGetStatus);
            this.groupBoxStatus.Controls.Add(this.cmbRunStatus);
            this.groupBoxStatus.Controls.Add(this.labelRunStatus);
            this.groupBoxStatus.Controls.Add(this.cmbRunMode);
            this.groupBoxStatus.Controls.Add(this.labelRunMode);
            this.groupBoxStatus.Location = new System.Drawing.Point(13, 156);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(499, 120);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // btnSetStatus
            // 
            this.btnSetStatus.Location = new System.Drawing.Point(384, 72);
            this.btnSetStatus.Name = "btnSetStatus";
            this.btnSetStatus.Size = new System.Drawing.Size(102, 36);
            this.btnSetStatus.TabIndex = 5;
            this.btnSetStatus.Text = "Set";
            this.btnSetStatus.Click += new System.EventHandler(this.btnSetStatus_Click);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(384, 36);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(102, 36);
            this.btnGetStatus.TabIndex = 4;
            this.btnGetStatus.Text = "Get";
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // cmbRunStatus
            // 
            this.cmbRunStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbRunStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbRunStatus.Items.AddRange(new object[] {
            "No Error",
            "Error"});
            this.cmbRunStatus.Location = new System.Drawing.Point(154, 72);
            this.cmbRunStatus.Name = "cmbRunStatus";
            this.cmbRunStatus.Size = new System.Drawing.Size(192, 30);
            this.cmbRunStatus.TabIndex = 3;
            // 
            // labelRunStatus
            // 
            this.labelRunStatus.Location = new System.Drawing.Point(26, 72);
            this.labelRunStatus.Name = "labelRunStatus";
            this.labelRunStatus.Size = new System.Drawing.Size(100, 24);
            this.labelRunStatus.TabIndex = 2;
            this.labelRunStatus.Text = "RunStatus";
            // 
            // cmbRunMode
            // 
            this.cmbRunMode.Items.AddRange(new object[] {
            "Program",
            "Run"});
            this.cmbRunMode.Location = new System.Drawing.Point(154, 36);
            this.cmbRunMode.Name = "cmbRunMode";
            this.cmbRunMode.Size = new System.Drawing.Size(192, 23);
            this.cmbRunMode.TabIndex = 1;
            // 
            // labelRunMode
            // 
            this.labelRunMode.Location = new System.Drawing.Point(26, 36);
            this.labelRunMode.Name = "labelRunMode";
            this.labelRunMode.Size = new System.Drawing.Size(88, 24);
            this.labelRunMode.TabIndex = 0;
            this.labelRunMode.Text = "RunMode";
            // 
            // groupBoxClock
            // 
            this.groupBoxClock.Controls.Add(this.btnSetClock);
            this.groupBoxClock.Controls.Add(this.btnGetClock);
            this.groupBoxClock.Controls.Add(this.txtClock);
            this.groupBoxClock.Location = new System.Drawing.Point(13, 84);
            this.groupBoxClock.Name = "groupBoxClock";
            this.groupBoxClock.Size = new System.Drawing.Size(499, 72);
            this.groupBoxClock.TabIndex = 1;
            this.groupBoxClock.TabStop = false;
            this.groupBoxClock.Text = "Clock";
            // 
            // btnSetClock
            // 
            this.btnSetClock.Location = new System.Drawing.Point(384, 24);
            this.btnSetClock.Name = "btnSetClock";
            this.btnSetClock.Size = new System.Drawing.Size(102, 36);
            this.btnSetClock.TabIndex = 2;
            this.btnSetClock.Text = "Set";
            this.btnSetClock.Click += new System.EventHandler(this.btnSetClock_Click);
            // 
            // btnGetClock
            // 
            this.btnGetClock.Location = new System.Drawing.Point(282, 24);
            this.btnGetClock.Name = "btnGetClock";
            this.btnGetClock.Size = new System.Drawing.Size(102, 36);
            this.btnGetClock.TabIndex = 1;
            this.btnGetClock.Text = "Get";
            this.btnGetClock.Click += new System.EventHandler(this.btnGetClock_Click);
            // 
            // txtClock
            // 
            this.txtClock.Location = new System.Drawing.Point(13, 24);
            this.txtClock.Name = "txtClock";
            this.txtClock.Size = new System.Drawing.Size(243, 25);
            this.txtClock.TabIndex = 0;
            // 
            // groupBoxUnitName
            // 
            this.groupBoxUnitName.Controls.Add(this.btnSetUnitName);
            this.groupBoxUnitName.Controls.Add(this.btnGetUnitName);
            this.groupBoxUnitName.Controls.Add(this.txtUnitName);
            this.groupBoxUnitName.Location = new System.Drawing.Point(13, 12);
            this.groupBoxUnitName.Name = "groupBoxUnitName";
            this.groupBoxUnitName.Size = new System.Drawing.Size(499, 72);
            this.groupBoxUnitName.TabIndex = 0;
            this.groupBoxUnitName.TabStop = false;
            this.groupBoxUnitName.Text = "Unit Name";
            // 
            // btnSetUnitName
            // 
            this.btnSetUnitName.Location = new System.Drawing.Point(384, 24);
            this.btnSetUnitName.Name = "btnSetUnitName";
            this.btnSetUnitName.Size = new System.Drawing.Size(102, 36);
            this.btnSetUnitName.TabIndex = 2;
            this.btnSetUnitName.Text = "Set";
            this.btnSetUnitName.Click += new System.EventHandler(this.btnSetUnitName_Click);
            // 
            // btnGetUnitName
            // 
            this.btnGetUnitName.Location = new System.Drawing.Point(282, 24);
            this.btnGetUnitName.Name = "btnGetUnitName";
            this.btnGetUnitName.Size = new System.Drawing.Size(102, 36);
            this.btnGetUnitName.TabIndex = 1;
            this.btnGetUnitName.Text = "Get";
            this.btnGetUnitName.Click += new System.EventHandler(this.btnGetUnitName_Click);
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(13, 24);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(243, 25);
            this.txtUnitName.TabIndex = 0;
            // 
            // tabPageOption
            // 
            this.tabPageOption.Controls.Add(this.groupBoxPlcEncoding);
            this.tabPageOption.Controls.Add(this.groupBoxHeartBeat);
            this.tabPageOption.Controls.Add(this.groupBoxMessageTimeLimit);
            this.tabPageOption.Location = new System.Drawing.Point(4, 21);
            this.tabPageOption.Name = "tabPageOption";
            this.tabPageOption.Size = new System.Drawing.Size(531, 587);
            this.tabPageOption.TabIndex = 2;
            this.tabPageOption.Text = "Options";
            // 
            // groupBoxPlcEncoding
            // 
            this.groupBoxPlcEncoding.Controls.Add(this.btnSetPlcEncoding);
            this.groupBoxPlcEncoding.Controls.Add(this.btnGetPlcEncoding);
            this.groupBoxPlcEncoding.Controls.Add(this.cmbPlcEncodingName);
            this.groupBoxPlcEncoding.Location = new System.Drawing.Point(13, 204);
            this.groupBoxPlcEncoding.Name = "groupBoxPlcEncoding";
            this.groupBoxPlcEncoding.Size = new System.Drawing.Size(499, 84);
            this.groupBoxPlcEncoding.TabIndex = 2;
            this.groupBoxPlcEncoding.TabStop = false;
            this.groupBoxPlcEncoding.Text = "PlcEncoding";
            // 
            // btnSetPlcEncoding
            // 
            this.btnSetPlcEncoding.Location = new System.Drawing.Point(384, 36);
            this.btnSetPlcEncoding.Name = "btnSetPlcEncoding";
            this.btnSetPlcEncoding.Size = new System.Drawing.Size(102, 36);
            this.btnSetPlcEncoding.TabIndex = 2;
            this.btnSetPlcEncoding.Text = "Set";
            this.btnSetPlcEncoding.Click += new System.EventHandler(this.btnSetPlcEncoding_Click);
            // 
            // btnGetPlcEncoding
            // 
            this.btnGetPlcEncoding.Location = new System.Drawing.Point(282, 36);
            this.btnGetPlcEncoding.Name = "btnGetPlcEncoding";
            this.btnGetPlcEncoding.Size = new System.Drawing.Size(102, 36);
            this.btnGetPlcEncoding.TabIndex = 1;
            this.btnGetPlcEncoding.Text = "Get";
            this.btnGetPlcEncoding.Click += new System.EventHandler(this.btnGetPlcEncoding_Click);
            // 
            // cmbPlcEncodingName
            // 
            this.cmbPlcEncodingName.Items.AddRange(new object[] {
            "utf-8",
            "shift_jis"});
            this.cmbPlcEncodingName.Location = new System.Drawing.Point(13, 36);
            this.cmbPlcEncodingName.Name = "cmbPlcEncodingName";
            this.cmbPlcEncodingName.Size = new System.Drawing.Size(256, 23);
            this.cmbPlcEncodingName.TabIndex = 0;
            this.cmbPlcEncodingName.Text = "utf-8";
            // 
            // groupBoxHeartBeat
            // 
            this.groupBoxHeartBeat.Controls.Add(this.txtCurrentTime);
            this.groupBoxHeartBeat.Controls.Add(this.labelCurrentTime);
            this.groupBoxHeartBeat.Controls.Add(this.btnSetHeartBeat);
            this.groupBoxHeartBeat.Controls.Add(this.btnGetHeartBeatTimer);
            this.groupBoxHeartBeat.Controls.Add(this.labelSEC);
            this.groupBoxHeartBeat.Controls.Add(this.txtTimerInterval);
            this.groupBoxHeartBeat.Controls.Add(this.labelHeartBeatTimer);
            this.groupBoxHeartBeat.Location = new System.Drawing.Point(13, 96);
            this.groupBoxHeartBeat.Name = "groupBoxHeartBeat";
            this.groupBoxHeartBeat.Size = new System.Drawing.Size(499, 108);
            this.groupBoxHeartBeat.TabIndex = 1;
            this.groupBoxHeartBeat.TabStop = false;
            this.groupBoxHeartBeat.Text = "HeartBeat";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Location = new System.Drawing.Point(166, 72);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(320, 25);
            this.txtCurrentTime.TabIndex = 6;
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Location = new System.Drawing.Point(13, 72);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(141, 24);
            this.labelCurrentTime.TabIndex = 5;
            this.labelCurrentTime.Text = "_CurrentTime";
            // 
            // btnSetHeartBeat
            // 
            this.btnSetHeartBeat.Location = new System.Drawing.Point(384, 24);
            this.btnSetHeartBeat.Name = "btnSetHeartBeat";
            this.btnSetHeartBeat.Size = new System.Drawing.Size(102, 36);
            this.btnSetHeartBeat.TabIndex = 4;
            this.btnSetHeartBeat.Text = "Set";
            this.btnSetHeartBeat.Click += new System.EventHandler(this.btnSetHeartBeat_Click);
            // 
            // btnGetHeartBeatTimer
            // 
            this.btnGetHeartBeatTimer.Location = new System.Drawing.Point(282, 24);
            this.btnGetHeartBeatTimer.Name = "btnGetHeartBeatTimer";
            this.btnGetHeartBeatTimer.Size = new System.Drawing.Size(102, 36);
            this.btnGetHeartBeatTimer.TabIndex = 3;
            this.btnGetHeartBeatTimer.Text = "Get";
            this.btnGetHeartBeatTimer.Click += new System.EventHandler(this.btnGetHeartBeatTimer_Click);
            // 
            // labelSEC
            // 
            this.labelSEC.Location = new System.Drawing.Point(218, 36);
            this.labelSEC.Name = "labelSEC";
            this.labelSEC.Size = new System.Drawing.Size(51, 24);
            this.labelSEC.TabIndex = 2;
            this.labelSEC.Text = "(sec)";
            // 
            // txtTimerInterval
            // 
            this.txtTimerInterval.Location = new System.Drawing.Point(166, 24);
            this.txtTimerInterval.Name = "txtTimerInterval";
            this.txtTimerInterval.Size = new System.Drawing.Size(52, 25);
            this.txtTimerInterval.TabIndex = 1;
            this.txtTimerInterval.Text = "1";
            // 
            // labelHeartBeatTimer
            // 
            this.labelHeartBeatTimer.Location = new System.Drawing.Point(13, 36);
            this.labelHeartBeatTimer.Name = "labelHeartBeatTimer";
            this.labelHeartBeatTimer.Size = new System.Drawing.Size(141, 24);
            this.labelHeartBeatTimer.TabIndex = 0;
            this.labelHeartBeatTimer.Text = "HeartBeatTimer";
            // 
            // groupBoxMessageTimeLimit
            // 
            this.groupBoxMessageTimeLimit.Controls.Add(this.btnSetMessageTimeLimit);
            this.groupBoxMessageTimeLimit.Controls.Add(this.btnGetMessageTimeLimit);
            this.groupBoxMessageTimeLimit.Controls.Add(this.labelMS);
            this.groupBoxMessageTimeLimit.Controls.Add(this.txtReceiveTimeLimit);
            this.groupBoxMessageTimeLimit.Location = new System.Drawing.Point(13, 12);
            this.groupBoxMessageTimeLimit.Name = "groupBoxMessageTimeLimit";
            this.groupBoxMessageTimeLimit.Size = new System.Drawing.Size(499, 84);
            this.groupBoxMessageTimeLimit.TabIndex = 0;
            this.groupBoxMessageTimeLimit.TabStop = false;
            this.groupBoxMessageTimeLimit.Text = "Message Time Limit";
            // 
            // btnSetMessageTimeLimit
            // 
            this.btnSetMessageTimeLimit.Location = new System.Drawing.Point(384, 36);
            this.btnSetMessageTimeLimit.Name = "btnSetMessageTimeLimit";
            this.btnSetMessageTimeLimit.Size = new System.Drawing.Size(102, 36);
            this.btnSetMessageTimeLimit.TabIndex = 3;
            this.btnSetMessageTimeLimit.Text = "Set";
            this.btnSetMessageTimeLimit.Click += new System.EventHandler(this.btnSetMessageTimeLimit_Click);
            // 
            // btnGetMessageTimeLimit
            // 
            this.btnGetMessageTimeLimit.Location = new System.Drawing.Point(282, 36);
            this.btnGetMessageTimeLimit.Name = "btnGetMessageTimeLimit";
            this.btnGetMessageTimeLimit.Size = new System.Drawing.Size(102, 36);
            this.btnGetMessageTimeLimit.TabIndex = 2;
            this.btnGetMessageTimeLimit.Text = "Get";
            this.btnGetMessageTimeLimit.Click += new System.EventHandler(this.btnGetMessageTimeLimit_Click);
            // 
            // labelMS
            // 
            this.labelMS.Location = new System.Drawing.Point(141, 48);
            this.labelMS.Name = "labelMS";
            this.labelMS.Size = new System.Drawing.Size(51, 24);
            this.labelMS.TabIndex = 1;
            this.labelMS.Text = "(ms)";
            // 
            // txtReceiveTimeLimit
            // 
            this.txtReceiveTimeLimit.Location = new System.Drawing.Point(13, 36);
            this.txtReceiveTimeLimit.Name = "txtReceiveTimeLimit";
            this.txtReceiveTimeLimit.Size = new System.Drawing.Size(115, 25);
            this.txtReceiveTimeLimit.TabIndex = 0;
            this.txtReceiveTimeLimit.Text = "0";
            this.txtReceiveTimeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Controls.Add(this.grpExecuteStatistics);
            this.tabPageStatistics.Controls.Add(this.grpLatestExecuteTime);
            this.tabPageStatistics.Controls.Add(this.grpMaxExecuteTimeSpan);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 21);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(531, 587);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistics";
            // 
            // grpExecuteStatistics
            // 
            this.grpExecuteStatistics.Controls.Add(this.dataGridViewExecuteStatistics);
            this.grpExecuteStatistics.Controls.Add(this.btnGetExecuteStatistics);
            this.grpExecuteStatistics.Controls.Add(this.btnAllClearExecuteStatistics);
            this.grpExecuteStatistics.Controls.Add(this.btnClearExecuteStatistics);
            this.grpExecuteStatistics.Location = new System.Drawing.Point(10, 186);
            this.grpExecuteStatistics.Name = "grpExecuteStatistics";
            this.grpExecuteStatistics.Size = new System.Drawing.Size(505, 357);
            this.grpExecuteStatistics.TabIndex = 2;
            this.grpExecuteStatistics.TabStop = false;
            this.grpExecuteStatistics.Text = "ExecuteTime Statistics";
            // 
            // dataGridViewExecuteStatistics
            // 
            this.dataGridViewExecuteStatistics.AllowUserToAddRows = false;
            this.dataGridViewExecuteStatistics.AllowUserToDeleteRows = false;
            this.dataGridViewExecuteStatistics.AllowUserToResizeRows = false;
            this.dataGridViewExecuteStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExecuteStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMin,
            this.colMax,
            this.colAverage});
            this.dataGridViewExecuteStatistics.Location = new System.Drawing.Point(10, 27);
            this.dataGridViewExecuteStatistics.MultiSelect = false;
            this.dataGridViewExecuteStatistics.Name = "dataGridViewExecuteStatistics";
            this.dataGridViewExecuteStatistics.RowHeadersVisible = false;
            this.dataGridViewExecuteStatistics.RowHeadersWidth = 51;
            this.dataGridViewExecuteStatistics.RowTemplate.Height = 21;
            this.dataGridViewExecuteStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExecuteStatistics.Size = new System.Drawing.Size(486, 275);
            this.dataGridViewExecuteStatistics.StandardTab = true;
            this.dataGridViewExecuteStatistics.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "TargetType";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 120;
            // 
            // colMin
            // 
            this.colMin.DataPropertyName = "Min";
            this.colMin.HeaderText = "Min";
            this.colMin.MinimumWidth = 6;
            this.colMin.Name = "colMin";
            this.colMin.ReadOnly = true;
            this.colMin.Width = 60;
            // 
            // colMax
            // 
            this.colMax.DataPropertyName = "Max";
            this.colMax.HeaderText = "Max";
            this.colMax.MinimumWidth = 6;
            this.colMax.Name = "colMax";
            this.colMax.ReadOnly = true;
            this.colMax.Width = 60;
            // 
            // colAverage
            // 
            this.colAverage.DataPropertyName = "Average";
            this.colAverage.HeaderText = "Average";
            this.colAverage.MinimumWidth = 6;
            this.colAverage.Name = "colAverage";
            this.colAverage.ReadOnly = true;
            this.colAverage.Width = 60;
            // 
            // btnGetExecuteStatistics
            // 
            this.btnGetExecuteStatistics.Location = new System.Drawing.Point(10, 314);
            this.btnGetExecuteStatistics.Name = "btnGetExecuteStatistics";
            this.btnGetExecuteStatistics.Size = new System.Drawing.Size(94, 34);
            this.btnGetExecuteStatistics.TabIndex = 1;
            this.btnGetExecuteStatistics.Text = "Get";
            this.btnGetExecuteStatistics.UseVisualStyleBackColor = true;
            this.btnGetExecuteStatistics.Click += new System.EventHandler(this.btnGetExecuteStatistics_Click);
            // 
            // btnAllClearExecuteStatistics
            // 
            this.btnAllClearExecuteStatistics.Location = new System.Drawing.Point(294, 314);
            this.btnAllClearExecuteStatistics.Name = "btnAllClearExecuteStatistics";
            this.btnAllClearExecuteStatistics.Size = new System.Drawing.Size(120, 34);
            this.btnAllClearExecuteStatistics.TabIndex = 3;
            this.btnAllClearExecuteStatistics.Text = "All Clear";
            this.btnAllClearExecuteStatistics.UseVisualStyleBackColor = true;
            this.btnAllClearExecuteStatistics.Click += new System.EventHandler(this.btnAllClearExecuteStatistics_Click);
            // 
            // btnClearExecuteStatistics
            // 
            this.btnClearExecuteStatistics.Location = new System.Drawing.Point(165, 314);
            this.btnClearExecuteStatistics.Name = "btnClearExecuteStatistics";
            this.btnClearExecuteStatistics.Size = new System.Drawing.Size(120, 34);
            this.btnClearExecuteStatistics.TabIndex = 2;
            this.btnClearExecuteStatistics.Text = "Clear";
            this.btnClearExecuteStatistics.UseVisualStyleBackColor = true;
            this.btnClearExecuteStatistics.Click += new System.EventHandler(this.btnClearExecuteStatistics_Click);
            // 
            // grpLatestExecuteTime
            // 
            this.grpLatestExecuteTime.Controls.Add(this.btnClearLatestExecuteTime);
            this.grpLatestExecuteTime.Controls.Add(this.btnGetLatestExecuteTime);
            this.grpLatestExecuteTime.Controls.Add(this.txtLatestExecuteTime);
            this.grpLatestExecuteTime.Location = new System.Drawing.Point(10, 16);
            this.grpLatestExecuteTime.Name = "grpLatestExecuteTime";
            this.grpLatestExecuteTime.Size = new System.Drawing.Size(505, 74);
            this.grpLatestExecuteTime.TabIndex = 0;
            this.grpLatestExecuteTime.TabStop = false;
            this.grpLatestExecuteTime.Text = "LatestExecuteTime";
            // 
            // btnClearLatestExecuteTime
            // 
            this.btnClearLatestExecuteTime.Location = new System.Drawing.Point(402, 27);
            this.btnClearLatestExecuteTime.Name = "btnClearLatestExecuteTime";
            this.btnClearLatestExecuteTime.Size = new System.Drawing.Size(94, 35);
            this.btnClearLatestExecuteTime.TabIndex = 2;
            this.btnClearLatestExecuteTime.Text = "Clear";
            this.btnClearLatestExecuteTime.UseVisualStyleBackColor = true;
            this.btnClearLatestExecuteTime.Click += new System.EventHandler(this.btnClearLatestExecuteTime_Click);
            // 
            // btnGetLatestExecuteTime
            // 
            this.btnGetLatestExecuteTime.Location = new System.Drawing.Point(298, 27);
            this.btnGetLatestExecuteTime.Name = "btnGetLatestExecuteTime";
            this.btnGetLatestExecuteTime.Size = new System.Drawing.Size(94, 35);
            this.btnGetLatestExecuteTime.TabIndex = 1;
            this.btnGetLatestExecuteTime.Text = "Get";
            this.btnGetLatestExecuteTime.UseVisualStyleBackColor = true;
            this.btnGetLatestExecuteTime.Click += new System.EventHandler(this.btnGetLatestExecuteTime_Click);
            // 
            // txtLatestExecuteTime
            // 
            this.txtLatestExecuteTime.Location = new System.Drawing.Point(10, 30);
            this.txtLatestExecuteTime.Name = "txtLatestExecuteTime";
            this.txtLatestExecuteTime.ReadOnly = true;
            this.txtLatestExecuteTime.Size = new System.Drawing.Size(275, 25);
            this.txtLatestExecuteTime.TabIndex = 0;
            // 
            // grpMaxExecuteTimeSpan
            // 
            this.grpMaxExecuteTimeSpan.Controls.Add(this.btnClearMaxExecuteTimeSpan);
            this.grpMaxExecuteTimeSpan.Controls.Add(this.btnGetMaxExecuteTimeSpan);
            this.grpMaxExecuteTimeSpan.Controls.Add(this.txtMaxExecuteTimeSpan);
            this.grpMaxExecuteTimeSpan.Location = new System.Drawing.Point(10, 99);
            this.grpMaxExecuteTimeSpan.Name = "grpMaxExecuteTimeSpan";
            this.grpMaxExecuteTimeSpan.Size = new System.Drawing.Size(505, 73);
            this.grpMaxExecuteTimeSpan.TabIndex = 1;
            this.grpMaxExecuteTimeSpan.TabStop = false;
            this.grpMaxExecuteTimeSpan.Text = "MaxExecuteTimeSpan";
            // 
            // btnClearMaxExecuteTimeSpan
            // 
            this.btnClearMaxExecuteTimeSpan.Location = new System.Drawing.Point(402, 27);
            this.btnClearMaxExecuteTimeSpan.Name = "btnClearMaxExecuteTimeSpan";
            this.btnClearMaxExecuteTimeSpan.Size = new System.Drawing.Size(94, 35);
            this.btnClearMaxExecuteTimeSpan.TabIndex = 2;
            this.btnClearMaxExecuteTimeSpan.Text = "Clear";
            this.btnClearMaxExecuteTimeSpan.UseVisualStyleBackColor = true;
            this.btnClearMaxExecuteTimeSpan.Click += new System.EventHandler(this.btnClearMaxExecuteTimeSpan_Click);
            // 
            // btnGetMaxExecuteTimeSpan
            // 
            this.btnGetMaxExecuteTimeSpan.Location = new System.Drawing.Point(298, 27);
            this.btnGetMaxExecuteTimeSpan.Name = "btnGetMaxExecuteTimeSpan";
            this.btnGetMaxExecuteTimeSpan.Size = new System.Drawing.Size(94, 35);
            this.btnGetMaxExecuteTimeSpan.TabIndex = 1;
            this.btnGetMaxExecuteTimeSpan.Text = "Get";
            this.btnGetMaxExecuteTimeSpan.UseVisualStyleBackColor = true;
            this.btnGetMaxExecuteTimeSpan.Click += new System.EventHandler(this.btnGetMaxExecuteTimeSpan_Click);
            // 
            // txtMaxExecuteTimeSpan
            // 
            this.txtMaxExecuteTimeSpan.Location = new System.Drawing.Point(10, 30);
            this.txtMaxExecuteTimeSpan.Name = "txtMaxExecuteTimeSpan";
            this.txtMaxExecuteTimeSpan.ReadOnly = true;
            this.txtMaxExecuteTimeSpan.Size = new System.Drawing.Size(275, 25);
            this.txtMaxExecuteTimeSpan.TabIndex = 0;
            // 
            // chkDoNotFragment
            // 
            this.chkDoNotFragment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDoNotFragment.Location = new System.Drawing.Point(13, 470);
            this.chkDoNotFragment.Name = "chkDoNotFragment";
            this.chkDoNotFragment.Size = new System.Drawing.Size(179, 24);
            this.chkDoNotFragment.TabIndex = 2;
            this.chkDoNotFragment.Text = "DoNotFragment";
            this.chkDoNotFragment.CheckedChanged += new System.EventHandler(this.chkDoNotFragment_CheckedChanged);
            // 
            // groupBoxTagTableVariables
            // 
            this.groupBoxTagTableVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTagTableVariables.Controls.Add(this.groupBoxBinaryVariableEdit);
            this.groupBoxTagTableVariables.Controls.Add(this.groupBoxVariableEdit);
            this.groupBoxTagTableVariables.Controls.Add(this.btnGetVaiable);
            this.groupBoxTagTableVariables.Controls.Add(this.chkSystemVariable);
            this.groupBoxTagTableVariables.Controls.Add(this.listViewOfVariableNames);
            this.groupBoxTagTableVariables.Controls.Add(this.chkDoNotFragment);
            this.groupBoxTagTableVariables.Location = new System.Drawing.Point(562, 12);
            this.groupBoxTagTableVariables.Name = "groupBoxTagTableVariables";
            this.groupBoxTagTableVariables.Size = new System.Drawing.Size(600, 734);
            this.groupBoxTagTableVariables.TabIndex = 1;
            this.groupBoxTagTableVariables.TabStop = false;
            this.groupBoxTagTableVariables.Text = "TagTable Variables";
            // 
            // groupBoxBinaryVariableEdit
            // 
            this.groupBoxBinaryVariableEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBinaryVariableEdit.Controls.Add(this.btnWriteRaw);
            this.groupBoxBinaryVariableEdit.Controls.Add(this.btnReadRaw);
            this.groupBoxBinaryVariableEdit.Controls.Add(this.txtBinaryValue);
            this.groupBoxBinaryVariableEdit.Controls.Add(this.labelValueOfBinary);
            this.groupBoxBinaryVariableEdit.Controls.Add(this.btnReadRawDataMultiple);
            this.groupBoxBinaryVariableEdit.Controls.Add(this.txtBinaryVariableName);
            this.groupBoxBinaryVariableEdit.Controls.Add(this.labelNameForUseBinary);
            this.groupBoxBinaryVariableEdit.Location = new System.Drawing.Point(13, 614);
            this.groupBoxBinaryVariableEdit.Name = "groupBoxBinaryVariableEdit";
            this.groupBoxBinaryVariableEdit.Size = new System.Drawing.Size(575, 108);
            this.groupBoxBinaryVariableEdit.TabIndex = 5;
            this.groupBoxBinaryVariableEdit.TabStop = false;
            this.groupBoxBinaryVariableEdit.Text = "Binary Variable Edit";
            // 
            // btnWriteRaw
            // 
            this.btnWriteRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteRaw.Location = new System.Drawing.Point(460, 60);
            this.btnWriteRaw.Name = "btnWriteRaw";
            this.btnWriteRaw.Size = new System.Drawing.Size(102, 36);
            this.btnWriteRaw.TabIndex = 6;
            this.btnWriteRaw.Text = "WriteRaw";
            this.btnWriteRaw.Click += new System.EventHandler(this.btnWriteRaw_Click);
            // 
            // btnReadRaw
            // 
            this.btnReadRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadRaw.Location = new System.Drawing.Point(358, 60);
            this.btnReadRaw.Name = "btnReadRaw";
            this.btnReadRaw.Size = new System.Drawing.Size(102, 36);
            this.btnReadRaw.TabIndex = 5;
            this.btnReadRaw.Text = "ReadRaw";
            this.btnReadRaw.Click += new System.EventHandler(this.btnReadRaw_Click);
            // 
            // txtBinaryValue
            // 
            this.txtBinaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryValue.Location = new System.Drawing.Point(102, 60);
            this.txtBinaryValue.Name = "txtBinaryValue";
            this.txtBinaryValue.Size = new System.Drawing.Size(230, 25);
            this.txtBinaryValue.TabIndex = 3;
            this.txtBinaryValue.Text = "00";
            // 
            // labelValueOfBinary
            // 
            this.labelValueOfBinary.Location = new System.Drawing.Point(13, 60);
            this.labelValueOfBinary.Name = "labelValueOfBinary";
            this.labelValueOfBinary.Size = new System.Drawing.Size(64, 24);
            this.labelValueOfBinary.TabIndex = 2;
            this.labelValueOfBinary.Text = "Value";
            // 
            // btnReadRawDataMultiple
            // 
            this.btnReadRawDataMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadRawDataMultiple.Location = new System.Drawing.Point(358, 24);
            this.btnReadRawDataMultiple.Name = "btnReadRawDataMultiple";
            this.btnReadRawDataMultiple.Size = new System.Drawing.Size(204, 36);
            this.btnReadRawDataMultiple.TabIndex = 4;
            this.btnReadRawDataMultiple.Text = "ReadRawMultiple";
            this.btnReadRawDataMultiple.Click += new System.EventHandler(this.btnReadRawDataMultiple_Click);
            // 
            // txtBinaryVariableName
            // 
            this.txtBinaryVariableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryVariableName.Location = new System.Drawing.Point(102, 24);
            this.txtBinaryVariableName.Name = "txtBinaryVariableName";
            this.txtBinaryVariableName.Size = new System.Drawing.Size(230, 25);
            this.txtBinaryVariableName.TabIndex = 1;
            // 
            // labelNameForUseBinary
            // 
            this.labelNameForUseBinary.Location = new System.Drawing.Point(13, 24);
            this.labelNameForUseBinary.Name = "labelNameForUseBinary";
            this.labelNameForUseBinary.Size = new System.Drawing.Size(64, 24);
            this.labelNameForUseBinary.TabIndex = 0;
            this.labelNameForUseBinary.Text = "Name";
            // 
            // groupBoxVariableEdit
            // 
            this.groupBoxVariableEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVariableEdit.Controls.Add(this.btnWriteVariable);
            this.groupBoxVariableEdit.Controls.Add(this.btnReadVariable);
            this.groupBoxVariableEdit.Controls.Add(this.txtValue);
            this.groupBoxVariableEdit.Controls.Add(this.labelValue);
            this.groupBoxVariableEdit.Controls.Add(this.btnReadVariableMultiple);
            this.groupBoxVariableEdit.Controls.Add(this.txtVariableName);
            this.groupBoxVariableEdit.Controls.Add(this.labelName);
            this.groupBoxVariableEdit.Location = new System.Drawing.Point(13, 506);
            this.groupBoxVariableEdit.Name = "groupBoxVariableEdit";
            this.groupBoxVariableEdit.Size = new System.Drawing.Size(575, 108);
            this.groupBoxVariableEdit.TabIndex = 4;
            this.groupBoxVariableEdit.TabStop = false;
            this.groupBoxVariableEdit.Text = "Variable Edit";
            // 
            // btnWriteVariable
            // 
            this.btnWriteVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteVariable.Location = new System.Drawing.Point(460, 60);
            this.btnWriteVariable.Name = "btnWriteVariable";
            this.btnWriteVariable.Size = new System.Drawing.Size(102, 36);
            this.btnWriteVariable.TabIndex = 6;
            this.btnWriteVariable.Text = "Write";
            this.btnWriteVariable.Click += new System.EventHandler(this.btnWriteVariable_Click);
            // 
            // btnReadVariable
            // 
            this.btnReadVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadVariable.Location = new System.Drawing.Point(358, 60);
            this.btnReadVariable.Name = "btnReadVariable";
            this.btnReadVariable.Size = new System.Drawing.Size(102, 36);
            this.btnReadVariable.TabIndex = 5;
            this.btnReadVariable.Text = "Read";
            this.btnReadVariable.Click += new System.EventHandler(this.btnReadVariable_Click);
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(102, 60);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(230, 25);
            this.txtValue.TabIndex = 3;
            this.txtValue.Text = "0";
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(13, 60);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(64, 24);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            // 
            // btnReadVariableMultiple
            // 
            this.btnReadVariableMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadVariableMultiple.Location = new System.Drawing.Point(358, 24);
            this.btnReadVariableMultiple.Name = "btnReadVariableMultiple";
            this.btnReadVariableMultiple.Size = new System.Drawing.Size(204, 36);
            this.btnReadVariableMultiple.TabIndex = 4;
            this.btnReadVariableMultiple.Text = "ReadVariableMultiple";
            this.btnReadVariableMultiple.Click += new System.EventHandler(this.btnReadVariableMultiple_Click);
            // 
            // txtVariableName
            // 
            this.txtVariableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVariableName.Location = new System.Drawing.Point(102, 24);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(230, 25);
            this.txtVariableName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(13, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // btnGetVaiable
            // 
            this.btnGetVaiable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetVaiable.Location = new System.Drawing.Point(370, 434);
            this.btnGetVaiable.Name = "btnGetVaiable";
            this.btnGetVaiable.Size = new System.Drawing.Size(205, 36);
            this.btnGetVaiable.TabIndex = 3;
            this.btnGetVaiable.Text = "Variable Names";
            this.btnGetVaiable.Click += new System.EventHandler(this.btnGetVaiable_Click);
            // 
            // chkSystemVariable
            // 
            this.chkSystemVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSystemVariable.Location = new System.Drawing.Point(13, 434);
            this.chkSystemVariable.Name = "chkSystemVariable";
            this.chkSystemVariable.Size = new System.Drawing.Size(192, 36);
            this.chkSystemVariable.TabIndex = 1;
            this.chkSystemVariable.Text = "System Variable";
            // 
            // listViewOfVariableNames
            // 
            this.listViewOfVariableNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOfVariableNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.variableNameOfTagTable,
            this.variableTypeOfTagTable,
            this.variableValueOfTagTable});
            this.listViewOfVariableNames.FullRowSelect = true;
            this.listViewOfVariableNames.GridLines = true;
            this.listViewOfVariableNames.HideSelection = false;
            this.listViewOfVariableNames.Location = new System.Drawing.Point(5, 22);
            this.listViewOfVariableNames.Name = "listViewOfVariableNames";
            this.listViewOfVariableNames.Size = new System.Drawing.Size(591, 400);
            this.listViewOfVariableNames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewOfVariableNames.TabIndex = 0;
            this.listViewOfVariableNames.UseCompatibleStateImageBehavior = false;
            this.listViewOfVariableNames.View = System.Windows.Forms.View.Details;
            this.listViewOfVariableNames.SelectedIndexChanged += new System.EventHandler(this.listViewOfVariableNames_SelectedIndexChanged);
            // 
            // variableNameOfTagTable
            // 
            this.variableNameOfTagTable.Text = "Name";
            this.variableNameOfTagTable.Width = 81;
            // 
            // variableTypeOfTagTable
            // 
            this.variableTypeOfTagTable.Text = "Type";
            this.variableTypeOfTagTable.Width = 104;
            // 
            // variableValueOfTagTable
            // 
            this.variableValueOfTagTable.Text = "Value";
            this.variableValueOfTagTable.Width = 99;
            // 
            // NXCompoletSampleForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(1175, 778);
            this.Controls.Add(this.groupBoxTagTableVariables);
            this.Controls.Add(this.tabNXCompolet);
            this.Name = "NXCompoletSampleForm";
            this.Text = "NX Compolet Sample C#";
            this.tabNXCompolet.ResumeLayout(false);
            this.tabPageCommunication.ResumeLayout(false);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxRoutePath.ResumeLayout(false);
            this.groupBoxRoutePath.PerformLayout();
            this.groupBoxPeerAddress.ResumeLayout(false);
            this.groupBoxPeerAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortNo)).EndInit();
            this.tabPageController.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxClock.ResumeLayout(false);
            this.groupBoxClock.PerformLayout();
            this.groupBoxUnitName.ResumeLayout(false);
            this.groupBoxUnitName.PerformLayout();
            this.tabPageOption.ResumeLayout(false);
            this.groupBoxPlcEncoding.ResumeLayout(false);
            this.groupBoxHeartBeat.ResumeLayout(false);
            this.groupBoxHeartBeat.PerformLayout();
            this.groupBoxMessageTimeLimit.ResumeLayout(false);
            this.groupBoxMessageTimeLimit.PerformLayout();
            this.tabPageStatistics.ResumeLayout(false);
            this.grpExecuteStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecuteStatistics)).EndInit();
            this.grpLatestExecuteTime.ResumeLayout(false);
            this.grpLatestExecuteTime.PerformLayout();
            this.grpMaxExecuteTimeSpan.ResumeLayout(false);
            this.grpMaxExecuteTimeSpan.PerformLayout();
            this.groupBoxTagTableVariables.ResumeLayout(false);
            this.groupBoxBinaryVariableEdit.ResumeLayout(false);
            this.groupBoxBinaryVariableEdit.PerformLayout();
            this.groupBoxVariableEdit.ResumeLayout(false);
            this.groupBoxVariableEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNXCompolet;
        private System.Windows.Forms.TabPage tabPageCommunication;
        private System.Windows.Forms.TabPage tabPageController;
        private System.Windows.Forms.TabPage tabPageOption;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.GroupBox groupBoxPeerAddress;
        private System.Windows.Forms.RadioButton radioPeerAddress;
        private System.Windows.Forms.Label labelPortNo;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.GroupBox groupBoxRoutePath;
        private System.Windows.Forms.RadioButton radioRoutePath;
        private System.Windows.Forms.Label labelRoutePath;
        private System.Windows.Forms.TextBox txtRoutePath;
        private System.Windows.Forms.Label labelConnectionType;
        private System.Windows.Forms.ComboBox cmbConnectionType;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkDoNotFragment;
        private System.Windows.Forms.ListView listViewOfEachValue;
        private System.Windows.Forms.ColumnHeader variableName;
        private System.Windows.Forms.ColumnHeader variableValue;
        private System.Windows.Forms.GroupBox groupBoxUnitName;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Button btnGetUnitName;
        private System.Windows.Forms.Button btnSetUnitName;
        private System.Windows.Forms.GroupBox groupBoxClock;
        private System.Windows.Forms.TextBox txtClock;
        private System.Windows.Forms.Button btnGetClock;
        private System.Windows.Forms.Button btnSetClock;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelRunMode;
        private System.Windows.Forms.ComboBox cmbRunMode;
        private System.Windows.Forms.Label labelRunStatus;
        private System.Windows.Forms.ComboBox cmbRunStatus;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.GroupBox groupBoxMessageTimeLimit;
        private System.Windows.Forms.TextBox txtReceiveTimeLimit;
        private System.Windows.Forms.Label labelMS;
        private System.Windows.Forms.Button btnGetMessageTimeLimit;
        private System.Windows.Forms.Button btnSetMessageTimeLimit;
        private System.Windows.Forms.GroupBox groupBoxHeartBeat;
        private System.Windows.Forms.Label labelHeartBeatTimer;
        private System.Windows.Forms.TextBox txtTimerInterval;
        private System.Windows.Forms.Label labelSEC;
        private System.Windows.Forms.Button btnGetHeartBeatTimer;
        private System.Windows.Forms.Button btnSetHeartBeat;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.GroupBox groupBoxPlcEncoding;
        private System.Windows.Forms.ComboBox cmbPlcEncodingName;
        private System.Windows.Forms.Button btnGetPlcEncoding;
        private System.Windows.Forms.Button btnSetPlcEncoding;
        private System.Windows.Forms.GroupBox groupBoxTagTableVariables;
        private System.Windows.Forms.ListView listViewOfVariableNames;
        private System.Windows.Forms.ColumnHeader variableNameOfTagTable;
        private System.Windows.Forms.ColumnHeader variableTypeOfTagTable;
        private System.Windows.Forms.ColumnHeader variableValueOfTagTable;
        private System.Windows.Forms.CheckBox chkSystemVariable;
        private System.Windows.Forms.Button btnGetVaiable;
        private System.Windows.Forms.GroupBox groupBoxVariableEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtVariableName;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnReadVariableMultiple;
        private System.Windows.Forms.Button btnReadVariable;
        private System.Windows.Forms.Button btnWriteVariable;
        private System.Windows.Forms.GroupBox groupBoxBinaryVariableEdit;
        private System.Windows.Forms.Label labelNameForUseBinary;
        private System.Windows.Forms.TextBox txtBinaryVariableName;
        private System.Windows.Forms.Label labelValueOfBinary;
        private System.Windows.Forms.TextBox txtBinaryValue;
        private System.Windows.Forms.Button btnReadRawDataMultiple;
        private System.Windows.Forms.Button btnReadRaw;
        private System.Windows.Forms.Button btnWriteRaw;
        private OMRON.Compolet.CIP.NXCompolet nxCompolet1;
        private System.Windows.Forms.Button btnGetCommunication;
        private System.Windows.Forms.NumericUpDown numPortNo;
        private System.Windows.Forms.Button btnEventLog;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.GroupBox grpExecuteStatistics;
        private System.Windows.Forms.DataGridView dataGridViewExecuteStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.Button btnGetExecuteStatistics;
        private System.Windows.Forms.Button btnAllClearExecuteStatistics;
        private System.Windows.Forms.Button btnClearExecuteStatistics;
        private System.Windows.Forms.GroupBox grpLatestExecuteTime;
        private System.Windows.Forms.Button btnClearLatestExecuteTime;
        private System.Windows.Forms.Button btnGetLatestExecuteTime;
        private System.Windows.Forms.TextBox txtLatestExecuteTime;
        private System.Windows.Forms.GroupBox grpMaxExecuteTimeSpan;
        private System.Windows.Forms.Button btnClearMaxExecuteTimeSpan;
        private System.Windows.Forms.Button btnGetMaxExecuteTimeSpan;
        private System.Windows.Forms.TextBox txtMaxExecuteTimeSpan;
    }
}