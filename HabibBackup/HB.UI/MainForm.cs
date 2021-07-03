using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB.UI
{
    public partial class HabibBackup : Form
    {
        public HabibBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void srcPathBrowseBtn_Click(object sender, EventArgs e)
        {
            this.srcPathTextBox.Text = "";
            try
            {
                this.srcPathTextBox.Text = _getFolderPath();
                if (_bothPathsAreEqual())
                {
                    MessageBox.Show("Source and destination paths cannot be the same.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.srcPathTextBox.Text = "";
                    return;
                }
            } catch (Exception ex)
            {
                throw;
            }
        }

        private void destPathBrowseBtn_Click(object sender, EventArgs e)
        {
            this.destPathTextBox.Text = "";
            try
            {
                this.destPathTextBox.Text = _getFolderPath();
                if (_bothPathsAreEqual())
                {
                    MessageBox.Show("Source and destination paths cannot be the same.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.destPathTextBox.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private string _getFolderPath()
        {
            using (var folderBrowserDialog = new CommonOpenFileDialog() 
            { 
                IsFolderPicker = true, 
                RestoreDirectory = true 
            })
            {
                var result = folderBrowserDialog.ShowDialog();
                if (result != CommonFileDialogResult.Ok ||
                    string.IsNullOrWhiteSpace(folderBrowserDialog.FileName))
                {
                    return "";
                }
                return folderBrowserDialog.FileName;
            }
        }

        private bool _bothPathsAreEqual()
        {
            // ignoring initial case
            if (this.destPathTextBox.Text == "" && this.srcPathTextBox.Text == "")
                return false;

            return this.destPathTextBox.Text == this.srcPathTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void srcPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
