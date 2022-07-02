using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIPanels {
    public class DropdownPanel : UiPanel {
        public NavigationButton DropdownButton { get; set; }

        public DropdownPanel(NavigationButton dropdownButton) : base() {
            InitializeComponents();
            DropdownButton = dropdownButton;
        }

        private void InitializeComponents() {
            Visible = false;
            Size = new Size(150, 150);
            BackColor = Color.FromArgb(13, 13, 13);
            BorderStyle = BorderStyle.FixedSingle;
        }

        public void AddToControls(ControlCollection control, Point location) {
            control.Add(this);
            Location = location;
            BringToFront();
            LoopControls(Parent.Controls);
        }
        private void LoopControls(ControlCollection controls) {
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
        private bool CheckComponentValidity(Control component) {
            return component == this || component == DropdownButton;
        }
        private void AddEvent(Control component) {
            component.MouseEnter += delegate(object sender, EventArgs e){
                EventManager.LeaveDropdownWindow(sender, e, this, DropdownButton);
            };
        }

        public void AddButtons(params Control[] components) {
            int tmpHeight = 0;
            foreach(Control component in components) {
                tmpHeight += component.Height;
                Controls.Add(component);
            }
            Height = tmpHeight;
            
        }
    }
}
