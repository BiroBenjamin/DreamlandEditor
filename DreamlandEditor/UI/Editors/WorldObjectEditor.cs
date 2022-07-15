using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace DreamlandEditor.UI.Editors
{
    public partial class WorldObjectEditor : UserControl
    {
        private WorldObject worldObject;
        private string path;

        //public static SystemPrefs SystemPrefs { get; set; } = new SystemPrefs();

        public WorldObjectEditor()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public void RenderUI()
        {
            this.Enabled = true;
            FolderBrowserImage.ReadOnlyChecked = true;

            TextBoxID.Text = worldObject.ID;
            TextBoxName.Text = worldObject.Name;
            CheckBoxIsInteractable.Checked = worldObject.IsInteractable;
            ChechBoxHasCollision.Checked = worldObject.IsCollidable;
            NudSize.Value = (decimal)(worldObject.Size.Width / worldObject.BaseSize.Width) * 100;

            string pathToSprites = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Sprites");
            DebugManager.Log(pathToSprites);
            if (!Directory.Exists(pathToSprites))
            {
                Directory.CreateDirectory(pathToSprites);
            }
            FolderBrowserImage.InitialDirectory = pathToSprites;
        }

        public void SetRenderableObject(BaseFile obj, string path)
        {
            worldObject = (WorldObject)obj;
            this.path = path;
            RenderUI();
        }

        public void ChechBoxHasCollision_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChechBoxHasCollision.Checked)
            {
                GroupBoxCollisionLocation.Enabled = false;
                GroupBoxCollisionSize.Enabled = false;
                return;
            }
            GroupBoxCollisionLocation.Enabled = true;
            GroupBoxCollisionSize.Enabled = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            WriteToFile();

            FileManager<WorldObject>.SaveFile(path, worldObject);
        }

        private void WriteToFile()
        {
            worldObject.Name = TextBoxName.Text;
            worldObject.ImagePath = TextBoxImagePath.Text;
            worldObject.CollisionLocation = new Point((int)NudCollisionX.Value, (int)NudCollisionY.Value);
            worldObject.CollisionSize = new Size((int)NudCollisionWidth.Value, (int)NudCollisionHeight.Value);
            worldObject.IsInteractable = CheckBoxIsInteractable.Checked;
            worldObject.IsCollidable = ChechBoxHasCollision.Checked;

            double percentage = (double)NudSize.Value / 100;
            worldObject.Size = new Size( (int)(worldObject.BaseSize.Width * percentage), (int)(worldObject.BaseSize.Height * percentage));
        }

        private void ButtonChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserImage.ShowDialog();

            if (result == DialogResult.OK)
            {
                ImageWObject.Load(FolderBrowserImage.FileName);
                TextBoxImagePath.Text = FolderBrowserImage.FileName;

                ImageWObject.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
