using DreamlandEditor.Controls.Editors;
using DreamlandEditor.Data;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.ExtensionClasses;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using Microsoft.Xna.Framework;
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
		private bool IsDragging = false;
		private UiPanel WorkArea;
		private UiPanel MiscPanel;
		private UiPanel ItemsPanel;
		private ComboBox TypeDropdown;
		private readonly string rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Objects");

		public ItemExplorer()
		{
			InitializeComponent();
			SetupLayout(DockStyle.Top);
			SetupPanels();
		}

		public void SetRenderWindow(MapEditor renderWindow, WindowChangeButton mapEditorButton)
		{
			MapEditor = renderWindow;
			MapEditor.MouseClick += RemoveItem;
			MapEditorButton = mapEditorButton;
		}

		private void SetupPanels()
		{
			WorkArea = new UiPanel(){Dock = DockStyle.Fill};
			Controls.Add(WorkArea);

			ItemsPanel = new UiPanel() { Dock = DockStyle.Fill };
			WorkArea.Controls.Add(ItemsPanel);
			ItemsPanel.HorizontalScroll.Enabled = true;
			ItemsPanel.VerticalScroll.Enabled = false;

			MiscPanel = new UiPanel()
			{
				Dock = DockStyle.Top,
				Height = 23,
			};
			WorkArea.Controls.Add(MiscPanel);

			SetupChangeTypeCombobox();
			SetupItems(ItemsPanel, ItemsManager.WorldObjects);
		}
		private void SetupChangeTypeCombobox()
		{
			TypeDropdown = new ComboBox()
			{
				FlatStyle = FlatStyle.Flat,
				DropDownStyle = ComboBoxStyle.DropDownList,
				Dock = DockStyle.Left,
				Width = 200,
			};
			MiscPanel.Controls.Add(TypeDropdown);

			List<string> dropdownTypes = new List<string>() { "All" };
			DirectoryInfo directory = new DirectoryInfo(rootPath);
			string directoryName = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Objects");
			dropdownTypes.AddRange(DirectoryManager.GetDirectoryNamesOnThatLevel(directoryName));
			

			TypeDropdown.DataSource = dropdownTypes;

			TypeDropdown.SelectedValueChanged += (sender, ev) =>
			{
				string selectedValue = ((ListControl)sender).SelectedValue.ToString();
				if(selectedValue.Equals("All"))
				{
					SetupItems(ItemsPanel, ItemsManager.WorldObjects);
					return;
				}
				string path = Path.Combine(rootPath, selectedValue);
				ICollection<WorldObject> filteredItems = ItemsManager.FilterByObjectType(selectedValue);
				SetupItems(ItemsPanel, filteredItems);
			};
		}

		private void SetupItems(UiPanel itemsPanel, ICollection<WorldObject> items)
		{
			itemsPanel.Controls.Clear();
			foreach (IBaseFile item in items)
			{
				if(item == null)
                {
					continue;
                }
				Panel itemBackground = new Panel()
				{
					Dock = DockStyle.Left,
					BorderStyle = BorderStyle.FixedSingle,
					Width = Height,
					BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0)
				};
				itemsPanel.Controls.Add(itemBackground);
				PictureBox pictureBox = new PictureBox()
				{
					Dock = DockStyle.Fill,
					SizeMode = PictureBoxSizeMode.CenterImage,
				};
				pictureBox.Image = (item.ImagePath == null ?
						new Bitmap(@"../../Content/not-found.png") :
						new Bitmap(item.ImagePath));
				itemBackground.Controls.Add(pictureBox);
				Label itemName = new Label()
				{
					Text = (item.Name == null ? "???" : item.Name),
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
				pictureBox.Click += delegate(object sender, EventArgs ev)
                {
					ClickOnItem(sender, ev, item);
                };
			}
		}

		private void ClickOnItem(object sender, EventArgs ev, IBaseFile item)
		{
			if (!MapEditor.IsLoaded) return;
			if (IsDragging)
			{
				IsDragging = false;
				MapEditor.ItemInQueue = null;
				return;
			}
			MapEditorButton.PerformClick();
			IsDragging = true;
			MapEditor.ItemInQueue = item;
		}
		public void RemoveItem(object sender, MouseEventArgs ev)
		{
			if(ev.Button == MouseButtons.Right)
			{
				IsDragging = false;
				MapEditor.ItemInQueue = null;
				return;
			}else if (ev.Button == MouseButtons.Left)
            {
				if (MapEditor.ItemInQueue == null) return;
				Vector2 mousePosition = new Vector2(MapEditor.GetMousePosition().X, MapEditor.GetMousePosition().Y);
				Vector2 relativeMousePosition = Vector2.Transform(mousePosition, Matrix.Invert(MapEditor.Camera.Transform));
				MapEditor.ItemInQueue.Position = new System.Drawing.Point((int)relativeMousePosition.X, (int)relativeMousePosition.Y);
				WorldObject newItem = (WorldObject)MapEditor.ItemInQueue.Clone();
				MapEditor.MapFile.WorldObjects.Add(newItem);
			}
		}
	}
}
