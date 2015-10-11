using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineMonitor
{
    public partial class AppConfig : UserControl
    {
        public AppConfig()
        {
            InitializeComponent();
        }
        public ConfigPanle.GeneralControl View_GeneralControl;

        private void GenaConfigBtn_Click(object sender, EventArgs e)
        {
            View_GeneralControl = new ConfigPanle.GeneralControl();
            View_GeneralControl.Show();
            ConfigSplitContainer.Panel2.Controls.Clear();
            ConfigSplitContainer.Panel2.Controls.Add(View_GeneralControl);
        }
    }
}
