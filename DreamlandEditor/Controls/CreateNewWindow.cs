﻿using DreamlandEditor.Controls.Editors;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using DreamlandEditor.Data.GameFiles.Objects;
using DreamlandEditor.Data.GameFiles.Characters;

namespace DreamlandEditor.Controls
{
  public partial class CreateNewWindow : Form
  {
    private readonly ICollection<Control> EditorWindows = new List<Control>();
    private readonly ICollection<WindowChangeButton> EditorButtons = new List<WindowChangeButton>();

    public CreateNewWindow(ICollection<WindowChangeButton> editorButtons, ICollection<Control> editorWindows)
    {
      InitializeComponent();
      EditorButtons = editorButtons;
      EditorWindows = editorWindows;
      OpenFileDialogImage.InitialDirectory = Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites");
      ComboboxFileType.Items.AddItems(typeof(FileTypesEnum).GetDescriptionOfAll());
      ComboboxFileType.SelectedIndex = 0;
      ComboBoxTerrainType.Items.Add("None");
      string directoryName = SystemPrefsManager.SystemPrefs.FolderStructure[FileTypesEnum.Tile.GetDescription()][0];
      DirectoryInfo directory = new DirectoryInfo(directoryName);
      ComboBoxTerrainType.Items.AddRange(DirectoryManager.GetDirectories(directory));
      ComboBoxTerrainType.SelectedIndex = 0;
    }

