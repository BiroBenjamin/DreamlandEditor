using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using System;
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
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            var filePath = systemPrefs.FolderStructure[ComboboxFileType.SelectedItem.ToString()];

            using (FileStream stream = File.Create(Path.Combine(filePath.Key, $"{TextboxFileID.Text}.{filePath.Value}")))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(stream);
                }
            }
        }
    }
}
