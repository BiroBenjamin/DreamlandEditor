using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;

namespace DreamlandEditor.Data
{
    public class BaseFile
    {
        public string FileType { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        [XmlIgnore]
        public Texture2D Texture { get; set; }
        public string FilePath { get; set; }

        public BaseFile()
        {
        }
    }
}
