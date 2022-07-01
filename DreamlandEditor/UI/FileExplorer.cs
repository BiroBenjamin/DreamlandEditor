using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DreamlandEditor.UI {
    class FileExplorer : TreeView {
        public FileExplorer() : base() {
            InitializeComponents();
        }

        private void InitializeComponents() {
            BackColor = Color.FromArgb(38, 38, 38);
            ForeColor = Color.FromArgb(191, 191, 191);
            Font = new Font("Microsoft Sans Serif", 9);
            UpdateTreeView();
        }

        private void UpdateTreeView() {
            BeginUpdate();

            TreeNode rootnode = new TreeNode(@"C:\Temp\");
            Nodes.Add(rootnode);
            FillChildNodes(rootnode);
            Nodes[0].Expand();
            Nodes[0].Text = "Project Dreamland";

            EndUpdate();
        }
        private void FillChildNodes(TreeNode node) {
            try {
                DirectoryInfo directory = new DirectoryInfo(node.FullPath);
                foreach (DirectoryInfo dir in directory.GetDirectories()) {
                    TreeNode newNode = new TreeNode(dir.Name);
                    node.Nodes.Add(newNode);
                    if (!IsDirectoryEmpty(node.FullPath)) {
                        FillChildNodes(newNode);
                    }
                }
                FileInfo file = new FileInfo(node.FullPath);
                foreach (FileInfo fl in directory.GetFiles()) {
                    TreeNode newNode = new TreeNode(fl.Name);
                    node.Nodes.Add(newNode);

                }
            } catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private bool IsDirectoryEmpty(string path) {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}
