using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DreamlandEditor.Data.Enums;
using System.Xml.Serialization;
using ProjectDreamland.Data.Enums;

namespace DreamlandEditor.Data.GameFiles.Characters
{
  public class BaseCharacter : BaseObject
  {
    public int Level { get; set; }
    public string ResourceType { get; set; }
    public int MaxResourcePoints { get; set; }
    public int CurrentResourcePoints;
    public int AttackDamage { get; set; }
    public float AttackRange { get; set; } = 1.5f;
    public int MaxHealthPoints { get; set; }
    public int CurrentHealthPoints;
    public bool IsDead { get; set; } = false;
    [XmlIgnore] public bool IsTakingDamage { get; set; } = false;
    public float Speed { get; set; } = 3f;
    [XmlIgnore] public LookDirectionsEnum Facing { get; set; } = LookDirectionsEnum.South;
    public string CharacterAffiliation { get; set; }

    protected Vector2 velocity;

    public Rectangle GetSize()
    {
      return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);
    }

    public BaseCharacter() { }
    public BaseCharacter(Texture2D texture)
    {
      Texture = texture;
    }
    public BaseCharacter(BaseObject baseObject) : base(baseObject) { }
    public BaseCharacter(BaseCharacter baseCharacter) : base(baseCharacter)
    {
      Texture = baseCharacter.Texture;
      Level = baseCharacter.Level;
      MaxHealthPoints = baseCharacter.MaxHealthPoints;
      CurrentHealthPoints = baseCharacter.CurrentHealthPoints;
      ResourceType = baseCharacter.ResourceType.ToString();
      MaxResourcePoints = baseCharacter.MaxResourcePoints;
      CurrentResourcePoints = baseCharacter.CurrentResourcePoints;
      Speed = baseCharacter.Speed;
      AttackDamage = baseCharacter.AttackDamage;
      AttackRange = baseCharacter.AttackRange;
      IsDead = baseCharacter.IsDead;
      Facing = baseCharacter.Facing;
      CharacterAffiliation = baseCharacter.CharacterAffiliation;
    }

    #region Collision
    protected bool IsCollidingLeft(BaseObject sprite)
    {
      Rectangle thisCollision = GetCollision();
      Rectangle targetCollision = sprite.GetCollision();
      return thisCollision.Right + velocity.X > targetCollision.Left &&
             thisCollision.Right < targetCollision.Right &&
             thisCollision.Top < targetCollision.Bottom &&
             thisCollision.Bottom > targetCollision.Top;

    }
    protected bool IsCollidingRight(BaseObject sprite)
    {
      Rectangle thisCollision = GetCollision();
      Rectangle targetCollision = sprite.GetCollision();
      return thisCollision.Left + velocity.X < targetCollision.Right &&
             thisCollision.Left > targetCollision.Left &&
             thisCollision.Top < targetCollision.Bottom &&
             thisCollision.Bottom > targetCollision.Top;

    }
    protected bool IsCollidingTop(BaseObject sprite)
    {
      Rectangle thisCollision = GetCollision();
      Rectangle targetCollision = sprite.GetCollision();
      return thisCollision.Bottom + this.velocity.Y > targetCollision.Top &&
             thisCollision.Top < targetCollision.Top &&
             thisCollision.Right > targetCollision.Left &&
             thisCollision.Left < targetCollision.Right;

    }
    protected bool IsCollidingBottom(BaseObject sprite)
    {
      int zindex = ZIndex;
      Rectangle thisCollision = GetCollision();
      Rectangle targetCollision = sprite.GetCollision();
      return thisCollision.Top + this.velocity.Y < targetCollision.Bottom &&
             thisCollision.Bottom > targetCollision.Bottom &&
             thisCollision.Right > targetCollision.Left &&
             thisCollision.Left < targetCollision.Right;

    }
    #endregion

    public override void Update(GameTime gameTime)
    {

    }
    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      base.Draw(gameTime, spriteBatch);
    }
  }
}
