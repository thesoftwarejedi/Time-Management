using System;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using Recorder;

namespace TimeManagement.WinApp
{
    static class Program
    {

        static NotifyIcon ntfy;
        internal static int pollRate = 5000;
        static RecorderServer recorder;

        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                recorder = new RecorderServer();
                //setup the systray
                ntfy = new NotifyIcon();
                MenuItem[] menuItems = new MenuItem[3];
                menuItems[0] = new MenuItem("Options");
                menuItems[0].Click += new EventHandler(Options_Select);
                menuItems[1] = new MenuItem("About");
                menuItems[1].Click += new EventHandler(About_Select);
                menuItems[2] = new MenuItem("Exit");
                menuItems[2].Click += new EventHandler(Exit_Select);
                ContextMenu menu = new ContextMenu(menuItems);
                ntfy.ContextMenu = menu;
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
                ntfy.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                ntfy.Visible = true;
                recorder.Start();
                //start the gui msg loop
                Application.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occurred: " + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        static void Options_Select(object sender, EventArgs e)
        {
            OptionsForm fmr = new OptionsForm();
            fmr.ShowDialog();
        }

        static void About_Select(object sender, EventArgs e)
        {
            MessageBox.Show("http://www.AnAppADay.com/");
        }

        static void Exit_Select(object sender, EventArgs e)
        {
            ntfy.Visible = false;
            ntfy.Dispose();
            recorder.Stop();
            Application.Exit();
            System.Environment.Exit(0);
        }
    }
}
