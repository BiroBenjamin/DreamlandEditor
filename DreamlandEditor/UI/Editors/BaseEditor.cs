using DreamlandEditor.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors {
    public partial class BaseEditor : UserControl {
        protected BaseFile RenderableFile;

        public BaseEditor() {
            InitializeComponent();
        }

        public void SetRenderableObject(BaseFile obj)
        {
            RenderableFile = obj;
            RenderUI();
        }
        public void RenderUI() { }
    }
}
