namespace DreamlandEditor.Controls
{
    partial class CreateNewItemWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextboxItemID = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAccept.Location = new System.Drawing.Point(128, 502);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 0;
            this.ButtonAccept.Text = "Ok";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(262, 502);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // TextboxItemID
            // 
            this.TextboxItemID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxItemID.Location = new System.Drawing.Point(128, 36);
            this.TextboxItemID.Name = "TextboxItemID";
            this.TextboxItemID.Size = new System.Drawing.Size(195, 22);
            this.TextboxItemID.TabIndex = 2;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.ForeColor = System.Drawing.Color.White;
            this.LabelID.Location = new System.Drawing.Point(13, 36);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(99, 16);
            this.LabelID.TabIndex = 3;
            this.LabelID.Text = "Name of he file:";
            // 
            // CreateNewItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TextboxItemID);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Name = "CreateNewItemWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextboxItemID;
        private System.Windows.Forms.Label LabelID;
    }
}