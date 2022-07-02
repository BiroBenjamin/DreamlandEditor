using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons {
    class IconButton : UiButton {
        private Image icon;

        public IconButton(string path, Size size, DockStyle dockStyle) {
            InitializeComponent(path, size, dockStyle);
        }

        private void InitializeComponent(string path, Size size, DockStyle dockStyle) {
            Image img = Image.FromFile(path);
            Size iconSize = new Size( (int)(size.Width * 0.8), (int)(size.Height * 0.8) );
            icon = new Bitmap(img, iconSize);

            Dock = dockStyle;
            Size = new Size( (int)(size.Width * 1.2), (int)(size.Height * 1.2) );
            Image = icon;
            ImageAlign = ContentAlignment.MiddleCenter;
            Padding = new Padding(0);
            BackColor = Color.FromArgb(166, 166, 166);
            ForeColor = Color.FromArgb(13, 13, 13);
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 89, 89);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 38, 38);
        }
    }
}
