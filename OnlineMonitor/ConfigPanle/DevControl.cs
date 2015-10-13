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
        

        private void AddDevBtn_Click(object sender, EventArgs e)
        {
            ReturnBtn.BringToFront();
            ApplyBtn.BringToFront();
            DIListView.SendToBack();
  
        }

        private void RemoveDevBtn_Click(object sender, EventArgs e)
        {
            ReturnBtn.BringToFront();
            ApplyBtn.BringToFront();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DevPanel.SendToBack();
            //DIListView.BringToFront();
            AddDevBtn.BringToFront();
            RemoveDevBtn.BringToFront();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            AddDevBtn.BringToFront();
            RemoveDevBtn.BringToFront();
        }


    }
}
