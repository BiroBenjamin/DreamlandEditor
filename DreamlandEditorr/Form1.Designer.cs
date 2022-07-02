
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
            this.sampleControl = new MonoGame.Forms.DX.Controls.SampleControl();
            this.PanelNavbar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sampleControl
            // 
            this.sampleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleControl.Location = new System.Drawing.Point(0, 0);
            this.sampleControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sampleControl.MouseHoverUpdatesOnly = false;
            this.sampleControl.Name = "sampleControl";
            this.sampleControl.Size = new System.Drawing.Size(1184, 661);
            this.sampleControl.TabIndex = 0;
            this.sampleControl.Text = "Sample Control";
            // 
            // PanelNavbar
            // 
            this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavbar.Location = new System.Drawing.Point(0, 0);
            this.PanelNavbar.Name = "PanelNavbar";
            this.PanelNavbar.Size = new System.Drawing.Size(1184, 20);
            this.PanelNavbar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PanelNavbar);
            this.Controls.Add(this.sampleControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SampleControl sampleControl;
        private System.Windows.Forms.Panel PanelNavbar;
    }
}

