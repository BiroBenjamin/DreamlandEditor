using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamlandEditor.Managers {
    static class FileExplorerManager {
        public static void UpdateTreeView(TreeView itemList) {
            itemList.BeginUpdate();

            TreeNode rootnode = new TreeNode(@"C:\Temp\");
            itemList.Nodes.Add(rootnode);
            FillChildNodes(rootnode);
            itemList.Nodes[0].Expand();
            itemList.Nodes[0].Text = "Project Dreamland";

            itemList.EndUpdate();
        }
        private static void FillChildNodes(TreeNode node) {
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
        private static bool IsDirectoryEmpty(string path) {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}
