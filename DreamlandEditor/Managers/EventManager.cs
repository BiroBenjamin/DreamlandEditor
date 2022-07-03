using DreamlandEditor.UI;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace DreamlandEditor.Managers {
    public static class EventManager {
        public static void CreateFile(object sender, EventArgs e) {

        }
        public static void OpenFile(object sender, EventArgs e) {

        }
        public static void ExitApplication(object sender, EventArgs e) {
            Application.Exit();
        }

        public static void DropDown(object sender, EventArgs e, DropdownPanel panel) {
            panel.Visible = !panel.Visible;
            panel.BringToFront();
            (sender as NavigationButton).SetActive(panel);
        }

        public static void LeaveDropdownWindow(object sender, EventArgs e, DropdownPanel panel, NavigationButton button) {
            panel.Visible = false;
            button.SetInactive();
        }

        public static void RefreshFileTree(object sender, EventArgs e, FileExplorer fileExplorer) {
            fileExplorer.SetUpTreeView();
        }
        public static void OpenTreeNodes(object sender, EventArgs e, TreeNodeCollection nodes) {
            OpenNodes(nodes);
        }
        private static void OpenNodes(TreeNodeCollection nodes) {
            foreach (TreeNode node in nodes) {
                node.Expand();
                OpenNodes(node?.Nodes);
            }
        }
        public static void CloseTreeNodes(object sender, EventArgs e, TreeNodeCollection nodes) {
            foreach (TreeNode node in nodes) {
                node.Collapse(false);
            }
        }
        public static void NodeItemClick(object sender, TreeNodeMouseClickEventArgs e) {
            string ext = Path.GetExtension(e.Node.Text);
            if (ext.Length > 0) {
                // TODO: Add logic for opening files. Either on the renderwindow or in a new form.
                DebugManager.Log(e.Node.FullPath);
            }
        }

        public static void SwitchEditor(object sender, EventArgs e, Control panelShow, ControlCollection collection) {
            foreach (Control control in collection) {
                if ( !(control is Panel) ) {
                    control.Visible = false;
                    continue;
                }
                foreach (Control button in control.Controls) {
                    (button as WindowChangeButton).SetInactive();
                }
            }
            (sender as WindowChangeButton).SetActive();
            panelShow.Visible = true;
        }
    }
}
