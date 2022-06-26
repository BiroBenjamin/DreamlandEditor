
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
            this.PanelItemExplorer = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelNavbar = new System.Windows.Forms.Panel();
            this.ButtonFiles = new System.Windows.Forms.Button();
            this.PanelFileExplorer = new System.Windows.Forms.Panel();
            this.TreeViewFileExplorer = new System.Windows.Forms.TreeView();
            this.PanelFileExplorerResizeArea = new System.Windows.Forms.Panel();
            this.PanelItemExplorerContainer = new System.Windows.Forms.Panel();
            this.PanelItemExplorerResizeArea = new System.Windows.Forms.Panel();
            this.MonoRenderWindow = new MonoGame.Forms.DX.Controls.SampleControl();
            this.PanelNavbar.SuspendLayout();
            this.PanelFileExplorer.SuspendLayout();
            this.PanelItemExplorerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelItemExplorer
            // 
            this.PanelItemExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelItemExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelItemExplorer.Location = new System.Drawing.Point(0, 3);
            this.PanelItemExplorer.Name = "PanelItemExplorer";
            this.PanelItemExplorer.Size = new System.Drawing.Size(1184, 97);
            this.PanelItemExplorer.TabIndex = 1;
            this.PanelItemExplorer.MouseEnter += new System.EventHandler(this.MainWindow_Hover);
            // 
            // PanelNavbar
            // 
            this.PanelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNavbar.Controls.Add(this.ButtonFiles);
            this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavbar.Location = new System.Drawing.Point(0, 0);
            this.PanelNavbar.Name = "PanelNavbar";
            this.PanelNavbar.Size = new System.Drawing.Size(1184, 29);
            this.PanelNavbar.TabIndex = 3;
            this.PanelNavbar.MouseEnter += new System.EventHandler(this.MainWindow_Hover);
            // 
            // ButtonFiles
            // 
            this.ButtonFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFiles.FlatAppearance.BorderSize = 0;
            this.ButtonFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ButtonFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ButtonFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonFiles.Location = new System.Drawing.Point(0, 0);
            this.ButtonFiles.Name = "ButtonFiles";
            this.ButtonFiles.Size = new System.Drawing.Size(50, 27);
            this.ButtonFiles.TabIndex = 0;
            this.ButtonFiles.Text = "File";
            this.ButtonFiles.UseVisualStyleBackColor = true;
            this.ButtonFiles.Click += new System.EventHandler(this.ButtonFiles_Click);
            // 
            // PanelFileExplorer
            // 
            this.PanelFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelFileExplorer.Controls.Add(this.TreeViewFileExplorer);
            this.PanelFileExplorer.Controls.Add(this.PanelFileExplorerResizeArea);
            this.PanelFileExplorer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelFileExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFileExplorer.Location = new System.Drawing.Point(0, 29);
            this.PanelFileExplorer.MaximumSize = new System.Drawing.Size(400, 0);
            this.PanelFileExplorer.MinimumSize = new System.Drawing.Size(150, 0);
            this.PanelFileExplorer.Name = "PanelFileExplorer";
            this.PanelFileExplorer.Size = new System.Drawing.Size(200, 632);
            this.PanelFileExplorer.TabIndex = 4;
            // 
            // TreeViewFileExplorer
            // 
            this.TreeViewFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TreeViewFileExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewFileExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TreeViewFileExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TreeViewFileExplorer.Location = new System.Drawing.Point(0, 0);
            this.TreeViewFileExplorer.Name = "TreeViewFileExplorer";
            this.TreeViewFileExplorer.Size = new System.Drawing.Size(197, 632);
            this.TreeViewFileExplorer.TabIndex = 0;
            this.TreeViewFileExplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewFileExplorer_NodeDoubleClick);
            // 
            // PanelFileExplorerResizeArea
            // 
            this.PanelFileExplorerResizeArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PanelFileExplorerResizeArea.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.PanelFileExplorerResizeArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFileExplorerResizeArea.Location = new System.Drawing.Point(197, 0);
            this.PanelFileExplorerResizeArea.Name = "PanelFileExplorerResizeArea";
            this.PanelFileExplorerResizeArea.Size = new System.Drawing.Size(3, 632);
            this.PanelFileExplorerResizeArea.TabIndex = 0;
            this.PanelFileExplorerResizeArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Explorer_MouseDown);
            this.PanelFileExplorerResizeArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelFileExplorer_MouseMove);
            this.PanelFileExplorerResizeArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Explorer_MouseUp);
            // 
            // PanelItemExplorerContainer
            // 
            this.PanelItemExplorerContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelItemExplorerContainer.Controls.Add(this.PanelItemExplorer);
            this.PanelItemExplorerContainer.Controls.Add(this.PanelItemExplorerResizeArea);
            this.PanelItemExplorerContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelItemExplorerContainer.Location = new System.Drawing.Point(0, 661);
            this.PanelItemExplorerContainer.MaximumSize = new System.Drawing.Size(0, 300);
            this.PanelItemExplorerContainer.MinimumSize = new System.Drawing.Size(0, 75);
            this.PanelItemExplorerContainer.Name = "PanelItemExplorerContainer";
            this.PanelItemExplorerContainer.Size = new System.Drawing.Size(1184, 100);
            this.PanelItemExplorerContainer.TabIndex = 5;
            // 
            // PanelItemExplorerResizeArea
            // 
            this.PanelItemExplorerResizeArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PanelItemExplorerResizeArea.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.PanelItemExplorerResizeArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelItemExplorerResizeArea.Location = new System.Drawing.Point(0, 0);
            this.PanelItemExplorerResizeArea.Name = "PanelItemExplorerResizeArea";
            this.PanelItemExplorerResizeArea.Size = new System.Drawing.Size(1184, 3);
            this.PanelItemExplorerResizeArea.TabIndex = 0;
            this.PanelItemExplorerResizeArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Explorer_MouseDown);
            this.PanelItemExplorerResizeArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelItemExplorer_MouseMove);
            this.PanelItemExplorerResizeArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Explorer_MouseUp);
            // 
            // MonoRenderWindow
            // 
            this.MonoRenderWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonoRenderWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonoRenderWindow.Location = new System.Drawing.Point(200, 29);
            this.MonoRenderWindow.Margin = new System.Windows.Forms.Padding(2);
            this.MonoRenderWindow.MouseHoverUpdatesOnly = false;
            this.MonoRenderWindow.Name = "MonoRenderWindow";
            this.MonoRenderWindow.Size = new System.Drawing.Size(984, 632);
            this.MonoRenderWindow.TabIndex = 0;
            this.MonoRenderWindow.Text = "Sample Control";
            this.MonoRenderWindow.MouseEnter += new System.EventHandler(this.MainWindow_Hover);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.MonoRenderWindow);
            this.Controls.Add(this.PanelFileExplorer);
            this.Controls.Add(this.PanelItemExplorerContainer);
            this.Controls.Add(this.PanelNavbar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Dreamland Editor";
            this.PanelNavbar.ResumeLayout(false);
            this.PanelFileExplorer.ResumeLayout(false);
            this.PanelItemExplorerContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SampleControl MonoRenderWindow;

        private System.Windows.Forms.FlowLayoutPanel PanelItemExplorer;
        private System.Windows.Forms.Panel PanelNavbar;
        private System.Windows.Forms.Button ButtonFiles;
        private System.Windows.Forms.Panel PanelFileExplorer;
        private System.Windows.Forms.TreeView TreeViewFileExplorer;
        private System.Windows.Forms.Panel PanelFileExplorerResizeArea;
        private System.Windows.Forms.Panel PanelItemExplorerContainer;
        private System.Windows.Forms.Panel PanelItemExplorerResizeArea;
    }
}

