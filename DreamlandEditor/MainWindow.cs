using DreamlandEditor.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class MainWindow : Form {
        readonly Color ButtonDarkerColor = Color.FromArgb(13, 13, 13);
        readonly Color ButtonLighterColor = Color.FromArgb(38, 38, 38);
        readonly Color ButtonLightestColor = Color.FromArgb(89, 89, 89);

        bool allowResize = false;

        public MainWindow() {
            InitializeComponent();

            CreateFileSubmenu(0, PanelNavbar.Height, 150, 150);

            FileExplorerManager.UpdateTreeView(TreeViewFileExplorer);
        }

        #region FileSubmenu
        private void CreateFileSubmenu(int xPos, int yPos, int width, int height) {
            Panel PanelFileSubmenu = new Panel {
                Name = "PanelFileSubmenu",
                Visible = false,
                Location = new Point(xPos + 1, yPos - 1),
                Size = new Size(width, height),
                BackColor = ButtonDarkerColor
            };
            PanelFileSubmenu.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(PanelFileSubmenu);
            PanelFileSubmenu.BringToFront();

            Button ButtonOpenFile = FormatButton("ButtonOpenFile", "Open", DockStyle.Top);
            PanelFileSubmenu.Controls.Add(ButtonOpenFile);

            PanelFileSubmenu.Controls.Add(new Panel {
                BackColor = ButtonLightestColor,
                Size = new Size(10, 2),
                Dock = DockStyle.Bottom
            });
            Button ButtonExitApp = FormatButton("ButtonExitApp", "Exit", DockStyle.Bottom);
            ButtonExitApp.Click += (sender, e) => {
                Application.Exit();
            };
            PanelFileSubmenu.Controls.Add(ButtonExitApp);
        }
        private Button FormatButton(string name, string text, DockStyle dockStyle) {
            Button Button = new Button {
                Dock = dockStyle,
                FlatStyle = FlatStyle.Flat,
                Name = name,
                Text = text,
                ForeColor = Color.FromArgb(191, 191, 191),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.5f),
                BackColor = ButtonDarkerColor,
            };
            Button.FlatAppearance.BorderSize = 0;
            Button.FlatAppearance.MouseDownBackColor = ButtonLightestColor;
            Button.FlatAppearance.MouseOverBackColor = ButtonLighterColor;

            return Button;
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
        private void ToggleColor(Button button, Panel panel) {
            if (button.BackColor == ButtonLighterColor) {
                if (panel.Visible) { button.BackColor = ButtonDarkerColor; }
            } else {
                button.BackColor = ButtonLighterColor;
            }
        }

        private void Explorer_MouseDown(object sender, MouseEventArgs e) {
            allowResize = true;
        }
        private void PanelFileExplorer_MouseMove(object sender, MouseEventArgs e) {
            if (allowResize) {
                this.PanelFileExplorer.Width = PanelFileExplorerResizeArea.Left + e.X;
            }
        }
        private void PanelItemExplorer_MouseMove(object sender, MouseEventArgs e) {
            if (allowResize) {
                this.PanelItemExplorerContainer.Height = PanelItemExplorerResizeArea.Top - e.Y;
            }
        }
        private void Explorer_MouseUp(object sender, MouseEventArgs e) {
            allowResize = false;
        }

        private void TreeViewFileExplorer_NodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Text.Contains(".pd")) {
                // TODO: Add logic for opening files. Either on the renderwindow or in a new form.
            }
        }
    }
}
