using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static OnlineMonitor.ConfigPanle.OperatINI;
namespace OnlineMonitor.ConfigPanle
{
    public partial class UsersControl : UserControl
    {
        private void UsersControl_Load(object sender, EventArgs e)
        {
            UserImageList.Images.Add(Image.FromFile(@"D:\Chiloy\GitHubVisualStudio\OnlineMonitor\OnlineMonitor\ico\Setting.png"));
            OperatINI UINI = new OperatINI(@"d:\UserConfig.ini");
            // UINI.WriteValue("Setting", "key2", "hello ini!");
            string TestResult = UINI.ReadValue("Section1", "name");
            //MessageBox.Show(TestResult, "系统提示");
            
            this.UIListView.View = System.Windows.Forms.View.LargeIcon;
            this.UIListView.LargeImageList = UserImageList;
            this.UIListView.BeginUpdate();
            ListViewItem lvi = new ListViewItem();
            lvi.ImageIndex = 0;
            lvi.Text = TestResult;
            this.UIListView.Items.Add(lvi);
            this.UIListView.EndUpdate();
        }
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
