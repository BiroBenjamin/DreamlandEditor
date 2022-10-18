
namespace DreamlandEditor.Controlers {
    partial class DebugWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TextBoxLogboard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxLogboard
            // 
            this.TextBoxLogboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLogboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLogboard.Location = new System.Drawing.Point(0, 0);
            this.TextBoxLogboard.Multiline = true;
            this.TextBoxLogboard.Name = "TextBoxLogboard";
            this.TextBoxLogboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxLogboard.Size = new System.Drawing.Size(800, 450);
            this.TextBoxLogboard.TabIndex = 0;
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxLogboard);
            this.Name = "DebugWindow";
            this.Text = "Debug Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogboard;
    }
}