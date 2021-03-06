﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StarboundSaveManager
{
    static class Directory
    {
        internal static string Backup(string source, string destination)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string pattern = @"yyyy-MM-dd-HHmm";
                string _destination = Path.Combine(destination, string.Format("StarboundBackup" + dt.ToString(pattern)));
                System.IO.Directory.CreateDirectory(_destination);
                string _source = Path.Combine(source, "Storage");
                DirectoryInfo dir = new DirectoryInfo(_source);
                if (dir.Exists)
                {                    
                    Copy(_source, _destination);
                }
                return _destination;
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Exception raised in Backup method:\n{0}", e.Message));
            }
            return "";
        }

        internal static void Restore(string destination, string selectedBackup)
        {
            string _destination = Path.Combine(destination, "Storage");
            DirectoryInfo dir = new DirectoryInfo(selectedBackup);
            if (!dir.Exists)
            {
                MessageBox.Show("Please select valid backup.");
            }
            else
            {
                Copy(selectedBackup, _destination);
            }
        }

        static void Copy(string source, string destination)
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            if (dir.Exists)
            {
                System.IO.Directory.CreateDirectory(destination);
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string path = Path.Combine(destination, file.Name);
                    file.CopyTo(path, true);
                    Console.WriteLine(file.Name);
                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo subdir in dirs)
                {
                    string path = Path.Combine(destination, subdir.Name);
                    Copy(subdir.FullName, path);
                }
            }
        }

        internal static List<string> GetFolders(string source)
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();
            List<string> directories = new List<string>();
            foreach (DirectoryInfo subdir in dirs)
            {
                directories.Add(subdir.Name);
            }
            return directories;
        }
    }
}
