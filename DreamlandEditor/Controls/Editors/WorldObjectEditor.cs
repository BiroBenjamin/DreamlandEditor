using DreamlandEditor.Data;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.ExtensionClasses;
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

            string pathToSprites = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Sprites");
            DebugManager.Log(pathToSprites);
            if (!Directory.Exists(pathToSprites))
            {
                Directory.CreateDirectory(pathToSprites);
            }
            FolderBrowserImage.InitialDirectory = pathToSprites;

            TextBoxID.Text = RenderableObject.ID;
            TextBoxName.Text = RenderableObject.Name;
            TextBoxImagePath.Text = RenderableObject.ImagePath;

            CheckBoxIsInteractable.Checked = RenderableObject.IsInteractable;
            ChechBoxHasCollision.Checked = RenderableObject.IsCollidable;

            NudWidth.Value = RenderableObject.Size.Width;
            NudHeight.Value = RenderableObject.Size.Height;
            NudCollisionHeight.Value = RenderableObject.CollisionSize.Height;
            NudCollisionWidth.Value = RenderableObject.CollisionSize.Width;
            NudCollisionX.Value = RenderableObject.CollisionPosition.X;
            NudCollisionY.Value = RenderableObject.CollisionPosition.Y;


            if (!String.IsNullOrEmpty(RenderableObject.ImagePath)) {
                SetPicture(image);
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
                WriteToFile();
                MessageBox.Show("Save succesfull", "Save");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Save unsuccesfull.\r\nSee debug log for further information.", "Save");
                DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}");
            }

            FileManager.SaveFile(RenderableObject);
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
            RenderableObject.Size = new Size((int)NudWidth.Value, (int)NudHeight.Value);

            double percentage = (double)NudWidth.Value / 100;
            RenderableObject.Size = new Size( (int)(RenderableObject.BaseSize.Width * percentage), (int)(RenderableObject.BaseSize.Height * percentage));
        }

        private void ButtonChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserImage.ShowDialog();

            if (result == DialogResult.OK)
            {
                RenderableObject.ImagePath = FolderBrowserImage.FileName;
                SetPicture(new Bitmap(FolderBrowserImage.FileName));
            }
        }
        private void SetPicture(Bitmap image)
		{
            ImageWObject.Image = image;
            TextBoxImagePath.Text = RenderableObject.ImagePath;
            ImageWObject.SizeMode = PictureBoxSizeMode.Zoom;
            //SetMaxCollisionCoordinates(worldObject.Size.Width, worldObject.Size.Height, worldObject.Size.Width, worldObject.Size.Height);
        }
        private void SetMaxCollisionCoordinates(int x, int y, int width, int height)
		{
            NudCollisionX.Maximum = x;
            NudCollisionY.Maximum = y;
            NudCollisionWidth.Maximum = width;
            NudCollisionHeight.Maximum = height;
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
                //NudCollisionX.Maximum = worldObject.Size.Width - NudCollisionWidth.Value;
                //NudCollisionY.Maximum = worldObject.Size.Height - NudCollisionHeight.Value;
            }
            graphics.Dispose();
            pen.Dispose();
		}
    }
}
