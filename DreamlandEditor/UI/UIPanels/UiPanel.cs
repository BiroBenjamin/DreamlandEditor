using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIPanels {
    class UiPanel : Panel {
        public UiPanel() {
            InitializeComponents();
        }

        private void InitializeComponents() {
            BackColor = Color.FromArgb(38, 38, 38);
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
