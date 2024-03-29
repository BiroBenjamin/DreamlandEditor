﻿using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DreamlandEditor.Data
{
  [Serializable]
  public class SystemPrefs
  {
    public string RootPath { get; set; }
    public string DebugLogPath { get; set; } = $@"C:\Users\{Environment.UserName}\Documents\DreamlandEditor\Log\";
    public bool IsDevMode { get; set; } = true;

    [XmlIgnore] public Dictionary<string, string[]> FolderStructure { get; set; }
    [XmlIgnore] public List<string> Extensions { get; set; } = new List<string>();

    public SystemPrefs() { }
    public void SetupFolderStructure()
    {
      FolderStructure = new Dictionary<string, string[]>()
      {
        { FileTypesEnum.Map.GetDescription(), new string[2] {Path.Combine(RootPath, "Maps"), "map" } },
        { FileTypesEnum.Character.GetDescription(), new string[2] { Path.Combine(RootPath, "Objects\\Characters"), "dex" } },
        { FileTypesEnum.WorldObject.GetDescription(), new string[2] { Path.Combine(RootPath, "Objects\\WorldObjects"), "dex" } },
        { FileTypesEnum.Tile.GetDescription(), new string[2] { Path.Combine(RootPath, "Objects\\Tiles"), "dex" } },
      };

      foreach (KeyValuePair<string, string[]> file in FolderStructure)
      {
        string extension = file.Value[1];
        if (!Extensions.Contains(extension))
        {
          Extensions.Add(extension);
        }
      }
    }
  }
}
