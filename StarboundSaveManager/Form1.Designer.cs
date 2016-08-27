namespace StarboundSaveManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.labelBackupsList = new System.Windows.Forms.Label();
            this.listViewBackups = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOtherSettings = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectBackupsLocation = new System.Windows.Forms.Button();
            this.textBoxBackupsLocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectSettingsFile = new System.Windows.Forms.Button();
            this.textBoxSettingsLocation = new System.Windows.Forms.TextBox();
            this.labelStarboundFolder = new System.Windows.Forms.Label();
            this.labelSettingsFile = new System.Windows.Forms.Label();
            this.labelBackupLocation = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectStarboundFolder = new System.Windows.Forms.Button();
            this.textBoxStarboundFolder = new System.Windows.Forms.TextBox();
            this.checkBoxAutoBackup = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saves";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBackupsList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewBackups, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonBackup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRestore, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(469, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackup.Location = new System.Drawing.Point(3, 3);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(228, 28);
            this.buttonBackup.TabIndex = 0;
            this.buttonBackup.Text = "Create new backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestore.Location = new System.Drawing.Point(237, 3);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(229, 28);
            this.buttonRestore.TabIndex = 1;
            this.buttonRestore.Text = "Restore selected";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // labelBackupsList
            // 
            this.labelBackupsList.AutoSize = true;
            this.labelBackupsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBackupsList.Location = new System.Drawing.Point(3, 40);
            this.labelBackupsList.Name = "labelBackupsList";
            this.labelBackupsList.Size = new System.Drawing.Size(213, 29);
            this.labelBackupsList.TabIndex = 1;
            this.labelBackupsList.Text = "Available backups:";
            // 
            // listViewBackups
            // 
            this.listViewBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBackups.Location = new System.Drawing.Point(3, 72);
            this.listViewBackups.MultiSelect = false;
            this.listViewBackups.Name = "listViewBackups";
            this.listViewBackups.Size = new System.Drawing.Size(469, 176);
            this.listViewBackups.TabIndex = 2;
            this.listViewBackups.UseCompatibleStateImageBehavior = false;
            this.listViewBackups.View = System.Windows.Forms.View.List;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 254);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(469, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelOtherSettings, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelStarboundFolder, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelSettingsFile, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelBackupLocation, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxAutoBackup, 0, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 281);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelOtherSettings
            // 
            this.labelOtherSettings.AutoSize = true;
            this.labelOtherSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOtherSettings.Location = new System.Drawing.Point(3, 192);
            this.labelOtherSettings.Name = "labelOtherSettings";
            this.labelOtherSettings.Size = new System.Drawing.Size(184, 31);
            this.labelOtherSettings.TabIndex = 9;
            this.labelOtherSettings.Text = "Other settings";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonSelectBackupsLocation, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxBackupsLocation, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 162);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(469, 27);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // buttonSelectBackupsLocation
            // 
            this.buttonSelectBackupsLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectBackupsLocation.Location = new System.Drawing.Point(422, 3);
            this.buttonSelectBackupsLocation.Name = "buttonSelectBackupsLocation";
            this.buttonSelectBackupsLocation.Size = new System.Drawing.Size(44, 21);
            this.buttonSelectBackupsLocation.TabIndex = 0;
            this.buttonSelectBackupsLocation.Text = "...";
            this.buttonSelectBackupsLocation.UseVisualStyleBackColor = true;
            this.buttonSelectBackupsLocation.Click += new System.EventHandler(this.buttonSelectBackupsLocation_Click);
            // 
            // textBoxBackupsLocation
            // 
            this.textBoxBackupsLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBackupsLocation.Location = new System.Drawing.Point(3, 3);
            this.textBoxBackupsLocation.Name = "textBoxBackupsLocation";
            this.textBoxBackupsLocation.Size = new System.Drawing.Size(413, 20);
            this.textBoxBackupsLocation.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonSelectSettingsFile, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxSettingsLocation, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 98);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(469, 27);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // buttonSelectSettingsFile
            // 
            this.buttonSelectSettingsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectSettingsFile.Location = new System.Drawing.Point(422, 3);
            this.buttonSelectSettingsFile.Name = "buttonSelectSettingsFile";
            this.buttonSelectSettingsFile.Size = new System.Drawing.Size(44, 21);
            this.buttonSelectSettingsFile.TabIndex = 0;
            this.buttonSelectSettingsFile.Text = "...";
            this.buttonSelectSettingsFile.UseVisualStyleBackColor = true;
            this.buttonSelectSettingsFile.Click += new System.EventHandler(this.buttonSelectSettingsFile_Click);
            // 
            // textBoxSettingsLocation
            // 
            this.textBoxSettingsLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSettingsLocation.Location = new System.Drawing.Point(3, 3);
            this.textBoxSettingsLocation.Name = "textBoxSettingsLocation";
            this.textBoxSettingsLocation.Size = new System.Drawing.Size(413, 20);
            this.textBoxSettingsLocation.TabIndex = 1;
            // 
            // labelStarboundFolder
            // 
            this.labelStarboundFolder.AutoSize = true;
            this.labelStarboundFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStarboundFolder.Location = new System.Drawing.Point(3, 0);
            this.labelStarboundFolder.Name = "labelStarboundFolder";
            this.labelStarboundFolder.Size = new System.Drawing.Size(358, 31);
            this.labelStarboundFolder.TabIndex = 2;
            this.labelStarboundFolder.Text = "Starbound installation folder:";
            // 
            // labelSettingsFile
            // 
            this.labelSettingsFile.AutoSize = true;
            this.labelSettingsFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSettingsFile.Location = new System.Drawing.Point(3, 64);
            this.labelSettingsFile.Name = "labelSettingsFile";
            this.labelSettingsFile.Size = new System.Drawing.Size(163, 31);
            this.labelSettingsFile.TabIndex = 3;
            this.labelSettingsFile.Text = "Settings file:";
            // 
            // labelBackupLocation
            // 
            this.labelBackupLocation.AutoSize = true;
            this.labelBackupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBackupLocation.Location = new System.Drawing.Point(3, 128);
            this.labelBackupLocation.Name = "labelBackupLocation";
            this.labelBackupLocation.Size = new System.Drawing.Size(228, 31);
            this.labelBackupLocation.TabIndex = 4;
            this.labelBackupLocation.Text = "Backups location:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonSelectStarboundFolder, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxStarboundFolder, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(469, 27);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // buttonSelectStarboundFolder
            // 
            this.buttonSelectStarboundFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectStarboundFolder.Location = new System.Drawing.Point(422, 3);
            this.buttonSelectStarboundFolder.Name = "buttonSelectStarboundFolder";
            this.buttonSelectStarboundFolder.Size = new System.Drawing.Size(44, 21);
            this.buttonSelectStarboundFolder.TabIndex = 0;
            this.buttonSelectStarboundFolder.Text = "...";
            this.buttonSelectStarboundFolder.UseVisualStyleBackColor = true;
            this.buttonSelectStarboundFolder.Click += new System.EventHandler(this.buttonSelectStarboundFolder_Click);
            // 
            // textBoxStarboundFolder
            // 
            this.textBoxStarboundFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStarboundFolder.Location = new System.Drawing.Point(3, 3);
            this.textBoxStarboundFolder.Name = "textBoxStarboundFolder";
            this.textBoxStarboundFolder.Size = new System.Drawing.Size(413, 20);
            this.textBoxStarboundFolder.TabIndex = 1;
            // 
            // checkBoxAutoBackup
            // 
            this.checkBoxAutoBackup.AutoSize = true;
            this.checkBoxAutoBackup.Checked = true;
            this.checkBoxAutoBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAutoBackup.Location = new System.Drawing.Point(3, 226);
            this.checkBoxAutoBackup.Name = "checkBoxAutoBackup";
            this.checkBoxAutoBackup.Size = new System.Drawing.Size(215, 26);
            this.checkBoxAutoBackup.TabIndex = 8;
            this.checkBoxAutoBackup.Text = "Auto backup on restore";
            this.checkBoxAutoBackup.UseVisualStyleBackColor = true;
            this.checkBoxAutoBackup.CheckedChanged += new System.EventHandler(this.checkBoxAutoBackup_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 313);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Starbound Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Label labelBackupsList;
        private System.Windows.Forms.ListView listViewBackups;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonSelectBackupsLocation;
        private System.Windows.Forms.TextBox textBoxBackupsLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonSelectSettingsFile;
        private System.Windows.Forms.TextBox textBoxSettingsLocation;
        private System.Windows.Forms.Label labelStarboundFolder;
        private System.Windows.Forms.Label labelSettingsFile;
        private System.Windows.Forms.Label labelBackupLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonSelectStarboundFolder;
        private System.Windows.Forms.TextBox textBoxStarboundFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelOtherSettings;
        private System.Windows.Forms.CheckBox checkBoxAutoBackup;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

