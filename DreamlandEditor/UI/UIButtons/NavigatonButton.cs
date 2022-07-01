using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    class NavigatonButton : UiButton {
        public NavigatonButton() : base() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            BackColor = Color.FromArgb(38, 38, 38);
            ForeColor = Color.FromArgb(191, 191, 191);
            Dock = DockStyle.Left;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 89, 89);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 13, 13);
            Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            FlatAppearance.BorderSize = 0;
            Width = 50;
        }

        public void SetDropdownPanel(Panel panel) {
            Click += (sender, ev) => {
                panel.Visible = !panel.Visible;
                SetActive(panel);
            };
        }
        public void SetActive(Panel panel) {
            if (panel.Visible) {
                BackColor = Color.FromArgb(13, 13, 13);
                return;
            }
            BackColor = Color.FromArgb(38, 38, 38);
        }
        public void SetInactive() {
            BackColor = Color.FromArgb(38, 38, 38);
        }
    }
}
