using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineMonitor.ConfigPanle
{
    public partial class DevControl : UserControl
    {
        public DevControl()
        {
            InitializeComponent();
        }
        public ConfigPanle.DevInfo View_DevInfo;
        private void DevAddBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(DevlistView);
            View_DevInfo = new ConfigPanle.DevInfo();
            this.Controls.Add(View_DevInfo);
            this.View_DevInfo.Location = new System.Drawing.Point(0, 30);

            this.DevlistView.BeginUpdate();

            this.DevlistView.EndUpdate();
        }
    }
}
