using System;
using System.Collections.Generic;
using System.Text;
using Recorder;
using System.Data;

namespace TimeManagement.WinApp
{
    public class AppController
    {
        TimeCardReport report;
        ITimeManageSysTray sysTray;
        IRecorderServer recorder;
        public AppController(ITimeManageSysTray sysTray, IRecorderServer recorder, TimeCardReport report)
        {
            this.sysTray = sysTray;
            this.recorder = recorder;
            this.report = report;
            WireItems();
        }

        private void WireItems()
        {
            this.sysTray.ReportEvent += new EventHandler(sysTray_ReportEvent);
            this.sysTray.ExitEvent += new EventHandler(sysTray_ExitEvent);
            this.sysTray.StartEvent += new EventHandler(sysTray_StartEvent);
            this.sysTray.StopEvent += new EventHandler(sysTray_StopEvent);
            this.report.RefreshEventClick += new EventHandler(report_RefreshEventClick);
            this.report.TimeCardChart.DataSource = this.recorder.GetReport();
            this.report.TimeCardChart.DataBind();
            this.report.TimeCardChart.Series[0].XValueMember = "Program";
            this.report.TimeCardChart.Series[0].YValueMembers = "Total Time";
            this.report.TimeCardDataGrid.DataSource = this.recorder.GetReport();
            this.report.TimeCardDataGrid.DataMember = "RecordEntries";
        }

        private void report_RefreshEventClick(object sender, EventArgs e)
        {
            this.report.PopulateData(this.recorder.GetReport());
        }

        private void sysTray_ReportEvent(object sender, EventArgs e)
        {
            this.report.Visible = !this.report.Visible;
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
            this.report.ExitApp();
        }
    }
}
