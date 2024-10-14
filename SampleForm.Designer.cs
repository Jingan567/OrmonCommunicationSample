namespace ReadVariableSample
{
    partial class SampleForm
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTargetDevice = new System.Windows.Forms.Label();
            this.txtTargetDevice = new System.Windows.Forms.TextBox();
            this.lblRun = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtReceiveTimeoutMilliSeconds = new System.Windows.Forms.TextBox();
            this.txtIntervalMilliseconds = new System.Windows.Forms.TextBox();
            this.lblReceiveTimeoutMilliSeconds = new System.Windows.Forms.Label();
            this.lblIntervalMilliseconds = new System.Windows.Forms.Label();
            this.pnlExecute = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.chkOutputSuccess = new System.Windows.Forms.CheckBox();
            this.chkOutputError = new System.Windows.Forms.CheckBox();
            this.chkOutputKeepAlive = new System.Windows.Forms.CheckBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlExecute.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(27, 38);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTargetDevice
            // 
            this.lblTargetDevice.AutoSize = true;
            this.lblTargetDevice.Location = new System.Drawing.Point(12, 14);
            this.lblTargetDevice.Name = "lblTargetDevice";
            this.lblTargetDevice.Size = new System.Drawing.Size(261, 12);
            this.lblTargetDevice.TabIndex = 0;
            this.lblTargetDevice.Text = "Input target device and varible name (csv format).";
            // 
            // txtTargetDevice
            // 
            this.txtTargetDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDevice.Location = new System.Drawing.Point(27, 38);
            this.txtTargetDevice.Multiline = true;
            this.txtTargetDevice.Name = "txtTargetDevice";
            this.txtTargetDevice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTargetDevice.Size = new System.Drawing.Size(375, 172);
            this.txtTargetDevice.TabIndex = 1;
            this.txtTargetDevice.WordWrap = false;
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(12, 14);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(84, 12);
            this.lblRun.TabIndex = 0;
            this.lblRun.Text = "Run/Stop work.";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlInput);
            this.pnlLeft.Controls.Add(this.pnlExecute);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(425, 445);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.txtReceiveTimeoutMilliSeconds);
            this.pnlInput.Controls.Add(this.txtIntervalMilliseconds);
            this.pnlInput.Controls.Add(this.lblReceiveTimeoutMilliSeconds);
            this.pnlInput.Controls.Add(this.lblIntervalMilliseconds);
            this.pnlInput.Controls.Add(this.lblTargetDevice);
            this.pnlInput.Controls.Add(this.txtTargetDevice);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(425, 370);
            this.pnlInput.TabIndex = 0;
            // 
            // txtReceiveTimeoutMilliSeconds
            // 
            this.txtReceiveTimeoutMilliSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReceiveTimeoutMilliSeconds.Location = new System.Drawing.Point(27, 331);
            this.txtReceiveTimeoutMilliSeconds.Name = "txtReceiveTimeoutMilliSeconds";
            this.txtReceiveTimeoutMilliSeconds.Size = new System.Drawing.Size(157, 19);
            this.txtReceiveTimeoutMilliSeconds.TabIndex = 5;
            this.txtReceiveTimeoutMilliSeconds.Text = "2000";
            // 
            // txtIntervalMilliseconds
            // 
            this.txtIntervalMilliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIntervalMilliseconds.Location = new System.Drawing.Point(27, 273);
            this.txtIntervalMilliseconds.Name = "txtIntervalMilliseconds";
            this.txtIntervalMilliseconds.Size = new System.Drawing.Size(157, 19);
            this.txtIntervalMilliseconds.TabIndex = 3;
            this.txtIntervalMilliseconds.Text = "1000";
            // 
            // lblReceiveTimeoutMilliSeconds
            // 
            this.lblReceiveTimeoutMilliSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReceiveTimeoutMilliSeconds.AutoSize = true;
            this.lblReceiveTimeoutMilliSeconds.Location = new System.Drawing.Point(12, 307);
            this.lblReceiveTimeoutMilliSeconds.Name = "lblReceiveTimeoutMilliSeconds";
            this.lblReceiveTimeoutMilliSeconds.Size = new System.Drawing.Size(306, 12);
            this.lblReceiveTimeoutMilliSeconds.TabIndex = 4;
            this.lblReceiveTimeoutMilliSeconds.Text = "Receive timeout time (ms) should be set 2000 ms or more.";
            // 
            // lblIntervalMilliseconds
            // 
            this.lblIntervalMilliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIntervalMilliseconds.AutoSize = true;
            this.lblIntervalMilliseconds.Location = new System.Drawing.Point(12, 229);
            this.lblIntervalMilliseconds.Name = "lblIntervalMilliseconds";
            this.lblIntervalMilliseconds.Size = new System.Drawing.Size(219, 24);
            this.lblIntervalMilliseconds.TabIndex = 2;
            this.lblIntervalMilliseconds.Text = "Interval time (ms) until next transmission.\r\nKeep alive is enable if over 10,000 " +
                "ms.";
            // 
            // pnlExecute
            // 
            this.pnlExecute.Controls.Add(this.btnRun);
            this.pnlExecute.Controls.Add(this.lblRun);
            this.pnlExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecute.Location = new System.Drawing.Point(0, 370);
            this.pnlExecute.Name = "pnlExecute";
            this.pnlExecute.Size = new System.Drawing.Size(425, 75);
            this.pnlExecute.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(438, 14);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(54, 12);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Message..";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(452, 54);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(352, 375);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.WordWrap = false;
            // 
            // chkOutputSuccess
            // 
            this.chkOutputSuccess.AutoSize = true;
            this.chkOutputSuccess.Checked = true;
            this.chkOutputSuccess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutputSuccess.Location = new System.Drawing.Point(452, 30);
            this.chkOutputSuccess.Name = "chkOutputSuccess";
            this.chkOutputSuccess.Size = new System.Drawing.Size(67, 16);
            this.chkOutputSuccess.TabIndex = 2;
            this.chkOutputSuccess.Text = "Success";
            this.chkOutputSuccess.UseVisualStyleBackColor = true;
            // 
            // chkOutputError
            // 
            this.chkOutputError.AutoSize = true;
            this.chkOutputError.Checked = true;
            this.chkOutputError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutputError.Location = new System.Drawing.Point(525, 30);
            this.chkOutputError.Name = "chkOutputError";
            this.chkOutputError.Size = new System.Drawing.Size(49, 16);
            this.chkOutputError.TabIndex = 3;
            this.chkOutputError.Text = "Error";
            this.chkOutputError.UseVisualStyleBackColor = true;
            // 
            // chkOutputKeepAlive
            // 
            this.chkOutputKeepAlive.AutoSize = true;
            this.chkOutputKeepAlive.Checked = true;
            this.chkOutputKeepAlive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutputKeepAlive.Location = new System.Drawing.Point(580, 30);
            this.chkOutputKeepAlive.Name = "chkOutputKeepAlive";
            this.chkOutputKeepAlive.Size = new System.Drawing.Size(75, 16);
            this.chkOutputKeepAlive.TabIndex = 4;
            this.chkOutputKeepAlive.Text = "KeepAlive";
            this.chkOutputKeepAlive.UseVisualStyleBackColor = true;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(661, 26);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 5;
            this.btnClearOutput.Text = "Clear";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 445);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.chkOutputKeepAlive);
            this.Controls.Add(this.chkOutputError);
            this.Controls.Add(this.chkOutputSuccess);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Name = "SampleForm";
            this.Text = "ReadVariable Sample";
            this.pnlLeft.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlExecute.ResumeLayout(false);
            this.pnlExecute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTargetDevice;
        private System.Windows.Forms.TextBox txtTargetDevice;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtIntervalMilliseconds;
        private System.Windows.Forms.Label lblIntervalMilliseconds;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlExecute;
        private System.Windows.Forms.TextBox txtReceiveTimeoutMilliSeconds;
        private System.Windows.Forms.Label lblReceiveTimeoutMilliSeconds;
        private System.Windows.Forms.CheckBox chkOutputSuccess;
        private System.Windows.Forms.CheckBox chkOutputError;
        private System.Windows.Forms.CheckBox chkOutputKeepAlive;
        private System.Windows.Forms.Button btnClearOutput;
    }
}

