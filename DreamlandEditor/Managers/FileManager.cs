using System.IO;
using System.Xml.Serialization;

namespace DreamlandEditor.Managers
{
    public static class FileManager<T>
    {
        private static readonly XmlSerializer serializer = new XmlSerializer(typeof(T));
        public static void SaveFile(string path, T obj)
        {
            /*using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
            }
            LoadFile(path);*/
            using(StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static T LoadFile(string path)
        {
            T obj;
            /*using(FileStream stream = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                obj = (T)formatter.Deserialize(stream);
            }*/

            using (StreamReader reader = new StreamReader(path))
            {
                obj = (T)serializer.Deserialize(reader);
            }

            return obj;
        }
    }
}
