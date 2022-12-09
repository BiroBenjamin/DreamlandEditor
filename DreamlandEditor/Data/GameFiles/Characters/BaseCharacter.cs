using DreamlandEditor.Data.GameFiles.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
    public float Speed { get; set; } = 3f;
    public string CharacterAffiliation { get; set; }

    protected Vector2 velocity;

    public BaseCharacter() { }
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
      CharacterAffiliation = baseCharacter.CharacterAffiliation;
    }

    public override void Update(GameTime gameTime)
    {

    }
    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      base.Draw(gameTime, spriteBatch);
    }
  }
}
