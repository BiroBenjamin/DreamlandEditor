using ProjectDreamland.Controls.Editors;
using ProjectDreamland.Data.Enums;
using ProjectDreamland.ExtensionClasses;
using ProjectDreamland.Managers;
using ProjectDreamland.UI;
using ProjectDreamland.UI.UIButtons;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MonoGame.Forms.DX
{
  public partial class Form1 : Form
  {
    private WorldObjectEditor WorldObjectEditor;
    private CharacterEditor CharacterEditor;

    public Form1()
    {
      InitializeComponent();
      DebugManager.ShowWindow(this);

      SetupEditors();

      FileExplorer.SetUpTreeView(true);
      FileExplorer.ItemExplorer = ItemExplorer;
      ItemExplorer.SetRenderWindow(MapEditor, ButtonSwitchToMapEditor);
      ButtonSaveNavbutton.Click += (sender, ev) =>
      {
        if (!String.IsNullOrEmpty(MapEditor.MapFile.FilePath))
        {
          ItemsManager.SaveItems();
        }
      };
    }

    private void SetupEditors()
    {
      MapEditor.GetLabels(LabelCursorPosition, LabelZoomAmount);
      ButtonSwitchToMapEditor.ButtonFor = FileTypesEnum.Map.ToString();
      ButtonSwitchToMapEditor.SetActive();
      ButtonSwitchToMapEditor.SetupEvents(MapEditor);

      WorldObjectEditor = new WorldObjectEditor
      {
        Dock = DockStyle.Fill
      };
      PanelWorkArea.Controls.Add(WorldObjectEditor);
      ButtonSwitchToWorldObjectEditor.ButtonFor = FileTypesEnum.WorldObject.ToString();
      ButtonSwitchToWorldObjectEditor.SetupEvents(WorldObjectEditor);

      CharacterEditor = new CharacterEditor
      {
        Dock = DockStyle.Fill
      };
      PanelWorkArea.Controls.Add(CharacterEditor);
      ButtonSwitchToCharacterEditor.ButtonFor = FileTypesEnum.Character.ToString();
      ButtonSwitchToCharacterEditor.SetupEvents(CharacterEditor);

      WindowChangeButton.ButtonsToCoordinate.AddRange(new List<WindowChangeButton>()
            {
                ButtonSwitchToMapEditor,
                ButtonSwitchToWorldObjectEditor,
                ButtonSwitchToCharacterEditor
            });
      WindowChangeButton.PanelsToCoordinate.AddRange(new List<Control>()
            {
                MapEditor,
                WorldObjectEditor,
                CharacterEditor
            });

      FileExplorer.AddEditors(WindowChangeButton.PanelsToCoordinate, WindowChangeButton.ButtonsToCoordinate);
    }
  }
}
