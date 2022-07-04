using DreamlandEditor.Data;
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
            using (FileStream stream = File.Create(Path.Combine(systemPrefs.rootPath, $"{TextboxItemID.Text}.pdi")))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(stream);
                }
            }
        }
    }
}
