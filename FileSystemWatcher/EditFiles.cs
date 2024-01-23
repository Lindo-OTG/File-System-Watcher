using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;

namespace FileSystemWatcher
{
    public partial class EditFiles : Form
    {
        List<string> listItems = new List<string>();
        FileHandler fh = new FileHandler();
        public EditFiles()
        {
            InitializeComponent();
        }
        private void btnBack_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFiles_Load(object sender, EventArgs e)
        {
            if (lstFiles == null || lstFiles.DataSource == null)
            {
                contextMenuStrip1.Enabled = false;
            }
            if (lstLogData == null || lstLogData == null)
            {
                contextMenuStrip2.Enabled = false;
            }
                   
            txtSelectedDirectory.Text = Form1.path;
            string[] files = Directory.GetFiles(txtSelectedDirectory.Text);
            foreach (var item in files)
            {
                lstFiles.Items.Add(item.ToString());
            }

            if (Form1.DataLogged == false)
            {
                lblLogFileEmpty.Visible = true;
                lstLogData.Visible = false;
                btnClearLog.Enabled = false;
                btnRefreshLog.Enabled = false;
            }
            else
            {
                lstLogData.Visible = true;
                lblLogFileEmpty.Visible = false;
                btnClearLog.Enabled = true;
                btnRefreshLog.Enabled = true;
                listItems = fh.Reader(Form1.LogPath);
            }
            lstLogData.DataSource = listItems;
        }

        private void tmenuDelete_Click(object sender, EventArgs e)
        {            
        }
        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool remove = false;
            int index = 0;
            foreach (var item in listItems)
            {
                if (item.Equals(lstLogData.SelectedItem))
                {
                    remove = true;
                    index = listItems.IndexOf(item);                   
                }              
            }
            lstLogData.DataSource = null;
            if (remove == true)
            {
                listItems.Remove(listItems[index]);
                lstLogData.Items.Remove(lstLogData.SelectedItem);
            }
            lstLogData.DataSource = null;
            lstLogData.DataSource = listItems;
            MessageBox.Show("Record Deleted");
        }

        private void btnRefreshLog_Click(object sender, EventArgs e)
        {
            lstLogData.Refresh();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            listItems.Clear();
            lstLogData.DataSource = null;
            lstLogData.Items.Clear();
            MessageBox.Show("Log File Clear", "File Edited", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            notifying.Icon = SystemIcons.WinLogo;
            notifying.BalloonTipText = "Log File has been Cleared";
            notifying.BalloonTipTitle = "File Empty";
            notifying.ShowBalloonTip(1000);
        }

        private void fileNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            foreach (var item in listItems)
            {
                if (item.Equals(lstLogData.SelectedItem))
                {
                    filename = item.Split('*')[0];
                }
            }
            MessageBox.Show("FileName: " + filename, "File Property");
        }

        private void filePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "";
            foreach (var item in listItems)
            {
                if (item.Equals(lstLogData.SelectedItem))
                {
                    filepath = item.Split('*')[1];
                }
            }
            MessageBox.Show("Filepath: " + filepath, "File Property");
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileDate = "";
            foreach (var item in listItems)
            {
                if (item.Equals(lstLogData.SelectedItem))
                {
                    fileDate = item.Split('*')[3];
                }
            }
            MessageBox.Show("FileDate: " + fileDate, "File Property");
        }

        private void typeOfChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileChange = "";
            foreach (var item in listItems)
            {
                if (item.Equals(lstLogData.SelectedItem))
                {
                    fileChange= item.Split('*')[2];
                }
            }
            MessageBox.Show("Change made to file: " + fileChange, "File Property");
        }
    }
}
