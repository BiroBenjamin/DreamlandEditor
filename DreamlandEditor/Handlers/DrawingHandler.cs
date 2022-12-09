using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DreamlandEditor.Handlers
{
  public class DrawingHandler
  {
    private SpriteBatch _spriteBatch;
    private ContentManager _content;
    private Texture2D _pointTexture;
    private SpriteFont _font;

    public DrawingHandler(SpriteBatch spriteBatch, ContentManager content)
    {
      _spriteBatch = spriteBatch;
      _content = content;
      _font = _content.Load<SpriteFont>("Fonts/Arial");
      _pointTexture = new Texture2D(_spriteBatch.GraphicsDevice, 1, 1);
      _pointTexture.SetData(new Color[] { Color.White });
    }

    public void DrawRectangle(Rectangle rectangle, Color color, int lineWidth)
    {
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y, lineWidth, rectangle.Height + lineWidth), color);
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y, rectangle.Width + lineWidth, lineWidth), color);
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X + rectangle.Width, rectangle.Y, lineWidth, rectangle.Height + lineWidth), color);
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y + rectangle.Height, rectangle.Width + lineWidth, lineWidth), color);
    }

    public void DrawHelp(int x, int y)
    {
      Vector2 point = new Vector2(x + 5, y + 5);
      int height = (int)(_font.MeasureString("Left Shift - Toggle paint mode").Y + 2.5);
      _spriteBatch.Draw(_pointTexture, new Rectangle(x, y, (int)_font.MeasureString("LShift (Hold) - Toggle paint mode").X + 10, 6 * height + 10), 
        Color.Black * .5f);
      _spriteBatch.DrawString(_font, "'W', 'A', 'S', 'D' - Move", point, Color.White);
      _spriteBatch.DrawString(_font, "MB3 - Zoom", point + new Vector2(0, height), 
        Color.White);
      _spriteBatch.DrawString(_font, "C - Toggle collision", point + new Vector2(0, 2 * height),
        Color.White);
      _spriteBatch.DrawString(_font, "LShift (Hold) - Toggle paint mode", point + new Vector2(0, 3 * height),
        Color.White);
      _spriteBatch.DrawString(_font, "Q - Drop item", point + new Vector2(0, 4 * height),
        Color.White);
      _spriteBatch.DrawString(_font, "E - Open command window", point + new Vector2(0, 5 * height),
        Color.White);
    }
  }
}
