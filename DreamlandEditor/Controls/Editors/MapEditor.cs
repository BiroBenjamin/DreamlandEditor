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
        public bool IsDragging { get; set; } = false;
        public IBaseFile ItemInQueue { get; set; } = null;
        public MouseState CurrentMouseState { get; set; }
        public MouseState LastMouseState { get; set; }
        public Camera Camera { get; set; }
        public Map MapFile { get; set; }
        public Vector2 TranslatedMousePosition { get; set; }

        protected override void Initialize() 
        {
            base.Initialize();
            Camera = new Camera(Editor.graphics);
            MapFile = new Map();
            IsLoaded = false;
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
        private void LoadTextures<T>(IEnumerable<IBaseFile> objects) where T : IBaseFile
        {
            foreach (WorldObject item in objects)
            {
                string name = item.ImagePath == null ? ImagePaths.NotFound : item.ImagePath.Split('.')[0];
                item.Texture = Editor.Content.Load<Texture2D>(name);
            }
        }

        protected override void Update(GameTime gameTime) 
        {
            base.Update(gameTime);
            if (!IsLoaded) return;

            TranslatedMousePosition = Vector2.Transform(
                new Vector2(CurrentMouseState.Position.X, CurrentMouseState.Position.Y), 
                Matrix.Invert(Camera.Transform));
            Camera.Update(gameTime, Width, Height);
        }

        protected override void Draw() 
        {
            base.Draw();
            if (!IsLoaded) return;

            Editor.spriteBatch.Begin(transformMatrix: Camera.Transform);

            if (MapFile.WorldObjects != null) {
                foreach (WorldObject item in MapFile.WorldObjects)
                {
                    Editor.spriteBatch.Draw(item.Texture, new Vector2(item.Position.X, item.Position.Y), Color.White);
                    if (!item.IsCollidable) continue;
                    DrawRectangle(item.GetCollision(), Color.Blue, 1);
                }
            }
            DrawDraggedImage();
            ManageMouseEvents();

            Editor.spriteBatch.End();
        }

        private Point GetMousePosition()
        {
            return CurrentMouseState.Position;
        }

        private void DrawDraggedImage()
        {
            if (ItemInQueue == null || (CurrentMouseState.Position.X < 0 || CurrentMouseState.Position.X > Width || CurrentMouseState.Position.Y < 0 || CurrentMouseState.Position.Y > Height))
            {
                return;
            }
            Vector2 mousePosition = new Vector2(CurrentMouseState.Position.X, CurrentMouseState.Position.Y);
            if (ItemInQueue.FileType == FileTypesEnum.Tile.ToString())
            {
                mousePosition = new Vector2(
                    CurrentMouseState.Position.X / (ItemInQueue as WorldObject).Size.Width * (ItemInQueue as WorldObject).Size.Width,
                    CurrentMouseState.Position.Y / (ItemInQueue as WorldObject).Size.Height * (ItemInQueue as WorldObject).Size.Height);
                Editor.spriteBatch.Draw(ItemInQueue.Texture, Vector2.Transform(mousePosition, Matrix.Invert(Camera.Transform)), Color.White);
                DrawGrid(Vector2.Transform(mousePosition, Matrix.Invert(Camera.Transform)));
                return;
            }
            Editor.spriteBatch.Draw(ItemInQueue.Texture, Vector2.Transform(mousePosition, Matrix.Invert(Camera.Transform)), Color.White);
        }

        private void ManageMouseEvents()
        {
            CurrentMouseState = Mouse.GetState();
            RemoveObject();
            PlaceObject();
            ClickOnObject();
            LastMouseState = CurrentMouseState;
        }
        private void RemoveObject()
        {
            if (CurrentMouseState.RightButton == ButtonState.Pressed &&
                LastMouseState.RightButton == ButtonState.Released && IsDragging)
            {
                IsDragging = false;
                ItemInQueue = null;
                return;
            }
        }
        private void PlaceObject()
        {
            if (CurrentMouseState.LeftButton == ButtonState.Pressed &&
                LastMouseState.LeftButton == ButtonState.Released && IsDragging && ItemInQueue != null)
            {
                Vector2 mousePosition = new Vector2(GetMousePosition().X, GetMousePosition().Y);
                if (ItemInQueue.FileType == FileTypesEnum.Tile.ToString())
                {
                    mousePosition = new Vector2(
                        CurrentMouseState.Position.X / (ItemInQueue as WorldObject).Size.Width * (ItemInQueue as WorldObject).Size.Width,
                        CurrentMouseState.Position.Y / (ItemInQueue as WorldObject).Size.Height * (ItemInQueue as WorldObject).Size.Height);
                }
                Vector2 relativeMousePosition = Vector2.Transform(mousePosition, Matrix.Invert(Camera.Transform));
                ItemInQueue.Position = new System.Drawing.Point((int)relativeMousePosition.X, (int)relativeMousePosition.Y);
                WorldObject newItem = (WorldObject)ItemInQueue.Clone();
                MapFile.WorldObjects.Add(newItem);
            }
        }
        private void ClickOnObject()
        {
            if (IsDragging) return;
            //foreach(WorldObject item in MapFile.WorldObjects)
            for(int i = 0; i < MapFile.WorldObjects.Count; i++)
            {
                if (MapFile.WorldObjects[i].CursorIntersects(TranslatedMousePosition))
                {
                    DrawRectangle(new Rectangle(MapFile.WorldObjects[i].Position.X, MapFile.WorldObjects[i].Position.Y, 
                        MapFile.WorldObjects[i].Size.Width, MapFile.WorldObjects[i].Size.Height), Color.Red, 2);
                }
                if(CurrentMouseState.LeftButton == ButtonState.Pressed &&
                    LastMouseState.LeftButton == ButtonState.Released && MapFile.WorldObjects[i].CursorIntersects(TranslatedMousePosition))
                {
                    //DebugManager.Log($"Position: {item.Position}, Name: {item.Name}");
                    MapFile.WorldObjects.Remove(MapFile.WorldObjects[i]);
                }
            }
        }

        private void DrawGrid(Vector2 mousePosition)
        {
            for(int i = -32; i <= 32; i += 32)
            {
                for(int j = -32; j <= 32; j += 32)
                {
                    DrawRectangle(new Rectangle((int)mousePosition.X + i, (int)mousePosition.Y + j,
                        (ItemInQueue as WorldObject).Size.Width, (ItemInQueue as WorldObject).Size.Height), Color.Red, 1);
                }
            }
        }
        public void DrawRectangle(Rectangle rectangle, Color color, int lineWidth)
        {
            Texture2D _pointTexture = null;
            if (_pointTexture == null)
            {
                _pointTexture = new Texture2D(Editor.spriteBatch.GraphicsDevice, 1, 1);
                _pointTexture.SetData(new Color[] { Color.White });
            }

            Editor.spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y, lineWidth, rectangle.Height + lineWidth), color);
            Editor.spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y, rectangle.Width + lineWidth, lineWidth), color);
            Editor.spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X + rectangle.Width, rectangle.Y, lineWidth, rectangle.Height + lineWidth), color);
            Editor.spriteBatch.Draw(_pointTexture, new Rectangle(rectangle.X, rectangle.Y + rectangle.Height, rectangle.Width + lineWidth, lineWidth), color);
        }
    }
}
