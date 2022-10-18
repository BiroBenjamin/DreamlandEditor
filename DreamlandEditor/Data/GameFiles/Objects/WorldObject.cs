using DreamlandEditor.Data.GameFiles;
using System;
using System.Drawing;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles.Objects
{
  [Serializable]
  public class WorldObject : BaseObject
  {
    public bool IsInteractable { get; set; } = false;

    public WorldObject() { }
    public WorldObject(BaseObject baseObject) : base(baseObject) { }
    public WorldObject(WorldObject worldObject) : base(worldObject) 
    {
      IsInteractable = worldObject.IsInteractable;
    }

    public Microsoft.Xna.Framework.Rectangle GetRectangle()
    {
      return new Microsoft.Xna.Framework.Rectangle(Position.X, Position.Y, Size.Width, Size.Height);
    }

    public override string ToString()
    {
      return $"ID: {ID}\nName: {Name}\nImagePath: {ImagePath}\nLocation: {Position}";
    }
  }
}
