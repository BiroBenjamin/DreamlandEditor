using DreamlandEditor.Data;
using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;

namespace DreamlandEditor.Controls 
{
    public class SampleControl : MonoGameControl 
    {

        protected BaseFile RenderableFile;

        protected override void Initialize() 
        {
            base.Initialize();
        }

        public void SetRenderableObject(BaseFile obj)
        {
            RenderableFile = obj;
        }

        protected override void Update(GameTime gameTime) 
        {
            base.Update(gameTime);
        }

        protected override void Draw() 
        {
            base.Draw();

            Editor.spriteBatch.Begin();



            Editor.spriteBatch.End();
        }
    }
}
