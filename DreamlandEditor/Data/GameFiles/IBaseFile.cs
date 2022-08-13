using Microsoft.Xna.Framework.Graphics;
using System;
using System.Drawing;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles
{
    public interface IBaseFile
    {
        string FileType { get; set; }
        string ID { get; set; }
        string Name { get; set; }
        string ImagePath { get; set; }
        string FilePath { get; set; }
        [XmlIgnore] Texture2D Texture { get; set; }
        Point Position { get; set; }

        IBaseFile Clone();
    }
}
