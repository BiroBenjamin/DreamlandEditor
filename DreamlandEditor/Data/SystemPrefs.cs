using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DreamlandEditor.Data
{
    [Serializable]
    public class SystemPrefs 
    {
        public string rootPath = @"C:\Temp";
        public string debugLogPath = $@"C:\Users\{Environment.UserName}\Documents\DreamlandEditor\DebugLog\";
        public bool isDevMode = true;

        [XmlIgnore] public Dictionary<string, string[]> FolderStructure;
        [XmlIgnore] public List<string> extensions = new List<string>();

        public SystemPrefs() 
        {
            FolderStructure = new Dictionary<string, string[]>() 
            {
                { "Map", new string[2] {$@"{rootPath}\Maps", "pdmap" } },
                //{ "Item", new string[2] {$@"{rootPath}\Items", "pdx" } },
                { "Character", new string[2] {$@"{rootPath}\Characters", "pdx" } },
                { "World Object", new string[2] {$@"{rootPath}\WorldObjects", "pdx" } },
            };

            foreach(KeyValuePair<string, string[]> file in FolderStructure)
            {
                extensions.Add(file.Value[1]);
            }
        }

        public override string ToString() 
        {
            return $"[ rootPath: {rootPath} ]" +
                $"  [ isDevMode: {isDevMode} ]" +
                $"  [ debugLogPath: {debugLogPath} ]";
        }

    }
}
