
namespace MonoGame.Forms.DX {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
			this.PanelNavbar = new System.Windows.Forms.Panel();
			this.ButtonSaveNavbutton = new ProjectDreamland.UI.UIButtons.NavigationButton();
			this.PanelSwitchWorkWindows = new System.Windows.Forms.Panel();
			this.ButtonSwitchToCharacterEditor = new ProjectDreamland.UI.UIButtons.WindowChangeButton();
			this.ButtonSwitchToWorldObjectEditor = new ProjectDreamland.UI.UIButtons.WindowChangeButton();
			this.ButtonSwitchToMapEditor = new ProjectDreamland.UI.UIButtons.WindowChangeButton();
			this.PanelWorkArea = new System.Windows.Forms.Panel();
			this.MapEditor = new ProjectDreamland.Controls.Editors.MapEditor();
			this.FileExplorer = new ProjectDreamland.UI.FileExplorer();
			this.ItemExplorer = new ProjectDreamland.UI.ItemExplorer();
			this.LabelZoomAmount = new System.Windows.Forms.Label();
			this.LabelCursorPosition = new System.Windows.Forms.Label();
			this.PanelNavbar.SuspendLayout();
			this.PanelSwitchWorkWindows.SuspendLayout();
			this.PanelWorkArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelNavbar
			// 
			this.PanelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.PanelNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelNavbar.Controls.Add(this.LabelCursorPosition);
			this.PanelNavbar.Controls.Add(this.LabelZoomAmount);
			this.PanelNavbar.Controls.Add(this.ButtonSaveNavbutton);
			this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelNavbar.Location = new System.Drawing.Point(0, 0);
			this.PanelNavbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PanelNavbar.Name = "PanelNavbar";
			this.PanelNavbar.Size = new System.Drawing.Size(1579, 30);
			this.PanelNavbar.TabIndex = 1;
			// 
			// ButtonSaveNavbutton
			// 
			this.ButtonSaveNavbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.ButtonSaveNavbutton.ButtonFor = null;
			this.ButtonSaveNavbutton.Dock = System.Windows.Forms.DockStyle.Left;
			this.ButtonSaveNavbutton.FlatAppearance.BorderSize = 0;
			this.ButtonSaveNavbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.ButtonSaveNavbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
			this.ButtonSaveNavbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSaveNavbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.ButtonSaveNavbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ButtonSaveNavbutton.Location = new System.Drawing.Point(0, 0);
			this.ButtonSaveNavbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ButtonSaveNavbutton.Name = "ButtonSaveNavbutton";
			this.ButtonSaveNavbutton.Size = new System.Drawing.Size(67, 28);
			this.ButtonSaveNavbutton.TabIndex = 0;
			this.ButtonSaveNavbutton.Text = "Save";
			this.ButtonSaveNavbutton.UseVisualStyleBackColor = false;
			// 
			// PanelSwitchWorkWindows
			// 
			this.PanelSwitchWorkWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.PanelSwitchWorkWindows.Controls.Add(this.ButtonSwitchToCharacterEditor);
			this.PanelSwitchWorkWindows.Controls.Add(this.ButtonSwitchToWorldObjectEditor);
			this.PanelSwitchWorkWindows.Controls.Add(this.ButtonSwitchToMapEditor);
			this.PanelSwitchWorkWindows.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelSwitchWorkWindows.Location = new System.Drawing.Point(0, 0);
			this.PanelSwitchWorkWindows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PanelSwitchWorkWindows.Name = "PanelSwitchWorkWindows";
			this.PanelSwitchWorkWindows.Size = new System.Drawing.Size(1313, 31);
			this.PanelSwitchWorkWindows.TabIndex = 1;
			// 
			// ButtonSwitchToCharacterEditor
			// 
			this.ButtonSwitchToCharacterEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.ButtonSwitchToCharacterEditor.ButtonFor = null;
			this.ButtonSwitchToCharacterEditor.Dock = System.Windows.Forms.DockStyle.Left;
			this.ButtonSwitchToCharacterEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.ButtonSwitchToCharacterEditor.FlatAppearance.BorderSize = 0;
			this.ButtonSwitchToCharacterEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
			this.ButtonSwitchToCharacterEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.ButtonSwitchToCharacterEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSwitchToCharacterEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.ButtonSwitchToCharacterEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ButtonSwitchToCharacterEditor.Location = new System.Drawing.Point(274, 0);
			this.ButtonSwitchToCharacterEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ButtonSwitchToCharacterEditor.Name = "ButtonSwitchToCharacterEditor";
			this.ButtonSwitchToCharacterEditor.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.ButtonSwitchToCharacterEditor.Size = new System.Drawing.Size(144, 31);
			this.ButtonSwitchToCharacterEditor.TabIndex = 2;
			this.ButtonSwitchToCharacterEditor.Text = "Character Editor";
			this.ButtonSwitchToCharacterEditor.UseVisualStyleBackColor = false;
			// 
			// ButtonSwitchToWorldObjectEditor
			// 
			this.ButtonSwitchToWorldObjectEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.ButtonSwitchToWorldObjectEditor.ButtonFor = null;
			this.ButtonSwitchToWorldObjectEditor.Dock = System.Windows.Forms.DockStyle.Left;
			this.ButtonSwitchToWorldObjectEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.ButtonSwitchToWorldObjectEditor.FlatAppearance.BorderSize = 0;
			this.ButtonSwitchToWorldObjectEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
			this.ButtonSwitchToWorldObjectEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.ButtonSwitchToWorldObjectEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSwitchToWorldObjectEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.ButtonSwitchToWorldObjectEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ButtonSwitchToWorldObjectEditor.Location = new System.Drawing.Point(147, 0);
			this.ButtonSwitchToWorldObjectEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ButtonSwitchToWorldObjectEditor.Name = "ButtonSwitchToWorldObjectEditor";
			this.ButtonSwitchToWorldObjectEditor.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.ButtonSwitchToWorldObjectEditor.Size = new System.Drawing.Size(127, 31);
			this.ButtonSwitchToWorldObjectEditor.TabIndex = 1;
			this.ButtonSwitchToWorldObjectEditor.Text = "World Object Editor";
			this.ButtonSwitchToWorldObjectEditor.UseVisualStyleBackColor = false;
			// 
			// ButtonSwitchToMapEditor
			// 
			this.ButtonSwitchToMapEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.ButtonSwitchToMapEditor.ButtonFor = null;
			this.ButtonSwitchToMapEditor.Dock = System.Windows.Forms.DockStyle.Left;
			this.ButtonSwitchToMapEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.ButtonSwitchToMapEditor.FlatAppearance.BorderSize = 0;
			this.ButtonSwitchToMapEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
			this.ButtonSwitchToMapEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.ButtonSwitchToMapEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSwitchToMapEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.ButtonSwitchToMapEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ButtonSwitchToMapEditor.Location = new System.Drawing.Point(0, 0);
			this.ButtonSwitchToMapEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ButtonSwitchToMapEditor.Name = "ButtonSwitchToMapEditor";
			this.ButtonSwitchToMapEditor.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.ButtonSwitchToMapEditor.Size = new System.Drawing.Size(147, 31);
			this.ButtonSwitchToMapEditor.TabIndex = 0;
			this.ButtonSwitchToMapEditor.Text = "Render Window";
			this.ButtonSwitchToMapEditor.UseVisualStyleBackColor = false;
			// 
			// PanelWorkArea
			// 
			this.PanelWorkArea.Controls.Add(this.MapEditor);
			this.PanelWorkArea.Controls.Add(this.PanelSwitchWorkWindows);
			this.PanelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelWorkArea.Location = new System.Drawing.Point(266, 30);
			this.PanelWorkArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PanelWorkArea.Name = "PanelWorkArea";
			this.PanelWorkArea.Size = new System.Drawing.Size(1313, 634);
			this.PanelWorkArea.TabIndex = 4;
			// 
			// MapEditor
			// 
			this.MapEditor.AllowDrop = true;
			this.MapEditor.Camera = null;
			this.MapEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MapEditor.EditorFor = "Map";
			this.MapEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MapEditor.IsCollisionDrawn = false;
			this.MapEditor.IsDragging = false;
			this.MapEditor.IsLoaded = false;
			this.MapEditor.ItemInQueue = null;
			this.MapEditor.CursorPositionLabel = null;
			this.MapEditor.Location = new System.Drawing.Point(0, 31);
			this.MapEditor.MapFile = null;
			this.MapEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MapEditor.MouseHoverUpdatesOnly = false;
			this.MapEditor.Name = "MapEditor";
			this.MapEditor.Size = new System.Drawing.Size(1313, 603);
			this.MapEditor.TabIndex = 0;
			this.MapEditor.Text = "Sample Control";
			// 
			// FileExplorer
			// 
			this.FileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.FileExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Left;
			this.FileExplorer.Location = new System.Drawing.Point(0, 30);
			this.FileExplorer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FileExplorer.MaximumSize = new System.Drawing.Size(533, 1230);
			this.FileExplorer.MinimumSize = new System.Drawing.Size(199, 2);
			this.FileExplorer.Name = "FileExplorer";
			this.FileExplorer.Size = new System.Drawing.Size(266, 634);
			this.FileExplorer.TabIndex = 1;
			// 
			// ItemExplorer
			// 
			this.ItemExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.ItemExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ItemExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ItemExplorer.Location = new System.Drawing.Point(0, 664);
			this.ItemExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ItemExplorer.MaximumSize = new System.Drawing.Size(1999, 251);
			this.ItemExplorer.MinimumSize = new System.Drawing.Size(2, 100);
			this.ItemExplorer.Name = "ItemExplorer";
			this.ItemExplorer.Size = new System.Drawing.Size(1579, 150);
			this.ItemExplorer.TabIndex = 2;
			// 
			// LabelZoomAmount
			// 
			this.LabelZoomAmount.Dock = System.Windows.Forms.DockStyle.Right;
			this.LabelZoomAmount.ForeColor = System.Drawing.Color.White;
			this.LabelZoomAmount.Location = new System.Drawing.Point(1527, 0);
			this.LabelZoomAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelZoomAmount.Name = "LabelZoomAmount";
			this.LabelZoomAmount.Size = new System.Drawing.Size(50, 28);
			this.LabelZoomAmount.TabIndex = 2;
			this.LabelZoomAmount.Text = "100%";
			this.LabelZoomAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelCursorPosition
			// 
			this.LabelCursorPosition.Dock = System.Windows.Forms.DockStyle.Right;
			this.LabelCursorPosition.ForeColor = System.Drawing.Color.White;
			this.LabelCursorPosition.Location = new System.Drawing.Point(1434, 0);
			this.LabelCursorPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelCursorPosition.Name = "LabelCursorPosition";
			this.LabelCursorPosition.Size = new System.Drawing.Size(93, 28);
			this.LabelCursorPosition.TabIndex = 3;
			this.LabelCursorPosition.Text = "X:0 - Y:0";
			this.LabelCursorPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1579, 814);
			this.Controls.Add(this.PanelWorkArea);
			this.Controls.Add(this.FileExplorer);
			this.Controls.Add(this.ItemExplorer);
			this.Controls.Add(this.PanelNavbar);
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dreamland Editor";
			this.PanelNavbar.ResumeLayout(false);
			this.PanelSwitchWorkWindows.ResumeLayout(false);
			this.PanelWorkArea.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private ProjectDreamland.Controls.Editors.MapEditor MapEditor;
        private System.Windows.Forms.Panel PanelNavbar;
        private ProjectDreamland.UI.FileExplorer FileExplorer;
        private ProjectDreamland.UI.UIButtons.NavigationButton ButtonSaveNavbutton;
        private System.Windows.Forms.Panel PanelSwitchWorkWindows;
        private ProjectDreamland.UI.UIButtons.WindowChangeButton ButtonSwitchToCharacterEditor;
        private ProjectDreamland.UI.UIButtons.WindowChangeButton ButtonSwitchToWorldObjectEditor;
        private ProjectDreamland.UI.UIButtons.WindowChangeButton ButtonSwitchToMapEditor;
        private System.Windows.Forms.Panel PanelWorkArea;
		private ProjectDreamland.UI.ItemExplorer ItemExplorer;
		private System.Windows.Forms.Label LabelCursorPosition;
		private System.Windows.Forms.Label LabelZoomAmount;
	}
}

