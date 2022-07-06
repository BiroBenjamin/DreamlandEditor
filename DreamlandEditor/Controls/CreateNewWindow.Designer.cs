namespace DreamlandEditor.Controls
{
    partial class CreateNewWindow
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
            this.PanelBaseData = new System.Windows.Forms.Panel();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.PanelMapDetails = new System.Windows.Forms.Panel();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.TextboxFileName = new System.Windows.Forms.TextBox();
            this.PanelBaseData.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.PanelMapDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAccept.Location = new System.Drawing.Point(130, 5);
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
            this.ButtonCancel.Location = new System.Drawing.Point(190, 5);
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
            this.TextboxFileID.Location = new System.Drawing.Point(142, 13);
            this.TextboxFileID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxFileID.Name = "TextboxFileID";
            this.TextboxFileID.Size = new System.Drawing.Size(147, 20);
            this.TextboxFileID.TabIndex = 2;
            // 
            // LabelFileID
            // 
            this.LabelFileID.AutoSize = true;
            this.LabelFileID.ForeColor = System.Drawing.Color.White;
            this.LabelFileID.Location = new System.Drawing.Point(80, 16);
            this.LabelFileID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFileID.Name = "LabelFileID";
            this.LabelFileID.Size = new System.Drawing.Size(57, 13);
            this.LabelFileID.TabIndex = 3;
            this.LabelFileID.Text = "File Name:";
            // 
            // ComboboxFileType
            // 
            this.ComboboxFileType.FormattingEnabled = true;
            this.ComboboxFileType.Location = new System.Drawing.Point(142, 47);
            this.ComboboxFileType.Name = "ComboboxFileType";
            this.ComboboxFileType.Size = new System.Drawing.Size(147, 21);
            this.ComboboxFileType.Sorted = true;
            this.ComboboxFileType.TabIndex = 4;
            this.ComboboxFileType.SelectedValueChanged += new System.EventHandler(this.SelectedValueChanged);
            // 
            // LabelFileType
            // 
            this.LabelFileType.AutoSize = true;
            this.LabelFileType.ForeColor = System.Drawing.Color.White;
            this.LabelFileType.Location = new System.Drawing.Point(84, 50);
            this.LabelFileType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFileType.Name = "LabelFileType";
            this.LabelFileType.Size = new System.Drawing.Size(53, 13);
            this.LabelFileType.TabIndex = 5;
            this.LabelFileType.Text = "File Type:";
            // 
            // PanelBaseData
            // 
            this.PanelBaseData.Controls.Add(this.LabelFileType);
            this.PanelBaseData.Controls.Add(this.ComboboxFileType);
            this.PanelBaseData.Controls.Add(this.LabelFileID);
            this.PanelBaseData.Controls.Add(this.TextboxFileID);
            this.PanelBaseData.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBaseData.Location = new System.Drawing.Point(0, 0);
            this.PanelBaseData.Name = "PanelBaseData";
            this.PanelBaseData.Size = new System.Drawing.Size(362, 83);
            this.PanelBaseData.TabIndex = 6;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonCancel);
            this.PanelButtons.Controls.Add(this.ButtonAccept);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 419);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(362, 30);
            this.PanelButtons.TabIndex = 7;
            // 
            // PanelMapDetails
            // 
            this.PanelMapDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMapDetails.Controls.Add(this.TextboxFileName);
            this.PanelMapDetails.Controls.Add(this.LabelFileName);
            this.PanelMapDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMapDetails.Location = new System.Drawing.Point(0, 0);
            this.PanelMapDetails.Name = "PanelMapDetails";
            this.PanelMapDetails.Size = new System.Drawing.Size(362, 419);
            this.PanelMapDetails.TabIndex = 8;
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.ForeColor = System.Drawing.Color.White;
            this.LabelFileName.Location = new System.Drawing.Point(50, 90);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(86, 13);
            this.LabelFileName.TabIndex = 6;
            this.LabelFileName.Text = "PLACEHOLDER";
            // 
            // TextboxFileName
            // 
            this.TextboxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxFileName.Location = new System.Drawing.Point(141, 87);
            this.TextboxFileName.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxFileName.Name = "TextboxFileName";
            this.TextboxFileName.Size = new System.Drawing.Size(147, 20);
            this.TextboxFileName.TabIndex = 6;
            // 
            // CreateNewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(362, 449);
            this.Controls.Add(this.PanelBaseData);
            this.Controls.Add(this.PanelMapDetails);
            this.Controls.Add(this.PanelButtons);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateNewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Item";
            this.PanelBaseData.ResumeLayout(false);
            this.PanelBaseData.PerformLayout();
            this.PanelButtons.ResumeLayout(false);
            this.PanelMapDetails.ResumeLayout(false);
            this.PanelMapDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextboxFileID;
        private System.Windows.Forms.Label LabelFileID;
        private System.Windows.Forms.ComboBox ComboboxFileType;
        private System.Windows.Forms.Label LabelFileType;
        private System.Windows.Forms.Panel PanelBaseData;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelMapDetails;
        private System.Windows.Forms.TextBox TextboxFileName;
        private System.Windows.Forms.Label LabelFileName;
    }
}