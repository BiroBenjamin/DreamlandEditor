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
        public int ZIndex { get; set; }
        [XmlIgnore] public Texture2D Texture { get; set; }
        public Point Position { get; set; }
        public Point CollisionPosition { get; set; } = new Point(0, 0);
        [XmlIgnore] public Size BaseSize { get; private set; } = new Size(32, 32);
        public Size Size { get; set; } = new Size(64, 64);
        public Size CollisionSize { get; set; } = new Size(0, 0);
        public bool IsInteractable { get; set; } = false;
        public bool IsCollidable { get; set; } = false;

        public WorldObject()
        {
        }

        public Microsoft.Xna.Framework.Rectangle GetCollision()
        {
            return new Microsoft.Xna.Framework.Rectangle(
                Position.X + CollisionPosition.X,
                Position.Y + CollisionPosition.Y,
                CollisionSize.Width,
                CollisionSize.Height);
        }
        public Microsoft.Xna.Framework.Rectangle GetRectangle()
		{
            return new Microsoft.Xna.Framework.Rectangle(Position.X, Position.Y, Size.Width, Size.Height);
		}

        public bool CursorIntersects(Microsoft.Xna.Framework.Vector2 cursor)
        {
            return cursor.X > Position.X && cursor.X < Size.Width + Position.X &&
                cursor.Y > Position.Y && cursor.Y < Size.Height + Position.Y;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nImagePath: {ImagePath}\nLocation: {Position}";
        }

        public IBaseFile Clone()
        {
            return new WorldObject()
            {
                FileType = FileType,
                ID = ID,
                Name = Name,
                ImagePath = ImagePath,
                FilePath = FilePath,
                ObjectType = ObjectType,
                ZIndex = ZIndex,
                Texture = Texture,
                Position = Position,
                CollisionPosition = CollisionPosition,
                BaseSize = BaseSize,
                Size = Size,
                CollisionSize = CollisionSize,
                IsInteractable = IsInteractable,
                IsCollidable = IsCollidable,
            };
        }
    }
}
