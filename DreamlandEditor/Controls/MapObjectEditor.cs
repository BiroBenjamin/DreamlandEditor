using DreamlandEditor.Controls.Editors;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.Data.GameFiles.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.Controls
{
  public partial class MapObjectEditor : Form
  {
    public static bool IsOpen { get; private set; }
    public static bool IsDone { get; set; }

    public static WorldObject File { get; private set; }

    public MapObjectEditor()
    {
      InitializeComponent();
    }
    public MapObjectEditor(WorldObject baseFile)
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
