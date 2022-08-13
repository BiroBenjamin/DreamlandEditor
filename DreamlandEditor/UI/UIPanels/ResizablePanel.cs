using System;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIPanels 
{
    public class ResizablePanel : UiPanel 
    {
        private Panel ResizeArea;
        private bool allowResize = false;

        public ResizablePanel() : base()
        {
        }

        public void SetupLayout(DockStyle resizeAreaPosition) {
            SetupResizeArea(resizeAreaPosition);
            Controls.Add(ResizeArea);
        }

        private void SetupResizeArea(DockStyle dockType) {
            ResizeArea = new Panel {
                BackColor = Color.FromArgb(166, 166, 166),
                Dock = dockType
            };

            if(!IsVerticalyResizable(dockType)) {
                Width = 2;
                ResizeArea.Cursor = Cursors.SizeWE;
                Width = 175;
                MinimumSize = new Size(150, 0);
                MaximumSize = new Size(400, Height * 10);
                ResizeArea.MaximumSize = new Size(2, Height * 10);
            } else if(IsVerticalyResizable(dockType)) {
                Height = 2;
                ResizeArea.Cursor = Cursors.SizeNS;
                Height = 125;
                MinimumSize = new Size(0, 100);
                MaximumSize = new Size(Width * 10, 250);
                ResizeArea.MaximumSize = new Size(Width * 10, 2);
            }

            SetupEvents();
        }
        private bool IsVerticalyResizable(DockStyle dockType) {
            return dockType == DockStyle.Top || dockType == DockStyle.Bottom;
        }
        private void SetupEvents() {
            ResizeArea.MouseDown += (sender, ev) => {
                allowResize = true;
            };
            ResizeArea.MouseMove += (sender, ev) => {
                if (!allowResize) {
                    return;
                }
                if (IsVerticalyResizable(Dock)) {
                    Height = ResizeArea.Top - ev.Y;
                    return;
                }
                Width = ResizeArea.Left + ev.X;
            };
            ResizeArea.MouseUp += (sender, ev) => {
                allowResize = false;
            };
        }
    }
}
