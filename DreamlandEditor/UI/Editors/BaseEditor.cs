using DreamlandEditor.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors {
    public partial class BaseEditor : UserControl {
        protected BaseFile RenderableFile;
        //public static SystemPrefs SystemPrefs { get; set; } = new SystemPrefs();

        public BaseEditor() {
            InitializeComponent();
        }
    }
}
