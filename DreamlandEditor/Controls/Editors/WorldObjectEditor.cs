using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.Managers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controls.Editors
{
	public partial class WorldObjectEditor : UserControl, IBaseEditor
    {
        public string EditorFor { get; set; }
        public WorldObject RenderableObject { get; set; }

        private Bitmap image;

        public WorldObjectEditor()
        {
            InitializeComponent();
            EditorFor = FileTypesEnum.WorldObject.ToString();
            Enabled = false;
        }

        public void RenderUI()
        {
            Enabled = true;
            FolderBrowserImage.ReadOnlyChecked = true;

            try
            {
                image = new Bitmap(RenderableObject.ImagePath);
                RenderableObject.Size = image.Size;
            }
            catch
            {
                DebugManager.Log($"Could not find the image in path {RenderableObject.ImagePath}");
            }

            string pathToSprites = RenderableObject.ImagePath == null ?
                Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites") :
                RenderableObject.ImagePath;
            if (!Directory.Exists(Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites")))
            {
                Directory.CreateDirectory(Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites"));
            }
            FolderBrowserImage.InitialDirectory = pathToSprites;

            TextBoxID.Text = RenderableObject.ID;
            TextBoxName.Text = RenderableObject.Name;
            TextBoxImagePath.Text = RenderableObject.ImagePath == null ?
                Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Sprites") :
                RenderableObject.ImagePath;

            CheckBoxIsInteractable.Checked = RenderableObject.IsInteractable;
            ChechBoxHasCollision.Checked = RenderableObject.IsCollidable;

            NudWidth.Value = RenderableObject.Size.Width;
            NudHeight.Value = RenderableObject.Size.Height;
            NudCollisionHeight.Value = RenderableObject.CollisionSize.Height;
            NudCollisionWidth.Value = RenderableObject.CollisionSize.Width;
            NudCollisionX.Value = RenderableObject.CollisionPosition.X;
            NudCollisionY.Value = RenderableObject.CollisionPosition.Y;


            if (!String.IsNullOrEmpty(RenderableObject.ImagePath)) {
                SetPicture();
            }
        }

        public void SetRenderableObject(WorldObject obj)
        {
            RenderableObject = obj;
            RenderUI();
        }

        public void ChechBoxHasCollision_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxCollisionLocation.Enabled = ChechBoxHasCollision.Checked;
            GroupBoxCollisionSize.Enabled = ChechBoxHasCollision.Checked;
            CheckBoxRenderCollision.Checked = ChechBoxHasCollision.Checked;
            CheckBoxRenderCollision.Enabled = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
				if (String.IsNullOrEmpty(RenderableObject.ImagePath))
				{
                    MessageBox.Show("Please set an image!", "No image");
                    return;
				}
                WriteToFile();
                MessageBox.Show("Save succesfull", "Save");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Save unsuccesfull.\r\nSee debug log for further information.", "Save");
                DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}");
            }

            FileManager.SaveFile(RenderableObject);
            ItemsManager.UpdateInMaps(RenderableObject);
        }

        private void WriteToFile()
        {
			if (!string.IsNullOrEmpty(RenderableObject.ImagePath))
			{
                RenderableObject.ImagePath = TextBoxImagePath.Text;
            }
            RenderableObject.Name = TextBoxName.Text;
            RenderableObject.CollisionPosition = new Point((int)NudCollisionX.Value, (int)NudCollisionY.Value);
            RenderableObject.CollisionSize = new Size((int)NudCollisionWidth.Value, (int)NudCollisionHeight.Value);
            RenderableObject.IsInteractable = CheckBoxIsInteractable.Checked;
            RenderableObject.IsCollidable = ChechBoxHasCollision.Checked;
            RenderableObject.Size = image.Size;
        }

        private void ButtonChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserImage.ShowDialog();

            if (result == DialogResult.OK)
            {
                RenderableObject.ImagePath = FolderBrowserImage.FileName;
                image = new Bitmap(RenderableObject.ImagePath);
                SetPicture();
                RenderableObject.Size = image.Size;
            }
        }
        private void SetPicture()
		{
            ImageWObject.Image = image;
            TextBoxImagePath.Text = RenderableObject.ImagePath;
            ImageWObject.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void RenderCollision(object sender, EventArgs e)
		{
            Pen pen = new Pen(Color.Red);
            Graphics graphics = ImageWObject.CreateGraphics();
            ImageWObject.Refresh();
            if (CheckBoxRenderCollision.Checked)
			{
                graphics.DrawRectangle(
                    pen, 
                    new Rectangle(
                        (int)(NudCollisionX.Value * ImageWObject.Width / RenderableObject.Size.Width), 
                        (int)(NudCollisionY.Value * ImageWObject.Height / RenderableObject.Size.Height), 
                        (int)(NudCollisionWidth.Value * ImageWObject.Width / RenderableObject.Size.Width - 1), 
                        (int)(NudCollisionHeight.Value * ImageWObject.Height / RenderableObject.Size.Height - 1)));
            }
            graphics.Dispose();
            pen.Dispose();
		}
    }
}
