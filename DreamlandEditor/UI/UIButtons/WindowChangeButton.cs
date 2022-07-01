using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    class WindowChangeButton : UiButton {
        public WindowChangeButton() :base() {
            InitializeComponent(false);
        }
        public WindowChangeButton(bool isActive) : base() {
            InitializeComponent(isActive);
        }

        private void InitializeComponent(bool isActive) {
            Dock = DockStyle.Left;
            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            FlatAppearance.BorderSize = 0;
            Padding = new Padding(0, 1, 0, 1);
            Width = Text.Length * 9;
            if (isActive) {
                SetActive();
                return;
            }
            SetInactive();
        }

        public void SetActive() {
            BackColor = Color.FromArgb(191, 191, 191);
            ForeColor = Color.FromArgb(38, 38, 38);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(191, 191, 191);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(191, 191, 191);
        }
        public void SetInactive() {
            BackColor = Color.FromArgb(38, 38, 38);
            ForeColor = Color.FromArgb(191, 191, 191);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 13);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 89, 89);
            //FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(166, 166, 166);
        }
    }
}
