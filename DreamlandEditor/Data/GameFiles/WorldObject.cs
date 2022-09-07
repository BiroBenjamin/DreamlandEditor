using System;
using System.Drawing;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles
{
  [Serializable]
  public class WorldObject : BaseFile
  {
    public Point CollisionPosition { get; set; } = new Point(0, 0);
    [XmlIgnore] public Size BaseSize { get; private set; } = new Size(32, 32);
    public Size Size { get; set; } = new Size(64, 64);
    public Size CollisionSize { get; set; } = new Size(0, 0);
    public bool IsInteractable { get; set; } = false;
    public bool IsCollidable { get; set; } = false;

    public WorldObject(){}
    public WorldObject(BaseFile baseFile) :
      base(baseFile){}

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

    public override BaseFile Clone()
    {
      WorldObject obj = new WorldObject(base.Clone());
      obj.CollisionPosition = CollisionPosition;
      obj.BaseSize = BaseSize;
      obj.Size = Size;
      obj.CollisionSize = CollisionSize;
      obj.IsInteractable = IsInteractable;
      obj.IsCollidable = IsCollidable;
      return obj;
    }
  }
}
