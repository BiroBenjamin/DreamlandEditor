using DreamlandEditor.UI.UIPanels;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons
{
    public class WindowChangeButton : Button, IUiButton
    {
        public string ButtonFor { get; set; }
        public static ICollection<WindowChangeButton> ButtonsToCoordinate { get; set; }
        public static ICollection<Control> PanelsToCoordinate { get; set; }

        public WindowChangeButton() :base() 
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            TextAlign = ContentAlignment.MiddleCenter;
            
            Width = Text.Length * 9;

            Dock = DockStyle.Left;
            Padding = new Padding(0, 1, 0, 1);

            ButtonsToCoordinate = new List<WindowChangeButton>();
            PanelsToCoordinate = new List<Control>();
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

        public void SetupEvents(Control panelToShow)
        {
            Click += (sender, ev) =>
            {
                foreach(WindowChangeButton button in ButtonsToCoordinate)
                {
                    button.SetInactive();
                }
                foreach (Control panel in PanelsToCoordinate)
                {
                    panel.Visible = false;
                }
                /*foreach (Control control in controls)
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
                }*/
                SetActive();
                panelToShow.Visible = true;
            };
        }
    }
}
