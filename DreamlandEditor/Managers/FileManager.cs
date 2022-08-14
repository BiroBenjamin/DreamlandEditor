using DreamlandEditor.Data;
using DreamlandEditor.Data.GameFiles;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DreamlandEditor.Managers
{
    public static class FileManager
    {
        public static void SaveFile<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                using (StreamWriter writer = new StreamWriter((obj as IBaseFile).FilePath))
                {

                    serializer.Serialize(writer, obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error during save.\nSee log file for further info.", "Error");
                DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
            }
        }

        public static IBaseFile LoadFile<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            IBaseFile loadedItem = default;
            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    loadedItem = (IBaseFile)serializer.Deserialize(reader);
                    loadedItem.FilePath = path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error during Load.\nSee log file for further info.", "Error");
                    DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
                }
            }

            return loadedItem;
        }
    }
}
