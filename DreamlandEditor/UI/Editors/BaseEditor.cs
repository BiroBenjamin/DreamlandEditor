using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors {
    class BaseEditor : UserControl {
        public BaseEditor() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // BaseEditor
            // 
            this.BackColor = Color.FromArgb(191, 191, 191); ;
            this.Name = "BaseEditor";
            this.ResumeLayout(false);

        }
    }
}
