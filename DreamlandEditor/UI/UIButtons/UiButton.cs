using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    class UiButton : Button {
        public UiButton() {
            InitializeComponents();
        }

        private void InitializeComponents() {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
