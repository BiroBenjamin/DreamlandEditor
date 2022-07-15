using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors
{
    public partial class WorldObjectEditor : UserControl
    {
        WorldObject worldObject;
        string path;

        public WorldObjectEditor()
        {
            InitializeComponent();
        }

        public void RenderUI()
        {
            TextBoxID.Text = worldObject.ID;
            TextBoxName.Text = worldObject.Name;
            CheckBoxIsInteractable.Checked = worldObject.IsInteractable;
            ChechBoxHasCollision.Checked = worldObject.IsCollidable;
            NudSize.Value = (decimal)(worldObject.Size.Width / 32) * 100;
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
    }
}
