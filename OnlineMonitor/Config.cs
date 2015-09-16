using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMonitor
{
    public partial class ConfigFrm : Form
    {
        public ConfigFrm()
        {
            InitializeComponent();
        }

        private void MonitorBtn_Click(object sender, EventArgs e)
        {
            Form MonitorFrm = new MonitorFrm();
            MonitorFrm.Show();
            this.Hide();
        }
    }
}
