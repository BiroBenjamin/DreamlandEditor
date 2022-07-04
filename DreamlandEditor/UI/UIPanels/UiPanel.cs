using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIPanels 
{
    public class UiPanel : Panel 
    {
        public UiPanel() : base()
        {
            BackColor = Color.FromArgb(38, 38, 38);
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
