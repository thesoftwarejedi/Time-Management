using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeManagement.WinApp
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void fileBrowseButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.OverwritePrompt = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                outputFileBox.Text = saveFileDialog1.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Program.pollRate = Int32.Parse(pollRateBox.Text);
            //    Program.filename = outputFileBox.Text;
            //    Program.OpenOutputFile();
            //    //save to ini file
            //    using (FileStream fs = new FileStream("TimeManagement.WinApp.jedi", FileMode.Create, FileAccess.Write)) 
            //    {
            //        using (StreamWriter sw = new StreamWriter(fs)) 
            //        {
            //            sw.WriteLine(Program.pollRate);
            //            sw.WriteLine(Program.filename);
            //            sw.Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error saving options: " + ex.Message + Environment.NewLine + ex.StackTrace);
            //}
            //finally
            //{
            Close();
            //}
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            //pollRateBox.Text = Program.pollRate.ToString() ;
            //outputFileBox.Text = Program.filename;
        }
    }
}