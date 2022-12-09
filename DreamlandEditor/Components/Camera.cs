using DreamlandEditor.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DreamlandEditor.Components
{
  public class Camera
  {
    public Rectangle Rectangle
    {
      get { return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); }
    }
    public Matrix Transform { get; private set; }
    public Vector2 Position { get; set; }

    private Vector2 velocity;
    private Texture2D Texture;
    private float speed, baseSpeed = 8f;
    private float zoom = 1f;
    private KeyboardState keyState = new KeyboardState();
    private MouseState currentMouseState = new MouseState();
    private MouseState lastMouseState = new MouseState();

    public Camera(GraphicsDevice graphicsDevice)
    {
      Position = new Vector2(0, 0);
      Texture = new Texture2D(graphicsDevice, 1, 1);
      speed = baseSpeed;
    }

    private void Follow(int screenWidth, int screenHeight)
    {
      Transform = Matrix.CreateTranslation(
          -Position.X - (Rectangle.Width / 2),
          -Position.Y - (Rectangle.Height / 2),
          0) *
          Matrix.CreateScale(zoom) *
          Matrix.CreateTranslation(
              screenWidth / 2,
              screenHeight / 2,
              0);
    }

    private void SetZoomAmount(float zoomAmount)
    {
      zoom += zoomAmount;
      if (zoom < .2f)
      {
        zoom = .2f;
      }
      if (zoom > 1.8f)
      {
        zoom = 1.8f;
      }
      SetSpeed();
    }
    private void SetSpeed()
    {
      if (zoom > .8f)
      {
        speed = baseSpeed;
      }
      else if (zoom < .8f && zoom >= .5f)
      {
        speed = baseSpeed * 3f;
      }
      else if (zoom < .5f && zoom > .2f)
      {
        speed = baseSpeed * 6;
      }
      else if (zoom <= .2f)
      {
        speed = baseSpeed * 10;
      }
    }
    public int GetZoomPercentage()
    {
      return (int)(zoom * 100);
    }

    private void HandleInput(GameTime gameTime)
    {
      keyState = Keyboard.GetState();
      velocity = new Vector2();
      if (keyState.IsKeyDown(Keys.W))
        velocity.Y -= speed;
      if (keyState.IsKeyDown(Keys.S))
        velocity.Y += speed;
      if (keyState.IsKeyDown(Keys.A))
        velocity.X -= speed;
      if (keyState.IsKeyDown(Keys.D))
        velocity.X += speed;
      Position += velocity;

      lastMouseState = currentMouseState;
      currentMouseState = Mouse.GetState();
      if (currentMouseState.ScrollWheelValue > lastMouseState.ScrollWheelValue)
      {
        SetZoomAmount(.05f);
      }
      if (currentMouseState.ScrollWheelValue < lastMouseState.ScrollWheelValue)
      {
        SetZoomAmount(-.05f);
      }
    }

    public void Update(GameTime gameTime, int width, int height)
    {
      HandleInput(gameTime);
      Follow(width, height);
    }
  }
}
