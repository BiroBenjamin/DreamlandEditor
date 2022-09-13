using DreamlandEditor.Data.GameFiles.Objects;
using ProjectDreamland.Controls;
using ProjectDreamland.Controls.Editors;
using ProjectDreamland.Data;
using ProjectDreamland.Data.Enums;
using ProjectDreamland.Data.GameFiles;
using ProjectDreamland.Managers;
using ProjectDreamland.UI.Misc;
using ProjectDreamland.UI.UIButtons;
using ProjectDreamland.UI.UIPanels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ProjectDreamland.UI
{
  public class FileExplorer : ResizablePanel
  {
    public ItemExplorer ItemExplorer { get; set; }

    private UiPanel MenuPanel;
    private TreeView FileTree;
    private ICollection<Control> EditorWindows = new List<Control>();
    private ICollection<WindowChangeButton> EditorButtons = new List<WindowChangeButton>();

    public FileExplorer()
    {
      InitializeComponents();
    }

    private void InitializeComponents()
    {
      SetupLayout(DockStyle.Right);
    }

    public void AddEditors(ICollection<Control> editorWindows, ICollection<WindowChangeButton> editorButtons)
    {
      EditorWindows = editorWindows;
      EditorButtons = editorButtons;
    }

    public void SetUpTreeView(bool isInitialLoad)
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
      UpdateTreeView(isInitialLoad);
      ItemsManager.SortItems();
      Controls.Add(FileTree);
      SetUpMenuPanel();
    }
    public void UpdateTreeView(bool isInitialLoad)
    {
      FileTree.NodeMouseClick += OpenContextMenu;
      FileTree.NodeMouseDoubleClick += OpenFile;

      FileTree.BeginUpdate();

      string rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.RootPath);
      UITreeNode rootnode = new UITreeNode(rootPath);
      FileTree.Nodes.Add(rootnode);
      FillChildNodes(rootnode, isInitialLoad);
      FileTree.Nodes[0].Expand();

      FileTree.EndUpdate();
    }
    private void OpenContextMenu(object sender, TreeNodeMouseClickEventArgs ev)
    {
      if (ev.Button != MouseButtons.Right || Path.GetExtension(ev.Node.Text).Length < 1) return;
      ContextMenuStrip contextMenu = new ContextMenuStrip();
      ContextMenuStrip = contextMenu;
      ToolStripMenuItem item = new ToolStripMenuItem("Delete");
      item.Click += (s, e) =>
      {
        DialogResult result = MessageBox.Show(
                  $"Do you really want to delete {ev.Node.Text}?", "Delete file",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        if (result == DialogResult.Yes)
        {
          File.Delete(ev.Node.FullPath);
          BaseFile obj = (ev.Node as UITreeNode).Item;
          ItemsManager.RemoveItem(obj);
        }
      };
      contextMenu.Items.Add(item);
      contextMenu.Show();
    }
    private void OpenFile(object sender, TreeNodeMouseClickEventArgs e)
    {
      bool isFile = Path.GetExtension(e.Node.Text).Length > 0;
      if (isFile)
      {
        string nodeParent = GetFileType(e.Node.FullPath);
        string fileType = nodeParent.Substring(0, nodeParent.Length - 1);
        string pathToSlice = SystemPrefsManager.SystemPrefs.RootPath + "\\";
        if (FileTypesEnum.Map.ToString().Equals(fileType))
        {
          Map selectedMap = ItemsManager.Maps
              .Where(x => x.FilePath == e.Node.FullPath.Replace(pathToSlice, ""))
              .FirstOrDefault();
          Map map = ItemsManager.GetMapById(selectedMap.ID, true).FirstOrDefault();
          MapEditor mapEditor = (MapEditor)FindEditorPanel(fileType);
          mapEditor.LoadMap(map);
        }
        else if (FileTypesEnum.WorldObject.ToString().Equals(fileType))
        {
          WorldObject selectedWorldObject = ItemsManager.WorldObjects
              .Where(x => x.FilePath == e.Node.FullPath.Replace(pathToSlice, ""))
              .FirstOrDefault();
          WorldObject worldObject = ItemsManager.GetWorldObjectById(selectedWorldObject.ID, true).FirstOrDefault();
          WorldObjectEditor worldObjectEditor = (WorldObjectEditor)FindEditorPanel(fileType);
          worldObjectEditor.SetRenderableObject(worldObject);
        }
        else if (FileTypesEnum.Character.ToString().Equals(fileType))
        {

        }
        else
        {
          MessageBox.Show("That type of file can't be opened!", "Open error",
              MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
          return;
        }
        FindEditorButton(fileType).PerformClick();
      }
    }
    private string GetFileType(string nodePath)
    {
      IEnumerable<string> slicedNodePath = nodePath.Split('\\');
      string[] rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, "Objects").Split('\\');
      foreach (string elem in rootPath)
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
        IBaseEditor editor = (IBaseEditor)window;
        if (editor.EditorFor.Equals(fileType)) return window;
      }
      throw new Exception("No editor was found");
    }
    private Button FindEditorButton(string fileType)
    {
      foreach (Button button in EditorButtons)
      {
        IUiButton editorButton = (IUiButton)button;
        if (editorButton.ButtonFor.Equals(fileType)) return button;
      }
      throw new Exception("No button was found");
    }

    private void FillChildNodes(UITreeNode node, bool isInitialLoad)
    {
      try
      {
        DirectoryInfo directory = new DirectoryInfo(node.FullPath);
        foreach (DirectoryInfo dir in directory.GetDirectories())
        {
          UITreeNode newNode = new UITreeNode(dir.Name);
          node.Nodes.Add(newNode);
          if (!IsDirectoryEmpty(node.FullPath))
          {
            FillChildNodes(newNode, isInitialLoad);
          }
        }
        FileInfo file = new FileInfo(node.FullPath);
        foreach (FileInfo fl in directory.GetFiles())
        {
          string ext = Path.GetExtension(fl.Name).Replace(".", "");
          if (!SystemPrefsManager.SystemPrefs.Extensions.Contains(ext)) return;
          LoadItem(node, fl.Name, isInitialLoad);
        }
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message.ToString());
      }
    }
    private bool IsDirectoryEmpty(string path)
    {
      return !Directory.EnumerateFileSystemEntries(path).Any();
    }
    private void LoadItem(UITreeNode node, string fileName, bool isInitialLoad)
    {
      XmlDocument document = new XmlDocument();
      document.Load(Path.Combine(node.FullPath, fileName));
      string xmlType = document.DocumentElement.Name;
      if (new Map().GetType().Name.Equals(xmlType))
      {
        Map item = (Map)FileManager.LoadFile<Map>(Path.Combine(node.FullPath, fileName));
        UITreeNode newNode = new UITreeNode(fileName, item);
        node.Nodes.Add(newNode);
        if (!isInitialLoad) return;
        ItemsManager.Maps.Add(item);
      }
      else if (new WorldObject().GetType().Name.Equals(xmlType))
      {
        WorldObject item = (WorldObject)FileManager.LoadFile<WorldObject>(Path.Combine(node.FullPath, fileName));
        UITreeNode newNode = new UITreeNode(fileName, item);
        node.Nodes.Add(newNode);
        if (!isInitialLoad) return;
        if (item.FileType == FileTypesEnum.WorldObject.ToString())
        {
          ItemsManager.WorldObjects.Add(item);
          return;
        }
      }
      else if (new Tile().GetType().Name.Equals(xmlType))
      {
        Tile item = (Tile)FileManager.LoadFile<Tile>(Path.Combine(node.FullPath, fileName));
        UITreeNode newNode = new UITreeNode(fileName, item);
        node.Nodes.Add(newNode);
        if (!isInitialLoad) return;
        ItemsManager.AddTile(item);
      }
    }

    private void SetUpMenuPanel()
    {
      Controls.Remove(MenuPanel);
      MenuPanel = new UiPanel
      {
        Name = "MenuPanel",
        Dock = DockStyle.Top,
        BackColor = Color.FromArgb(166, 166, 166),
        Height = 25
      };
      Controls.Add(MenuPanel);

      IconButton openNodesButton = new IconButton(new Bitmap(ImagePaths.OpenFolder), new Size(25, 25), DockStyle.Right);
      openNodesButton.Click += (sender, ev) =>
      {
        OpenNodes(FileTree.Nodes);
      };
      MenuPanel.Controls.Add(openNodesButton);

      IconButton closeNodesButton = new IconButton(new Bitmap(ImagePaths.CloseFolder), new Size(25, 25), DockStyle.Right);
      closeNodesButton.Click += (sender, ev) =>
      {
        foreach (UITreeNode node in FileTree.Nodes[0].Nodes)
        {
          node.Collapse(false);
        }
      };
      MenuPanel.Controls.Add(closeNodesButton);

      IconButton addFileButton = new IconButton(new Bitmap(ImagePaths.Plus), new Size(25, 25), DockStyle.Left);
      addFileButton.Click += (sender, ev) =>
      {
        DialogResult result = new CreateNewWindow(EditorButtons, EditorWindows).ShowDialog();
        if (result == DialogResult.Cancel) return;
        SetUpTreeView(false);
        //ItemExplorer.SetupItems(ItemsManager.WorldObjects.Cast<BaseFile>().Union(ItemsManager.GetTiles()).ToList());
      };
      MenuPanel.Controls.Add(addFileButton);

      IconButton refreshNodesBtn = new IconButton(new Bitmap(ImagePaths.Refresh), new Size(25, 25), DockStyle.Left);
      refreshNodesBtn.Click += (sender, ev) =>
      {
        SetUpTreeView(false);
      };
      MenuPanel.Controls.Add(refreshNodesBtn);
    }

    private void OpenNodes(TreeNodeCollection nodes)
    {
      foreach (UITreeNode node in nodes)
      {
        node.Expand();
        OpenNodes(node?.Nodes);
      }
    }
  }
}
