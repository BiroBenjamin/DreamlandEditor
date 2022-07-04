using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIPanels 
{
    public class DropdownPanel : UiPanel 
    {
        public IUiButton DropdownButton { get; set; }

        public DropdownPanel() : base()
        {
            Visible = false;
            BackColor = Color.FromArgb(13, 13, 13);
            BorderStyle = BorderStyle.FixedSingle;

            Height = 0;
            Width = 150;
        }

        public void SetupButton(IUiButton dropdownButton)
        {
            DropdownButton = dropdownButton;
        }

        public void AddToControls(ControlCollection control, Point location)
        {
            control.Add(this);
            Location = location;
            BringToFront();
            LoopControls(Parent.Controls);
        }
        private void LoopControls(ControlCollection controls)
        {
            foreach (Control component in controls) {
                if (CheckComponentValidity(component)) {
                    continue;
                }
                AddEvent(component);
                if (component.HasChildren) {
                    LoopControls(component.Controls);
                }
            }
        }
        private bool CheckComponentValidity(Control component)
        {
            return component == this || component == DropdownButton;
        }
        private void AddEvent(Control component)
        {
            component.MouseEnter += (sender, ev) => {
                Visible = false;
                DropdownButton.SetInactive();
            };
        }

        public void AddComponent(params Control[] components) {
            foreach(Control component in components) {
                Height += component.Height;
                Controls.Add(component);
            }            
        }
    }
}
