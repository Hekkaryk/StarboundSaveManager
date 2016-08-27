using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace StarboundSaveManager
{
    public partial class Form1 : Form
    {
        #region Properties
        private string starboundFolder;
        public string StarboundFolder
        {
            get
            {
                return starboundFolder;
            }
            set
            {
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(value);
                    if (!dir.Exists)
                    {
                        MessageBox.Show("Could not find Starbound installation folder. Remember to set it in Settings tab.");
                    }
                    else
                    {
                        starboundFolder = value;
                        textBoxStarboundFolder.Text = value;
                        settings.StarboundFolder = value;
                        SaveSettings();
                    }
                }
                catch
                {
                    MessageBox.Show("Please select valid folder.");
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
                SaveSettings();
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
                SaveSettings();
            }
        }
        private string SelectedBackup { get; set; }
        private string Action { get; set; }
        Settings settings = new Settings();
        #endregion
        #region Init
        public Form1()
        {
            InitializeComponent();
            var temp = Path.GetDirectoryName(Application.ExecutablePath);
            SettingsFile = temp;
            ReadSettings();
            GetAvailableBackups();
        }
        #endregion
        #region Input reation methods
        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                Action = "Backup";
                int numberOfFilesToCopy = Directory.Count(Path.Combine(StarboundFolder, "Storage"));
                progressBar1.Maximum = numberOfFilesToCopy;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                DisableAll();
                backgroundWorker1.RunWorkerAsync();                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                Action = "Restore";                
                if (listViewBackups.SelectedItems.Count != 1) throw new Exception("Please select backup to restore");
                SelectedBackup = listViewBackups.SelectedItems[0].Text;
                string selectedBackupPath = Path.Combine(BackupFolder, SelectedBackup);
                int numberOfFilesToCopy = Directory.Count(selectedBackupPath);
                if (AutoBackup) numberOfFilesToCopy += Directory.Count(Path.Combine(StarboundFolder, "Storage"));
                progressBar1.Maximum = numberOfFilesToCopy;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                DisableAll();
                backgroundWorker1.RunWorkerAsync();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
        #endregion
        #region Private methods
        private void GetAvailableBackups()
        {
            listViewBackups.Items.Clear();
            List<string> availableBackups = Directory.GetFolders(BackupFolder);
            if (availableBackups != null)
            {
                foreach (string backup in availableBackups)
                {
                    if (backup.StartsWith("StarboundBackup"))
                        listViewBackups.Items.Add(backup);
                }
            }
        }

        private void ReadSettings()
        {
            try
            {
                using (Stream stream = File.Open(Path.Combine(settingsFile, "StarboundSaveManager.settings"), FileMode.Open))
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
        
        private void DisableAll()
        {
            tabControl1.Enabled = false;
        }

        private void EnableAll()
        {
            tabControl1.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var backgroundWorker = sender as BackgroundWorker;
                if (Action == "Backup")
                {                                      
                    string temp = Directory.Backup(StarboundFolder, BackupFolder, backgroundWorker);
                    SelectedBackup = temp;
                }
                else if (Action == "Restore")
                {                    
                    string selectedBackupPath = Path.Combine(BackupFolder, SelectedBackup);
                    if (AutoBackup)
                    {
                        Directory.Backup(StarboundFolder, BackupFolder, backgroundWorker);
                    }
                    Directory.Restore(StarboundFolder, selectedBackupPath, backgroundWorker);                    
                }
                else
                {
                    MessageBox.Show("Something bad happened. Worker is running with no task!", "Uh-oh...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value += e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GetAvailableBackups();
            if(Action == "Backup")
            {
                MessageBox.Show("Backup complete!");
            }
            else if (Action == "Restore")
            {
                if (!AutoBackup)
                    MessageBox.Show("Restore complete!");
                else
                    MessageBox.Show("Automatic backup and restore complete!");
            }
            EnableAll();
        }
        #endregion
    }
}
