using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TimeManagement.WinApp
{
    public partial class TimeManagementSysTray : Component, ITimeManageSysTray
    {
        public TimeManagementSysTray()
        {
            InitializeComponent();
            ServerStoppedButtons();
        }

        public TimeManagementSysTray(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            ServerStoppedButtons();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://wiki.github.com/iyo/Time-Management");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (StartEvent != null)
            {
                StartEvent(sender, e);
                ServerRunningButtons();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (StopEvent != null)
            {
                StopEvent(sender, e);
                ServerStoppedButtons();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (ExitEvent != null)
            {
                ServerStoppedButtons();
                this.timeManagementIcon.Visible = false;
                ExitEvent(sender, e);
            }
        }

        #region ITimeManageSysTray Members

        public event EventHandler StopEvent;

        public event EventHandler StartEvent;

        public event EventHandler ExitEvent;

        #endregion


        private void ServerRunningButtons()
        {
            this.startMonitoring.Enabled = false;
            this.stopMonitoring.Enabled = true;
        }

        private void ServerStoppedButtons()
        {
            this.stopMonitoring.Enabled = false;
            this.startMonitoring.Enabled = true;
        }
    }
}
