using ProjectDreamland.Data.Enums;
using ProjectDreamland.Data.GameFiles.Characters;
using ProjectDreamland.ExtensionClasses;
using ProjectDreamland.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectDreamland.Controls.Editors
{
  partial class CharacterEditor : UserControl, IBaseEditor
  {
    public string EditorFor { get; set; }
    public BaseCharacter RenderableCharacter { get; set; }

    private Bitmap _image;
    private string _pathToSlice = SystemPrefsManager.SystemPrefs.RootPath + "\\";

    public CharacterEditor() : base()
    {
      InitializeComponent();
      EditorFor = FileTypesEnum.Character.ToString();
    }

    public void RenderUI()
    {
      Enabled = true;
      ComboboxResourceType.Items.AddItems(typeof(ResourceTypesEnum).GetDescriptionOfAll());

      try
      {
        _image = new Bitmap(Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, RenderableCharacter.ImagePath));
        RenderableCharacter.Size = _image.Size;
      }
      catch
      {
        DebugManager.Log($"Could not find the image in path {RenderableCharacter.ImagePath}");
      }

      string pathToSprites = RenderableCharacter.ImagePath == null ?
          Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites") :
          Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, RenderableCharacter.ImagePath);
      if (!Directory.Exists(Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites")))
      {
        Directory.CreateDirectory(Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites"));
      }
      OpenFileDialogImage.InitialDirectory = pathToSprites;

      TextBoxID.Text = RenderableCharacter.ID;
      TextBoxName.Text = RenderableCharacter.Name;
      TextBoxImagePath.Text = RenderableCharacter.ImagePath == null ?
          Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites") :
          Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, RenderableCharacter.ImagePath);
      NudLevel.Value = (decimal)RenderableCharacter.Level;
      NudMaxHealth.Value = (decimal)RenderableCharacter.MaxHealthPoints;
      NudCurrentHealth.Value = (decimal)RenderableCharacter.CurrentHealthPoints;
      List<string> resourceTypes = typeof(ResourceTypesEnum).GetDescriptionOfAll().ToList();
      ComboboxResourceType.SelectedIndex = resourceTypes.IndexOf(RenderableCharacter.ResourceType);
      NudMaxResource.Value = (decimal)RenderableCharacter.MaxResourcePoints;
      NudCurrentResource.Value = (decimal)RenderableCharacter.CurrentResourcePoints;

      if (!String.IsNullOrEmpty(RenderableCharacter.ImagePath))
      {
        SetPicture();
      }
    }

    public void SetRenderableObject(BaseCharacter obj)
    {
      RenderableCharacter = obj;
      RenderUI();
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
      try
      {
        if (String.IsNullOrEmpty(RenderableCharacter.ImagePath))
        {
          MessageBox.Show("Please set an image!", "No image");
          return;
        }
        WriteToFile();
        MessageBox.Show("Save succesfull", "Save");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Save unsuccesfull.\r\nSee debug log for further information.", "Save");
        DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}");
      }

      FileManager.SaveFile(RenderableCharacter);
      ItemsManager.UpdateInMaps(RenderableCharacter);
    }

    private void WriteToFile()
    {
      if (!string.IsNullOrEmpty(RenderableCharacter.ImagePath))
      {
        RenderableCharacter.ImagePath = TextBoxImagePath.Text.Replace(_pathToSlice, "");
      }
      RenderableCharacter.Name = TextBoxName.Text;
      RenderableCharacter.Level = (int)NudLevel.Value;
      RenderableCharacter.MaxHealthPoints = (float)NudMaxHealth.Value;
      RenderableCharacter.CurrentHealthPoints = (float)NudCurrentHealth.Value;
      RenderableCharacter.MaxResourcePoints = (float)NudMaxResource.Value;
      RenderableCharacter.ResourceType = ComboboxResourceType.SelectedItem.ToString();
      RenderableCharacter.CurrentResourcePoints = (float)NudCurrentResource.Value;
      RenderableCharacter.IsCollidable = true;
      RenderableCharacter.CollisionPosition = new Point(0 + _image.Width / 3 / 2, _image.Height - _image.Height / 4);
      RenderableCharacter.CollisionSize = new Size(_image.Width - _image.Width / 3, _image.Height / 4);
      RenderableCharacter.Size = _image.Size;
    }

    private void ButtonChooseImage_Click(object sender, EventArgs e)
    {
      DialogResult result = OpenFileDialogImage.ShowDialog();

      if (result == DialogResult.OK)
      {
        RenderableCharacter.ImagePath = OpenFileDialogImage.FileName;
        _image = new Bitmap(RenderableCharacter.ImagePath);
        SetPicture();
        RenderableCharacter.Size = _image.Size;
      }
    }
    private void SetPicture()
    {
      ImageWObject.Image = _image;
      TextBoxImagePath.Text = RenderableCharacter.ImagePath;
      ImageWObject.SizeMode = PictureBoxSizeMode.Zoom;
    }
  }
}
