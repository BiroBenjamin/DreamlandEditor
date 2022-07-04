using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DreamlandEditor.Data
{
    [Serializable]
    public class SystemPrefs /*: ISerializable*/ 
    {
        public string rootPath = @"C:\Temp";
        public string debugLogPath = $@"C:\Users\{Environment.UserName}\Documents\DreamlandEditor\DebugLog\";
        public bool isDevMode = true;

        [XmlIgnore] public Dictionary<string, KeyValuePair<string, string>> FolderStructure = 
            new Dictionary<string, KeyValuePair<string, string>>();

        public SystemPrefs() 
        {
            FolderStructure.Add("Map", new KeyValuePair<string, string> ($@"{rootPath}\Maps", "pdm"));
            FolderStructure.Add("Item", new KeyValuePair<string, string> ($@"{rootPath}\Items", "pdi"));
            FolderStructure.Add("Character", new KeyValuePair<string, string> ($@"{rootPath}\Characters", "pdc"));
        }
        /*public SystemPrefs(SerializationInfo info, StreamingContext context) {
            rootPath = info.GetString("static.rootPath");
            isDevMode = info.GetBoolean("static.isDevMode");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("static.rootPath", rootPath, typeof(string));
            info.AddValue("static.isDevMode", isDevMode, typeof(bool));
        }*/
        public override string ToString() 
        {
            return $"[ rootPath: {rootPath} ]" +
                $"  [ isDevMode: {isDevMode} ]" +
                $"  [ debugLogPath: {debugLogPath} ]";
        }

    }
}
