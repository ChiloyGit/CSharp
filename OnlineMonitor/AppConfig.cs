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
        public ConfigPanle.AboutControl View_AboutControl;
        public ConfigPanle.DevControl View_DevControl;
        public ConfigPanle.UsersControl View_UsersControl;

        private void GenaConfigBtn_Click(object sender, EventArgs e)
        {
            View_GeneralControl = new ConfigPanle.GeneralControl();
            View_GeneralControl.Show();
            ConfigSplitContainer.Panel2.Controls.Clear();
            ConfigSplitContainer.Panel2.Controls.Add(View_GeneralControl);
        }

        private void UserConfigBtn_Click(object sender, EventArgs e)
        {
            View_UsersControl = new ConfigPanle.UsersControl();
            View_UsersControl.Show();
            ConfigSplitContainer.Panel2.Controls.Clear();
            ConfigSplitContainer.Panel2.Controls.Add(View_UsersControl);
        }

        private void DevConfigBtn_Click(object sender, EventArgs e)
        {
            View_DevControl = new ConfigPanle.DevControl();
            View_DevControl.Show();
            ConfigSplitContainer.Panel2.Controls.Clear();
            ConfigSplitContainer.Panel2.Controls.Add(View_DevControl);
        }

        private void AboutConfigBtn_Click(object sender, EventArgs e)
        {
            View_AboutControl = new ConfigPanle.AboutControl();
            View_AboutControl.Show();
            ConfigSplitContainer.Panel2.Controls.Clear();
            ConfigSplitContainer.Panel2.Controls.Add(View_AboutControl);
        }
    }
}
