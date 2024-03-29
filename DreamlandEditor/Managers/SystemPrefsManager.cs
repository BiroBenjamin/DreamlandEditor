﻿using DreamlandEditor.Data;
using DreamlandEditor.UI;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DreamlandEditor.Managers
{
  public static class SystemPrefsManager
  {
    private static readonly XmlSerializer serializer = new XmlSerializer(typeof(SystemPrefs));
    private static readonly string pathDirectory = $@"C:\Users\{Environment.UserName}\Documents\DreamlandEditor\";
    private static readonly string path = $@"C:\Users\{Environment.UserName}\Documents\DreamlandEditor\SystemPrefs.xml";
    public static SystemPrefs SystemPrefs { get; set; } = new SystemPrefs();

    public static SystemPrefs SetUpSystemPrefs()
    {
      if (!File.Exists(path))
      {
        MessageBox.Show($"Can not find {path}.\n Please make sure it exists.", "File loading error");
        Environment.Exit(-1);
      }
      DeserializeSystemPrefs();
      SystemPrefs.SetupFolderStructure();
      return SystemPrefs;
    }
    private static void DeserializeSystemPrefs()
    {
      using (TextReader reader = new StreamReader(path))
      {
        SystemPrefs = (SystemPrefs)serializer.Deserialize(reader);
      }
    }
    private static void SerializeSystemPrefs()
    {
      using (StreamWriter writer = new StreamWriter(path))
      {
        SystemPrefs = new SystemPrefs();
        serializer.Serialize(writer, SystemPrefs);
      }
    }
  }
}
