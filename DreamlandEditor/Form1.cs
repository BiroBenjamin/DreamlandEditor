using DreamlandEditor.Controls;
using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.Editors;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class Form1 : Form {
        private ItemEditor ItemEditor { get; set; }
        private CharacterEditor CharacterEditor { get; set; }

        private DropdownPanel PanelFileDropdown { get; set; }

        public Form1() {
            SystemPrefs systemPrefs = SystemPrefsManager.SetUpSystemPrefs();

            InitializeComponent();
            SetupEditors();

            DebugManager.SystemPrefs = systemPrefs;
            DebugManager.ShowWindow();

            FileExplorer.AddSystemPrefs(systemPrefs);
            FileExplorer.SetUpTreeView();

            PanelItemExplorer.SetupLayout(DockStyle.Top);

            SetupDropdownPanel();
        }

        private void SetupEditors() {
            ButtonSwitchToRenderWindow.SetActive();
            ButtonSwitchToRenderWindow.Click += delegate (object sender, EventArgs e) {
                EventManager.SwitchEditor(sender, e, RenderWindow, PanelWorkArea.Controls);
            };

            ItemEditor = new ItemEditor();
            PanelWorkArea.Controls.Add(ItemEditor);
            ButtonSwitchToItemEditor.Click += delegate (object sender, EventArgs e) {
                EventManager.SwitchEditor(sender, e, ItemEditor, PanelWorkArea.Controls);
            };

            CharacterEditor = new CharacterEditor();
            PanelWorkArea.Controls.Add(CharacterEditor);
            ButtonSwitchToCharacterEditor.Click += delegate (object sender, EventArgs e) {
                EventManager.SwitchEditor(sender, e, CharacterEditor, PanelWorkArea.Controls);
            };
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
