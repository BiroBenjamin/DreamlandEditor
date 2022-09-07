using DreamlandEditor.Controls.Editors;
using DreamlandEditor.Data;
using DreamlandEditor.Data.Attributes;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.ExtensionClasses;
using DreamlandEditor.Managers;
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
  public partial class ItemExplorer : ResizablePanel
  {
    private WindowChangeButton MapEditorButton;
    private MapEditor MapEditor;
    private UiPanel WorkArea;
    private UiPanel MiscPanel;
    private UiPanel ItemsPanel;
    private ComboBox TypeDropdown;
    private TextBox filterField;
    private Timer timer;

    public ItemExplorer()
    {
      InitializeComponent();
      SetupLayout(DockStyle.Top);
      SetupPanels();
      SetupTimer();
    }

    public void SetRenderWindow(MapEditor renderWindow, WindowChangeButton mapEditorButton)
    {
      MapEditor = renderWindow;
      MapEditorButton = mapEditorButton;
    }

    private void SetupPanels()
    {
      WorkArea = new UiPanel() { Dock = DockStyle.Fill };
      Controls.Add(WorkArea);

      ItemsPanel = new UiPanel() { Dock = DockStyle.Fill };
      WorkArea.Controls.Add(ItemsPanel);
      ItemsPanel.AutoScroll = false;
      ItemsPanel.HorizontalScroll.Enabled = false;
      ItemsPanel.HorizontalScroll.Visible = false;
      ItemsPanel.VerticalScroll.Visible = false;
      ItemsPanel.HorizontalScroll.Maximum = 0;
      ItemsPanel.AutoScroll = true;

      MiscPanel = new UiPanel()
      {
        Dock = DockStyle.Top,
        Height = 25,
      };
      WorkArea.Controls.Add(MiscPanel);

      SetupChangeTypeCombobox();
      SetupFilterField();
      /*SetupItems(ItemsManager.WorldObjects
        .Cast<BaseFile>()
        .Union(ItemsManager.GetTiles()
          .Cast<BaseFile>())
        .ToList());*/
    }
    private void SetupChangeTypeCombobox()
    {
      TypeDropdown = new ComboBox()
      {
        FlatStyle = FlatStyle.Flat,
        DropDownStyle = ComboBoxStyle.DropDownList,
        Dock = DockStyle.Left,
        Width = 250,
        Height = 25,
      };
      MiscPanel.Controls.Add(TypeDropdown);

      List<string> dropdownTypes = new List<string>() { "All" };
      dropdownTypes.AddRange(typeof(FileTypesEnum).GetDescriptionOfAll(typeof(DisplayableAttribute)));
      TypeDropdown.DataSource = dropdownTypes;
      TypeDropdown.SelectedValueChanged += (sender, ev) =>
      {
        string selectedValue = ((ListControl)sender).SelectedValue.ToString();
        if (selectedValue.Equals("All"))
        {
          SetupItems(ItemsManager.WorldObjects
            .Cast<BaseFile>()
            .Union(ItemsManager.GetTiles()
              .Cast<BaseFile>()).ToList()
            .Where(x => x.Name.ToLower()
              .Contains(filterField.Text.ToLower()))
            .ToList());
          return;
        }
        else if (selectedValue.Equals(FileTypesEnum.WorldObject.GetDescription()))
        {
          List<BaseFile> filteredItems = ItemsManager.WorldObjects
            .Where(x => x.Name.ToLower()
              .Contains(filterField.Text.ToLower()))
            .Cast<BaseFile>()
            .ToList();
          SetupItems(filteredItems);
        }
        else if (selectedValue.Equals(FileTypesEnum.Tile.ToString()))
        {
          List<BaseFile> filteredItems = ItemsManager.GetTiles()
            .Where(x => x.Name.ToLower()
              .Contains(filterField.Text.ToLower()))
            .Cast<BaseFile>()
            .ToList();
          SetupItems(filteredItems);
        }
      };
    }
    private void SetupFilterField()
    {
      filterField = new TextBox()
      {
        Dock = DockStyle.Left,
        Width = 250,
        Height = 25,
      };
      MiscPanel.Controls.Add(filterField);
      filterField.TextChanged += (sender, ev) =>
      {
        timer.Stop();
        timer.Tag = ((TextBox)sender).Text;
        timer.Start();
      };
    }
    private void SetupTimer()
    {
      timer = new Timer();
      timer.Interval = 500;
      timer.Tick += (sender, ev) =>
      {
        Timer timer = sender as Timer;
        if (timer == null) return;
        string[] filters = timer.Tag.ToString().Split(' ');
        SetFilter(filters);
        timer.Stop();
      };
    }
    private void SetFilter(string[] filters)
    {
      if (TypeDropdown.SelectedValue.ToString().Equals("All"))
      {
        var items = ItemsManager.WorldObjects.Cast<BaseFile>().Union(ItemsManager.GetTiles()).ToList();
        foreach (string filter in filters)
        {
          items = items.Where(x => x.Name.ToLower()
            .Contains(filter.ToLower())).ToList();
        }

        SetupItems(items);
      }
      else if (TypeDropdown.SelectedValue.ToString().Equals(FileTypesEnum.Tile.GetDescription()))
      {
        var items = ItemsManager.GetCollectionByType(TypeDropdown.SelectedValue.ToString()).Cast<BaseFile>().ToList();
        foreach (string filter in filters)
        {
          items = items.Where(x => x.Name.ToLower()
            .Contains(filter.ToLower())).ToList();
        }
        SetupItems(items);
      }
    }

    public void SetupItems(ICollection<BaseFile> items)
    {
      ItemsPanel.Controls.Clear();
      foreach (BaseFile item in items)
      {
        if (item == null) continue;
        Panel itemBackground = new Panel()
        {
          Dock = DockStyle.Left,
          Width = Height,
          BorderStyle = BorderStyle.FixedSingle,
          BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
        };
        ItemsPanel.Controls.Add(itemBackground);
        PictureBox pictureBox = new PictureBox()
        {
          Dock = DockStyle.Fill,
          SizeMode = PictureBoxSizeMode.Zoom,
          Image = (String.IsNullOrEmpty(item.FullImagePath) ?
            new Bitmap(@"../../Content/not-found.png") :
            new Bitmap(item.FullImagePath)),
        };
        itemBackground.Controls.Add(pictureBox);
        new ToolTip().SetToolTip(pictureBox, item.Name == null ? "???" : item.Name);
        Label itemName = new Label()
        {
          Text = item.Name == null ? "???" : item.Name,
          TextAlign = ContentAlignment.MiddleCenter,
          Dock = DockStyle.Bottom,
          BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0),
          ForeColor = System.Drawing.Color.White
        };
        itemBackground.Controls.Add(itemName);

        itemBackground.SizeChanged += (sender, ev) =>
        {
          ((Panel)sender).Width = ((Panel)sender).Height;
        };
        pictureBox.MouseEnter += (sender, ev) =>
        {
          ((PictureBox)sender).BackColor = System.Drawing.Color.White;
        };
        pictureBox.MouseLeave += (sender, ev) =>
        {
          ((PictureBox)sender).BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
        };
        pictureBox.Click += delegate (object sender, EventArgs ev)
        {
          ClickOnItem(sender, ev, item);
        };
      }
    }

    private void ClickOnItem(object sender, EventArgs ev, BaseFile item)
    {
      if (!MapEditor.IsLoaded) return;
      if (MapEditor.IsDragging)
      {
        MapEditor.IsDragging = false;
        MapEditor.ItemInQueue = null;
        return;
      }
      MapEditorButton.PerformClick();
      MapEditor.IsDragging = true;
      MapEditor.ItemInQueue = item;
    }
  }
}
