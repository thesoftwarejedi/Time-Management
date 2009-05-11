namespace TimeManagement.WinApp
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.pollRateLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pollRateBox = new System.Windows.Forms.TextBox();
            this.outputFileBox = new System.Windows.Forms.TextBox();
            this.fileBrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(135, 64);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pollRateLabel
            // 
            this.pollRateLabel.AutoSize = true;
            this.pollRateLabel.Location = new System.Drawing.Point(15, 13);
            this.pollRateLabel.Name = "pollRateLabel";
            this.pollRateLabel.Size = new System.Drawing.Size(67, 13);
            this.pollRateLabel.TabIndex = 1;
            this.pollRateLabel.Text = "Poll rate (ms)";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(24, 39);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(58, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output File";
            // 
            // pollRateBox
            // 
            this.pollRateBox.Location = new System.Drawing.Point(88, 10);
            this.pollRateBox.Name = "pollRateBox";
            this.pollRateBox.Size = new System.Drawing.Size(67, 20);
            this.pollRateBox.TabIndex = 3;
            // 
            // outputFileBox
            // 
            this.outputFileBox.Location = new System.Drawing.Point(88, 36);
            this.outputFileBox.Name = "outputFileBox";
            this.outputFileBox.Size = new System.Drawing.Size(169, 20);
            this.outputFileBox.TabIndex = 4;
            // 
            // fileBrowseButton
            // 
            this.fileBrowseButton.Location = new System.Drawing.Point(263, 34);
            this.fileBrowseButton.Name = "fileBrowseButton";
            this.fileBrowseButton.Size = new System.Drawing.Size(24, 23);
            this.fileBrowseButton.TabIndex = 5;
            this.fileBrowseButton.Text = "...";
            this.fileBrowseButton.UseVisualStyleBackColor = true;
            this.fileBrowseButton.Click += new System.EventHandler(this.fileBrowseButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 99);
            this.Controls.Add(this.fileBrowseButton);
            this.Controls.Add(this.outputFileBox);
            this.Controls.Add(this.pollRateBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pollRateLabel);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.Text = "TimeManagement Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label pollRateLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox pollRateBox;
        private System.Windows.Forms.TextBox outputFileBox;
        private System.Windows.Forms.Button fileBrowseButton;
    }
}