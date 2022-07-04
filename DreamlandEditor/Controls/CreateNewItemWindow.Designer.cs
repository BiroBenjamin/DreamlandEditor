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
            this.ButtonAccept.Location = new System.Drawing.Point(96, 408);
            this.ButtonAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(56, 19);
            this.ButtonAccept.TabIndex = 0;
            this.ButtonAccept.Text = "Ok";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(196, 408);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(56, 19);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // TextboxFileID
            // 
            this.TextboxFileID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxFileID.Location = new System.Drawing.Point(96, 29);
            this.TextboxFileID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxFileID.Name = "TextboxFileID";
            this.TextboxFileID.Size = new System.Drawing.Size(147, 20);
            this.TextboxFileID.TabIndex = 2;
            // 
            // LabelFileID
            // 
            this.LabelFileID.AutoSize = true;
            this.LabelFileID.ForeColor = System.Drawing.Color.White;
            this.LabelFileID.Location = new System.Drawing.Point(10, 29);
            this.LabelFileID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFileID.Name = "LabelFileID";
            this.LabelFileID.Size = new System.Drawing.Size(81, 13);
            this.LabelFileID.TabIndex = 3;
            this.LabelFileID.Text = "Name of he file:";
            // 
            // ComboboxFileType
            // 
            this.ComboboxFileType.FormattingEnabled = true;
            this.ComboboxFileType.Items.AddRange(new object[] {
            "Character",
            "Item",
            "Map"});
            this.ComboboxFileType.Location = new System.Drawing.Point(96, 63);
            this.ComboboxFileType.Name = "ComboboxFileType";
            this.ComboboxFileType.Size = new System.Drawing.Size(147, 21);
            this.ComboboxFileType.Sorted = true;
            this.ComboboxFileType.TabIndex = 4;
            // 
            // LabelFileType
            // 
            this.LabelFileType.AutoSize = true;
            this.LabelFileType.ForeColor = System.Drawing.Color.White;
            this.LabelFileType.Location = new System.Drawing.Point(10, 66);
            this.LabelFileType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFileType.Name = "LabelFileType";
            this.LabelFileType.Size = new System.Drawing.Size(81, 13);
            this.LabelFileType.TabIndex = 5;
            this.LabelFileType.Text = "Name of he file:";
            // 
            // CreateNewItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(362, 449);
            this.Controls.Add(this.LabelFileType);
            this.Controls.Add(this.ComboboxFileType);
            this.Controls.Add(this.LabelFileID);
            this.Controls.Add(this.TextboxFileID);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAccept);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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