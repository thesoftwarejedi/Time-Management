using System;
using System.Collections.Generic;
using System.Text;
using Recorder;

namespace TimeManagement.WinApp
{
    public class AppController
    {
        DummyForm dummy;
        ITimeManageSysTray sysTray;
        IRecorderServer recorder;
        public AppController(ITimeManageSysTray sysTray, IRecorderServer recorder, DummyForm dummy)
        {
            this.sysTray = sysTray;
            this.recorder = recorder;
            this.dummy = dummy;
            WireItems();
        }

        private void WireItems()
        {
            this.sysTray.ExitEvent += new EventHandler(sysTray_ExitEvent);
            this.sysTray.StartEvent += new EventHandler(sysTray_StartEvent);
            this.sysTray.StopEvent += new EventHandler(sysTray_StopEvent);
        }

        private void sysTray_StopEvent(object sender, EventArgs e)
        {
            this.recorder.Stop();
        }

        private void sysTray_StartEvent(object sender, EventArgs e)
        {
            this.recorder.Start();
        }

        private void sysTray_ExitEvent(object sender, EventArgs e)
        {
            this.recorder.Stop();
            this.dummy.ExitApp();
        }
    }
}
