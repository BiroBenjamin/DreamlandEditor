using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controls
{
    public partial class CreateNewItemWindow : Form
    {
        private readonly SystemPrefs systemPrefs;

        public CreateNewItemWindow(SystemPrefs systemPrefs)
        {
            InitializeComponent();
            this.systemPrefs = systemPrefs;

            foreach (var item in systemPrefs.FolderStructure)
            {
                ComboboxFileType.Items.Add(item.Key);
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
                WriteToFile(filePath);
            }
            catch (DirectoryNotFoundException ex)
            {
                DebugManager.Log(ex.Message);
                Directory.CreateDirectory(filePath.Key);
                WriteToFile(filePath);
            }
        }
        private bool FieldsAreEmpty()
        {
            return TextboxFileID.Text.Length == 0 || ComboboxFileType.SelectedItem == null;
        }
        private void WriteToFile(KeyValuePair<string, string> filePath)
        {
            string path = Path.Combine(filePath.Key, $"{TextboxFileID.Text}.{filePath.Value}");

            if (CheckForDuplicate(path))
            {
                DebugManager.Log($"File {TextboxFileID.Text}.{filePath.Value} already exists!\nFile was not created!");
                return;
            }

            using (FileStream stream = File.Create(Path.Combine(filePath.Key, $"{TextboxFileID.Text}.{filePath.Value}")))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(stream);
                }
            }
        }
        private bool CheckForDuplicate(string name)
        {
            return File.Exists(name);
        }
    }
}
