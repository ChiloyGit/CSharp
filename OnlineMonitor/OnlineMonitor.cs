﻿using System;
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
    public partial class MonitorFrm : Form
    {
        public MonitorFrm()
        {
            InitializeComponent();
        }
        public AppConfig View_AppConfig;
        public MonitorState View_MonitorState;
        public void MainFrm_Load(object sender, EventArgs e)
        {
            View_AppConfig = new AppConfig();
            View_MonitorState = new MonitorState();
        }

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void MonitorFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void MonitorFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void MonitorFrm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.BringToFront();
            View_AppConfig.Show();
            MainPanle.Controls.Clear();
            MainPanle.Controls.Add(View_AppConfig);
           
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SetBtn.BringToFront();
            View_MonitorState.Show();
            MainPanle.Controls.Clear();
            MainPanle.Controls.Add(View_MonitorState);
        }
    }
}
