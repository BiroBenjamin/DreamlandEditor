using DreamlandEditor.Data;
using DreamlandEditor.Data.GameFiles;
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
                    (obj as IBaseFile).FilePath = path;
                    serializer.Serialize(writer, obj);
				}
				catch(Exception ex)
				{
                    MessageBox.Show("Unexpected error during save.\nSee log file for further info.", "Error");
                    DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
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
                    DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
                }
            }

            return obj;
        }
    }
}
