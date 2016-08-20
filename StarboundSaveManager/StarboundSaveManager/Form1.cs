using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
                DirectoryInfo dir = new DirectoryInfo(value);
                if (!dir.Exists)
                {
                    MessageBox.Show("Could not find Starbound installation folder. Remember to set it in Settings tab.");
                } else
                {
                    starboundFolder = value;
                    textBoxStarboundFolder.Text = value;
                    settings.StarboundFolder = value;
                }
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
                ReadSettings();
                GetAvailableBackups();
            }
        }
        private string backupFolder;
        public string BackupFolder
        {
            get
            {
                return backupFolder;
            }
            set
            {
                backupFolder = value;
                textBoxBackupsLocation.Text = value;
                settings.BackupFolder = value;
            }
        }
        private bool autoBackup;
        public bool AutoBackup
        {
            get
            {
                return autoBackup;
            }
            set
            {
                autoBackup = value;
                checkBoxAutoBackup.Checked = value;
                settings.AutoBackup = value;
            }
        }
        private string SelectedBackup { get; set; }
        Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();
            var temp = Path.GetDirectoryName(Application.ExecutablePath);
            SettingsFile = temp;
            ReadSettings();
            GetAvailableBackups();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Confirm to start backup.\nProgram may freeze until it finish copying files.");
                string temp = Directory.Backup(StarboundFolder, BackupFolder);
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
                if (AutoBackup) Directory.Backup(StarboundFolder, BackupFolder);
                SelectedBackup = listViewBackups.SelectedItems[0].Text;
                string selectedBackupPath = Path.Combine(BackupFolder, SelectedBackup);
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
            BackupFolder = folderBrowserDialog1.SelectedPath;
            GetAvailableBackups();
        }

        private void checkBoxAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            AutoBackup = checkBoxAutoBackup.Checked;
        }

        private void GetAvailableBackups()
        {
            listViewBackups.Items.Clear();
            List<string> availableBackups = Directory.GetFolders(BackupFolder);
            if(availableBackups != null)
            {
                foreach (string backup in availableBackups)
                {
                    if(backup.StartsWith("StarboundBackup"))
                        listViewBackups.Items.Add(backup);
                }
            }
        }

        private void ReadSettings()
        {
            try
            {               
                using (Stream stream = File.Open(Path.Combine(settingsFile,"StarboundSaveManager.settings"), FileMode.Open))
                {
                    settings = null;
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    settings = (Settings)binaryFormatter.Deserialize(stream);
                }
                StarboundFolder = settings.StarboundFolder;
                BackupFolder = settings.BackupFolder;
                AutoBackup = settings.AutoBackup;
            }
            catch (FileNotFoundException)
            {
                StarboundFolder = settings.StarboundFolder;
                BackupFolder = settings.BackupFolder;
                AutoBackup = settings.AutoBackup;
            }
        }

        private void SaveSettings()
        {
            try
            {
                using (Stream stream = File.Open(Path.Combine(settingsFile, "StarboundSaveManager.settings"), FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, settings);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to save user preferences: " + e.Message);
            }   
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
