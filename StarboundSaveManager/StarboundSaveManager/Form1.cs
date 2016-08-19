using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StarboundSaveManager
{
    public partial class Form1 : Form
    {
        private string starboundFolder;
        public string StarboundFolder
        {
            get
            {
                return starboundFolder;
            }
            set
            {
                starboundFolder = value;
                textBoxStarboundFolder.Text = value;
            }
        }
        private string settingsFile;
        public string SettingsFile
        {
            get
            {
                return settingsFile;
            }
            set
            {
                settingsFile = value;
                textBoxSettingsLocation.Text = value;
            }
        }
        private string backupsLocation;
        public string BackupsLocation
        {
            get
            {
                return backupsLocation;
            }
            set
            {
                backupsLocation = value;
                textBoxBackupsLocation.Text = value;
            }
        }
        private string SelectedBackup { get; set; }

        public Form1()
        {
            InitializeComponent();
            string temp = @"C:\Program Files (x86)\Steam\steamapps\common\Starbound";
            DirectoryInfo dir = new DirectoryInfo(temp);
            if (!dir.Exists)
            {
                MessageBox.Show("Could not find Starbound installation folder. Remember to set it in Settings tab.");
            } else
            {
                StarboundFolder = temp;
            }
            temp = Path.GetDirectoryName(Application.ExecutablePath);
            SettingsFile = temp;
            BackupsLocation = temp;
            GetAvailableBackups();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Confirm to start backup.\nProgram may freeze until it finish copying files.");
                string temp = Directory.Backup(StarboundFolder, BackupsLocation);
                SelectedBackup = temp;
                GetAvailableBackups();
                MessageBox.Show("Backup complete!");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Confirm to start restore.\nProgram may freeze until it finish copying files.");
                //Directory.Backup(StarboundFolder, BackupsLocation);
                SelectedBackup = listViewBackups.SelectedItems[0].Text;
                string selectedBackupPath = Path.Combine(BackupsLocation, SelectedBackup);
                Directory.Restore(StarboundFolder, selectedBackupPath);
                MessageBox.Show("Restore complete!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonSelectStarboundFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            StarboundFolder = folderBrowserDialog1.SelectedPath;
        }

        private void buttonSelectSettingsFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            SettingsFile = folderBrowserDialog1.SelectedPath;
        }

        private void buttonSelectBackupsLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            BackupsLocation = folderBrowserDialog1.SelectedPath;
            GetAvailableBackups();
        }

        private void GetAvailableBackups()
        {
            List<string> availableBackups = Directory.GetFolders(BackupsLocation);
            if(availableBackups != null)
            {
                foreach (string backup in availableBackups)
                {
                    listViewBackups.Items.Add(backup);
                }
            }            
        }
    }
}
