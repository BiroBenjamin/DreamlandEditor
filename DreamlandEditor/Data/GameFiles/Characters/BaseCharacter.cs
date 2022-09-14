﻿using DreamlandEditor.Data.GameFiles.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectDreamland.Data.Enums;

namespace ProjectDreamland.Data.GameFiles.Characters
{
  public class BaseCharacter : BaseObject
  {
    public int Level { get; set; }
    public string ResourceType { get; set; }
    public float MaxResourcePoints { get; set; }
    private float _currentResourcePoints;
    public float CurrentResourcePoints
    {
      get { return _currentResourcePoints; }
      set
      {
        if (value > MaxResourcePoints) _currentResourcePoints = MaxResourcePoints;
      }
    }
    public float MaxHealthPoints { get; set; }
    private float _currentHealthPoints;
    public float CurrentHealthPoints
    {
      get { return _currentHealthPoints; }
      set
      {
        if (value > MaxHealthPoints) _currentHealthPoints = MaxHealthPoints;
      }
    }
    public float Speed { get; set; } = 3f;
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
    public BaseCharacter(Texture2D texture, float maxHealth, float currentHealth, ResourceTypesEnum resourceType, float maxResource, float currentResource, float speed)
    {
      Texture = texture;
      MaxHealthPoints = maxHealth;
      CurrentHealthPoints = currentHealth;
      ResourceType = resourceType.ToString();
      MaxResourcePoints = maxResource;
      CurrentResourcePoints = currentResource;
      Speed = speed;
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