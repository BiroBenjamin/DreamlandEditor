using DreamlandEditor.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DreamlandEditor
{
    public class Camera
    {
        public Rectangle Rectangle
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); }
        }
        public Matrix Transform { get; private set; }

        private Vector2 Position;
        private Vector2 velocity;
        private Texture2D Texture;
        private float speed = 3f;
        private KeyboardState keyState = new KeyboardState();

        public Camera(GraphicsDevice graphicsDevice)
        {
            Position = new Vector2(0, 0);
            Texture = new Texture2D(graphicsDevice, 1, 1);
        }

        public void Follow(int screenWidth, int screenHeight)
        {
            Transform = Matrix.CreateTranslation(
                -Position.X - (Rectangle.Width / 2),
                -Position.Y - (Rectangle.Height / 2),
                0) * Matrix.CreateTranslation(
                    screenWidth / 2,
                    screenHeight / 2,
                    0);
        }

        private void Move(GameTime gameTime)
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
        }

        public void Update(GameTime gameTime, int width, int height)
        {
            Move(gameTime);
            Follow(width, height);
        }
    }
}
