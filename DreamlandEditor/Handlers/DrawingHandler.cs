using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DreamlandEditor.Handlers
{
  public class DrawingHandler
  {
    private SpriteBatch _spriteBatch;
    private Texture2D _pointTexture;

    public DrawingHandler(SpriteBatch spriteBatch)
    {
      _spriteBatch = spriteBatch;
      _pointTexture = new Texture2D(_spriteBatch.GraphicsDevice, 1, 1);
      _pointTexture.SetData(new Color[] { Color.White });
    }

    public void DrawRectangle(Rectangle rectangle, Color color, int lineWidth)
    {
      //_pointTexture = null;
      //if (_pointTexture == null)
      //{
      //  _pointTexture = new Texture2D(_spriteBatch.GraphicsDevice, 1, 1);
      //  _pointTexture.SetData(new Color[] { Color.White });
      //}

      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y, lineWidth, rectangle.Height + lineWidth), color);
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y, rectangle.Width + lineWidth, lineWidth), color);
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X + rectangle.Width, rectangle.Y, lineWidth, rectangle.Height + lineWidth), color);
      _spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y + rectangle.Height, rectangle.Width + lineWidth, lineWidth), color);
    }

    public void Dispose()
    {
      if (_pointTexture != null) _pointTexture.Dispose();
    }
  }
}
