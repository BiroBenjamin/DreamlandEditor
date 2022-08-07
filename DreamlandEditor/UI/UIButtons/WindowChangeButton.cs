using DreamlandEditor.UI.UIPanels;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons
{
    public class WindowChangeButton : Button, IUiButton
    {
        public WindowChangeButton() :base() 
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            TextAlign = ContentAlignment.MiddleCenter;
            
            Width = Text.Length * 9;

            Dock = DockStyle.Left;
            Padding = new Padding(0, 1, 0, 1);
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
            FlatAppearance.BorderColor = Color.FromArgb(166, 166, 166);
        }

        public void SetDropdownPanel(UiPanel panel)
        {
            throw new System.NotImplementedException();
        }

        public void SetupEvents(ControlCollection controls, Control panelToShow)
        {
            Click += (sender, ev) =>
            {
                foreach (Control control in controls)
                {
                    if (!(control is Panel))
                    {
                        control.Visible = false;
                        continue;
                    }
                    foreach (Control button in control.Controls)
                    {
                        (button as WindowChangeButton).SetInactive();
                    }
                }
                SetActive();
                panelToShow.Visible = true;
            };
        }
    }
}
