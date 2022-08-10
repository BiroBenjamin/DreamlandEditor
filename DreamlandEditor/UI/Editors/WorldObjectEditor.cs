using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors
{
	public partial class WorldObjectEditor : UserControl
    {
        private WorldObject worldObject;
        private string path;
        private Bitmap image;

        public WorldObjectEditor()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        public void RenderUI()
        {
            Enabled = true;
            FolderBrowserImage.ReadOnlyChecked = true;

            if (worldObject.ImagePath != null)
            {
                image = new Bitmap(worldObject.ImagePath);
                worldObject.Size = image.Size;
            }

            string pathToSprites = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Sprites");
            DebugManager.Log(pathToSprites);
            if (!Directory.Exists(pathToSprites))
            {
                Directory.CreateDirectory(pathToSprites);
            }
            FolderBrowserImage.InitialDirectory = pathToSprites;

            TextBoxID.Text = worldObject.ID;
            TextBoxName.Text = worldObject.Name;
            TextBoxImagePath.Text = worldObject.ImagePath;
            CheckBoxIsInteractable.Checked = worldObject.IsInteractable;
            ChechBoxHasCollision.Checked = worldObject.IsCollidable;

            //NudCollisionHeight.Maximum = worldObject.Size.Height;
            NudCollisionHeight.Value = worldObject.CollisionSize.Height;
            //NudCollisionWidth.Maximum = worldObject.Size.Width;
            NudCollisionWidth.Value = worldObject.CollisionSize.Width;
            //NudCollisionX.Maximum = worldObject.Location.X;
            NudCollisionX.Value = worldObject.CollisionLocation.X;
            //NudCollisionY.Maximum = worldObject.Location.Y;
            NudCollisionY.Value = worldObject.CollisionLocation.Y;

            //NudSize.Value = (decimal)(worldObject.Size.Width / worldObject.BaseSize.Width) * 100;

            if (!String.IsNullOrEmpty(worldObject.ImagePath)) {
                SetPicture(image);
            }
        }

        public void SetRenderableObject(BaseFile obj, string path)
        {
            worldObject = (WorldObject)obj;
            this.path = path;
            DebugManager.Log(path);
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

            FileManager<WorldObject>.SaveFile(path, worldObject);
        }

        private void WriteToFile()
        {
			if (!string.IsNullOrEmpty(worldObject.ImagePath))
			{
                worldObject.ImagePath = TextBoxImagePath.Text;
            }
            worldObject.Name = TextBoxName.Text;
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
                worldObject.ImagePath = FolderBrowserImage.FileName;
                SetPicture(new Bitmap(FolderBrowserImage.FileName));
            }
        }
        private void SetPicture(Bitmap image)
		{
            ImageWObject.Image = image;
            TextBoxImagePath.Text = worldObject.ImagePath;
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
                        (int)(NudCollisionX.Value * ImageWObject.Width / worldObject.Size.Width), 
                        (int)(NudCollisionY.Value * ImageWObject.Height / worldObject.Size.Height), 
                        (int)(NudCollisionWidth.Value * ImageWObject.Width / worldObject.Size.Width - 1), 
                        (int)(NudCollisionHeight.Value * ImageWObject.Height / worldObject.Size.Height - 1)));
                //NudCollisionX.Maximum = worldObject.Size.Width - NudCollisionWidth.Value;
                //NudCollisionY.Maximum = worldObject.Size.Height - NudCollisionHeight.Value;
            }
            graphics.Dispose();
            pen.Dispose();
		}
    }
}
