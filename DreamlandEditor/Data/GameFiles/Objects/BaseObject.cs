using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles.Objects
{
  public class BaseObject : BaseFile
  {
    public int ZIndex { get; set; }
    public string ImagePath { get; set; }
    [XmlIgnore] public Texture2D Texture { get; set; }
    public System.Drawing.Point Position { get; set; }
    public System.Drawing.Size Size { get; set; }
    public System.Drawing.Point CollisionPosition { get; set; } = new System.Drawing.Point(0, 0);
    public System.Drawing.Size CollisionSize { get; set; } = new System.Drawing.Size(0, 0);
    public bool IsCollidable { get; set; } = false;

    public BaseObject() { }
    public BaseObject(BaseFile baseFile) : base(baseFile) { }
    public BaseObject(BaseObject baseObject) : base (baseObject)
    {
      ZIndex = baseObject.ZIndex;
      ImagePath = baseObject.ImagePath;
      Texture = baseObject.Texture;
      Position = baseObject.Position;
      Size = baseObject.Size;
      IsCollidable = baseObject.IsCollidable;
      CollisionPosition = baseObject.CollisionPosition;
      CollisionSize = baseObject.CollisionSize;
    }

    public Rectangle GetCollision()
    {
      return new Rectangle(
        Position.X + CollisionPosition.X,
        Position.Y + CollisionPosition.Y,
        CollisionSize.Width,
        CollisionSize.Height);
    }

    public bool CursorIntersects(Vector2 cursor)
    {
      return cursor.X > Position.X && cursor.X < Size.Width + Position.X &&
        cursor.Y > Position.Y && cursor.Y < Size.Height + Position.Y;
    }
    public virtual void Update(GameTime gameTime)
    {

    }
    public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(Texture, new Vector2(Position.X, Position.Y), Color.White);
    }
  }
}
