using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;
using MonoGame.Forms.DX;

namespace DreamlandEditor.Controls
{
    public class MapEditor : MonoGameControl 
    {
        public bool IsLoaded { get; set; } = false;
        public BaseFile ItemInQueue { get; set; }
        public MouseState MouseState { get; set; }
        public Matrix TransformMatrix { get; set; }

        private string Path;
        private Map MapFile = new Map();
        private Camera Camera;

        protected override void Initialize() 
        {
            base.Initialize();

            Camera = new Camera(Editor.graphics);
            TransformMatrix = Camera.Transform;
        }

        public void LoadMap(Map obj, string path)
        {
            MapFile = obj;
            Path = path;

            foreach (WorldObject item in MapFile.WorldObjects)
            {
                string[] splitImagePath = item.ImagePath.Split('/');
                string name = splitImagePath[splitImagePath.Length - 1].Split('.')[0];
                item.Texture = Editor.Content.Load<Texture2D>(name);
            }

            IsLoaded = true;
        }

        public void PutItemInQueue(BaseFile item)
        {
            ItemInQueue = item;
        }

        public Point GetMousePosition()
        {
            return MouseState.Position;
        }

        protected override void Update(GameTime gameTime) 
        {
            base.Update(gameTime);

            MouseState = Mouse.GetState();
            Camera.Update(gameTime, Width, Height);
        }

        protected override void Draw() 
        {
            base.Draw();

            Editor.spriteBatch.Begin(transformMatrix: Camera.Transform);

            if (MapFile.WorldObjects != null) {
                foreach (WorldObject item in MapFile.WorldObjects)
                {
                    Editor.spriteBatch.Draw(item.Texture, new Vector2(item.Location.X, item.Location.Y), Color.White);
                }
            }

            Editor.spriteBatch.End();
        }
    }
}
