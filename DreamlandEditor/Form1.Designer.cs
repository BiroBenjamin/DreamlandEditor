
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
            this.PanelWorkArea = new System.Windows.Forms.Panel();
            this.PanelSwitchEditorWindows = new System.Windows.Forms.Panel();
            this.sampleControl = new DreamlandEditor.Controls.SampleControl();
            this.FileExplorer = new DreamlandEditor.UI.FileExplorer();
            this.PanelItemExplorer = new DreamlandEditor.UI.UIPanels.ResizablePanel();
            this.ButtonFileNavbutton = new DreamlandEditor.UI.UIButtons.NavigationButton();
            this.ButtonSwitchToRenderWindow = new DreamlandEditor.UI.UIButtons.WindowChangeButton();
            this.ButtonSwitchToItemEditor = new DreamlandEditor.UI.UIButtons.WindowChangeButton();
            this.ButtonSwitchToCharacterEditor = new DreamlandEditor.UI.UIButtons.WindowChangeButton();
            this.PanelNavbar.SuspendLayout();
            this.PanelWorkArea.SuspendLayout();
            this.PanelSwitchEditorWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelNavbar
            // 
            this.PanelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNavbar.Controls.Add(this.ButtonFileNavbutton);
            this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavbar.Location = new System.Drawing.Point(0, 0);
            this.PanelNavbar.Name = "PanelNavbar";
            this.PanelNavbar.Size = new System.Drawing.Size(1184, 25);
            this.PanelNavbar.TabIndex = 1;
            // 
            // PanelWorkArea
            // 
            this.PanelWorkArea.Controls.Add(this.sampleControl);
            this.PanelWorkArea.Controls.Add(this.PanelSwitchEditorWindows);
            this.PanelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWorkArea.Location = new System.Drawing.Point(200, 25);
            this.PanelWorkArea.Name = "PanelWorkArea";
            this.PanelWorkArea.Size = new System.Drawing.Size(984, 536);
            this.PanelWorkArea.TabIndex = 3;
            // 
            // PanelSwitchEditorWindows
            // 
            this.PanelSwitchEditorWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelSwitchEditorWindows.Controls.Add(this.ButtonSwitchToCharacterEditor);
            this.PanelSwitchEditorWindows.Controls.Add(this.ButtonSwitchToItemEditor);
            this.PanelSwitchEditorWindows.Controls.Add(this.ButtonSwitchToRenderWindow);
            this.PanelSwitchEditorWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSwitchEditorWindows.Location = new System.Drawing.Point(0, 0);
            this.PanelSwitchEditorWindows.Name = "PanelSwitchEditorWindows";
            this.PanelSwitchEditorWindows.Size = new System.Drawing.Size(984, 25);
            this.PanelSwitchEditorWindows.TabIndex = 1;
            // 
            // sampleControl
            // 
            this.sampleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleControl.Location = new System.Drawing.Point(0, 25);
            this.sampleControl.Margin = new System.Windows.Forms.Padding(2);
            this.sampleControl.MouseHoverUpdatesOnly = false;
            this.sampleControl.Name = "sampleControl";
            this.sampleControl.Size = new System.Drawing.Size(984, 511);
            this.sampleControl.TabIndex = 0;
            this.sampleControl.Text = "Sample Control";
            // 
            // FileExplorer
            // 
            this.FileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FileExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileExplorer.Location = new System.Drawing.Point(0, 25);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(200, 536);
            this.FileExplorer.TabIndex = 1;
            // 
            // PanelItemExplorer
            // 
            this.PanelItemExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelItemExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelItemExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelItemExplorer.Location = new System.Drawing.Point(0, 561);
            this.PanelItemExplorer.Name = "PanelItemExplorer";
            this.PanelItemExplorer.Size = new System.Drawing.Size(1184, 100);
            this.PanelItemExplorer.TabIndex = 2;
            // 
            // ButtonFileNavbutton
            // 
            this.ButtonFileNavbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonFileNavbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFileNavbutton.FlatAppearance.BorderSize = 0;
            this.ButtonFileNavbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ButtonFileNavbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ButtonFileNavbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFileNavbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonFileNavbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonFileNavbutton.Location = new System.Drawing.Point(0, 0);
            this.ButtonFileNavbutton.Name = "ButtonFileNavbutton";
            this.ButtonFileNavbutton.Size = new System.Drawing.Size(50, 23);
            this.ButtonFileNavbutton.TabIndex = 0;
            this.ButtonFileNavbutton.Text = "File";
            this.ButtonFileNavbutton.UseVisualStyleBackColor = false;
            // 
            // ButtonSwitchToRenderWindow
            // 
            this.ButtonSwitchToRenderWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonSwitchToRenderWindow.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSwitchToRenderWindow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ButtonSwitchToRenderWindow.FlatAppearance.BorderSize = 0;
            this.ButtonSwitchToRenderWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ButtonSwitchToRenderWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ButtonSwitchToRenderWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSwitchToRenderWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSwitchToRenderWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonSwitchToRenderWindow.Location = new System.Drawing.Point(0, 0);
            this.ButtonSwitchToRenderWindow.Name = "ButtonSwitchToRenderWindow";
            this.ButtonSwitchToRenderWindow.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ButtonSwitchToRenderWindow.Size = new System.Drawing.Size(75, 25);
            this.ButtonSwitchToRenderWindow.TabIndex = 0;
            this.ButtonSwitchToRenderWindow.Text = "Render Window";
            this.ButtonSwitchToRenderWindow.UseVisualStyleBackColor = false;
            // 
            // ButtonSwitchToItemEditor
            // 
            this.ButtonSwitchToItemEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonSwitchToItemEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSwitchToItemEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ButtonSwitchToItemEditor.FlatAppearance.BorderSize = 0;
            this.ButtonSwitchToItemEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ButtonSwitchToItemEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ButtonSwitchToItemEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSwitchToItemEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSwitchToItemEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonSwitchToItemEditor.Location = new System.Drawing.Point(75, 0);
            this.ButtonSwitchToItemEditor.Name = "ButtonSwitchToItemEditor";
            this.ButtonSwitchToItemEditor.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ButtonSwitchToItemEditor.Size = new System.Drawing.Size(75, 25);
            this.ButtonSwitchToItemEditor.TabIndex = 1;
            this.ButtonSwitchToItemEditor.Text = "Item Editor";
            this.ButtonSwitchToItemEditor.UseVisualStyleBackColor = false;
            // 
            // ButtonSwitchToCharacterEditor
            // 
            this.ButtonSwitchToCharacterEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonSwitchToCharacterEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSwitchToCharacterEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ButtonSwitchToCharacterEditor.FlatAppearance.BorderSize = 0;
            this.ButtonSwitchToCharacterEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ButtonSwitchToCharacterEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ButtonSwitchToCharacterEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSwitchToCharacterEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSwitchToCharacterEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonSwitchToCharacterEditor.Location = new System.Drawing.Point(150, 0);
            this.ButtonSwitchToCharacterEditor.Name = "ButtonSwitchToCharacterEditor";
            this.ButtonSwitchToCharacterEditor.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ButtonSwitchToCharacterEditor.Size = new System.Drawing.Size(75, 25);
            this.ButtonSwitchToCharacterEditor.TabIndex = 2;
            this.ButtonSwitchToCharacterEditor.Text = "Character Editor";
            this.ButtonSwitchToCharacterEditor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PanelWorkArea);
            this.Controls.Add(this.FileExplorer);
            this.Controls.Add(this.PanelItemExplorer);
            this.Controls.Add(this.PanelNavbar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dreamland Editor";
            this.PanelNavbar.ResumeLayout(false);
            this.PanelWorkArea.ResumeLayout(false);
            this.PanelSwitchEditorWindows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DreamlandEditor.Controls.SampleControl sampleControl;
        private System.Windows.Forms.Panel PanelNavbar;
        private DreamlandEditor.UI.UIPanels.ResizablePanel PanelItemExplorer;
        private System.Windows.Forms.Panel PanelWorkArea;
        private DreamlandEditor.UI.FileExplorer FileExplorer;
        private DreamlandEditor.UI.UIButtons.NavigationButton ButtonFileNavbutton;
        private System.Windows.Forms.Panel PanelSwitchEditorWindows;
        private DreamlandEditor.UI.UIButtons.WindowChangeButton ButtonSwitchToCharacterEditor;
        private DreamlandEditor.UI.UIButtons.WindowChangeButton ButtonSwitchToItemEditor;
        private DreamlandEditor.UI.UIButtons.WindowChangeButton ButtonSwitchToRenderWindow;
    }
}

