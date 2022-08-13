using Microsoft.Xna.Framework.Graphics;
using System;
using System.Drawing;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles
{
    [Serializable]
    public class WorldObject : IBaseFile
    {
        public string FileType { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string FilePath { get; set; }
        public string ObjectType { get; set; }
        [XmlIgnore] public Texture2D Texture { get; set; }
        public Point Position { get; set; }
        public Point CollisionLocation { get; set; } = new Point(0, 0);
        [XmlIgnore] public Size BaseSize { get; private set; } = new Size(32, 32);
        public Size Size { get; set; } = new Size(64, 64);
        public Size CollisionSize { get; set; } = new Size(0, 0);
        public bool IsInteractable { get; set; } = false;
        public bool IsCollidable { get; set; } = false;

        public WorldObject()
        {
        }

        
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nImagePath: {ImagePath}\nLocation: {Position}";
        }

        public IBaseFile Clone()
        {
            return new WorldObject()
            {
                ID = ID,
                Texture = Texture,
                Size = Size,
                Position = Position,
                Name = Name,
                ImagePath = ImagePath,
                FileType = FileType,
                BaseSize = BaseSize,
                CollisionLocation = CollisionLocation,
                CollisionSize = CollisionSize,
                FilePath = FilePath,
                IsCollidable = IsCollidable,
                IsInteractable = IsInteractable,
            };
        }
    }
}
