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
    public partial class UsersControl : UserControl
    {
        public object UIPanel { get; private set; }

        public UsersControl()
        {
            InitializeComponent();
        }

        private void AddDevBtn_Click(object sender, EventArgs e)
        {
            UIListView.SendToBack();
            ReturnBtn.BringToFront();
            ApplyBtn.BringToFront();
        }

        private void RemoveDevBtn_Click(object sender, EventArgs e)
        {
            ReturnBtn.BringToFront();
            ApplyBtn.BringToFront();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            UIListView.BringToFront();
            //UsersControl.UIPanel.SendToBack();
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
