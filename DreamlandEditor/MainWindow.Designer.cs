
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
            this.PanelItemExplorer = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelFileExplorer = new System.Windows.Forms.Panel();
            this.MonoRenderWindow = new MonoGame.Forms.DX.Controls.SampleControl();
            this.PanelNavbar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelItemExplorer
            // 
            this.PanelItemExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelItemExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelItemExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelItemExplorer.Location = new System.Drawing.Point(0, 646);
            this.PanelItemExplorer.Name = "PanelItemExplorer";
            this.PanelItemExplorer.Size = new System.Drawing.Size(1184, 115);
            this.PanelItemExplorer.TabIndex = 1;
            // 
            // PanelFileExplorer
            // 
            this.PanelFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelFileExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFileExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFileExplorer.Location = new System.Drawing.Point(0, 29);
            this.PanelFileExplorer.Name = "PanelFileExplorer";
            this.PanelFileExplorer.Size = new System.Drawing.Size(200, 617);
            this.PanelFileExplorer.TabIndex = 2;
            // 
            // MonoRenderWindow
            // 
            this.MonoRenderWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonoRenderWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonoRenderWindow.Location = new System.Drawing.Point(200, 29);
            this.MonoRenderWindow.Margin = new System.Windows.Forms.Padding(2);
            this.MonoRenderWindow.MouseHoverUpdatesOnly = false;
            this.MonoRenderWindow.Name = "MonoRenderWindow";
            this.MonoRenderWindow.Size = new System.Drawing.Size(984, 617);
            this.MonoRenderWindow.TabIndex = 0;
            this.MonoRenderWindow.Text = "Sample Control";
            // 
            // PanelNavbar
            // 
            this.PanelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavbar.Location = new System.Drawing.Point(0, 0);
            this.PanelNavbar.Name = "PanelNavbar";
            this.PanelNavbar.Size = new System.Drawing.Size(1184, 29);
            this.PanelNavbar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.MonoRenderWindow);
            this.Controls.Add(this.PanelFileExplorer);
            this.Controls.Add(this.PanelItemExplorer);
            this.Controls.Add(this.PanelNavbar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SampleControl MonoRenderWindow;
        private System.Windows.Forms.FlowLayoutPanel PanelItemExplorer;
        private System.Windows.Forms.Panel PanelFileExplorer;
        private System.Windows.Forms.Panel PanelNavbar;
    }
}

