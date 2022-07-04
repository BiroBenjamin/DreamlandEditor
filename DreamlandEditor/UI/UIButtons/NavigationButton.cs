using DreamlandEditor.UI.UIPanels;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons
{
    public class NavigationButton : Button, IUiButton
    {
        public NavigationButton() : base() 
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 13, 13);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 89, 89);

            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            
            Width = 50;

            Dock = DockStyle.Left;

            BackColor = Color.FromArgb(38, 38, 38);
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
            BackColor = Color.FromArgb(13, 13, 13);
        }
        public void SetInactive() 
        {
            BackColor = Color.FromArgb(38, 38, 38);
        }
    }
}
