namespace ProjectDreamland.Controls.CreateNewItem
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
			this.PanelTileDetails = new System.Windows.Forms.Panel();
			this.ComboBoxTileType = new System.Windows.Forms.ComboBox();
			this.LabelTileType = new System.Windows.Forms.Label();
			this.PictureBoxTile = new System.Windows.Forms.PictureBox();
			this.LabelImagePath = new System.Windows.Forms.Label();
			this.ButtonChooseTileImage = new System.Windows.Forms.Button();
			this.TextBoxTileImagePath = new System.Windows.Forms.TextBox();
			this.FolderBrowserImage = new System.Windows.Forms.OpenFileDialog();
			this.PanelWorldObjectDetails = new System.Windows.Forms.Panel();
			this.PictureBoxWorldObject = new System.Windows.Forms.PictureBox();
			this.LabelImage = new System.Windows.Forms.Label();
			this.ButtonChooseWOImage = new System.Windows.Forms.Button();
			this.TextBoxWOImagePath = new System.Windows.Forms.TextBox();
			this.PanelBaseData.SuspendLayout();
			this.PanelButtons.SuspendLayout();
			this.PanelMapDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudMapHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NudMapWidth)).BeginInit();
			this.PanelTileDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxTile)).BeginInit();
			this.PanelWorldObjectDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxWorldObject)).BeginInit();
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
			this.LabelFileID.Size = new System.Drawing.Size(72, 16);
			this.LabelFileID.TabIndex = 3;
			this.LabelFileID.Text = "File Name:";
			// 
			// ComboboxFileType
			// 
			this.ComboboxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboboxFileType.FormattingEnabled = true;
			this.ComboboxFileType.Location = new System.Drawing.Point(267, 33);
			this.ComboboxFileType.Margin = new System.Windows.Forms.Padding(4);
			this.ComboboxFileType.Name = "ComboboxFileType";
			this.ComboboxFileType.Size = new System.Drawing.Size(195, 24);
			this.ComboboxFileType.Sorted = true;
			this.ComboboxFileType.TabIndex = 4;
			this.ComboboxFileType.SelectedValueChanged += new System.EventHandler(this.SelectedValueChanged);
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
			this.PanelBaseData.Controls.Add(this.ComboboxFileType);
			this.PanelBaseData.Controls.Add(this.LabelFileID);
			this.PanelBaseData.Controls.Add(this.TextboxFileID);
			this.PanelBaseData.Controls.Add(this.TextboxFileName);
			this.PanelBaseData.Controls.Add(this.LabelFileName);
			this.PanelBaseData.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelBaseData.Location = new System.Drawing.Point(0, 0);
			this.PanelBaseData.Margin = new System.Windows.Forms.Padding(4);
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
			this.PanelButtons.Margin = new System.Windows.Forms.Padding(4);
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
			this.PanelMapDetails.Margin = new System.Windows.Forms.Padding(4);
			this.PanelMapDetails.Name = "PanelMapDetails";
			this.PanelMapDetails.Size = new System.Drawing.Size(483, 386);
			this.PanelMapDetails.TabIndex = 8;
			// 
			// ComboBoxTerrainType
			// 
			this.ComboBoxTerrainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxTerrainType.FormattingEnabled = true;
			this.ComboBoxTerrainType.Location = new System.Drawing.Point(265, 31);
			this.ComboBoxTerrainType.Margin = new System.Windows.Forms.Padding(4);
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
			// PanelTileDetails
			// 
			this.PanelTileDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelTileDetails.Controls.Add(this.ComboBoxTileType);
			this.PanelTileDetails.Controls.Add(this.LabelTileType);
			this.PanelTileDetails.Controls.Add(this.PictureBoxTile);
			this.PanelTileDetails.Controls.Add(this.LabelImagePath);
			this.PanelTileDetails.Controls.Add(this.ButtonChooseTileImage);
			this.PanelTileDetails.Controls.Add(this.TextBoxTileImagePath);
			this.PanelTileDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelTileDetails.Location = new System.Drawing.Point(0, 130);
			this.PanelTileDetails.Margin = new System.Windows.Forms.Padding(4);
			this.PanelTileDetails.Name = "PanelTileDetails";
			this.PanelTileDetails.Size = new System.Drawing.Size(483, 386);
			this.PanelTileDetails.TabIndex = 11;
			// 
			// ComboBoxTileType
			// 
			this.ComboBoxTileType.FormattingEnabled = true;
			this.ComboBoxTileType.Location = new System.Drawing.Point(256, 99);
			this.ComboBoxTileType.Margin = new System.Windows.Forms.Padding(4);
			this.ComboBoxTileType.Name = "ComboBoxTileType";
			this.ComboBoxTileType.Size = new System.Drawing.Size(160, 24);
			this.ComboBoxTileType.TabIndex = 13;
			// 
			// LabelTileType
			// 
			this.LabelTileType.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelTileType.AutoSize = true;
			this.LabelTileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelTileType.ForeColor = System.Drawing.Color.White;
			this.LabelTileType.Location = new System.Drawing.Point(261, 77);
			this.LabelTileType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelTileType.Name = "LabelTileType";
			this.LabelTileType.Size = new System.Drawing.Size(71, 18);
			this.LabelTileType.TabIndex = 12;
			this.LabelTileType.Text = "Tile Type:";
			// 
			// PictureBoxTile
			// 
			this.PictureBoxTile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PictureBoxTile.BackColor = System.Drawing.Color.White;
			this.PictureBoxTile.Location = new System.Drawing.Point(25, 15);
			this.PictureBoxTile.Margin = new System.Windows.Forms.Padding(4);
			this.PictureBoxTile.Name = "PictureBoxTile";
			this.PictureBoxTile.Size = new System.Drawing.Size(207, 155);
			this.PictureBoxTile.TabIndex = 8;
			this.PictureBoxTile.TabStop = false;
			// 
			// LabelImagePath
			// 
			this.LabelImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelImagePath.AutoSize = true;
			this.LabelImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelImagePath.ForeColor = System.Drawing.Color.White;
			this.LabelImagePath.Location = new System.Drawing.Point(260, 11);
			this.LabelImagePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelImagePath.Name = "LabelImagePath";
			this.LabelImagePath.Size = new System.Drawing.Size(52, 18);
			this.LabelImagePath.TabIndex = 9;
			this.LabelImagePath.Text = "Image:";
			// 
			// ButtonChooseTileImage
			// 
			this.ButtonChooseTileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ButtonChooseTileImage.FlatAppearance.BorderSize = 0;
			this.ButtonChooseTileImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.ButtonChooseTileImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.ButtonChooseTileImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseTileImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonChooseTileImage.ForeColor = System.Drawing.Color.Black;
			this.ButtonChooseTileImage.Location = new System.Drawing.Point(410, 33);
			this.ButtonChooseTileImage.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonChooseTileImage.Name = "ButtonChooseTileImage";
			this.ButtonChooseTileImage.Size = new System.Drawing.Size(49, 23);
			this.ButtonChooseTileImage.TabIndex = 11;
			this.ButtonChooseTileImage.Text = "...";
			this.ButtonChooseTileImage.UseVisualStyleBackColor = false;
			this.ButtonChooseTileImage.Click += new System.EventHandler(this.ButtonChooseTileImage_Click);
			// 
			// TextBoxTileImagePath
			// 
			this.TextBoxTileImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBoxTileImagePath.Enabled = false;
			this.TextBoxTileImagePath.Location = new System.Drawing.Point(256, 34);
			this.TextBoxTileImagePath.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxTileImagePath.Name = "TextBoxTileImagePath";
			this.TextBoxTileImagePath.Size = new System.Drawing.Size(204, 22);
			this.TextBoxTileImagePath.TabIndex = 10;
			// 
			// PanelWorldObjectDetails
			// 
			this.PanelWorldObjectDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelWorldObjectDetails.Controls.Add(this.PictureBoxWorldObject);
			this.PanelWorldObjectDetails.Controls.Add(this.LabelImage);
			this.PanelWorldObjectDetails.Controls.Add(this.ButtonChooseWOImage);
			this.PanelWorldObjectDetails.Controls.Add(this.TextBoxWOImagePath);
			this.PanelWorldObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelWorldObjectDetails.Location = new System.Drawing.Point(0, 130);
			this.PanelWorldObjectDetails.Margin = new System.Windows.Forms.Padding(4);
			this.PanelWorldObjectDetails.Name = "PanelWorldObjectDetails";
			this.PanelWorldObjectDetails.Size = new System.Drawing.Size(483, 386);
			this.PanelWorldObjectDetails.TabIndex = 14;
			this.PanelWorldObjectDetails.Visible = false;
			// 
			// PictureBoxWorldObject
			// 
			this.PictureBoxWorldObject.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PictureBoxWorldObject.BackColor = System.Drawing.Color.White;
			this.PictureBoxWorldObject.Location = new System.Drawing.Point(25, 15);
			this.PictureBoxWorldObject.Margin = new System.Windows.Forms.Padding(4);
			this.PictureBoxWorldObject.Name = "PictureBoxWorldObject";
			this.PictureBoxWorldObject.Size = new System.Drawing.Size(207, 155);
			this.PictureBoxWorldObject.TabIndex = 8;
			this.PictureBoxWorldObject.TabStop = false;
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
			// ButtonChooseWOImage
			// 
			this.ButtonChooseWOImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ButtonChooseWOImage.FlatAppearance.BorderSize = 0;
			this.ButtonChooseWOImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.ButtonChooseWOImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.ButtonChooseWOImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonChooseWOImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonChooseWOImage.ForeColor = System.Drawing.Color.Black;
			this.ButtonChooseWOImage.Location = new System.Drawing.Point(410, 33);
			this.ButtonChooseWOImage.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonChooseWOImage.Name = "ButtonChooseWOImage";
			this.ButtonChooseWOImage.Size = new System.Drawing.Size(49, 23);
			this.ButtonChooseWOImage.TabIndex = 11;
			this.ButtonChooseWOImage.Text = "...";
			this.ButtonChooseWOImage.UseVisualStyleBackColor = false;
			this.ButtonChooseWOImage.Click += new System.EventHandler(this.ButtonChooseWOImage_Click);
			// 
			// TextBoxWOImagePath
			// 
			this.TextBoxWOImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBoxWOImagePath.Enabled = false;
			this.TextBoxWOImagePath.Location = new System.Drawing.Point(256, 34);
			this.TextBoxWOImagePath.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxWOImagePath.Name = "TextBoxWOImagePath";
			this.TextBoxWOImagePath.Size = new System.Drawing.Size(204, 22);
			this.TextBoxWOImagePath.TabIndex = 10;
			// 
			// CreateNewWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(483, 553);
			this.Controls.Add(this.PanelTileDetails);
			this.Controls.Add(this.PanelWorldObjectDetails);
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
			this.PanelTileDetails.ResumeLayout(false);
			this.PanelTileDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxTile)).EndInit();
			this.PanelWorldObjectDetails.ResumeLayout(false);
			this.PanelWorldObjectDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxWorldObject)).EndInit();
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
		private System.Windows.Forms.Label LabelMapHeight;
		private System.Windows.Forms.Label LabelMapWidth;
		private System.Windows.Forms.NumericUpDown NudMapHeight;
		private System.Windows.Forms.NumericUpDown NudMapWidth;
		private System.Windows.Forms.ComboBox ComboBoxTerrainType;
		private System.Windows.Forms.Label LabelFillType;
        private System.Windows.Forms.Panel PanelTileDetails;
        private System.Windows.Forms.PictureBox PictureBoxTile;
        private System.Windows.Forms.Label LabelImagePath;
        private System.Windows.Forms.Button ButtonChooseTileImage;
        private System.Windows.Forms.TextBox TextBoxTileImagePath;
        private System.Windows.Forms.OpenFileDialog FolderBrowserImage;
        private System.Windows.Forms.ComboBox ComboBoxTileType;
        private System.Windows.Forms.Label LabelTileType;
		private System.Windows.Forms.Panel PanelWorldObjectDetails;
		private System.Windows.Forms.PictureBox PictureBoxWorldObject;
		private System.Windows.Forms.Label LabelImage;
		private System.Windows.Forms.Button ButtonChooseWOImage;
		private System.Windows.Forms.TextBox TextBoxWOImagePath;
	}
}