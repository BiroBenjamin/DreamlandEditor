using DreamlandEditor.Data;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;
using System.Collections.Generic;

namespace DreamlandEditor.Controls.Editors
{
    public class MapEditor : MonoGameControl, IBaseEditor 
    {
        public string EditorFor { get; set; } = FileTypesEnum.Map.ToString();
        public bool IsLoaded { get; set; } = false;
        public IBaseFile ItemInQueue { get; set; } = null;
        public MouseState MouseState { get; set; }
        public Camera Camera { get; set; }
        public Map MapFile { get; set; }

        protected override void Initialize() 
        {
            base.Initialize();
            Camera = new Camera(Editor.graphics);
            MapFile = new Map();
        }

        public void LoadMap(Map obj)
        {
            LoadTextures<WorldObject>(ItemsManager.WorldObjects);
            MapFile = obj;
            foreach (WorldObject item in MapFile.WorldObjects)
            {
                string name = item.ImagePath.Split('.')[0];
                item.Texture = Editor.Content.Load<Texture2D>(name);
            }
            LoadTextures<WorldObject>(MapFile.WorldObjects);
            IsLoaded = true;
        }
        public void LoadTextures<T>(IEnumerable<IBaseFile> objects) where T : IBaseFile
        {
            foreach (WorldObject item in objects)
            {
                string name = item.ImagePath == null ? ImagePaths.NotFound : item.ImagePath.Split('.')[0];
                item.Texture = Editor.Content.Load<Texture2D>(name);
            }
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
                    Editor.spriteBatch.Draw(item.Texture, new Vector2(item.Position.X, item.Position.Y), Color.White);
                }
            }
            DrawDraggedImage();

            Editor.spriteBatch.End();
        }

        public void DrawDraggedImage()
        {
            if (ItemInQueue == null || 
                (MouseState.Position.X < 0 || MouseState.Position.X > Width || MouseState.Position.Y < 0 || MouseState.Position.Y > Height) )
                return;
            Vector2 mousePosition = new Vector2(MouseState.Position.X, MouseState.Position.Y);
            Editor.spriteBatch.Draw(ItemInQueue.Texture, Vector2.Transform(mousePosition, Matrix.Invert(Camera.Transform)), Color.White);
        }
    }
}
