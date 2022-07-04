using DreamlandEditor.UI.UIPanels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    class DropdownUiButton : Button, IUiButton
    {
        public DropdownUiButton(DockStyle dockStyle, string text) : base() 
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 89, 89);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 166, 166);

            Text = text;
            TextAlign = ContentAlignment.MiddleLeft;
            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            
            Dock = dockStyle;

            BackColor = Color.FromArgb(13, 13, 13);
            ForeColor = Color.FromArgb(191, 191, 191);
            
        }

        public void SetDropdownPanel(UiPanel panel)
        {
            Click += (sender, ev) => {
                panel.Visible = !panel.Visible;
                panel.BringToFront();
                SetActive();
            };
        }

        public void SetActive()
        {
            BackColor = Color.FromArgb(89, 89, 89);
        }

        public void SetInactive()
        {
            BackColor = Color.FromArgb(13, 13, 13);
        }
    }
}
