using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class Form1 : Form {
        DropdownPanel PanelFileDropdown { get; set; }

        public Form1() {
            InitializeComponent();

            SystemPrefs systemPrefs = SystemPrefsManager.SetUpSystemPrefs();
            DebugManager.ShowWindow();

            FileExplorer.AddSystemPrefs(systemPrefs);
            FileExplorer.SetUpTreeView();

            PanelItemExplorer.SetupLayout(DockStyle.Top);

            SetupDropdownPanel();

            ButtonSwitchToRenderWindow.SetActive();
        }

        private void SetupDropdownPanel() {
            PanelFileDropdown = new DropdownPanel(ButtonFileNavbutton);
            PanelFileDropdown.AddToControls(Controls, new Point(1, PanelNavbar.Height));
            ButtonFileNavbutton.SetDropdownPanel(PanelFileDropdown);
            AddButtonsToDropdown(PanelFileDropdown);
        }
        private void AddButtonsToDropdown(DropdownPanel panel) {
            panel.AddButtons(
                new DropdownUiButton(DockStyle.Top, "Open"),
                new DropdownUiButton(DockStyle.Top, "Create"),
                new Panel {
                    Height = 3,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.FromArgb(166, 166, 166)
                },
                new DropdownUiButton(DockStyle.Bottom, "Exit")
            );
        }
    }
}