    private void ButtonAccept_Click(object sender, EventArgs e)
    {
      if (FieldsAreEmpty())
      {
        MessageBox.Show("No file was created!", "File creation error");
        DebugManager.Log("No file was created due to empty fields.");
        return;
      }

      string filePath = SystemPrefsManager.SystemPrefs.FolderStructure[ComboboxFileType.SelectedItem.ToString()][0];
      string extension = SystemPrefsManager.SystemPrefs.FolderStructure[ComboboxFileType.SelectedItem.ToString()][1];

      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }
      WriteToFile(ComboboxFileType.SelectedItem.ToString().Replace(" ", ""), filePath, extension);
    }
    private bool FieldsAreEmpty()
    {
      return TextboxFileID.Text.Length == 0 || ComboboxFileType.SelectedItem == null;
    }
    private void WriteToFile(string fileType, string filePath, string extension)
    {
      string imagePath = TextBoxImagePath.Text;
      string[] folders = filePath.Split('\\');
      string[] endOfPathFolders = imagePath.Replace(folders[folders.Length - 1], "*").Split('*');
      string end = endOfPathFolders[endOfPathFolders.Length - 1].TrimStart('\\');
      string subFolders = String.Join("", end.Split('\\').TakeWhile(x => !x.Contains(".png")));
      if (!Directory.Exists(Path.Combine(filePath, subFolders)))
      {
        Directory.CreateDirectory(Path.Combine(filePath, subFolders));
      }
      string path = Path.Combine(filePath, subFolders, $"{TextboxFileID.Text}.{extension}");
      if (File.Exists(path))
      {
        MessageBox.Show($"File {TextboxFileID.Text}.{extension} already exists!", "File creation error");
        DebugManager.Log($"File {TextboxFileID.Text}.{extension} already exists!");
        return;
      }
      //Map
      if (FileTypesEnum.Map.ToString().Equals(fileType))
      {
        if (ItemsManager.GetMapById(TextboxFileID.Text, true).Count > 0)
        {
          MessageBox.Show($"Map with ID: {TextboxFileID.Text} already exists!", "File creation error");
          return;
        }
        Map map = new Map()
        {
          FileType = fileType,
          ID = TextboxFileID.Text,
          Name = TextboxFileName.Text,
          Size = new Size((int)NudMapWidth.Value, (int)NudMapHeight.Value),
          FilePath = path.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
        };
        if (ComboBoxTerrainType.SelectedItem.ToString() != "None")
        {
          List<Tile> tileTypes = ItemsManager.GetTileByTileType(ComboBoxTerrainType.SelectedItem.ToString()).ToList();
          Random rand = new Random();
          if (tileTypes.Count < 1)
          {
            MessageBox.Show("The selected tile type was not found!", "Object not found");
            return;
          }
          int nameParts = 999;
          foreach (Tile tileType in tileTypes)
          {
            int splitNameLength = tileType.ID.Split('_').Length;
            if (splitNameLength < nameParts) nameParts = splitNameLength;
          }
          List<Tile> normalTiles = tileTypes.Where(x => x.ID.Split('_').Length == nameParts).ToList();
          List<Tile> filledTiles = tileTypes.Where(x => x.ID.Split('_').Length != nameParts).ToList();
          for (int i = -(int)Math.Floor(NudMapWidth.Value / 2); i < (int)Math.Ceiling(NudMapWidth.Value / 2); i++)
          {
            for (int j = -(int)Math.Floor(NudMapWidth.Value / 2); j < (int)Math.Ceiling(NudMapWidth.Value / 2); j++)
            {
              Tile tile;
              if (rand.Next(1, 100) > 90)
                tile = new Tile(filledTiles[rand.Next(1, filledTiles.Count)]);
              else
                tile = new Tile(normalTiles[rand.Next(1, normalTiles.Count)]);
              tile.Position = new Point(i * tile.Size.Width, j * tile.Size.Height);
              map.Tiles.Add(tile);
            }
          }
        }
        FileManager.SaveFile(map);
        ItemsManager.Maps.Add(map);
        MapEditor mapEditor = (MapEditor)FindEditorPanel(fileType);
        mapEditor.LoadMap(map);
      }
      //WorldObject
      else if (FileTypesEnum.WorldObject.ToString().Equals(fileType))
      {
        if (ItemsManager.GetObjectById(TextboxFileID.Text, true).Count > 0)
        {
          MessageBox.Show($"World Object with ID: {TextboxFileID.Text} already exists!", "File creation error");
          return;
        }
        WorldObject worldObject = new WorldObject
        {
          FileType = fileType,
          ID = TextboxFileID.Text,
          Name = TextboxFileName.Text,
          //FullImagePath = TextBoxWOImagePath.Text,
          ImagePath = TextBoxImagePath.Text.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
          //ObjectType = FileTypesEnum.WorldObject.ToString(),
          //FullFilePath = path,
          FilePath = path.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
          ZIndex = 1
        };
        FileManager.SaveFile(worldObject);
        ItemsManager.WorldObjects.Add(worldObject);
        WorldObjectEditor editor = (WorldObjectEditor)FindEditorPanel(fileType);
        editor.SetRenderableObject(worldObject);
      }
      //Character
      else if (FileTypesEnum.Character.ToString().Equals(fileType))
      {
        if (ItemsManager.GetObjectById(TextboxFileID.Text, true).Count > 0)
        {
          MessageBox.Show($"Character with ID: {TextboxFileID.Text} already exists!", "File creation error");
          return;
        }
        if (String.IsNullOrEmpty(TextBoxImagePath.Text))
        {
          MessageBox.Show("Please select an image before saving!", "File creation error");
          return;
        }
        BaseCharacter character = new BaseCharacter()
        {
          FileType = fileType,
          ID = TextboxFileID.Text,
          Name = TextboxFileName.Text,
          ImagePath = TextBoxImagePath.Text.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
          Size = PictureBoxObject.Image.Size,
          FilePath = path.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
          ZIndex = 0,
          IsCollidable = true,
          CollisionPosition = new Point(0 + PictureBoxObject.Image.Width / 3 / 2, PictureBoxObject.Image.Height - PictureBoxObject.Image.Height / 4),
          CollisionSize = new Size(PictureBoxObject.Image.Width - PictureBoxObject.Image.Width / 3, PictureBoxObject.Image.Height / 4),
        };
        FileManager.SaveFile(character);
        ItemsManager.Characters.Add(character);
        CharacterEditor editor = (CharacterEditor)FindEditorPanel(fileType);
        editor.SetRenderableObject(character);
      }
      //Tile
      else if (FileTypesEnum.Tile.ToString().Equals(fileType))
      {
        if (ItemsManager.GetObjectById(TextboxFileID.Text, true).Count > 0)
        {
          MessageBox.Show($"Tile with ID: {TextboxFileID.Text} already exists!", "File creation error");
          return;
        }
        if (String.IsNullOrEmpty(TextBoxImagePath.Text))
        {
          MessageBox.Show("Please select an image before saving!", "File creation error");
          return;
        }
        Tile tile = new Tile()
        {
          FileType = fileType,
          ID = TextboxFileID.Text,
          Name = TextboxFileName.Text,
          //FullImagePath = TextBoxTileImagePath.Text,
          ImagePath = TextBoxImagePath.Text.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
          Size = PictureBoxObject.Image.Size,
          //FullFilePath = path,
          FilePath = path.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", ""),
          ZIndex = -9999,
        };
        ItemsManager.AddTile(tile);
        return;
      }
      else
      {
        throw new Exception("File type does not exist");
      }
      FindEditorButton(fileType).PerformClick();
    }

