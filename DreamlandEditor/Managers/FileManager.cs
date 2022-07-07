using DreamlandEditor.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DreamlandEditor.Managers
{
    public static class FileManager<T>
    {
        public static void SaveFile(string path, T obj)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
            }
            LoadFile(path);
        }

        public static T LoadFile(string path)
        {
            T obj;
            using(FileStream stream = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                obj = (T)formatter.Deserialize(stream);
            }

            return obj;
        }
    }
}
