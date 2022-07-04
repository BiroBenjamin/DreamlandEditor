using DreamlandEditor.UI.UIPanels;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons 
{
    class IconButton : Button, IUiButton 
    {
        private Image icon;

        public IconButton(string path, Size size, DockStyle dockStyle) 
        {
            Image img = Image.FromFile(path);
            Size iconSize = new Size((int)(size.Width * 0.8), (int)(size.Height * 0.8));
            icon = new Bitmap(img, iconSize);

            Image = icon;
            ImageAlign = ContentAlignment.MiddleCenter;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 89, 89);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 38, 38);

            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

            Size = new Size((int)(size.Width * 1.2), (int)(size.Height * 1.2));

            Dock = dockStyle;
            Padding = new Padding(0);
            
            BackColor = Color.FromArgb(166, 166, 166);
            ForeColor = Color.FromArgb(13, 13, 13);
        }

        public void SetActive()
        {
            throw new System.NotImplementedException();
        }

        public void SetInactive()
        {
            throw new System.NotImplementedException();
        }

        public void SetDropdownPanel(UiPanel panel)
        {
            throw new System.NotImplementedException();
        }
    }
}
