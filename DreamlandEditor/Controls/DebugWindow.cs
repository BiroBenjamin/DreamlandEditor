using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.Controlers {
    public partial class DebugWindow : Form {
        public DebugWindow() {
            InitializeComponent();
        }

        public void AddLog(string text) {
            try {
                ListBoxDebugMessages.Items.Add($"{ListBoxDebugMessages.Items.Count + 1}.) {text}");
            } catch { }
        }
    }
}
