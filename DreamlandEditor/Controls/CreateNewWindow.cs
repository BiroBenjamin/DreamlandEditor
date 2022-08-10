using DreamlandEditor.Data;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.Editors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controls
{
    public partial class CreateNewWindow : Form
    {
        private ICollection<Control> EditorWindows { get; set; } = new List<Control>();
        private ICollection<Button> EditorButtons { get; set; } = new List<Button>();

        public CreateNewWindow(Panel editorsArea)
        {
            InitializeComponent();
			foreach (FileTypesEnum item in Enum.GetValues(typeof(FileTypesEnum)))
			{
                ComboboxFileType.Items.Add(item.GetDescription());
            }
            ComboboxFileType.SelectedIndex = 0;
            foreach (TerrainTypesEnum item in Enum.GetValues(typeof(TerrainTypesEnum)))
            {
                ComboBoxTerrainType.Items.Add(item.GetDescription());
            }
            ComboBoxTerrainType.SelectedItem = TerrainTypesEnum.None.GetDescription();
            AddEditors(editorsArea);
        }

        private void AddEditors(Panel editorsArea)
        {
            foreach (Control component in editorsArea.Controls)
            {
                if (component.Name.Contains("Editor"))
                {
                    EditorWindows.Add(component);
                    continue;
                }
                foreach(Button button in component.Controls)
                {
                    EditorButtons.Add(button);
                }
            }
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if(FieldsAreEmpty())
            {
                MessageBox.Show("No file was created!", "Unable to create file");
                DebugManager.Log("No file was created due to empty fields.");
                return;
            }

            var filePath = SystemPrefsManager.SystemPrefs.FolderStructure[ComboboxFileType.SelectedItem.ToString()];

            try
            {
                WriteToFile(ComboboxFileType.SelectedItem.ToString(), filePath);
            }
            catch (DirectoryNotFoundException ex)
            {
                DebugManager.Log(ex.Message);
                Directory.CreateDirectory(filePath[0]);
                WriteToFile(ComboboxFileType.SelectedItem.ToString(), filePath);
            }
        }
        private bool FieldsAreEmpty()
        {
            return TextboxFileID.Text.Length == 0 || ComboboxFileType.SelectedItem == null;
        }
        private void WriteToFile(string fileType, string[] filePath)
        {
            string path = Path.Combine(filePath[0], $"{TextboxFileID.Text}.{filePath[1]}");

            if (File.Exists(path))
            {
                DebugManager.Log($"File {TextboxFileID.Text}.{filePath[1]} already exists!\r\nFile was not created!");
                return;
            }

			if (FileTypesEnum.Map.GetDescription().Equals(fileType))
			{
                Map map = new Map()
                {
                    FileType = fileType,
                    ID = TextboxFileID.Text,
                    Name = TextboxFileName.Text,
                    Size = new Size((int)NudMapWidth.Value, (int)NudMapHeight.Value),
                    TerrainType = ComboBoxTerrainType.SelectedItem.ToString()
                };
                FileManager<Map>.SaveFile(path, map);
                SampleControl mapEditor = (SampleControl)FindEditorPanel(fileType);
                mapEditor.LoadMap(map, path);
            }
            else if (FileTypesEnum.WorldObject.GetDescription().Equals(fileType))
			{
                WorldObject worldObject = new WorldObject
                {
                    FileType = fileType,
                    ID = TextboxFileID.Text,
                    Name = TextboxFileName.Text
                };
                FileManager<WorldObject>.SaveFile(path, worldObject);
                WorldObjectEditor editor = (WorldObjectEditor)FindEditorPanel(fileType);
                editor.SetRenderableObject(worldObject, path);
            }
            else if (FileTypesEnum.Character.GetDescription().Equals(fileType))
			{

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
                if (window.Name.Contains(fileType.Replace(" ", ""))) return window;
            }
            throw new Exception("No editor was found");
        }
        private Button FindEditorButton(string fileType)
        {
            foreach (Button button in EditorButtons)
            {
                if (button.Name.Contains(fileType.Replace(" ", ""))) return button;
            }
            throw new Exception("No button was found");
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            LabelFileName.Text = $"{ComboboxFileType.SelectedItem} Name: ";
			if (FileTypesEnum.Map.GetDescription().Equals(ComboboxFileType.SelectedItem))
			{
                HidePanels();
                PanelMapDetails.Visible = true;
            }
            else if (FileTypesEnum.WorldObject.GetDescription().Equals(ComboboxFileType.SelectedItem))
			{
                HidePanels();
            }
            else if (FileTypesEnum.Character.GetDescription().Equals(ComboboxFileType.SelectedItem))
			{
                HidePanels();
            }
			else
			{
                throw new Exception("File type not found!");
			}
        }
        private void HidePanels()
		{
            PanelMapDetails.Visible = false;
		}
    }
}
