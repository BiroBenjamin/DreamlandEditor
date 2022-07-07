﻿using DreamlandEditor.Data;
using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;

namespace DreamlandEditor.Controls {
    public class SampleControl : MonoGameControl {
        const string WelcomeMessage = "Hello MonoGame.Forms!";

        protected BaseFile RenderableFile;

        protected override void Initialize() {
            base.Initialize();
        }

        public void SetRenderableObject(BaseFile obj)
        {
            RenderableFile = obj;
        }

        protected override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        protected override void Draw() {
            base.Draw();

            Editor.spriteBatch.Begin();

            Editor.spriteBatch.DrawString(Editor.Font, WelcomeMessage, new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(WelcomeMessage).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                Color.White);

            Editor.spriteBatch.End();
        }
    }
}
