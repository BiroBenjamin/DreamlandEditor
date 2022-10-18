namespace DreamlandEditor.Controls.Editors
{
    partial class CharacterEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.ButtonSave = new System.Windows.Forms.Button();
      this.ImageWObject = new System.Windows.Forms.PictureBox();
      this.LabelID = new System.Windows.Forms.Label();
      this.TextBoxID = new System.Windows.Forms.TextBox();
      this.LabelName = new System.Windows.Forms.Label();
      this.TextBoxName = new System.Windows.Forms.TextBox();
      this.LabelImagePath = new System.Windows.Forms.Label();
      this.ButtonChooseImage = new System.Windows.Forms.Button();
      this.TextBoxImagePath = new System.Windows.Forms.TextBox();
      this.OpenFileDialogImage = new System.Windows.Forms.OpenFileDialog();
      this.GroupBoxHealth = new System.Windows.Forms.GroupBox();
      this.NudCurrentHealth = new System.Windows.Forms.NumericUpDown();
      this.LabelCurrentHealth = new System.Windows.Forms.Label();
      this.NudMaxHealth = new System.Windows.Forms.NumericUpDown();
      this.LabelMaxHealth = new System.Windows.Forms.Label();
      this.GroupBoxResource = new System.Windows.Forms.GroupBox();
      this.LabelResourceType = new System.Windows.Forms.Label();
      this.NudCurrentResource = new System.Windows.Forms.NumericUpDown();
      this.LabelCurrentResource = new System.Windows.Forms.Label();
      this.ComboboxResourceType = new System.Windows.Forms.ComboBox();
      this.NudMaxResource = new System.Windows.Forms.NumericUpDown();
      this.LabelMaxResource = new System.Windows.Forms.Label();
      this.NudLevel = new System.Windows.Forms.NumericUpDown();
      this.LabelLevel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ImageWObject)).BeginInit();
      this.GroupBoxHealth.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudCurrentHealth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudMaxHealth)).BeginInit();
      this.GroupBoxResource.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudCurrentResource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudMaxResource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudLevel)).BeginInit();
      this.SuspendLayout();
      // 
      // ButtonSave
      // 
      this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.ButtonSave.Location = new System.Drawing.Point(387, 441);
      this.ButtonSave.Name = "ButtonSave";
      this.ButtonSave.Size = new System.Drawing.Size(75, 23);
      this.ButtonSave.TabIndex = 35;
      this.ButtonSave.Text = "Save";
      this.ButtonSave.UseVisualStyleBackColor = true;
      this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
      // 
      // ImageWObject
      // 
      this.ImageWObject.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.ImageWObject.BackColor = System.Drawing.Color.White;
      this.ImageWObject.Location = new System.Drawing.Point(330, 155);
      this.ImageWObject.Name = "ImageWObject";
      this.ImageWObject.Size = new System.Drawing.Size(200, 200);
      this.ImageWObject.TabIndex = 22;
      this.ImageWObject.TabStop = false;
      // 
      // LabelID
      // 
      this.LabelID.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelID.AutoSize = true;
      this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelID.Location = new System.Drawing.Point(333, 358);
      this.LabelID.Name = "LabelID";
      this.LabelID.Size = new System.Drawing.Size(25, 15);
      this.LabelID.TabIndex = 24;
      this.LabelID.Text = "ID:";
      // 
      // TextBoxID
      // 
      this.TextBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxID.Enabled = false;
      this.TextBoxID.Location = new System.Drawing.Point(330, 376);
      this.TextBoxID.Name = "TextBoxID";
      this.TextBoxID.Size = new System.Drawing.Size(200, 20);
      this.TextBoxID.TabIndex = 23;
      // 
      // LabelName
      // 
      this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelName.AutoSize = true;
      this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelName.Location = new System.Drawing.Point(333, 397);
      this.LabelName.Name = "LabelName";
      this.LabelName.Size = new System.Drawing.Size(49, 15);
      this.LabelName.TabIndex = 26;
      this.LabelName.Text = "Name:";
      // 
      // TextBoxName
      // 
      this.TextBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxName.Location = new System.Drawing.Point(330, 415);
      this.TextBoxName.Name = "TextBoxName";
      this.TextBoxName.Size = new System.Drawing.Size(200, 20);
      this.TextBoxName.TabIndex = 25;
      // 
      // LabelImagePath
      // 
      this.LabelImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelImagePath.AutoSize = true;
      this.LabelImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelImagePath.Location = new System.Drawing.Point(559, 159);
      this.LabelImagePath.Name = "LabelImagePath";
      this.LabelImagePath.Size = new System.Drawing.Size(51, 15);
      this.LabelImagePath.TabIndex = 27;
      this.LabelImagePath.Text = "Image:";
      // 
      // ButtonChooseImage
      // 
      this.ButtonChooseImage.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.ButtonChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
      this.ButtonChooseImage.FlatAppearance.BorderSize = 0;
      this.ButtonChooseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
      this.ButtonChooseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.ButtonChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.ButtonChooseImage.ForeColor = System.Drawing.Color.Black;
      this.ButtonChooseImage.Location = new System.Drawing.Point(724, 179);
      this.ButtonChooseImage.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonChooseImage.Name = "ButtonChooseImage";
      this.ButtonChooseImage.Size = new System.Drawing.Size(30, 18);
      this.ButtonChooseImage.TabIndex = 29;
      this.ButtonChooseImage.Text = "...";
      this.ButtonChooseImage.UseVisualStyleBackColor = false;
      this.ButtonChooseImage.Click += new System.EventHandler(this.ButtonChooseImage_Click);
      // 
      // TextBoxImagePath
      // 
      this.TextBoxImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxImagePath.Enabled = false;
      this.TextBoxImagePath.Location = new System.Drawing.Point(556, 178);
      this.TextBoxImagePath.Name = "TextBoxImagePath";
      this.TextBoxImagePath.Size = new System.Drawing.Size(199, 20);
      this.TextBoxImagePath.TabIndex = 28;
      // 
      // OpenFileDialogImage
      // 
      this.OpenFileDialogImage.Filter = "PNG files (*.png; *.PNG)|*.png; *.PNG";
      this.OpenFileDialogImage.ReadOnlyChecked = true;
      this.OpenFileDialogImage.RestoreDirectory = true;
      // 
      // GroupBoxHealth
      // 
      this.GroupBoxHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBoxHealth.Controls.Add(this.NudCurrentHealth);
      this.GroupBoxHealth.Controls.Add(this.LabelCurrentHealth);
      this.GroupBoxHealth.Controls.Add(this.NudMaxHealth);
      this.GroupBoxHealth.Controls.Add(this.LabelMaxHealth);
      this.GroupBoxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.GroupBoxHealth.Location = new System.Drawing.Point(556, 204);
      this.GroupBoxHealth.Name = "GroupBoxHealth";
      this.GroupBoxHealth.Size = new System.Drawing.Size(198, 74);
      this.GroupBoxHealth.TabIndex = 36;
      this.GroupBoxHealth.TabStop = false;
      this.GroupBoxHealth.Text = "Health";
      // 
      // NudCurrentHealth
      // 
      this.NudCurrentHealth.Location = new System.Drawing.Point(108, 39);
      this.NudCurrentHealth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudCurrentHealth.Name = "NudCurrentHealth";
      this.NudCurrentHealth.Size = new System.Drawing.Size(81, 20);
      this.NudCurrentHealth.TabIndex = 40;
      // 
      // LabelCurrentHealth
      // 
      this.LabelCurrentHealth.AutoSize = true;
      this.LabelCurrentHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCurrentHealth.Location = new System.Drawing.Point(110, 21);
      this.LabelCurrentHealth.Name = "LabelCurrentHealth";
      this.LabelCurrentHealth.Size = new System.Drawing.Size(58, 15);
      this.LabelCurrentHealth.TabIndex = 39;
      this.LabelCurrentHealth.Text = "Current:";
      // 
      // NudMaxHealth
      // 
      this.NudMaxHealth.Location = new System.Drawing.Point(12, 39);
      this.NudMaxHealth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudMaxHealth.Name = "NudMaxHealth";
      this.NudMaxHealth.Size = new System.Drawing.Size(81, 20);
      this.NudMaxHealth.TabIndex = 38;
      // 
      // LabelMaxHealth
      // 
      this.LabelMaxHealth.AutoSize = true;
      this.LabelMaxHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelMaxHealth.Location = new System.Drawing.Point(14, 21);
      this.LabelMaxHealth.Name = "LabelMaxHealth";
      this.LabelMaxHealth.Size = new System.Drawing.Size(38, 15);
      this.LabelMaxHealth.TabIndex = 37;
      this.LabelMaxHealth.Text = "Max:";
      // 
      // GroupBoxResource
      // 
      this.GroupBoxResource.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBoxResource.Controls.Add(this.LabelResourceType);
      this.GroupBoxResource.Controls.Add(this.NudCurrentResource);
      this.GroupBoxResource.Controls.Add(this.LabelCurrentResource);
      this.GroupBoxResource.Controls.Add(this.ComboboxResourceType);
      this.GroupBoxResource.Controls.Add(this.NudMaxResource);
      this.GroupBoxResource.Controls.Add(this.LabelMaxResource);
      this.GroupBoxResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.GroupBoxResource.Location = new System.Drawing.Point(556, 284);
      this.GroupBoxResource.Name = "GroupBoxResource";
      this.GroupBoxResource.Size = new System.Drawing.Size(198, 112);
      this.GroupBoxResource.TabIndex = 41;
      this.GroupBoxResource.TabStop = false;
      this.GroupBoxResource.Text = "Resource";
      // 
      // LabelResourceType
      // 
      this.LabelResourceType.AutoSize = true;
      this.LabelResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelResourceType.Location = new System.Drawing.Point(17, 17);
      this.LabelResourceType.Name = "LabelResourceType";
      this.LabelResourceType.Size = new System.Drawing.Size(41, 15);
      this.LabelResourceType.TabIndex = 42;
      this.LabelResourceType.Text = "Type:";
      // 
      // NudCurrentResource
      // 
      this.NudCurrentResource.Location = new System.Drawing.Point(108, 80);
      this.NudCurrentResource.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudCurrentResource.Name = "NudCurrentResource";
      this.NudCurrentResource.Size = new System.Drawing.Size(81, 20);
      this.NudCurrentResource.TabIndex = 40;
      // 
      // LabelCurrentResource
      // 
      this.LabelCurrentResource.AutoSize = true;
      this.LabelCurrentResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCurrentResource.Location = new System.Drawing.Point(110, 62);
      this.LabelCurrentResource.Name = "LabelCurrentResource";
      this.LabelCurrentResource.Size = new System.Drawing.Size(58, 15);
      this.LabelCurrentResource.TabIndex = 39;
      this.LabelCurrentResource.Text = "Current:";
      // 
      // ComboboxResourceType
      // 
      this.ComboboxResourceType.FormattingEnabled = true;
      this.ComboboxResourceType.Location = new System.Drawing.Point(11, 35);
      this.ComboboxResourceType.Name = "ComboboxResourceType";
      this.ComboboxResourceType.Size = new System.Drawing.Size(82, 21);
      this.ComboboxResourceType.TabIndex = 41;
      // 
      // NudMaxResource
      // 
      this.NudMaxResource.Location = new System.Drawing.Point(11, 80);
      this.NudMaxResource.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudMaxResource.Name = "NudMaxResource";
      this.NudMaxResource.Size = new System.Drawing.Size(82, 20);
      this.NudMaxResource.TabIndex = 38;
      // 
      // LabelMaxResource
      // 
      this.LabelMaxResource.AutoSize = true;
      this.LabelMaxResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelMaxResource.Location = new System.Drawing.Point(13, 62);
      this.LabelMaxResource.Name = "LabelMaxResource";
      this.LabelMaxResource.Size = new System.Drawing.Size(38, 15);
      this.LabelMaxResource.TabIndex = 37;
      this.LabelMaxResource.Text = "Max:";
      // 
      // NudLevel
      // 
      this.NudLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.NudLevel.Location = new System.Drawing.Point(556, 416);
      this.NudLevel.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudLevel.Name = "NudLevel";
      this.NudLevel.Size = new System.Drawing.Size(82, 20);
      this.NudLevel.TabIndex = 44;
      // 
      // LabelLevel
      // 
      this.LabelLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelLevel.AutoSize = true;
      this.LabelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelLevel.Location = new System.Drawing.Point(558, 398);
      this.LabelLevel.Name = "LabelLevel";
      this.LabelLevel.Size = new System.Drawing.Size(45, 15);
      this.LabelLevel.TabIndex = 43;
      this.LabelLevel.Text = "Level:";
      // 
      // CharacterEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.Controls.Add(this.NudLevel);
      this.Controls.Add(this.LabelLevel);
      this.Controls.Add(this.GroupBoxResource);
      this.Controls.Add(this.GroupBoxHealth);
      this.Controls.Add(this.ButtonSave);
      this.Controls.Add(this.ImageWObject);
      this.Controls.Add(this.LabelID);
      this.Controls.Add(this.TextBoxID);
      this.Controls.Add(this.LabelName);
      this.Controls.Add(this.TextBoxName);
      this.Controls.Add(this.LabelImagePath);
      this.Controls.Add(this.ButtonChooseImage);
      this.Controls.Add(this.TextBoxImagePath);
      this.Name = "CharacterEditor";
      this.Size = new System.Drawing.Size(1200, 650);
      ((System.ComponentModel.ISupportInitialize)(this.ImageWObject)).EndInit();
      this.GroupBoxHealth.ResumeLayout(false);
      this.GroupBoxHealth.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudCurrentHealth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudMaxHealth)).EndInit();
      this.GroupBoxResource.ResumeLayout(false);
      this.GroupBoxResource.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudCurrentResource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudMaxResource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudLevel)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button ButtonSave;
    private System.Windows.Forms.PictureBox ImageWObject;
    private System.Windows.Forms.Label LabelID;
    private System.Windows.Forms.TextBox TextBoxID;
    private System.Windows.Forms.Label LabelName;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.Label LabelImagePath;
    private System.Windows.Forms.Button ButtonChooseImage;
    private System.Windows.Forms.TextBox TextBoxImagePath;
    private System.Windows.Forms.OpenFileDialog OpenFileDialogImage;
    private System.Windows.Forms.GroupBox GroupBoxHealth;
    private System.Windows.Forms.NumericUpDown NudCurrentHealth;
    private System.Windows.Forms.Label LabelCurrentHealth;
    private System.Windows.Forms.NumericUpDown NudMaxHealth;
    private System.Windows.Forms.Label LabelMaxHealth;
    private System.Windows.Forms.GroupBox GroupBoxResource;
    private System.Windows.Forms.Label LabelResourceType;
    private System.Windows.Forms.NumericUpDown NudCurrentResource;
    private System.Windows.Forms.Label LabelCurrentResource;
    private System.Windows.Forms.ComboBox ComboboxResourceType;
    private System.Windows.Forms.NumericUpDown NudMaxResource;
    private System.Windows.Forms.Label LabelMaxResource;
    private System.Windows.Forms.NumericUpDown NudLevel;
    private System.Windows.Forms.Label LabelLevel;
  }
}
