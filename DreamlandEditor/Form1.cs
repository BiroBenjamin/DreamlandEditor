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

            DebugManager.ShowWindow(systemPrefs, this);

            FileExplorer.AddSystemPrefs(systemPrefs);
            FileExplorer.SetUpTreeView();

            PanelItemExplorer.SetupLayout(DockStyle.Top);

            SetupDropdownPanel();
        }

        private void SetupEditors() {
            ButtonSwitchToRenderWindow.SetActive();
            ButtonSwitchToRenderWindow.SetupEvents(PanelWorkArea.Controls, RenderWindow);

            ItemEditor = new ItemEditor();
            PanelWorkArea.Controls.Add(ItemEditor);
            ButtonSwitchToItemEditor.SetupEvents(PanelWorkArea.Controls, ItemEditor);

            CharacterEditor = new CharacterEditor();
            PanelWorkArea.Controls.Add(CharacterEditor);
            ButtonSwitchToCharacterEditor.SetupEvents(PanelWorkArea.Controls, CharacterEditor);
        }

        private void SetupDropdownPanel() {
            PanelFileDropdown = new DropdownPanel();
            PanelFileDropdown.SetupButton(ButtonFileNavbutton);
            PanelFileDropdown.AddToControls(Controls, new Point(1, PanelNavbar.Height));

            ButtonFileNavbutton.SetDropdownPanel(PanelFileDropdown);

            AddButtonsToDropdown(PanelFileDropdown, "Open",DockStyle.Top, 
                (sender, ev) => { 
                    
                });
            AddButtonsToDropdown(PanelFileDropdown, "Create", DockStyle.Top,
                (sender, ev) => {
                    
                });
            PanelFileDropdown.AddComponent(new UiPanel {
                Height = 3,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(166, 166, 166)
            });
            AddButtonsToDropdown(PanelFileDropdown, "Exit", DockStyle.Bottom,
                (sender, ev) => {
                    Application.Exit();
                });
        }
        private void AddButtonsToDropdown(DropdownPanel panel, string text, DockStyle dockStyle, EventHandler action) {
            DropdownUiButton button = new DropdownUiButton(dockStyle, text);
            button.Click += action;

            panel.AddComponent(button);
        }
    }
}
