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
      this.ComboBoxFileType = new System.Windows.Forms.ComboBox();
      this.LabelFileType = new System.Windows.Forms.Label();
      this.PanelBaseData = new System.Windows.Forms.Panel();
      this.TextboxFileName = new System.Windows.Forms.TextBox();
      this.LabelFileName = new System.Windows.Forms.Label();
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.PanelMapDetails = new System.Windows.Forms.Panel();
      this.ComboBoxTerrainType = new System.Windows.Forms.ComboBox();
      this.LabelFillType = new System.Windows.Forms.Label();
      this.LabelMapHeight = new System.Windows.Forms.Label();
      this.LabelMapWidth = new System.Windows.Forms.Label();
      this.NudMapHeight = new System.Windows.Forms.NumericUpDown();
      this.NudMapWidth = new System.Windows.Forms.NumericUpDown();
      this.OpenFileDialogImage = new System.Windows.Forms.OpenFileDialog();
      this.PanelObjectDetails = new System.Windows.Forms.Panel();
      this.PictureBoxObject = new System.Windows.Forms.PictureBox();
      this.LabelImage = new System.Windows.Forms.Label();
      this.ButtonChooseImage = new System.Windows.Forms.Button();
      this.TextBoxImagePath = new System.Windows.Forms.TextBox();
      this.CheckBoxTileCollision = new System.Windows.Forms.CheckBox();
      this.PanelBaseData.SuspendLayout();
      this.PanelButtons.SuspendLayout();
      this.PanelMapDetails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudMapHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudMapWidth)).BeginInit();
      this.PanelObjectDetails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBoxObject)).BeginInit();
      this.SuspendLayout();
      // 
      // ButtonAccept
      // 
      this.ButtonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonAccept.Location = new System.Drawing.Point(169, 6);
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
      this.ButtonCancel.Location = new System.Drawing.Point(249, 6);
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
      this.TextboxFileID.Location = new System.Drawing.Point(27, 33);
      this.TextboxFileID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TextboxFileID.Name = "TextboxFileID";
      this.TextboxFileID.Size = new System.Drawing.Size(195, 22);
      this.TextboxFileID.TabIndex = 2;
      // 
      // LabelFileID
      // 
      this.LabelFileID.AutoSize = true;
      this.LabelFileID.ForeColor = System.Drawing.Color.White;
      this.LabelFileID.Location = new System.Drawing.Point(23, 14);
      this.LabelFileID.Name = "LabelFileID";
      this.LabelFileID.Size = new System.Drawing.Size(48, 16);
      this.LabelFileID.TabIndex = 3;
      this.LabelFileID.Text = "File ID:";
      // 
      // ComboboxFileType
      // 
      this.ComboBoxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboBoxFileType.FormattingEnabled = true;
      this.ComboBoxFileType.Location = new System.Drawing.Point(267, 33);
      this.ComboBoxFileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.ComboBoxFileType.Name = "ComboboxFileType";
      this.ComboBoxFileType.Size = new System.Drawing.Size(195, 24);
      this.ComboBoxFileType.Sorted = true;
      this.ComboBoxFileType.TabIndex = 4;
      this.ComboBoxFileType.SelectedValueChanged += new System.EventHandler(this.SelectedValueChanged);
      // 
      // LabelFileType
      // 
      this.LabelFileType.AutoSize = true;
      this.LabelFileType.ForeColor = System.Drawing.Color.White;
      this.LabelFileType.Location = new System.Drawing.Point(263, 14);
      this.LabelFileType.Name = "LabelFileType";
      this.LabelFileType.Size = new System.Drawing.Size(67, 16);
      this.LabelFileType.TabIndex = 5;
      this.LabelFileType.Text = "File Type:";
      // 
      // PanelBaseData
      // 
      this.PanelBaseData.Controls.Add(this.LabelFileType);
      this.PanelBaseData.Controls.Add(this.ComboBoxFileType);
      this.PanelBaseData.Controls.Add(this.LabelFileID);
      this.PanelBaseData.Controls.Add(this.TextboxFileID);
      this.PanelBaseData.Controls.Add(this.TextboxFileName);
      this.PanelBaseData.Controls.Add(this.LabelFileName);
      this.PanelBaseData.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelBaseData.Location = new System.Drawing.Point(0, 0);
      this.PanelBaseData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.PanelBaseData.Name = "PanelBaseData";
      this.PanelBaseData.Size = new System.Drawing.Size(483, 130);
      this.PanelBaseData.TabIndex = 6;
      // 
      // TextboxFileName
      // 
      this.TextboxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.TextboxFileName.Location = new System.Drawing.Point(27, 89);
      this.TextboxFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TextboxFileName.Name = "TextboxFileName";
      this.TextboxFileName.Size = new System.Drawing.Size(195, 22);
      this.TextboxFileName.TabIndex = 6;
      // 
      // LabelFileName
      // 
      this.LabelFileName.AutoSize = true;
      this.LabelFileName.ForeColor = System.Drawing.Color.White;
      this.LabelFileName.Location = new System.Drawing.Point(23, 71);
      this.LabelFileName.Name = "LabelFileName";
      this.LabelFileName.Size = new System.Drawing.Size(106, 16);
      this.LabelFileName.TabIndex = 6;
      this.LabelFileName.Text = "PLACEHOLDER";
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ButtonCancel);
      this.PanelButtons.Controls.Add(this.ButtonAccept);
      this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelButtons.Location = new System.Drawing.Point(0, 516);
      this.PanelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.PanelButtons.Name = "PanelButtons";
      this.PanelButtons.Size = new System.Drawing.Size(483, 37);
      this.PanelButtons.TabIndex = 7;
      // 
      // PanelMapDetails
      // 
      this.PanelMapDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelMapDetails.Controls.Add(this.ComboBoxTerrainType);
      this.PanelMapDetails.Controls.Add(this.LabelFillType);
      this.PanelMapDetails.Controls.Add(this.LabelMapHeight);
      this.PanelMapDetails.Controls.Add(this.LabelMapWidth);
      this.PanelMapDetails.Controls.Add(this.NudMapHeight);
      this.PanelMapDetails.Controls.Add(this.NudMapWidth);
      this.PanelMapDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelMapDetails.Location = new System.Drawing.Point(0, 130);
      this.PanelMapDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.PanelMapDetails.Name = "PanelMapDetails";
      this.PanelMapDetails.Size = new System.Drawing.Size(483, 386);
      this.PanelMapDetails.TabIndex = 8;
      // 
      // ComboBoxTerrainType
      // 
      this.ComboBoxTerrainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboBoxTerrainType.FormattingEnabled = true;
      this.ComboBoxTerrainType.Location = new System.Drawing.Point(265, 31);
      this.ComboBoxTerrainType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.ComboBoxTerrainType.Name = "ComboBoxTerrainType";
      this.ComboBoxTerrainType.Size = new System.Drawing.Size(195, 24);
      this.ComboBoxTerrainType.Sorted = true;
      this.ComboBoxTerrainType.TabIndex = 7;
      // 
      // LabelFillType
      // 
      this.LabelFillType.AutoSize = true;
      this.LabelFillType.ForeColor = System.Drawing.Color.White;
      this.LabelFillType.Location = new System.Drawing.Point(261, 11);
      this.LabelFillType.Name = "LabelFillType";
      this.LabelFillType.Size = new System.Drawing.Size(52, 16);
      this.LabelFillType.TabIndex = 10;
      this.LabelFillType.Text = "Fill with:";
      // 
      // LabelMapHeight
      // 
      this.LabelMapHeight.AutoSize = true;
      this.LabelMapHeight.ForeColor = System.Drawing.Color.White;
      this.LabelMapHeight.Location = new System.Drawing.Point(131, 14);
      this.LabelMapHeight.Name = "LabelMapHeight";
      this.LabelMapHeight.Size = new System.Drawing.Size(49, 16);
      this.LabelMapHeight.TabIndex = 9;
      this.LabelMapHeight.Text = "Height:";
      // 
      // LabelMapWidth
      // 
      this.LabelMapWidth.AutoSize = true;
      this.LabelMapWidth.ForeColor = System.Drawing.Color.White;
      this.LabelMapWidth.Location = new System.Drawing.Point(39, 14);
      this.LabelMapWidth.Name = "LabelMapWidth";
      this.LabelMapWidth.Size = new System.Drawing.Size(44, 16);
      this.LabelMapWidth.TabIndex = 6;
      this.LabelMapWidth.Text = "Width:";
      // 
      // NudMapHeight
      // 
      this.NudMapHeight.Location = new System.Drawing.Point(133, 33);
      this.NudMapHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.NudMapHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.NudMapHeight.Name = "NudMapHeight";
      this.NudMapHeight.Size = new System.Drawing.Size(65, 22);
      this.NudMapHeight.TabIndex = 8;
      // 
      // NudMapWidth
      // 
      this.NudMapWidth.Location = new System.Drawing.Point(43, 33);
      this.NudMapWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.NudMapWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.NudMapWidth.Name = "NudMapWidth";
      this.NudMapWidth.Size = new System.Drawing.Size(65, 22);
      this.NudMapWidth.TabIndex = 7;
      // 
      // OpenFileDialogImage
      // 
      this.OpenFileDialogImage.Filter = "PNG files (*.png; *.PNG)|*.png; *.PNG";
      this.OpenFileDialogImage.Multiselect = true;
      this.OpenFileDialogImage.ReadOnlyChecked = true;
      this.OpenFileDialogImage.RestoreDirectory = true;
      // 
      // PanelObjectDetails
      // 
      this.PanelObjectDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelObjectDetails.Controls.Add(this.CheckBoxTileCollision);
      this.PanelObjectDetails.Controls.Add(this.PictureBoxObject);
      this.PanelObjectDetails.Controls.Add(this.LabelImage);
      this.PanelObjectDetails.Controls.Add(this.ButtonChooseImage);
      this.PanelObjectDetails.Controls.Add(this.TextBoxImagePath);
      this.PanelObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelObjectDetails.Location = new System.Drawing.Point(0, 130);
      this.PanelObjectDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.PanelObjectDetails.Name = "PanelObjectDetails";
      this.PanelObjectDetails.Size = new System.Drawing.Size(483, 386);
      this.PanelObjectDetails.TabIndex = 14;
      this.PanelObjectDetails.Visible = false;
      // 
      // PictureBoxObject
      // 
      this.PictureBoxObject.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.PictureBoxObject.BackColor = System.Drawing.Color.White;
      this.PictureBoxObject.Location = new System.Drawing.Point(25, 15);
      this.PictureBoxObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.PictureBoxObject.Name = "PictureBoxObject";
      this.PictureBoxObject.Size = new System.Drawing.Size(207, 155);
      this.PictureBoxObject.TabIndex = 8;
      this.PictureBoxObject.TabStop = false;
      // 
      // LabelImage
      // 
      this.LabelImage.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelImage.AutoSize = true;
      this.LabelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelImage.ForeColor = System.Drawing.Color.White;
      this.LabelImage.Location = new System.Drawing.Point(260, 11);
      this.LabelImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LabelImage.Name = "LabelImage";
      this.LabelImage.Size = new System.Drawing.Size(52, 18);
      this.LabelImage.TabIndex = 9;
      this.LabelImage.Text = "Image:";
      // 
      // ButtonChooseImage
      // 
      this.ButtonChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
      this.ButtonChooseImage.FlatAppearance.BorderSize = 0;
      this.ButtonChooseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
      this.ButtonChooseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.ButtonChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.ButtonChooseImage.ForeColor = System.Drawing.Color.Black;
      this.ButtonChooseImage.Location = new System.Drawing.Point(411, 33);
      this.ButtonChooseImage.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonChooseImage.Name = "ButtonChooseImage";
      this.ButtonChooseImage.Size = new System.Drawing.Size(49, 23);
      this.ButtonChooseImage.TabIndex = 11;
      this.ButtonChooseImage.Text = "...";
      this.ButtonChooseImage.UseVisualStyleBackColor = false;
      this.ButtonChooseImage.Click += new System.EventHandler(this.ButtonChooseImage_Click);
      // 
      // TextBoxImagePath
      // 
      this.TextBoxImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxImagePath.Enabled = false;
      this.TextBoxImagePath.Location = new System.Drawing.Point(256, 34);
      this.TextBoxImagePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.TextBoxImagePath.Name = "TextBoxImagePath";
      this.TextBoxImagePath.Size = new System.Drawing.Size(204, 22);
      this.TextBoxImagePath.TabIndex = 10;
      // 
      // CheckBoxTileCollision
      // 
      this.CheckBoxTileCollision.AutoSize = true;
      this.CheckBoxTileCollision.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.CheckBoxTileCollision.ForeColor = System.Drawing.Color.White;
      this.CheckBoxTileCollision.Location = new System.Drawing.Point(256, 88);
      this.CheckBoxTileCollision.Name = "CheckBoxTileCollision";
      this.CheckBoxTileCollision.Size = new System.Drawing.Size(147, 20);
      this.CheckBoxTileCollision.TabIndex = 12;
      this.CheckBoxTileCollision.Text = "Tile has collision";
      this.CheckBoxTileCollision.UseVisualStyleBackColor = true;
      this.CheckBoxTileCollision.Visible = false;
      // 
      // CreateNewWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.ClientSize = new System.Drawing.Size(483, 553);
      this.Controls.Add(this.PanelObjectDetails);
      this.Controls.Add(this.PanelMapDetails);
      this.Controls.Add(this.PanelButtons);
      this.Controls.Add(this.PanelBaseData);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "CreateNewWindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create New Item";
      this.PanelBaseData.ResumeLayout(false);
      this.PanelBaseData.PerformLayout();
      this.PanelButtons.ResumeLayout(false);
      this.PanelMapDetails.ResumeLayout(false);
      this.PanelMapDetails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudMapHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudMapWidth)).EndInit();
      this.PanelObjectDetails.ResumeLayout(false);
      this.PanelObjectDetails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBoxObject)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextboxFileID;
        private System.Windows.Forms.Label LabelFileID;
        private System.Windows.Forms.ComboBox ComboBoxFileType;
        private System.Windows.Forms.Label LabelFileType;
        private System.Windows.Forms.Panel PanelBaseData;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelMapDetails;
        private System.Windows.Forms.TextBox TextboxFileName;
        private System.Windows.Forms.Label LabelFileName;
		private System.Windows.Forms.Label LabelMapHeight;
		private System.Windows.Forms.Label LabelMapWidth;
		private System.Windows.Forms.NumericUpDown NudMapHeight;
		private System.Windows.Forms.NumericUpDown NudMapWidth;
		private System.Windows.Forms.ComboBox ComboBoxTerrainType;
		private System.Windows.Forms.Label LabelFillType;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogImage;
		private System.Windows.Forms.Panel PanelObjectDetails;
		private System.Windows.Forms.PictureBox PictureBoxObject;
		private System.Windows.Forms.Label LabelImage;
		private System.Windows.Forms.Button ButtonChooseImage;
		private System.Windows.Forms.TextBox TextBoxImagePath;
        private System.Windows.Forms.CheckBox CheckBoxTileCollision;
    }
}