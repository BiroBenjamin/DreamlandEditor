using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    public class NavigationButton : UiButton {
        public NavigationButton() : base() {
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

        public void SetDropdownPanel(DropdownPanel panel) {
            Click += delegate (object sender, EventArgs e) {
                EventManager.DropDown(sender, e, panel);
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
