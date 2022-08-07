using DreamlandEditor.Controls;
using DreamlandEditor.Data;
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
		private SampleControl MapEditor;
		private bool IsDragging = false;

		private UiPanel WorkArea;
		private UiPanel ChangeTypePanel;
		private UiPanel ItemsPanel;

		private ComboBox TypeDropdown;
		private readonly string rootPath = Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Objects");
		private List<BaseFile> Items = new List<BaseFile>();
		
		public ItemExplorer()
		{
			InitializeComponent();
			SetupLayout(DockStyle.Top);

			SetupPanels();
		}

		public void SetRenderWindow(SampleControl renderWindow, WindowChangeButton mapEditorButton)
		{
			MapEditor = renderWindow;
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

			ChangeTypePanel = new UiPanel()
			{
				Dock = DockStyle.Top,
				Height = 30,
			};
			WorkArea.Controls.Add(ChangeTypePanel);

			SetupChangeTypeCombobox();
			SetupItems(ItemsPanel, Items);
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
					SetupItems(ItemsPanel, Items);
					return;
				}
				string path = Path.Combine(rootPath, selectedValue);
				var filteredItems = Items.Where(x => x.FilePath.StartsWith(path)).ToList();
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
						Items.AddRange(CycleFiles(dir));
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
				Bitmap image = item.ImagePath == null ? null : new Bitmap(item.ImagePath);
				PictureBox pictureBox = new PictureBox()
				{
					Dock = DockStyle.Left,
					Image = image,
					BorderStyle = BorderStyle.FixedSingle,
					Width = Height,
					SizeMode = PictureBoxSizeMode.Zoom,
				};

				pictureBox.SizeChanged += (sender, ev) =>
				{
					((PictureBox)sender).Width = ((PictureBox)sender).Height;
				};
				pictureBox.MouseEnter += (sender, ev) =>
				{
					((PictureBox)sender).BackColor = Color.White;
				};
				pictureBox.MouseLeave += (sender, ev) =>
				{
					((PictureBox)sender).BackColor = Color.FromArgb(0, 0, 0, 0);
				};
				pictureBox.Click += ClickOnItem;

				itemsPanel.Controls.Add(pictureBox);
			}
		}

		private void ClickOnItem(object sender, EventArgs ev)
		{
			if (IsDragging)
			{
				IsDragging = false;
				return;
			}
			MapEditorButton.PerformClick();
			IsDragging = true;
		}
	}
}
