using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

using OMRON.Compolet.CIP;
using OMRON.Compolet.Framework.Function.EventLogs;

namespace NXCompoletSample.EventLogs
{
    public partial class EventLogForm : Form
    {
        public EventLogForm()
        {
            InitializeComponent();
        }

        private readonly NXCompolet compolet;
        private EventLogItemCollection collection;
        private string userDefinisionPath;

        public EventLogForm(NXCompolet compolet)
            : this()
        {
            this.compolet = compolet;

            this.grid.AutoGenerateColumns = false;

            int index = -1;
            List<CultureInfo> availableCultures = EventLogItemCollection.AvailableCultures;
            if (availableCultures == null)
            {
                this.cmbCulture.Enabled = false;
                this.btnUserMessageBrowse.Enabled = false;
                this.btnReload.Enabled = false;
                this.btnSaveElrFile.Enabled = false;
                this.btnLoadElrFile.Enabled = false;
                this.btnShowDetail.Enabled = false;
                return;
            }

            for (int i = 0; i < availableCultures.Count; i++)
            {
                CultureItem ci = new CultureItem(availableCultures[i]);
                this.cmbCulture.Items.Add(ci);
                if (ci.CultureInfo.Name == "en-US")
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                this.cmbCulture.SelectedIndex = index;
                EventLogItemCollection.EventLogResourceCulture = availableCultures[index];
            }
            this.cmbCulture.SelectedIndexChanged += cmbCulture_SelectedIndexChanged;
        }

        protected override void OnLoad(System.EventArgs e)
        {
            this.UpdateData();

            base.OnLoad(e);
        }

        private void cmbCulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureItem c = this.cmbCulture.SelectedItem as CultureItem;
            if (c != null)
            {
                EventLogItemCollection.EventLogResourceCulture = c.CultureInfo;
                this.grid.Refresh();
            }
        }

        private void grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnShowDetail_Click(this, EventArgs.Empty);
        }

        private void btnReload_Click(object sender, System.EventArgs e)
        {
            this.UpdateData();
        }

        private void btnUserMessageBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogUserDef.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            this.userDefinisionPath = this.openFileDialogUserDef.FileName;
            this.txtUserMessage.Text = this.userDefinisionPath;

            LoadUserDef();
            this.grid.Refresh();
        }

        private void btnLoadElrFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogELR.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            try
            {
                this.collection = EventLogItemCollection.RestoreEventLogs(this.openFileDialogELR.FileName);
                UpdateGrid();
            }
            catch
            {
                MessageBox.Show(this, "Failed to load elr'file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.grid.DataSource = null;
                this.grid.Refresh();
            }
        }

        private void btnSaveElrFile_Click(object sender, EventArgs e)
        {
            if (this.collection == null)
            {
                return;
            }

            if (this.saveFileDialogELR.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            try
            {
                this.collection.RecordEventLogs(this.saveFileDialogELR.FileName);
            }
            catch
            {
                MessageBox.Show(this, "Failed to save elr'file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            List<GridRowItem> rows = this.grid.DataSource as List<GridRowItem>;
            if (rows == null)
            {
                return;
            }

            if (this.grid.SelectedCells.Count < 1)
            {
                return;
            }

            GridRowItem row = rows[this.grid.SelectedCells[0].RowIndex];
            using (EventLogItemForm form = new EventLogItemForm())
            {
                form.SetData(row);
                form.ShowDialog(this);
            }
        }

        private void UpdateData()
        {
            if (this.compolet == null || !this.btnReload.Enabled)
            {
                return;
            }

            Cursor cur = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.collection = this.compolet.GetEventLogs(EventCategory.SystemEvent | EventCategory.AccessEvent | EventCategory.UserEvent);
                UpdateGrid();
            }
            catch
            {
                MessageBox.Show(this, "Failed to get eventlog from controller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.grid.DataSource = null;
                this.grid.Refresh();
            }
            finally
            {
                this.Cursor = cur;
            }
        }

        private void UpdateGrid()
        {
            LoadUserDef();

            List<GridRowItem> rows = new List<GridRowItem>();
            int index = 0;
            foreach (EventLogItem log in this.collection)
            {
                rows.Add(new GridRowItem(log, index++));
            }

            rows.Sort();
            this.grid.DataSource = rows;
            this.grid.Refresh();
        }

        private void LoadUserDef()
        {
            if (this.collection != null && this.userDefinisionPath != null)
            {
                try
                {
                    this.collection.UserEventErrDefPath = this.userDefinisionPath;
                }
                catch
                {
                    MessageBox.Show(this, "Failed to load user message file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private class CultureItem
        {
            public CultureItem(CultureInfo ci)
            {
                this.CultureInfo = ci;
                while (ci.Parent != null && ci.Parent.IsNeutralCulture && ci.Parent.Name != "zh")
                {
                    ci = ci.Parent;
                }

                this.caption = ci.DisplayName;
            }

            public readonly CultureInfo CultureInfo;
            private readonly string caption;

            public override string ToString()
            {
                return caption;
            }
        }
    }
}