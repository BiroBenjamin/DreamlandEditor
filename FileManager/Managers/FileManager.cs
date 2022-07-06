using FileManager.Data;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Serialization;

namespace FileManager.Managers
{
    public static class FileManager
    {
        private static Aes key;
        public static void SerializeWorldObject(string path, WorldObject obj)
        {
            key = Aes.Create();
            XmlSerializer serializer = new XmlSerializer(typeof(WorldObject));

            using StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, obj);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(path);

            EncryptedXml eXml = new EncryptedXml();
            foreach(XmlElement elem in xmlDoc)
            {
                byte[] encryptedElement = eXml.EncryptData(elem, key, false);
                EncryptedData edElement = new EncryptedData();
                edElement.Type = EncryptedXml.XmlEncElementUrl;

                if (!(key is Aes)) return;
                string encryptionMethod = EncryptedXml.XmlEncAES256Url;
                edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);

                edElement.CipherData.CipherValue = encryptedElement;
                EncryptedXml.ReplaceElement(elem, edElement, false);
            }
        }
    }
}
