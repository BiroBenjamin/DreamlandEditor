
namespace MonoGame.Forms.DX {
    partial class MainWindow {
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
            this.ButtonNavbarFile = new DreamlandEditor.UI.UIButtons.NavigatonButton();
            this.PanelWorkArea = new System.Windows.Forms.Panel();
            this.PanelWindowSwitcher = new System.Windows.Forms.Panel();
            this.ButtonSwitchToCharacterCreator = new DreamlandEditor.UI.UIButtons.WindowChangeButton();
            this.ButtonSwitchToItemCreator = new DreamlandEditor.UI.UIButtons.WindowChangeButton();
            this.ButtonSwitchToRenderWindow = new DreamlandEditor.UI.UIButtons.WindowChangeButton();
            this.MonoRenderWindow = new MonoGame.Forms.DX.Controls.SampleControl();
            this.PanelItemExplorer = new DreamlandEditor.UI.UIPanels.ResizablePanel();
            this.PanelFileExplorer = new DreamlandEditor.UI.UIPanels.ResizablePanel();
            this.FileExplorer = new DreamlandEditor.UI.FileExplorer();
            this.PanelNavbar.SuspendLayout();
            this.PanelWorkArea.SuspendLayout();
            this.PanelWindowSwitcher.SuspendLayout();
            this.PanelFileExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelNavbar
            // 
            this.PanelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNavbar.Controls.Add(this.ButtonNavbarFile);
            this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavbar.Location = new System.Drawing.Point(0, 0);
            this.PanelNavbar.Name = "PanelNavbar";
            this.PanelNavbar.Size = new System.Drawing.Size(1184, 29);
            this.PanelNavbar.TabIndex = 3;
            // 
            // ButtonNavbarFile
            // 
            this.ButtonNavbarFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonNavbarFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonNavbarFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNavbarFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonNavbarFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonNavbarFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonNavbarFile.Name = "ButtonNavbarFile";
            this.ButtonNavbarFile.Size = new System.Drawing.Size(50, 27);
            this.ButtonNavbarFile.TabIndex = 0;
            this.ButtonNavbarFile.Text = "File";
            this.ButtonNavbarFile.UseVisualStyleBackColor = false;
            // 
            // PanelWorkArea
            // 
            this.PanelWorkArea.Controls.Add(this.PanelWindowSwitcher);
            this.PanelWorkArea.Controls.Add(this.MonoRenderWindow);
            this.PanelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWorkArea.Location = new System.Drawing.Point(200, 29);
            this.PanelWorkArea.Name = "PanelWorkArea";
            this.PanelWorkArea.Size = new System.Drawing.Size(984, 602);
            this.PanelWorkArea.TabIndex = 6;
            // 
            // PanelWindowSwitcher
            // 
            this.PanelWindowSwitcher.Controls.Add(this.ButtonSwitchToCharacterCreator);
            this.PanelWindowSwitcher.Controls.Add(this.ButtonSwitchToItemCreator);
            this.PanelWindowSwitcher.Controls.Add(this.ButtonSwitchToRenderWindow);
            this.PanelWindowSwitcher.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelWindowSwitcher.Location = new System.Drawing.Point(0, 0);
            this.PanelWindowSwitcher.Name = "PanelWindowSwitcher";
            this.PanelWindowSwitcher.Size = new System.Drawing.Size(984, 23);
            this.PanelWindowSwitcher.TabIndex = 1;
            // 
            // ButtonSwitchToCharacterCreator
            // 
            this.ButtonSwitchToCharacterCreator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonSwitchToCharacterCreator.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSwitchToCharacterCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSwitchToCharacterCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSwitchToCharacterCreator.ForeColor = System.Drawing.Color.White;
            this.ButtonSwitchToCharacterCreator.Location = new System.Drawing.Point(150, 0);
            this.ButtonSwitchToCharacterCreator.Name = "ButtonSwitchToCharacterCreator";
            this.ButtonSwitchToCharacterCreator.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ButtonSwitchToCharacterCreator.Size = new System.Drawing.Size(75, 23);
            this.ButtonSwitchToCharacterCreator.TabIndex = 2;
            this.ButtonSwitchToCharacterCreator.Text = "Character Creator";
            this.ButtonSwitchToCharacterCreator.UseVisualStyleBackColor = true;
            // 
            // ButtonSwitchToItemCreator
            // 
            this.ButtonSwitchToItemCreator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonSwitchToItemCreator.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSwitchToItemCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSwitchToItemCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSwitchToItemCreator.ForeColor = System.Drawing.Color.White;
            this.ButtonSwitchToItemCreator.Location = new System.Drawing.Point(75, 0);
            this.ButtonSwitchToItemCreator.Name = "ButtonSwitchToItemCreator";
            this.ButtonSwitchToItemCreator.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ButtonSwitchToItemCreator.Size = new System.Drawing.Size(75, 23);
            this.ButtonSwitchToItemCreator.TabIndex = 1;
            this.ButtonSwitchToItemCreator.Text = "Item Creator";
            this.ButtonSwitchToItemCreator.UseVisualStyleBackColor = true;
            // 
            // ButtonSwitchToRenderWindow
            // 
            this.ButtonSwitchToRenderWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonSwitchToRenderWindow.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSwitchToRenderWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSwitchToRenderWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonSwitchToRenderWindow.ForeColor = System.Drawing.Color.White;
            this.ButtonSwitchToRenderWindow.Location = new System.Drawing.Point(0, 0);
            this.ButtonSwitchToRenderWindow.Name = "ButtonSwitchToRenderWindow";
            this.ButtonSwitchToRenderWindow.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ButtonSwitchToRenderWindow.Size = new System.Drawing.Size(75, 23);
            this.ButtonSwitchToRenderWindow.TabIndex = 0;
            this.ButtonSwitchToRenderWindow.Text = "Render Window";
            this.ButtonSwitchToRenderWindow.UseVisualStyleBackColor = true;
            // 
            // MonoRenderWindow
            // 
            this.MonoRenderWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MonoRenderWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonoRenderWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonoRenderWindow.Location = new System.Drawing.Point(0, 0);
            this.MonoRenderWindow.Margin = new System.Windows.Forms.Padding(2);
            this.MonoRenderWindow.MouseHoverUpdatesOnly = false;
            this.MonoRenderWindow.Name = "MonoRenderWindow";
            this.MonoRenderWindow.Size = new System.Drawing.Size(984, 602);
            this.MonoRenderWindow.TabIndex = 0;
            this.MonoRenderWindow.Text = "Sample Control";
            // 
            // PanelItemExplorer
            // 
            this.PanelItemExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelItemExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelItemExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelItemExplorer.Location = new System.Drawing.Point(0, 631);
            this.PanelItemExplorer.Name = "PanelItemExplorer";
            this.PanelItemExplorer.Size = new System.Drawing.Size(1184, 130);
            this.PanelItemExplorer.TabIndex = 2;
            // 
            // PanelFileExplorer
            // 
            this.PanelFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelFileExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFileExplorer.Controls.Add(this.FileExplorer);
            this.PanelFileExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFileExplorer.Location = new System.Drawing.Point(0, 29);
            this.PanelFileExplorer.Name = "PanelFileExplorer";
            this.PanelFileExplorer.Size = new System.Drawing.Size(200, 602);
            this.PanelFileExplorer.TabIndex = 2;
            // 
            // FileExplorer
            // 
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(198, 600);
            this.FileExplorer.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.PanelWorkArea);
            this.Controls.Add(this.PanelFileExplorer);
            this.Controls.Add(this.PanelItemExplorer);
            this.Controls.Add(this.PanelNavbar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dreamland Editor";
            this.PanelNavbar.ResumeLayout(false);
            this.PanelWorkArea.ResumeLayout(false);
            this.PanelWindowSwitcher.ResumeLayout(false);
            this.PanelFileExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SampleControl MonoRenderWindow;
        private System.Windows.Forms.Panel PanelNavbar;
        private System.Windows.Forms.Panel PanelWorkArea;
        private System.Windows.Forms.Panel PanelWindowSwitcher;
        private DreamlandEditor.UI.UIButtons.NavigatonButton ButtonNavbarFile;
        private DreamlandEditor.UI.UIButtons.WindowChangeButton ButtonSwitchToCharacterCreator;
        private DreamlandEditor.UI.UIButtons.WindowChangeButton ButtonSwitchToItemCreator;
        private DreamlandEditor.UI.UIButtons.WindowChangeButton ButtonSwitchToRenderWindow;
        private DreamlandEditor.UI.UIPanels.ResizablePanel PanelItemExplorer;
        private DreamlandEditor.UI.UIPanels.ResizablePanel PanelFileExplorer;
        private DreamlandEditor.UI.FileExplorer FileExplorer;
    }
}

