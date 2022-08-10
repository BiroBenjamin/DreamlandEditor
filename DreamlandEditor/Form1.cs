using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI;
using DreamlandEditor.UI.Editors;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class Form1 : Form 
    {
        private PictureBox DraggedImage { get; set; } = new PictureBox();

        private WorldObjectEditor WorldObjectEditor { get; set; }
        private CharacterEditor CharacterEditor { get; set; }

        private DropdownPanel PanelFileDropdown { get; set; } = new DropdownPanel();
        private DropdownUiButton OpenButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Open");
        private DropdownUiButton CreateButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Create");
        private DropdownUiButton ExitButton { get; set; } = new DropdownUiButton(DockStyle.Bottom, "Exit");

        private DropdownPanel PanelOpenDropdown { get; set; } = new DropdownPanel();
        private DropdownUiButton OpenItemButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Open existing item");
        private DropdownUiButton OpenCharacterButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Open existing character");
        private DropdownUiButton OpenMapButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Open existing map");

        private DropdownPanel PanelCreateDropdown { get; set; } = new DropdownPanel();
        private DropdownUiButton NewItemButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Create new item");
        private DropdownUiButton NewCharacterButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Create new character");
        private DropdownUiButton NewMapButton { get; set; } = new DropdownUiButton(DockStyle.Top, "Create new map");

        public Form1() 
        {
            InitializeComponent();
            SetupEditors();

            DebugManager.ShowWindow(this);

            FileExplorer.SetUpTreeView();
            ItemExplorer.SetRenderWindow(MapEditor, ButtonSwitchToMapEditor, DraggedImage);
            MapEditor.Controls.Add(DraggedImage);
            DraggedImage.Visible = false;
            MapEditor.MouseMove += ItemExplorer.MoveItem;
            MapEditor.MouseClick += ItemExplorer.RemoveItem;

            SetupButtonEvents();
            SetupDropdownPanel(ButtonFileNavbutton, PanelFileDropdown, new Point(1, PanelNavbar.Height),
                    CreateButton, OpenButton,
                    new Panel
                    {
                        Height = 3,
                        Dock = DockStyle.Bottom,
                        BackColor = Color.FromArgb(166, 166, 166)
                    },
                    ExitButton
            );
            SetupDropdownPanel(OpenButton, PanelOpenDropdown,
                    new Point(PanelOpenDropdown.Width, PanelNavbar.Height + OpenButton.Location.Y),
                    OpenItemButton, OpenCharacterButton, OpenMapButton);
            SetupDropdownPanel(CreateButton, PanelCreateDropdown,
                    new Point(PanelFileDropdown.Width, PanelNavbar.Height + CreateButton.Location.Y),
                    NewItemButton, NewCharacterButton, NewMapButton);
        }

        private void SetupEditors() {
            ButtonSwitchToMapEditor.SetActive();
            ButtonSwitchToMapEditor.SetupEvents(PanelWorkArea.Controls, MapEditor);

            WorldObjectEditor = new WorldObjectEditor
            {
                Dock = DockStyle.Fill
            };
            PanelWorkArea.Controls.Add(WorldObjectEditor);
            ButtonSwitchToWorldObjectEditor.SetupEvents(PanelWorkArea.Controls, WorldObjectEditor);

            CharacterEditor = new CharacterEditor
            {
                Dock = DockStyle.Fill
            };
            PanelWorkArea.Controls.Add(CharacterEditor);
            ButtonSwitchToCharacterEditor.SetupEvents(PanelWorkArea.Controls, CharacterEditor);


            FileExplorer.AddEditors(PanelWorkArea);
        }

        private void SetupDropdownPanel(IUiButton dropdownButton, DropdownPanel dropdownPanel, Point position, 
                                        params Control[] components)
        {
            dropdownPanel.SetupButton(dropdownButton);
            dropdownPanel.AddToControls(Controls, position);

            dropdownButton.SetDropdownPanel(dropdownPanel);

            foreach(Control component in components)
            {
                dropdownPanel.AddComponent(component);
            }
        }
        
        private void SetupButtonEvents()
        {
            CreateButton.SetDropdownPanel(PanelCreateDropdown);
            OpenButton.SetDropdownPanel(PanelOpenDropdown);
            ExitButton.Click += (sender, ev) => 
            {
                Application.Exit();
            };
        }
    }
}
