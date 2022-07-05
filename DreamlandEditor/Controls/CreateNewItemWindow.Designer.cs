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
            this.TextboxFileID = new System.Windows.Forms.TextBox();
            this.LabelFileID = new System.Windows.Forms.Label();
            this.ComboboxFileType = new System.Windows.Forms.ComboBox();
            this.LabelFileType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAccept.Location = new System.Drawing.Point(128, 502);
            this.ButtonAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ButtonCancel.Location = new System.Drawing.Point(261, 502);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // TextboxFileID
            // 
            this.TextboxFileID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxFileID.Location = new System.Drawing.Point(128, 36);
            this.TextboxFileID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxFileID.Name = "TextboxFileID";
            this.TextboxFileID.Size = new System.Drawing.Size(195, 22);
            this.TextboxFileID.TabIndex = 2;
            // 
            // LabelFileID
            // 
            this.LabelFileID.AutoSize = true;
            this.LabelFileID.ForeColor = System.Drawing.Color.White;
            this.LabelFileID.Location = new System.Drawing.Point(13, 36);
            this.LabelFileID.Name = "LabelFileID";
            this.LabelFileID.Size = new System.Drawing.Size(99, 16);
            this.LabelFileID.TabIndex = 3;
            this.LabelFileID.Text = "Name of he file:";
            // 
            // ComboboxFileType
            // 
            this.ComboboxFileType.FormattingEnabled = true;
            this.ComboboxFileType.Location = new System.Drawing.Point(128, 78);
            this.ComboboxFileType.Margin = new System.Windows.Forms.Padding(4);
            this.ComboboxFileType.Name = "ComboboxFileType";
            this.ComboboxFileType.Size = new System.Drawing.Size(195, 24);
            this.ComboboxFileType.Sorted = true;
            this.ComboboxFileType.TabIndex = 4;
            // 
            // LabelFileType
            // 
            this.LabelFileType.AutoSize = true;
            this.LabelFileType.ForeColor = System.Drawing.Color.White;
            this.LabelFileType.Location = new System.Drawing.Point(13, 81);
            this.LabelFileType.Name = "LabelFileType";
            this.LabelFileType.Size = new System.Drawing.Size(99, 16);
            this.LabelFileType.TabIndex = 5;
            this.LabelFileType.Text = "Name of he file:";
            // 
            // CreateNewItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(483, 553);
            this.Controls.Add(this.LabelFileType);
            this.Controls.Add(this.ComboboxFileType);
            this.Controls.Add(this.LabelFileID);
            this.Controls.Add(this.TextboxFileID);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateNewItemWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextboxFileID;
        private System.Windows.Forms.Label LabelFileID;
        private System.Windows.Forms.ComboBox ComboboxFileType;
        private System.Windows.Forms.Label LabelFileType;
    }
}