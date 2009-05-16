namespace TimeManagement.WinApp
{
    partial class TimeCardReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.innerMainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.timeReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refreshButton = new System.Windows.Forms.Button();
            this.innerMainPanel.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeReportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // innerMainPanel
            // 
            this.innerMainPanel.Controls.Add(this.splitContainer);
            this.innerMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerMainPanel.Location = new System.Drawing.Point(5, 5);
            this.innerMainPanel.Name = "innerMainPanel";
            this.innerMainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.innerMainPanel.Size = new System.Drawing.Size(574, 398);
            this.innerMainPanel.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(5, 5);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.timeReportChart);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.refreshButton);
            this.splitContainer.Size = new System.Drawing.Size(564, 388);
            this.splitContainer.SplitterDistance = 322;
            this.splitContainer.TabIndex = 0;
            // 
            // timeReportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.timeReportChart.ChartAreas.Add(chartArea1);
            this.timeReportChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeReportChart.Location = new System.Drawing.Point(0, 0);
            this.timeReportChart.Name = "timeReportChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.timeReportChart.Series.Add(series1);
            this.timeReportChart.Size = new System.Drawing.Size(564, 322);
            this.timeReportChart.TabIndex = 0;
            this.timeReportChart.Text = "chart1";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(435, 20);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // TimeCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 408);
            this.ControlBox = false;
            this.Controls.Add(this.innerMainPanel);
            this.Name = "TimeCardReport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Time Card Report";
            this.innerMainPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeReportChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel innerMainPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeReportChart;
        private System.Windows.Forms.Button refreshButton;
    }
}