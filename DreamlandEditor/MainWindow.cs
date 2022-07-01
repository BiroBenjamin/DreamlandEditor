using DreamlandEditor.Managers;
using DreamlandEditor.UI;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System.Drawing;
using System.Windows.Forms;

namespace MonoGame.Forms.DX {
    public partial class MainWindow : Form {
        private DropdownPanel FileDropdown { get; set; }

        public MainWindow() {
            InitializeComponent();
            FileDropdown = new DropdownPanel(ButtonNavbarFile);

            PanelItemExplorer.SetupLayout(DockStyle.Top);
            PanelFileExplorer.SetupLayout(DockStyle.Right);

            FileDropdown.AddToControls(Controls, new Point(1, PanelNavbar.Height - 1));
            ButtonNavbarFile.SetDropdownPanel(FileDropdown);

            FileDropdown.AddButtons(
                new DropdownUiButton(DockStyle.Top, "Create"),
                new DropdownUiButton(DockStyle.Top, "Open"),
                new Panel {
                    BackColor = UiColors.LightGray,
                    Size = new Size(10, 3),
                    Dock = DockStyle.Bottom
                },
                new DropdownUiButton(DockStyle.Bottom, "Exit")
            );

            ButtonSwitchToRenderWindow.SetActive();
        }

        private void TreeViewFileExplorer_NodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Text.Contains(".pd")) {
                // TODO: Add logic for opening files. Either on the renderwindow or in a new form.
            }
        }
    }
}
