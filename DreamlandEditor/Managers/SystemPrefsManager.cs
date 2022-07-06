﻿using DreamlandEditor.Data;
using System.IO;
using System.Xml.Serialization;

namespace DreamlandEditor.Managers 
{
    public static class SystemPrefsManager 
    {
        private static readonly XmlSerializer serializer = new XmlSerializer(typeof(SystemPrefs));
        private static readonly string path = @"../../SystemPrefs.xml";
        private static SystemPrefs systemPrefs = new SystemPrefs();

        public static SystemPrefs SetUpSystemPrefs() 
        {
            try 
            {
                DeserializeSystemPrefs();
            } 
            catch (FileNotFoundException)
            {
                SerializeSystemPrefs();
            }
            return systemPrefs;
        }
        private static void DeserializeSystemPrefs() 
        {
            using (TextReader reader = new StreamReader(path)) 
            {
                systemPrefs = (SystemPrefs)serializer.Deserialize(reader);
            }
        }
        private static void SerializeSystemPrefs() 
        {
            using (StreamWriter writer = new StreamWriter(path)) 
            {
                systemPrefs = new SystemPrefs();
                serializer.Serialize(writer, systemPrefs);
            }
        }
    }
}
