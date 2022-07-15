using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.Editors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controls
{
    public partial class CreateNewWindow : Form
    {
        private readonly SystemPrefs systemPrefs;

        //private Panel EditorsArea { get; set; }
        private ICollection<Control> EditorWindows { get; set; } = new List<Control>();
        private ICollection<Button> EditorButtons { get; set; } = new List<Button>();

        public CreateNewWindow(SystemPrefs systemPrefs, Panel editorsArea)
        {
            InitializeComponent();
            this.systemPrefs = systemPrefs;

            foreach (var item in systemPrefs.FolderStructure)
            {
                ComboboxFileType.Items.Add(item.Key);
            }
            ComboboxFileType.SelectedIndex = 0;

            AddControls(editorsArea);
        }

        private void AddControls(Panel editorArea)
        {
            foreach (Control component in editorArea.Controls)
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
                return;
            }

            var filePath = systemPrefs.FolderStructure[ComboboxFileType.SelectedItem.ToString()];

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
                DebugManager.Log($"File {TextboxFileID.Text}.{filePath[1]} already exists!\nFile was not created!");
                return;
            }

            switch (fileType)
            {
                case "Map":
                    
                    break;
                case "World Object":
                    WorldObject file = new WorldObject
                    {
                        FileType = fileType, 
                        ID = TextboxFileID.Text, 
                        Name = TextboxFileName.Text
                    };
                    FileManager<WorldObject>.SaveFile(path, file);

                    WorldObjectEditor editor = (WorldObjectEditor)FindEditorPanel(fileType);
                    editor.SetRenderableObject(file, path);

                    break;
                case "Character":

                  break;
                default:
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
        }
    }
}
