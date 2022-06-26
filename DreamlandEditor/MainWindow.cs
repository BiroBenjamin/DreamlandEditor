using DreamlandEditor.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class MainWindow : Form {
        readonly Color ButtonDarkerColor = Color.FromArgb(13, 13, 13);
        readonly Color ButtonLighterColor = Color.FromArgb(38, 38, 38);
        readonly Color ButtonLightestColor = Color.FromArgb(89, 89, 89);

        public MainWindow() {
            InitializeComponent();

            CreateFileSubmenu(0, PanelNavbar.Height, 150, 150);

            FileExplorerManager.UpdateTreeView(TreeViewFileExplorer);
        }
        #region FileSubmenu
        private void CreateFileSubmenu(int xPos, int yPos, int width, int height) {
            Panel newPanel = new Panel {
                Name = "PanelFileSubmenu",
                Visible = false,
                Location = new Point(xPos + 1, yPos - 1),
                Size = new Size(width, height),
                BackColor = ButtonDarkerColor
            };

            this.Controls.Add(newPanel);
            newPanel.BringToFront();

            AddButtonsToFileSubmenu(newPanel);
        }
        private void ToggleColor(Button button, Panel panel) {
            if (button.BackColor == ButtonLighterColor) {
                if (panel.Visible) { button.BackColor = ButtonDarkerColor; }
            } else {
                button.BackColor = ButtonLighterColor;
            }
        }
        private void AddButtonsToFileSubmenu(Panel submenu) {
            Button newButton = new Button {
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                Name = "ButtonOpenFile",
                Text = "Open",
                ForeColor = Color.FromArgb(191, 191, 191),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.5f),
                BackColor = ButtonDarkerColor,
            };
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatAppearance.MouseDownBackColor = ButtonLightestColor;
            newButton.FlatAppearance.MouseOverBackColor = ButtonLighterColor;

            submenu.Controls.Add(newButton);
        }

        #endregion FileSubmenu
        private void ButtonFiles_Click(object sender, EventArgs e) {
            foreach(Control panel in this.Controls) {
                if(panel.Name == "PanelFileSubmenu") {
                    panel.Visible = !panel.Visible;
                    ToggleColor(ButtonFiles, (Panel)panel);
                }
            }
        }

        private void MainWindow_Hover(object sender, EventArgs e) {
            foreach (Control panel in this.Controls) {
                if (panel.Name.EndsWith("Submenu")) {
                    panel.Visible = false;
                    ToggleColor(ButtonFiles, (Panel)panel);
                }
            }
        }

        private void TreeViewFileExplorer_AfterSelect(object sender, TreeViewEventArgs e) {
            
        }
    }
}
