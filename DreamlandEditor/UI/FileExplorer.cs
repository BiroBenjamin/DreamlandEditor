using DreamlandEditor.Controls;
using DreamlandEditor.Data;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.Editors;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using System;
using System.Collections.Generic;
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

        private Panel EditorsArea { get; set; }
        private ICollection<Control> EditorWindows { get; set; } = new List<Control>();
        private ICollection<Button> EditorButtons { get; set; } = new List<Button>();

        public FileExplorer() 
        {
            InitializeComponents();
        }

        private void InitializeComponents() 
        {
            SetupLayout(DockStyle.Right);
        }

        public void AddEditors(Panel editorsArea)
        {
            EditorsArea = editorsArea;
            foreach (Control component in editorsArea.Controls)
            {
                if (component.Name.Contains("Editor"))
                {
                    EditorWindows.Add(component);
                    continue;
                }
                foreach (Button button in component.Controls)
                {
                    EditorButtons.Add(button);
                }
            }
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

            string rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath);
            TreeNode rootnode = new TreeNode(rootPath);
            FileTree.Nodes.Add(rootnode);
            FillChildNodes(rootnode);
            FileTree.Nodes[0].Expand();

            FileTree.EndUpdate();
        }
        private void ClickOnNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            bool isFile = Path.GetExtension(e.Node.Text).Length > 0;
            if (isFile)
            {
                string nodeParent = GetFileType(e.Node.FullPath);
                string fileType = nodeParent.Substring(0, nodeParent.Length - 1);
				if (FileTypesEnum.Map.ToString().Equals(fileType))
				{
                    Map map = FileManager<Map>.LoadFile(e.Node.FullPath);
                    SampleControl mapEditor = (SampleControl)FindEditorPanel(fileType);
                    mapEditor.LoadMap(map, e.Node.FullPath);
                }
                else if (FileTypesEnum.WorldObject.ToString().Equals(fileType))
				{
                    WorldObject worldObject = FileManager<WorldObject>.LoadFile(e.Node.FullPath);
                    WorldObjectEditor wOEditor = (WorldObjectEditor)FindEditorPanel(fileType);
                    wOEditor.SetRenderableObject(worldObject, e.Node.FullPath);
                }
                else if (FileTypesEnum.Character.ToString().Equals(fileType))
				{

				}
				else{
                    throw new Exception("File type not found!");
				}
                DebugManager.Log(fileType);
                FindEditorButton(fileType).PerformClick();
            }
        }
        private string GetFileType(string nodePath)
        {
            IEnumerable<string> slicedNodePath = nodePath.Split('\\');
            string[] rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Objects").Split('\\');
            foreach(string elem in rootPath)
            {
                if (slicedNodePath.Contains(elem))
                {
                    slicedNodePath = slicedNodePath.Where(x => x != elem);
                }
            }

            return slicedNodePath.First();
        }
        private Control FindEditorPanel(string fileType)
        {
            foreach (Control window in EditorWindows)
            {
                if (window.Name.Contains(fileType.Replace(" ", ""))) return window;
            }
            throw new Exception("No editor was found");
        }
        private Button FindEditorButton(string fileType)
        {
            foreach (Button button in EditorButtons)
            {
                if (button.Name.Contains(fileType.Replace(" ", ""))) return button;
            }
            throw new Exception("No button was found");
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
                    string ext = Path.GetExtension(fl.Name).Replace(".", "");
                    if (!SystemPrefsManager.SystemPrefs.extensions.Contains(ext)) return;

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

            IconButton openNodesButton = new IconButton(@"../../Content/folder-open-icon.png", new Size(25, 25), DockStyle.Right);
            openNodesButton.Click += (sender, ev) => 
            {
                OpenNodes(FileTree.Nodes);
            };
            MenuPanel.Controls.Add(openNodesButton);

            IconButton closeNodesButton = new IconButton(@"../../Content/folder-close-icon.png", new Size(25, 25), DockStyle.Right);
            closeNodesButton.Click += (sender, ev) => 
            {
                foreach (TreeNode node in FileTree.Nodes[0].Nodes)
                {
                    node.Collapse(false);
                }
            };
            MenuPanel.Controls.Add(closeNodesButton);

            IconButton addFileButton = new IconButton(@"../../Content/plus-icon.png", new Size(25, 25), DockStyle.Left);
            addFileButton.Click += (sender, ev) =>
            {
                DialogResult result = new CreateNewWindow(EditorsArea).ShowDialog();
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
