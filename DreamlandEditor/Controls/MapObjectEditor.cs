using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.Data.GameFiles.Objects;
using System;
using System.Windows.Forms;

namespace DreamlandEditor.Controls
{
  public partial class MapObjectEditor : Form
  {
    public static bool IsOpen { get; private set; }
    public static bool IsDone { get; set; }

    public static BaseFile File { get; private set; }

    public MapObjectEditor()
    {
      InitializeComponent();
    }
    public MapObjectEditor(BaseFile baseFile)
    {
      InitializeComponent();
      File = baseFile;
      IsOpen = true;
      IsDone = false;
      Text = $"Edit - {File.Name}";
      if (File.Instructions != null) TextBoxCommands.Text = File.Instructions.Replace(";", ";\r\n");
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
      File.Instructions = TextBoxCommands.Text.Replace("\r\n", "");
      IsDone = true;
      IsOpen = false;
      MessageBox.Show("Save succesfull!", "Save");
      Close();
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      IsOpen = false;
      Close();
    }
  }
}
