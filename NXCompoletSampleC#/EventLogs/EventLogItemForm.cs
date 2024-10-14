using System.Collections.Generic;
using System.Windows.Forms;

namespace NXCompoletSample.EventLogs
{
    public partial class EventLogItemForm : Form
    {
        public EventLogItemForm()
        {
            InitializeComponent();
        }

        public void SetData(GridRowItem item)
        {
            this.txtTime.Text = item.Time;
            this.txtLevel.Text = item.Level;
            this.txtEventCode.Text = item.EventCode;
            this.txtGroup.Text = item.Group;
            this.txtSource.Text = item.EventSource;
            this.txtSourceDetail.Text = item.EventSourceDetail;
            this.txtEventName.Text = item.EventName;
            this.txtDetails.Text = item.Details;
            List<string> list = item.AttachedInformations;
            this.txtAttachedInformation1.Text = 0 < list.Count ? list[0] : null;
            this.txtAttachedInformation2.Text = 1 < list.Count ? list[1] : null;
            this.txtAttachedInformation3.Text = 2 < list.Count ? list[2] : null;
            this.txtAttachedInformation4.Text = 3 < list.Count ? list[3] : null;
            this.txtActionAndCorrection.Text = item.ActionAndCorrection;
        }
    }
}