namespace FileSystemWatcher
{
    partial class EditFiles
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtSelectedDirectory = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnRefreshLog = new System.Windows.Forms.Button();
            this.lstLogData = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogFileEmpty = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.notifying = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.lblDirectory);
            this.tabPage1.Controls.Add(this.txtSelectedDirectory);
            this.tabPage1.Controls.Add(this.lstFiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files In Directory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.Location = new System.Drawing.Point(13, 314);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(696, 39);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(10, 22);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(52, 13);
            this.lblDirectory.TabIndex = 2;
            this.lblDirectory.Text = "Directory:";
            // 
            // txtSelectedDirectory
            // 
            this.txtSelectedDirectory.Location = new System.Drawing.Point(65, 19);
            this.txtSelectedDirectory.Name = "txtSelectedDirectory";
            this.txtSelectedDirectory.ReadOnly = true;
            this.txtSelectedDirectory.Size = new System.Drawing.Size(644, 20);
            this.txtSelectedDirectory.TabIndex = 1;
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lstFiles.ForeColor = System.Drawing.Color.White;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(13, 60);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(696, 238);
            this.lstFiles.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.filePropertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tmenuDelete_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // filePropertiesToolStripMenuItem
            // 
            this.filePropertiesToolStripMenuItem.Name = "filePropertiesToolStripMenuItem";
            this.filePropertiesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.filePropertiesToolStripMenuItem.Text = "File Properties";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearLog);
            this.tabPage2.Controls.Add(this.btnRefreshLog);
            this.tabPage2.Controls.Add(this.lstLogData);
            this.tabPage2.Controls.Add(this.lblLogFileEmpty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Log Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.Red;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Location = new System.Drawing.Point(6, 304);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(346, 42);
            this.btnClearLog.TabIndex = 8;
            this.btnClearLog.Text = "Clear LogFile";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnRefreshLog
            // 
            this.btnRefreshLog.BackColor = System.Drawing.Color.Orange;
            this.btnRefreshLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLog.Location = new System.Drawing.Point(369, 304);
            this.btnRefreshLog.Name = "btnRefreshLog";
            this.btnRefreshLog.Size = new System.Drawing.Size(346, 42);
            this.btnRefreshLog.TabIndex = 7;
            this.btnRefreshLog.Text = "Refresh";
            this.btnRefreshLog.UseVisualStyleBackColor = false;
            this.btnRefreshLog.Click += new System.EventHandler(this.btnRefreshLog_Click);
            // 
            // lstLogData
            // 
            this.lstLogData.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstLogData.ContextMenuStrip = this.contextMenuStrip2;
            this.lstLogData.ForeColor = System.Drawing.Color.LimeGreen;
            this.lstLogData.FormattingEnabled = true;
            this.lstLogData.Location = new System.Drawing.Point(6, 11);
            this.lstLogData.Name = "lstLogData";
            this.lstLogData.Size = new System.Drawing.Size(709, 277);
            this.lstLogData.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteEntryToolStripMenuItem,
            this.copyEntryToolStripMenuItem,
            this.editEntryToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(140, 70);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
            this.deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
            // 
            // copyEntryToolStripMenuItem
            // 
            this.copyEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameToolStripMenuItem,
            this.filePathToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.typeOfChangeToolStripMenuItem});
            this.copyEntryToolStripMenuItem.Name = "copyEntryToolStripMenuItem";
            this.copyEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyEntryToolStripMenuItem.Text = "Entry Details";
            // 
            // fileNameToolStripMenuItem
            // 
            this.fileNameToolStripMenuItem.Name = "fileNameToolStripMenuItem";
            this.fileNameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fileNameToolStripMenuItem.Text = "FileName";
            this.fileNameToolStripMenuItem.Click += new System.EventHandler(this.fileNameToolStripMenuItem_Click);
            // 
            // filePathToolStripMenuItem
            // 
            this.filePathToolStripMenuItem.Name = "filePathToolStripMenuItem";
            this.filePathToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.filePathToolStripMenuItem.Text = "File Path";
            this.filePathToolStripMenuItem.Click += new System.EventHandler(this.filePathToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // typeOfChangeToolStripMenuItem
            // 
            this.typeOfChangeToolStripMenuItem.Name = "typeOfChangeToolStripMenuItem";
            this.typeOfChangeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.typeOfChangeToolStripMenuItem.Text = "Type of Change";
            this.typeOfChangeToolStripMenuItem.Click += new System.EventHandler(this.typeOfChangeToolStripMenuItem_Click);
            // 
            // editEntryToolStripMenuItem
            // 
            this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
            this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editEntryToolStripMenuItem.Text = "Edit Entry";
            // 
            // lblLogFileEmpty
            // 
            this.lblLogFileEmpty.AutoSize = true;
            this.lblLogFileEmpty.Location = new System.Drawing.Point(281, 180);
            this.lblLogFileEmpty.Name = "lblLogFileEmpty";
            this.lblLogFileEmpty.Size = new System.Drawing.Size(166, 13);
            this.lblLogFileEmpty.TabIndex = 0;
            this.lblLogFileEmpty.Text = "No Changes have be Logged Yet";
            this.lblLogFileEmpty.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(29, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(724, 43);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Clicked);
            // 
            // notifying
            // 
            this.notifying.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifying.Text = "ROD\'S EYE";
            this.notifying.Visible = true;
            // 
            // EditFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 472);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFiles";
            this.Load += new System.EventHandler(this.EditFiles_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtSelectedDirectory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLogFileEmpty;
        private System.Windows.Forms.ListBox lstLogData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRefreshLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyEntryToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifying;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOfChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
    }
}