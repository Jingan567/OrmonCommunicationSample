namespace NXCompoletSample.EventLogs
{
    partial class EventLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.columnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEventCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEventSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCulture = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.cmbCulture = new System.Windows.Forms.ComboBox();
            this.txtUserMessage = new System.Windows.Forms.TextBox();
            this.btnUserMessageBrowse = new System.Windows.Forms.Button();
            this.openFileDialogUserDef = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogELR = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveElrFile = new System.Windows.Forms.Button();
            this.btnLoadElrFile = new System.Windows.Forms.Button();
            this.btnShowDetail = new System.Windows.Forms.Button();
            this.openFileDialogELR = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCategory,
            this.columnDate,
            this.columnPriority,
            this.columnEventCode,
            this.columnEventSource,
            this.columnEventName});
            this.grid.Location = new System.Drawing.Point(16, 75);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 21;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(756, 445);
            this.grid.TabIndex = 5;
            this.grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDoubleClick);
            // 
            // columnCategory
            // 
            this.columnCategory.DataPropertyName = "Category";
            this.columnCategory.HeaderText = "Category";
            this.columnCategory.Name = "columnCategory";
            // 
            // columnDate
            // 
            this.columnDate.DataPropertyName = "Time";
            this.columnDate.HeaderText = "Time";
            this.columnDate.Name = "columnDate";
            this.columnDate.Width = 120;
            // 
            // columnPriority
            // 
            this.columnPriority.DataPropertyName = "Level";
            this.columnPriority.HeaderText = "Level";
            this.columnPriority.Name = "columnPriority";
            this.columnPriority.Width = 120;
            // 
            // columnEventCode
            // 
            this.columnEventCode.DataPropertyName = "EventCode";
            this.columnEventCode.HeaderText = "Event Code";
            this.columnEventCode.Name = "columnEventCode";
            this.columnEventCode.Width = 120;
            // 
            // columnEventSource
            // 
            this.columnEventSource.DataPropertyName = "EventSource";
            this.columnEventSource.HeaderText = "Source";
            this.columnEventSource.Name = "columnEventSource";
            this.columnEventSource.Width = 120;
            // 
            // columnEventName
            // 
            this.columnEventName.DataPropertyName = "EventName";
            this.columnEventName.HeaderText = "Message";
            this.columnEventName.Name = "columnEventName";
            this.columnEventName.Width = 200;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(12, 535);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(91, 23);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Update";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(697, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCulture
            // 
            this.lblCulture.AutoSize = true;
            this.lblCulture.Location = new System.Drawing.Point(13, 13);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.Size = new System.Drawing.Size(42, 12);
            this.lblCulture.TabIndex = 0;
            this.lblCulture.Text = "Culture";
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Location = new System.Drawing.Point(14, 41);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(74, 12);
            this.lblUserMessage.TabIndex = 2;
            this.lblUserMessage.Text = "UserMessage";
            // 
            // cmbCulture
            // 
            this.cmbCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCulture.FormattingEnabled = true;
            this.cmbCulture.Location = new System.Drawing.Point(112, 10);
            this.cmbCulture.Name = "cmbCulture";
            this.cmbCulture.Size = new System.Drawing.Size(178, 20);
            this.cmbCulture.TabIndex = 1;
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.Location = new System.Drawing.Point(112, 38);
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.ReadOnly = true;
            this.txtUserMessage.Size = new System.Drawing.Size(417, 19);
            this.txtUserMessage.TabIndex = 3;
            // 
            // btnUserMessageBrowse
            // 
            this.btnUserMessageBrowse.Location = new System.Drawing.Point(535, 36);
            this.btnUserMessageBrowse.Name = "btnUserMessageBrowse";
            this.btnUserMessageBrowse.Size = new System.Drawing.Size(25, 23);
            this.btnUserMessageBrowse.TabIndex = 4;
            this.btnUserMessageBrowse.Text = "...";
            this.btnUserMessageBrowse.UseVisualStyleBackColor = true;
            this.btnUserMessageBrowse.Click += new System.EventHandler(this.btnUserMessageBrowse_Click);
            // 
            // openFileDialogUserDef
            // 
            this.openFileDialogUserDef.Filter = "UserDef(*.xml)|*.xml";
            // 
            // saveFileDialogELR
            // 
            this.saveFileDialogELR.Filter = "ELR File(*.elr)|*.elr";
            // 
            // btnSaveElrFile
            // 
            this.btnSaveElrFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveElrFile.Location = new System.Drawing.Point(188, 535);
            this.btnSaveElrFile.Name = "btnSaveElrFile";
            this.btnSaveElrFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveElrFile.TabIndex = 7;
            this.btnSaveElrFile.Text = "Save";
            this.btnSaveElrFile.UseVisualStyleBackColor = true;
            this.btnSaveElrFile.Click += new System.EventHandler(this.btnSaveElrFile_Click);
            // 
            // btnLoadElrFile
            // 
            this.btnLoadElrFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadElrFile.Location = new System.Drawing.Point(269, 535);
            this.btnLoadElrFile.Name = "btnLoadElrFile";
            this.btnLoadElrFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadElrFile.TabIndex = 8;
            this.btnLoadElrFile.Text = "Load";
            this.btnLoadElrFile.UseVisualStyleBackColor = true;
            this.btnLoadElrFile.Click += new System.EventHandler(this.btnLoadElrFile_Click);
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowDetail.Location = new System.Drawing.Point(382, 535);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(75, 23);
            this.btnShowDetail.TabIndex = 9;
            this.btnShowDetail.Text = "Detail";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // openFileDialogELR
            // 
            this.openFileDialogELR.Filter = "ELR File(*.elr)|*.elr";
            // 
            // EventLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.btnLoadElrFile);
            this.Controls.Add(this.btnSaveElrFile);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnUserMessageBrowse);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.cmbCulture);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.lblCulture);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReload);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "EventLogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventLog";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCulture;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.ComboBox cmbCulture;
        private System.Windows.Forms.TextBox txtUserMessage;
        private System.Windows.Forms.Button btnUserMessageBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialogUserDef;
        private System.Windows.Forms.SaveFileDialog saveFileDialogELR;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEventCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEventSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEventName;
        private System.Windows.Forms.Button btnSaveElrFile;
        private System.Windows.Forms.Button btnLoadElrFile;
        private System.Windows.Forms.Button btnShowDetail;
        private System.Windows.Forms.OpenFileDialog openFileDialogELR;
    }
}