    private Control FindEditorPanel(string fileType)
    {
      foreach (Control window in EditorWindows)
      {
        IBaseEditor editor = (IBaseEditor)window;
        if (editor.EditorFor.Equals(fileType)) return window;
      }
      throw new Exception("No editor was found");
    }
    private Button FindEditorButton(string fileType)
    {
      foreach (Button button in EditorButtons)
      {
        IUiButton editorButton = (IUiButton)button;
        if (editorButton.ButtonFor.Equals(fileType)) return button;
      }
      throw new Exception("No button was found");
    }

    private void SelectedValueChanged(object sender, EventArgs e)
    {
      LabelFileName.Text = $"{ComboboxFileType.SelectedItem} Name: ";
      if (FileTypesEnum.Map.GetDescription().Equals(ComboboxFileType.SelectedItem))
      {
        SetupMapPanel();
      }
      else if (FileTypesEnum.WorldObject.GetDescription().Equals(ComboboxFileType.SelectedItem))
      {
        HidePanels();
        PanelObjectDetails.Visible = true;
      }
      else if (FileTypesEnum.Character.GetDescription().Equals(ComboboxFileType.SelectedItem))
      {
        HidePanels();
        PanelObjectDetails.Visible = true;
      }
      else if (FileTypesEnum.Tile.GetDescription().Equals(ComboboxFileType.SelectedItem))
      {
        HidePanels();
        //PanelTileDetails.Visible = true;
        PanelObjectDetails.Visible = true;
      }
      else
      {
        throw new Exception("File type not found!");
      }
    }
    private void SetupMapPanel()
    {
      HidePanels();
      PanelMapDetails.Visible = true;
      if (ComboBoxTerrainType.Items.Count > 0) return;
    }

    private void HidePanels()
    {
      PanelMapDetails.Visible = false;
      //PanelTileDetails.Visible = false;
      PanelObjectDetails.Visible = false;
    }

    private void SetIdAndName(string fileName)
    {
      string[] splitPath = fileName.Split('\\');
      string fileId = splitPath[splitPath.Length - 1].Split('.')[0];
      TextboxFileID.Text = fileId;
      TextInfo textinfo = new CultureInfo("en-US", false).TextInfo;
      TextboxFileName.Text = String.Join("", fileId.Split('_').Select(x => textinfo.ToTitleCase(x)).ToArray());
    }
    //private void ButtonChooseTileImage_Click(object sender, EventArgs e)
    //{
    //  DialogResult result = OpenFileDialogImage.ShowDialog();
    //  if (result == DialogResult.OK && OpenFileDialogImage.FileNames.Length == 1)
    //  {
    //    PictureBoxTile.Image = new Bitmap(OpenFileDialogImage.FileNames[0]);
    //    TextBoxTileImagePath.Text = OpenFileDialogImage.FileNames[0];
    //    PictureBoxTile.SizeMode = PictureBoxSizeMode.Zoom;
    //    SetIdAndName(OpenFileDialogImage.FileNames[0]);
    //  }
    //  else if (result == DialogResult.OK && OpenFileDialogImage.FileNames.Length > 1)
    //  {
    //    foreach (string name in OpenFileDialogImage.FileNames)
    //    {
    //      PictureBoxTile.Image = new Bitmap(name);
    //      TextBoxTileImagePath.Text = name;
    //      PictureBoxTile.SizeMode = PictureBoxSizeMode.Zoom;
    //      SetIdAndName(name);
    //      ButtonAccept.PerformClick();
    //    }
    //  }
    //}
    private void ButtonChooseImage_Click(object sender, EventArgs e)
    {
      DialogResult result = OpenFileDialogImage.ShowDialog();
      if (result == DialogResult.OK && OpenFileDialogImage.FileNames.Length == 1)
      {
        PictureBoxObject.Image = new Bitmap(OpenFileDialogImage.FileName);
        TextBoxImagePath.Text = OpenFileDialogImage.FileName;
        PictureBoxObject.SizeMode = PictureBoxSizeMode.Zoom;
        SetIdAndName(OpenFileDialogImage.FileName);
      }
      else if (result == DialogResult.OK && OpenFileDialogImage.FileNames.Length > 1)
      {
        foreach (string name in OpenFileDialogImage.FileNames)
        {
          PictureBoxObject.Image = new Bitmap(name);
          TextBoxImagePath.Text = name;
          PictureBoxObject.SizeMode = PictureBoxSizeMode.Zoom;
          SetIdAndName(name);
          ButtonAccept.PerformClick();
        }
      }
    }
  }
}
