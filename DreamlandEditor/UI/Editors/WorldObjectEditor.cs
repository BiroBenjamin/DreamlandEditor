using DreamlandEditor.Data;
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
        }

        public void SetRenderableObject(BaseFile obj)
        {
            worldObject = (WorldObject)obj;
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
    }
}
