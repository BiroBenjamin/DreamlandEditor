using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    public class UiButton : Button {
        public UiButton() : base() {
            InitializeComponents();
        }

        private void InitializeComponents() {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }
    }
}
