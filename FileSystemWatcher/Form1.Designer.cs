namespace FileSystemWatcher
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStartWatching = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.rbtFile = new System.Windows.Forms.RadioButton();
            this.rbtDirectory = new System.Windows.Forms.RadioButton();
            this.cbxIncludeSubs = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfCHangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMakeChnages = new System.Windows.Forms.Button();
            this.btnLogChanges = new System.Windows.Forms.Button();
            this.tmrAddChanges = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.dlgBrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifying = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartWatching
            // 
            this.btnStartWatching.BackColor = System.Drawing.Color.Blue;
            this.btnStartWatching.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartWatching.ForeColor = System.Drawing.Color.White;
            this.btnStartWatching.Location = new System.Drawing.Point(79, 64);
            this.btnStartWatching.Name = "btnStartWatching";
            this.btnStartWatching.Size = new System.Drawing.Size(117, 31);
            this.btnStartWatching.TabIndex = 0;
            this.btnStartWatching.Text = "Start Watching";
            this.btnStartWatching.UseVisualStyleBackColor = false;
            this.btnStartWatching.Click += new System.EventHandler(this.btnStartWatching_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(413, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(25, 32);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(371, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // rbtFile
            // 
            this.rbtFile.AutoSize = true;
            this.rbtFile.Checked = true;
            this.rbtFile.Location = new System.Drawing.Point(7, 24);
            this.rbtFile.Name = "rbtFile";
            this.rbtFile.Size = new System.Drawing.Size(76, 17);
            this.rbtFile.TabIndex = 3;
            this.rbtFile.TabStop = true;
            this.rbtFile.Text = "Watch File";
            this.rbtFile.UseVisualStyleBackColor = true;
            this.rbtFile.CheckedChanged += new System.EventHandler(this.rbtFile_CheckedChanged);
            // 
            // rbtDirectory
            // 
            this.rbtDirectory.AutoSize = true;
            this.rbtDirectory.Location = new System.Drawing.Point(7, 47);
            this.rbtDirectory.Name = "rbtDirectory";
            this.rbtDirectory.Size = new System.Drawing.Size(102, 17);
            this.rbtDirectory.TabIndex = 4;
            this.rbtDirectory.Text = "Watch Directory";
            this.rbtDirectory.UseVisualStyleBackColor = true;
            this.rbtDirectory.CheckedChanged += new System.EventHandler(this.rbtDirectory_CheckedChanged);
            // 
            // cbxIncludeSubs
            // 
            this.cbxIncludeSubs.AutoSize = true;
            this.cbxIncludeSubs.Enabled = false;
            this.cbxIncludeSubs.Location = new System.Drawing.Point(8, 70);
            this.cbxIncludeSubs.Name = "cbxIncludeSubs";
            this.cbxIncludeSubs.Size = new System.Drawing.Size(131, 17);
            this.cbxIncludeSubs.TabIndex = 5;
            this.cbxIncludeSubs.Text = "Include Subdirectories";
            this.cbxIncludeSubs.UseVisualStyleBackColor = true;
            this.cbxIncludeSubs.CheckedChanged += new System.EventHandler(this.cbxIncludeSubs_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.typeOfCHangeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.changeToDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.changesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 264);
            this.dataGridView1.TabIndex = 6;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "File Path";
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ToolTipText = "path of file";
            this.filePathDataGridViewTextBoxColumn.Width = 250;
            // 
            // typeOfCHangeDataGridViewTextBoxColumn
            // 
            this.typeOfCHangeDataGridViewTextBoxColumn.DataPropertyName = "TypeOfCHange";
            this.typeOfCHangeDataGridViewTextBoxColumn.HeaderText = "Description";
            this.typeOfCHangeDataGridViewTextBoxColumn.Name = "typeOfCHangeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date - Time";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeToDataGridViewTextBoxColumn
            // 
            this.changeToDataGridViewTextBoxColumn.DataPropertyName = "ChangeTo";
            this.changeToDataGridViewTextBoxColumn.HeaderText = "Changed To:";
            this.changeToDataGridViewTextBoxColumn.Name = "changeToDataGridViewTextBoxColumn";
            this.changeToDataGridViewTextBoxColumn.Width = 120;
            // 
            // changesBindingSource
            // 
            this.changesBindingSource.DataSource = typeof(FileSystemWatcher.Changes);
            // 
            // btnMakeChnages
            // 
            this.btnMakeChnages.Enabled = false;
            this.btnMakeChnages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeChnages.Location = new System.Drawing.Point(213, 64);
            this.btnMakeChnages.Name = "btnMakeChnages";
            this.btnMakeChnages.Size = new System.Drawing.Size(117, 31);
            this.btnMakeChnages.TabIndex = 7;
            this.btnMakeChnages.Text = "Manage Log";
            this.btnMakeChnages.UseVisualStyleBackColor = true;
            this.btnMakeChnages.Click += new System.EventHandler(this.btnMakeChnages_Click);
            // 
            // btnLogChanges
            // 
            this.btnLogChanges.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogChanges.Enabled = false;
            this.btnLogChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogChanges.Location = new System.Drawing.Point(10, 381);
            this.btnLogChanges.Name = "btnLogChanges";
            this.btnLogChanges.Size = new System.Drawing.Size(290, 36);
            this.btnLogChanges.TabIndex = 8;
            this.btnLogChanges.Text = "Log Changes";
            this.btnLogChanges.UseVisualStyleBackColor = false;
            this.btnLogChanges.Click += new System.EventHandler(this.btnLogChanges_Click);
            // 
            // tmrAddChanges
            // 
            this.tmrAddChanges.Interval = 10;
            this.tmrAddChanges.Tick += new System.EventHandler(this.tmrAddChanges_Tick);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDirectory);
            this.groupBox1.Controls.Add(this.rbtFile);
            this.groupBox1.Controls.Add(this.cbxIncludeSubs);
            this.groupBox1.Location = new System.Drawing.Point(609, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Watch Mode";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(516, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(251, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // notifying
            // 
            this.notifying.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifying.Text = "ROD\'S EYE";
            this.notifying.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(775, 426);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogChanges);
            this.Controls.Add(this.btnMakeChnages);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnStartWatching);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GODS EYE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartWatching;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.RadioButton rbtFile;
        private System.Windows.Forms.RadioButton rbtDirectory;
        private System.Windows.Forms.CheckBox cbxIncludeSubs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource changesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfCHangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMakeChnages;
        private System.Windows.Forms.Button btnLogChanges;
        private System.Windows.Forms.Timer tmrAddChanges;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseFolder;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.NotifyIcon notifying;
    }
}

