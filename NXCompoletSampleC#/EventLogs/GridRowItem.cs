using System;
using System.Collections.Generic;

using OMRON.Compolet.Framework.Function.EventLogs;

namespace NXCompoletSample.EventLogs
{
    public class GridRowItem : IComparable
    {
        public GridRowItem(EventLogItem info, int index)
        {
            this.index = index;
            this.info = info;
        }

        private readonly int index;
        private readonly EventLogItem info;

        public string Category
        {
            get
            {
                switch (this.info.Category)
                {
                    case EventCategory.SystemEvent:
                        return "System";
                    case EventCategory.AccessEvent:
                        return "Access";
                    case EventCategory.UserEvent:
                        return "User";
                }

                return this.info.Category.ToString();
            }
        }

        public string Time
        {
            get { return this.info.Time.ToString("yyyy/MM/dd HH:mm:ss"); }
        }

        public string Level
        {
            get { return this.info.LevelName; }
        }

        public string EventCode
        {
            get { return string.Format("0x{0:X08}", this.info.EventCode); }
        }

        public string Group
        {
            get { return this.info.Group; }
        }

        public string EventSource
        {
            get { return this.info.Source; }
        }

        public string EventSourceDetail
        {
            get { return this.info.SourceDetail; }
        }

        public string EventName
        {
            get { return this.info.EventName; }
        }

        public string Details
        {
            get
            {
                string str = string.Empty;
                if (this.info.Details != null)
                {
                    foreach (string s in this.info.Details)
                    {
                        str += s + "\r\n";
                    }
                }
                return str;
            }
        }

        public List<string> AttachedInformations
        {
            get
            {
                List<string> list = new List<string>();
                if (this.info.AttachedInformations != null)
                {
                    foreach (AttachedInformation a in this.info.AttachedInformations)
                    {
                        list.Add(a.ToString());
                    }
                }
                return list;
            }
        }

        public string ActionAndCorrection
        {
            get
            {
                string str = string.Empty;
                if (this.info.ActionAndCorrection != null)
                {
                    foreach (string s in this.info.ActionAndCorrection)
                    {
                        str += s + "\r\n";
                    }
                }
                return str;
            }
        }

        public int CompareTo(object obj)
        {
            GridRowItem other = obj as GridRowItem;
            if (other == null)
            {
                return 0;
            }

            int diff = other.info.Time.CompareTo(this.info.Time);
            if (diff != 0)
            {
                return diff;
            }

            diff = other.info.Category.CompareTo(this.info.Category);
            if (diff != 0)
            {
                return diff;
            }

            return other.index.CompareTo(this.index);
        }
    }
}