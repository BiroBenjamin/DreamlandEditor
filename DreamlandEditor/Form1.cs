using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class Form1 : Form {
        DropdownPanel PanelFileDropdown { get; set; }

        public Form1() {
            InitializeComponent();

            SystemPrefs systemPrefs = SystemPrefsManager.SetUpSystemPrefs();
            DebugManager.SystemPrefs = systemPrefs;
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

            AddButtonsToDropdown(PanelFileDropdown, "Open",DockStyle.Top, EventManager.OpenFile);
            AddButtonsToDropdown(PanelFileDropdown, "Create", DockStyle.Top, EventManager.CreateFile);
            PanelFileDropdown.AddComponent(new UiPanel {
                Height = 3,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(166, 166, 166)
            });
            AddButtonsToDropdown(PanelFileDropdown, "Exit", DockStyle.Bottom, EventManager.ExitApplication);
        }
        private void AddButtonsToDropdown(DropdownPanel panel, string text, DockStyle dockStyle, EventHandler action) {
            DropdownUiButton button = new DropdownUiButton(dockStyle, text);
            button.Click += action;

            panel.AddComponent(button);
        }
    }
}
