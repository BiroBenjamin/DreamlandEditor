using DreamlandEditor.Controls;
using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using DreamlandEditor.UI.UIButtons;
using DreamlandEditor.UI.UIPanels;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DreamlandEditor.UI
{
	public partial class ItemExplorer : ResizablePanel
	{
		private WindowChangeButton MapEditorButton;
		private MapEditor MapEditor;
		private PictureBox DraggedImage;
		private System.Drawing.Point DraggedImageOffset;
		private bool IsDragging = false;

		private UiPanel WorkArea;
		private UiPanel ChangeTypePanel;
		private UiPanel ItemsPanel;

		private ComboBox TypeDropdown;
		private readonly string rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Objects");
		
		public ItemExplorer()
		{
			DraggedImageOffset = new System.Drawing.Point(5, 8);

			InitializeComponent();
			SetupLayout(DockStyle.Top);

			SetupPanels();
		}

		public void SetRenderWindow(MapEditor renderWindow, WindowChangeButton mapEditorButton, PictureBox draggedImage)
		{
			MapEditor = renderWindow;
			MapEditor.MouseMove += MoveItem;
			MapEditor.MouseClick += RemoveItem;
			MapEditorButton = mapEditorButton;
			DraggedImage = draggedImage;
			DraggedImage.Size = new Size(64, 64);
		}

		private void SetupPanels()
		{
			WorkArea = new UiPanel(){Dock = DockStyle.Fill};
			Controls.Add(WorkArea);

			ItemsPanel = new UiPanel() { Dock = DockStyle.Fill };
			WorkArea.Controls.Add(ItemsPanel);
			ItemsPanel.HorizontalScroll.Enabled = true;
			ItemsPanel.VerticalScroll.Enabled = false;

			ChangeTypePanel = new UiPanel()
			{
				Dock = DockStyle.Top,
				Height = 30,
			};
			WorkArea.Controls.Add(ChangeTypePanel);

			SetupChangeTypeCombobox();
			SetupItems(ItemsPanel, ItemsManager.Items);
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
			ChangeTypePanel.Controls.Add(TypeDropdown);

			List<string> dropdownTypes = new List<string>() { "All" };
			DirectoryInfo directory = new DirectoryInfo(rootPath);
			CycleDirectories(directory, dropdownTypes);

			TypeDropdown.DataSource = dropdownTypes;

			TypeDropdown.SelectedValueChanged += (sender, ev) =>
			{
				string selectedValue = ((ListControl)sender).SelectedValue.ToString();
				DebugManager.Log(((ListControl)sender).SelectedValue.ToString());
				if(selectedValue.Equals("All"))
				{
					SetupItems(ItemsPanel, ItemsManager.Items);
					return;
				}
				string path = Path.Combine(rootPath, selectedValue);
				var filteredItems = ItemsManager.Items.Where(x => x.FilePath.StartsWith(path)).ToList();
				SetupItems(ItemsPanel, filteredItems);
			};
		}
		private void CycleDirectories(DirectoryInfo directory, List<string> dropdownTypes)
		{
			foreach (DirectoryInfo dir in directory.GetDirectories())
			{
				if (dir.GetDirectories().Length == 0)
				{
					dropdownTypes.Add(dir.FullName.Remove(0, rootPath.Length + 1));
					if (dir.GetFiles().Length != 0) 
					{
						ItemsManager.Items.AddRange(CycleFiles(dir));
					}

					continue;
				}
				CycleDirectories(dir, dropdownTypes);
			}
		}
		private List<BaseFile> CycleFiles(DirectoryInfo folder)
		{
			List<BaseFile> files = new List<BaseFile>();
			foreach(FileInfo file in folder.GetFiles())
			{
				if (!SystemPrefsManager.SystemPrefs.extensions.Contains(file.Extension.Remove(0, 1))) continue;
				string fileName = Path.Combine(folder.FullName, file.Name);
				files.Add(FileManager<WorldObject>.LoadFile(fileName));
			}

			return files;
		}

		private void SetupItems(UiPanel itemsPanel, List<BaseFile> items)
		{
			itemsPanel.Controls.Clear();
			foreach (BaseFile item in items)
			{
				PictureBox pictureBox = new PictureBox()
				{
					Dock = DockStyle.Left,
					BorderStyle = BorderStyle.FixedSingle,
					Width = Height,
					SizeMode = PictureBoxSizeMode.Zoom,
				};
                try
                {
					pictureBox.Image = item.ImagePath == null ? null : new Bitmap(item.ImagePath);
                }
                catch
                {
					DebugManager.Log($"Could not find the image for {item.ID}");
                }

				pictureBox.SizeChanged += (sender, ev) =>
				{
					((PictureBox)sender).Width = ((PictureBox)sender).Height;
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

				itemsPanel.Controls.Add(pictureBox);
			}
		}

		private void ClickOnItem(object sender, EventArgs ev, BaseFile item)
		{
			if (!MapEditor.IsLoaded) return;
			if (IsDragging)
			{
				IsDragging = false;
				DraggedImage.Visible = false;
				MapEditor.ItemInQueue = null;
				return;
			}
			MapEditorButton.PerformClick();
			DraggedImage.Image = ((PictureBox)sender).Image;
			DraggedImage.SizeMode = PictureBoxSizeMode.Zoom;
			IsDragging = true;
			MapEditor.ItemInQueue = item;
		}
		public void MoveItem(object sender, MouseEventArgs ev)
		{
			if (!IsDragging) return;
			DraggedImage.Visible = true;
			DraggedImage.BringToFront();
			DraggedImage.Top = ev.Y + DraggedImageOffset.Y;
			DraggedImage.Left = ev.X + DraggedImageOffset.X;
		}
		public void RemoveItem(object sender, MouseEventArgs ev)
		{
			if(ev.Button == MouseButtons.Right)
			{
				IsDragging = false;
				DraggedImage.Visible = false;
				MapEditor.ItemInQueue = null;
				return;
			}else if (ev.Button == MouseButtons.Left)
            {
				Vector2 mousePosition = new Vector2(MapEditor.GetMousePosition().X, MapEditor.GetMousePosition().Y);
				var relativeMousePosition = Vector2.Transform(mousePosition, Matrix.Invert(MapEditor.TransformMatrix));
				DebugManager.Log($"{mousePosition.ToPoint()} --> {relativeMousePosition.ToPoint()}");
			}
		}
	}
}
