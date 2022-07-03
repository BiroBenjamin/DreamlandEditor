
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
            this.ListBoxDebugMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBoxDebugMessages
            // 
            this.ListBoxDebugMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxDebugMessages.FormattingEnabled = true;
            this.ListBoxDebugMessages.Location = new System.Drawing.Point(0, 0);
            this.ListBoxDebugMessages.Name = "ListBoxDebugMessages";
            this.ListBoxDebugMessages.Size = new System.Drawing.Size(800, 450);
            this.ListBoxDebugMessages.TabIndex = 0;
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxDebugMessages);
            this.Name = "DebugWindow";
            this.Text = "Debug Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxDebugMessages;
    }
}