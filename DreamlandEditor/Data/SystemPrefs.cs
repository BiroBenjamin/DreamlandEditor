using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DreamlandEditor.Data
{
    [Serializable]
    public class SystemPrefs 
    {
        [XmlIgnore] public string rootPath = @"..\..\..\TempFolder";
        public string debugLogPath = $@"C:\Users\{Environment.UserName}\Documents\DreamlandEditor\DebugLog\";
        public bool isDevMode = true;

        [XmlIgnore] public Dictionary<string, string[]> FolderStructure;
        [XmlIgnore] public List<string> extensions = new List<string>();

        public SystemPrefs() 
        {
            FolderStructure = new Dictionary<string, string[]>() 
            {
                { FileTypesEnum.Map.GetDescription(), new string[2] {$@"{rootPath}\Maps", "map" } },
                //{ "Item", new string[2] {$@"{rootPath}\Objects\Items", "dex" } },
                { FileTypesEnum.Character.GetDescription(), new string[2] {$@"{rootPath}\Objects\Characters", "dex" } },
                { FileTypesEnum.WorldObject.GetDescription(), new string[2] {$@"{rootPath}\Objects\WorldObjects", "dex" } },
                { FileTypesEnum.Tile.GetDescription(), new string[2] {$@"{rootPath}\Objects\Tiles", "dex" } },
            };

            foreach(KeyValuePair<string, string[]> file in FolderStructure)
            {
                string extension = file.Value[1];
				if (!extensions.Contains(extension))
				{
                    extensions.Add(extension);
				}
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
