using DreamlandEditor.Controls.Editors;
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
            FolderBrowserImage.ReadOnlyChecked = true;
            FolderBrowserImage.InitialDirectory = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Sprites");
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
            if(FieldsAreEmpty())
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
            WriteToFile(ComboboxFileType.SelectedItem.ToString(), filePath, extension);
        }
        private bool FieldsAreEmpty()
        {
            return TextboxFileID.Text.Length == 0 || ComboboxFileType.SelectedItem == null;
        }
        private void WriteToFile(string fileType, string filePath, string extension)
        {
            string path = Path.Combine(filePath, $"{TextboxFileID.Text}.{extension}");
            if (File.Exists(path))
            {
                MessageBox.Show($"File {TextboxFileID.Text}.{extension} already exists!", "File creation error");
                DebugManager.Log($"File {TextboxFileID.Text}.{extension} already exists!");
                return;
            }
            //Map
			if (FileTypesEnum.Map.GetDescription().Equals(fileType))
			{
                Map map = new Map()
                {
                    FileType = fileType,
                    ID = TextboxFileID.Text,
                    Name = TextboxFileName.Text,
                    Size = new Size((int)NudMapWidth.Value, (int)NudMapHeight.Value),
                };
                if (ComboBoxTerrainType.SelectedItem.ToString() != "None")
                {
                    WorldObject tileType = (WorldObject)ItemsManager.GetById(ComboBoxTerrainType.SelectedItem.ToString());
                    if(tileType == null)
                    {
                        MessageBox.Show("The selected tile type was not found!", "Object not found");
                        return;
                    }
                    for (int i = 0; i < NudMapWidth.Value; i++)
                    {
                        for (int j = 0; j < NudMapHeight.Value; j++)
                        {
                            map.WorldObjects.Add(new WorldObject()
                            {
                                Size = tileType.Size,
                                Position = new Point(i * tileType.Size.Width, j * tileType.Size.Height),
                                ImagePath = tileType.ImagePath

                            });
                        }
                    }
                }
                FileManager<Map>.SaveFile(path, map);
                MapEditor mapEditor = (MapEditor)FindEditorPanel(fileType);
                mapEditor.LoadMap(map);
            }
            //WorldObject
            else if (FileTypesEnum.WorldObject.GetDescription().Equals(fileType))
			{
                WorldObject worldObject = new WorldObject
                {
                    FileType = fileType,
                    ID = TextboxFileID.Text,
                    Name = TextboxFileName.Text,
                    ObjectType = FileTypesEnum.WorldObject.ToString(),
                };
                FileManager<WorldObject>.SaveFile(path, worldObject);
                WorldObjectEditor editor = (WorldObjectEditor)FindEditorPanel(fileType);
                editor.SetRenderableObject(worldObject, path);
            }
            //Character
            else if (FileTypesEnum.Character.GetDescription().Equals(fileType))
			{

			}
            //Tile
            else if (FileTypesEnum.Tile.GetDescription().Equals(fileType))
            {
                if (String.IsNullOrEmpty(TextBoxImagePath.Text))
                {
                    MessageBox.Show("Please select an image before saving!", "File path is empty");
                    return;
                }
                WorldObject tile = new WorldObject()
                {
                    FileType = fileType,
                    ID = TextboxFileID.Text,
                    Name = TextboxFileName.Text,
                    ImagePath = TextBoxImagePath.Text,
                    Size = ImageTile.Image.Size,
                    ObjectType = FileTypesEnum.Tile.ToString(),
                };
                FileManager<WorldObject>.SaveFile(path, tile);
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
            foreach(Control window in EditorWindows)
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
            }
            else if (FileTypesEnum.Character.GetDescription().Equals(ComboboxFileType.SelectedItem))
			{
                HidePanels();
            }
            else if (FileTypesEnum.Tile.GetDescription().Equals(ComboboxFileType.SelectedItem))
            {
                SetupTilePanel();
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
        private void SetupTilePanel()
        {
            HidePanels();
            PanelTileDetails.Visible = true;
        }

        private void HidePanels()
		{
            PanelMapDetails.Visible = false;
            PanelTileDetails.Visible = false;
		}

        private void ButtonChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageTile.Image = new Bitmap(FolderBrowserImage.FileName);
                TextBoxImagePath.Text = FolderBrowserImage.FileName;
                ImageTile.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
