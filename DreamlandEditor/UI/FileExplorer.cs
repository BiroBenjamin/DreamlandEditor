using DreamlandEditor.Controls;
using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DreamlandEditor.UI 
{
    public class FileExplorer : ResizablePanel 
    {
        private UiPanel MenuPanel { get; set; }
        private TreeView FileTree { get; set; }

        private SystemPrefs systemPrefs = new SystemPrefs();

        public FileExplorer() 
        {
        }
        public FileExplorer(SystemPrefs systemPrefs) : base() 
        {
            this.systemPrefs = systemPrefs;
        }

        public void AddSystemPrefs(SystemPrefs systemPrefs) 
        {
            this.systemPrefs = systemPrefs;
            InitializeComponents();
        }

        private void InitializeComponents() 
        {
            SetupLayout(DockStyle.Right);
        }
        public void SetUpTreeView() 
        {
            Controls.Remove(FileTree);
            FileTree = new TreeView 
            {
                Name = "FileExplorer",
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(38, 38, 38),
                ForeColor = Color.FromArgb(191, 191, 191),
                Font = new Font("Microsoft Sans Serif", 9),
                Padding = new Padding(20)
            };
            UpdateTreeView();
            Controls.Add(FileTree);
            SetUpMenuPanel();
        }
        private void UpdateTreeView() 
        {
            FileTree.NodeMouseDoubleClick += ClickOnNode;

            FileTree.BeginUpdate();

            TreeNode rootnode = new TreeNode(systemPrefs.rootPath);
            FileTree.Nodes.Add(rootnode);
            FillChildNodes(rootnode);
            FileTree.Nodes[0].Expand();

            FileTree.EndUpdate();
        }
        private void ClickOnNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            string ext = Path.GetExtension(e.Node.Text);
            if (ext.Length > 0)
            {
                // TODO: Add logic for opening files. Either on the renderwindow or in a new form.
                DebugManager.Log(e.Node.FullPath);
            }
        }
        private void FillChildNodes(TreeNode node) 
        {
            try 
            {
                DirectoryInfo directory = new DirectoryInfo(node.FullPath);
                foreach (DirectoryInfo dir in directory.GetDirectories()) 
                {
                    TreeNode newNode = new TreeNode(dir.Name);
                    node.Nodes.Add(newNode);
                    if (!IsDirectoryEmpty(node.FullPath)) 
                    {
                        FillChildNodes(newNode);
                    }
                }
                FileInfo file = new FileInfo(node.FullPath);
                foreach (FileInfo fl in directory.GetFiles()) 
                {
                    TreeNode newNode = new TreeNode(fl.Name);
                    node.Nodes.Add(newNode);
                }
            } catch (Exception e) 
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private bool IsDirectoryEmpty(string path) 
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        private void SetUpMenuPanel() 
        {
            Controls.RemoveByKey("MenuPanel");
            MenuPanel = new UiPanel 
            {
                Name = "MenuPanel",
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(166, 166, 166),
                Height = 25
            };
            Controls.Add(MenuPanel);

            IconButton openNodesBtn = new IconButton(@"../../Content/folder-open-icon.png", new Size(25, 25), DockStyle.Right);
            openNodesBtn.Click += (sender, ev) => 
            {
                OpenNodes(FileTree.Nodes);
            };
            MenuPanel.Controls.Add(openNodesBtn);

            IconButton closeNodesBtn = new IconButton(@"../../Content/folder-close-icon.png", new Size(25, 25), DockStyle.Right);
            closeNodesBtn.Click += (sender, ev) => 
            {
                foreach (TreeNode node in FileTree.Nodes[0].Nodes)
                {
                    node.Collapse(false);
                }
            };
            MenuPanel.Controls.Add(closeNodesBtn);

            IconButton addFileButton = new IconButton(@"../../Content/plus-icon.png", new Size(25, 25), DockStyle.Left);
            addFileButton.Click += (sender, ev) =>
            {
                DialogResult result = new CreateNewItemWindow(systemPrefs).ShowDialog();
                if (result == DialogResult.Cancel) return;
                SetUpTreeView();
            };
            MenuPanel.Controls.Add(addFileButton);

            IconButton refreshNodesBtn = new IconButton(@"../../Content/refresh-icon.png", new Size(25, 25), DockStyle.Left);
            refreshNodesBtn.Click += (sender, ev) => 
            {
                SetUpTreeView();
            };
            MenuPanel.Controls.Add(refreshNodesBtn);
        }

        private void OpenNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Expand();
                OpenNodes(node?.Nodes);
            }
        }
    }
}
