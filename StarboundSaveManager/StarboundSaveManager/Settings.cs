using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace StarboundSaveManager
{
    [Serializable()]
    class Settings : ISerializable
    {
        public string StarboundFolder { get; set; }
        public string BackupFolder { get; set; }
        public bool AutoBackup { get; set; }
        public Settings()
        {
            StarboundFolder = @"C:\Program Files (x86)\Steam\steamapps\common\Starbound";
            BackupFolder = Path.GetDirectoryName(Application.ExecutablePath);
            AutoBackup = true;
        }

        // Serialization
        public Settings(SerializationInfo info, StreamingContext ctxt)
        {
            StarboundFolder = (string)info.GetValue("StarboundFolder", typeof(string));
            BackupFolder = (string)info.GetValue("BackupFolder", typeof(string));
            AutoBackup = (bool)info.GetValue("AutoBackup", typeof(bool));
        }

        // Deserialization
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("StarboundFolder", StarboundFolder);
            info.AddValue("BackupFolder", BackupFolder);
            info.AddValue("AutoBackup", AutoBackup);
        }
    }
}
