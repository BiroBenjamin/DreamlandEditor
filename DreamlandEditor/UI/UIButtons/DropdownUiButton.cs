using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    class DropdownUiButton : UiButton {
        public DropdownUiButton(DockStyle dockStyle, string text) : base() {
            InitializeComponent();
            Dock = dockStyle;
            Text = text;
        }

        private void InitializeComponent() {
            TextAlign = ContentAlignment.MiddleLeft;
            BackColor = Color.FromArgb(13, 13, 13);
            ForeColor = Color.FromArgb(191, 191, 191);
            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 89, 89);
        }
    }
}
