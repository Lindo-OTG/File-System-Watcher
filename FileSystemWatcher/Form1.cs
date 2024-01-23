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

namespace FileSystemWatcher
{
    public partial class Form1 : Form
    {
        #region Variables
        public static bool edited = false;
        public static string path;
        public static DateTime TimeNow;
        public static System.IO.FileSystemWatcher FileWatch;
        List<Changes> changes = new List<Changes>();
        FileHandler fh = new FileHandler();
        public static bool SearchClicked = false;
        public static bool DataLogged = false;
        public static string LogPath;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStartWatching_Click(object sender, EventArgs file)
        {
            btnMakeChnages.Enabled = true;
            try
            {
                FileWatch = new System.IO.FileSystemWatcher(txtFilePath.Text);
                if (SearchClicked == true)
                {
                    SearchClicked = false;
                }
                else
                {
                    SearchClicked = true;
                }
                if (SearchClicked == true)
                {
                    rbtDirectory.Enabled = false;
                    rbtFile.Enabled = false;
                    cbxIncludeSubs.Enabled = false;
                    btnStartWatching.BackColor = Color.Red;
                    btnStartWatching.Text = "Stop Watching";
                    tmrAddChanges.Enabled = true;
                    FileWatch.EnableRaisingEvents = true;
                }
                else
                {
                    rbtDirectory.Enabled = true;
                    rbtFile.Enabled = true;
                    cbxIncludeSubs.Enabled = true;
                    btnStartWatching.BackColor = Color.Blue;
                    btnStartWatching.Text = "Start Watching";
                    tmrAddChanges.Enabled = false;
                    FileWatch.EnableRaisingEvents = false;
                }
                if (cbxIncludeSubs.Checked)
                {
                    FileWatch.IncludeSubdirectories = true;
                }
                else
                {
                    FileWatch.IncludeSubdirectories = false;
                }
                FileWatch.Deleted += FileWatch_Deleted;
                FileWatch.Created += FileWatch_Created;
                FileWatch.Changed += FileWatch_Changed;
                FileWatch.Renamed += FileWatch_Renamed;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please enter a valid Directory", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #region FileEvents
        private void FileWatch_Renamed(object sender, RenamedEventArgs rename)
        {
            if (tmrAddChanges.Enabled == true)
            {
                TimeNow = DateTime.Now;
                if (edited == false)
                {
                    changes.Add(new Changes(rename.OldName, rename.FullPath, rename.ChangeType.ToString(), TimeNow, rename.Name));
                    notifying.Icon = SystemIcons.Information;
                    notifying.BalloonTipText = rename.OldName + " has been renamed to: " + rename.Name;
                    notifying.BalloonTipTitle = "File Renamed";
                    notifying.ShowBalloonTip(1000);
                    edited = true;
                }
            }           
        }
        private void FileWatch_Changed(object sender, FileSystemEventArgs change)
        {
            if (tmrAddChanges.Enabled)
            {
                TimeNow = DateTime.Now;
                if (edited == false)
                {
                    changes.Add(new Changes(change.Name, change.FullPath, change.ChangeType.ToString(), TimeNow, null));
                    notifying.Icon = SystemIcons.Information;
                    notifying.BalloonTipText = change.Name + " has been Changed";
                    notifying.BalloonTipTitle = "File Changed";
                    notifying.ShowBalloonTip(1000);
                    edited = true;
                }
            }           
        }
        private void FileWatch_Created(object sender, FileSystemEventArgs create)
        {
            if (tmrAddChanges.Enabled)
            {
                TimeNow = DateTime.Now;
                if (edited == false)
                {
                    changes.Add(new Changes(create.Name, create.FullPath, create.ChangeType.ToString(), TimeNow, null));
                    notifying.Icon = SystemIcons.Information;
                    notifying.BalloonTipText = create.Name + " has been Created in: \n" + create.FullPath;
                    notifying.BalloonTipTitle = "File Created";
                    notifying.ShowBalloonTip(1000);
                    edited = true;
                }
            }          
        }
        private void FileWatch_Deleted(object sender, FileSystemEventArgs delete)
        {
            if (tmrAddChanges.Enabled)
            {
                TimeNow = DateTime.Now;
                if (edited == false)
                {
                    changes.Add(new Changes(delete.Name, delete.FullPath, delete.ChangeType.ToString(), TimeNow, null));
                    notifying.Icon = SystemIcons.Information;
                    notifying.BalloonTipText = delete.Name + " has been deleted from: \n" + delete.FullPath;
                    notifying.BalloonTipTitle = "File Deleted";
                    notifying.ShowBalloonTip(1000);
                    edited = true;
                }
            }           
        }
        #endregion
        #region Timer
        private void tmrAddChanges_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (edited == true)
            {
                dataGridView1.DataSource = changes;
                edited = false;
            }
            if (changes.Count != 0)
            {
                btnLogChanges.Enabled = true;
            }
            dataGridView1.DataSource = changes;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {            
        }
        #region SearchDialogue
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filename = null;
            string filter = null;
            if (rbtFile.Checked)
            {
                dlgOpenFile.ShowDialog();
                filename = dlgOpenFile.FileName;
                filter = filename.Substring(filename.LastIndexOf('\\') + 1).ToString();
                path = filename.Substring(0, filename.Length - filter.Length);
                txtFilePath.Text = path;             
            }
            else
            {
                dlgBrowseFolder.ShowDialog();
                path = dlgBrowseFolder.SelectedPath;
                txtFilePath.Text = path;              
            }
            
        }
        #endregion
        #region Radio_Buttons
        private void rbtDirectory_CheckedChanged(object sender, EventArgs e)
        {
            cbxIncludeSubs.Enabled = true;
        }
        private void rbtFile_CheckedChanged(object sender, EventArgs e)
        {
            cbxIncludeSubs.Checked = false;
            cbxIncludeSubs.Enabled = false;
        }
        #endregion

        private void btnLogChanges_Click(object sender, EventArgs e)
        {          
            dlgOpenFile.ShowDialog();
            LogPath = dlgOpenFile.FileName;
            fh.Writeer(changes, LogPath);           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMakeChnages_Click(object sender, EventArgs e)
        {
            if (File.Exists(LogPath))
            {
                DataLogged = true;
            }
            EditFiles edit = new EditFiles();
            edit.ShowDialog();
        }

        private void cbxIncludeSubs_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
