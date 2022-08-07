using DreamlandEditor.Data;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DreamlandEditor.Managers
{
    public static class FileManager<T>
    {
        private static readonly XmlSerializer serializer = new XmlSerializer(typeof(T));
        public static void SaveFile(string path, T obj)
        {
            using(StreamWriter writer = new StreamWriter(path))
            {
				try
				{
                    (obj as BaseFile).FilePath = path;
                    serializer.Serialize(writer, obj);
				}
				catch(Exception ex)
				{
                    MessageBox.Show("Unexpected error during save.\nSee log file for further info.", "Error");
                    DebugManager.Log($"Error at file saving\n{ex.Message}");
				}
            }
        }

        public static T LoadFile(string path)
        {
            T obj = default;
            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    obj = (T)serializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error during Load.\nSee log file for further info.", "Error");
                    DebugManager.Log($"Error at file loading\n{ex.Message}");
                }
            }

            return obj;
        }
    }
}
