using DreamlandEditor.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors {
    public class BaseEditor : UserControl {
        protected FileBase RenderableFile;

        public BaseEditor() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // BaseEditor
            // 
            this.BackColor = Color.FromArgb(191, 191, 191);
            this.Name = "BaseEditor";
            this.ResumeLayout(false);

        }

        public void SetRenderableObject(FileBase obj)
        {
            RenderableFile = obj;
        }
    }
}
