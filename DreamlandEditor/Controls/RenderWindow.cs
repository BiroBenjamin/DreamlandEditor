using DreamlandEditor.Data;
using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;

namespace DreamlandEditor.Controls 
{
    public class SampleControl : MonoGameControl 
    {

        private Map RenderableFile;
        private string Path;

        protected override void Initialize() 
        {
            base.Initialize();
        }

        public void LoadMap(Map obj, string path)
        {
            RenderableFile = obj;
            Path = path;
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
