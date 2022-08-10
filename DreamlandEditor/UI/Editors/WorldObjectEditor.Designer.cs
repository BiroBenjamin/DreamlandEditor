namespace DreamlandEditor.UI.Editors
{
    partial class WorldObjectEditor
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
			this.ImageWObject = new System.Windows.Forms.PictureBox();
			this.TextBoxID = new System.Windows.Forms.TextBox();
			this.LabelID = new System.Windows.Forms.Label();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.LabelName = new System.Windows.Forms.Label();
			this.LabelImagePath = new System.Windows.Forms.Label();
			this.TextBoxImagePath = new System.Windows.Forms.TextBox();
			this.ButtonChooseImage = new System.Windows.Forms.Button();
			this.ChechBoxHasCollision = new System.Windows.Forms.CheckBox();
			this.LabelSize = new System.Windows.Forms.Label();
			this.NudSize = new System.Windows.Forms.NumericUpDown();
			this.CheckBoxIsInteractable = new System.Windows.Forms.CheckBox();
			this.LabelIsInteractable = new System.Windows.Forms.Label();
			this.LabelCollisionWidth = new System.Windows.Forms.Label();
			this.GroupBoxCollision = new System.Windows.Forms.GroupBox();
			this.CheckBoxRenderCollision = new System.Windows.Forms.CheckBox();
			this.GroupBoxCollisionLocation = new System.Windows.Forms.GroupBox();
			this.NudCollisionY = new System.Windows.Forms.NumericUpDown();
			this.NudCollisionX = new System.Windows.Forms.NumericUpDown();
			this.LabelCollisionY = new System.Windows.Forms.Label();
			this.LabelCollisionX = new System.Windows.Forms.Label();
			this.GroupBoxCollisionSize = new System.Windows.Forms.GroupBox();
			this.LabelCollisionHeight = new System.Windows.Forms.Label();
			this.NudCollisionHeight = new System.Windows.Forms.NumericUpDown();
			this.NudCollisionWidth = new System.Windows.Forms.NumericUpDown();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.FolderBrowserImage = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.ImageWObject)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NudSize)).BeginInit();
			this.GroupBoxCollision.SuspendLayout();
			this.GroupBoxCollisionLocation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionX)).BeginInit();
			this.GroupBoxCollisionSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageWObject
			// 
			this.ImageWObject.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ImageWObject.BackColor = System.Drawing.Color.White;
			this.ImageWObject.Location = new System.Drawing.Point(440, 191);
			this.ImageWObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ImageWObject.Name = "ImageWObject";
			this.ImageWObject.Size = new System.Drawing.Size(267, 246);
			this.ImageWObject.TabIndex = 0;
			this.ImageWObject.TabStop = false;
			// 
			// TextBoxID
			// 
			this.TextBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBoxID.Enabled = false;
			this.TextBoxID.Location = new System.Drawing.Point(440, 463);
			this.TextBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TextBoxID.Name = "TextBoxID";
			this.TextBoxID.Size = new System.Drawing.Size(265, 22);
			this.TextBoxID.TabIndex = 1;
			// 
			// LabelID
			// 
			this.LabelID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelID.AutoSize = true;
			this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelID.Location = new System.Drawing.Point(444, 441);
			this.LabelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelID.Name = "LabelID";
			this.LabelID.Size = new System.Drawing.Size(29, 18);
			this.LabelID.TabIndex = 2;
			this.LabelID.Text = "ID:";
			// 
			// TextBoxName
			// 
			this.TextBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBoxName.Location = new System.Drawing.Point(440, 511);
			this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(265, 22);
			this.TextBoxName.TabIndex = 3;
			// 
			// LabelName
			// 
			this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelName.AutoSize = true;
			this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelName.Location = new System.Drawing.Point(444, 489);
			this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelName.Name = "LabelName";
			this.LabelName.Size = new System.Drawing.Size(57, 18);
			this.LabelName.TabIndex = 4;
			this.LabelName.Text = "Name:";
			// 
			// LabelImagePath
			// 
			this.LabelImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelImagePath.AutoSize = true;
			this.LabelImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelImagePath.Location = new System.Drawing.Point(745, 228);
			this.LabelImagePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelImagePath.Name = "LabelImagePath";
			this.LabelImagePath.Size = new System.Drawing.Size(58, 18);
			this.LabelImagePath.TabIndex = 5;
			this.LabelImagePath.Text = "Image:";
			// 
			// TextBoxImagePath
			// 
			this.TextBoxImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBoxImagePath.Enabled = false;
			this.TextBoxImagePath.Location = new System.Drawing.Point(741, 251);
			this.TextBoxImagePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TextBoxImagePath.Name = "TextBoxImagePath";
			this.TextBoxImagePath.Size = new System.Drawing.Size(264, 22);
			this.TextBoxImagePath.TabIndex = 6;
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
			this.ButtonChooseImage.Location = new System.Drawing.Point(965, 252);
			this.ButtonChooseImage.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonChooseImage.Name = "ButtonChooseImage";
			this.ButtonChooseImage.Size = new System.Drawing.Size(40, 22);
			this.ButtonChooseImage.TabIndex = 7;
			this.ButtonChooseImage.Text = "...";
			this.ButtonChooseImage.UseVisualStyleBackColor = false;
			this.ButtonChooseImage.Click += new System.EventHandler(this.ButtonChooseImage_Click);
			// 
			// ChechBoxHasCollision
			// 
			this.ChechBoxHasCollision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ChechBoxHasCollision.AutoSize = true;
			this.ChechBoxHasCollision.BackColor = System.Drawing.Color.White;
			this.ChechBoxHasCollision.Checked = true;
			this.ChechBoxHasCollision.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChechBoxHasCollision.FlatAppearance.BorderSize = 2;
			this.ChechBoxHasCollision.Location = new System.Drawing.Point(413, 11);
			this.ChechBoxHasCollision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ChechBoxHasCollision.Name = "ChechBoxHasCollision";
			this.ChechBoxHasCollision.Size = new System.Drawing.Size(18, 17);
			this.ChechBoxHasCollision.TabIndex = 9;
			this.ChechBoxHasCollision.UseVisualStyleBackColor = false;
			this.ChechBoxHasCollision.CheckedChanged += new System.EventHandler(this.ChechBoxHasCollision_CheckedChanged);
			this.ChechBoxHasCollision.CheckStateChanged += new System.EventHandler(this.RenderCollision);
			// 
			// LabelSize
			// 
			this.LabelSize.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelSize.AutoSize = true;
			this.LabelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelSize.Location = new System.Drawing.Point(745, 283);
			this.LabelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelSize.Name = "LabelSize";
			this.LabelSize.Size = new System.Drawing.Size(46, 18);
			this.LabelSize.TabIndex = 10;
			this.LabelSize.Text = "Size:";
			// 
			// NudSize
			// 
			this.NudSize.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NudSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NudSize.Location = new System.Drawing.Point(951, 283);
			this.NudSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NudSize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.NudSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.NudSize.Name = "NudSize";
			this.NudSize.Size = new System.Drawing.Size(56, 22);
			this.NudSize.TabIndex = 11;
			this.NudSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// CheckBoxIsInteractable
			// 
			this.CheckBoxIsInteractable.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CheckBoxIsInteractable.AutoSize = true;
			this.CheckBoxIsInteractable.Location = new System.Drawing.Point(987, 315);
			this.CheckBoxIsInteractable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CheckBoxIsInteractable.Name = "CheckBoxIsInteractable";
			this.CheckBoxIsInteractable.Size = new System.Drawing.Size(18, 17);
			this.CheckBoxIsInteractable.TabIndex = 13;
			this.CheckBoxIsInteractable.UseVisualStyleBackColor = true;
			// 
			// LabelIsInteractable
			// 
			this.LabelIsInteractable.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelIsInteractable.AutoSize = true;
			this.LabelIsInteractable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelIsInteractable.Location = new System.Drawing.Point(745, 315);
			this.LabelIsInteractable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelIsInteractable.Name = "LabelIsInteractable";
			this.LabelIsInteractable.Size = new System.Drawing.Size(118, 18);
			this.LabelIsInteractable.TabIndex = 12;
			this.LabelIsInteractable.Text = "Is interactable:";
			// 
			// LabelCollisionWidth
			// 
			this.LabelCollisionWidth.AutoSize = true;
			this.LabelCollisionWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCollisionWidth.Location = new System.Drawing.Point(15, 22);
			this.LabelCollisionWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelCollisionWidth.Name = "LabelCollisionWidth";
			this.LabelCollisionWidth.Size = new System.Drawing.Size(123, 18);
			this.LabelCollisionWidth.TabIndex = 15;
			this.LabelCollisionWidth.Text = "Collision width:";
			// 
			// GroupBoxCollision
			// 
			this.GroupBoxCollision.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GroupBoxCollision.Controls.Add(this.CheckBoxRenderCollision);
			this.GroupBoxCollision.Controls.Add(this.GroupBoxCollisionLocation);
			this.GroupBoxCollision.Controls.Add(this.GroupBoxCollisionSize);
			this.GroupBoxCollision.Controls.Add(this.ChechBoxHasCollision);
			this.GroupBoxCollision.Location = new System.Drawing.Point(727, 343);
			this.GroupBoxCollision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.GroupBoxCollision.Name = "GroupBoxCollision";
			this.GroupBoxCollision.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.GroupBoxCollision.Size = new System.Drawing.Size(435, 193);
			this.GroupBoxCollision.TabIndex = 18;
			this.GroupBoxCollision.TabStop = false;
			this.GroupBoxCollision.Text = "Collision";
			// 
			// CheckBoxRenderCollision
			// 
			this.CheckBoxRenderCollision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckBoxRenderCollision.AutoSize = true;
			this.CheckBoxRenderCollision.BackColor = System.Drawing.Color.White;
			this.CheckBoxRenderCollision.Checked = true;
			this.CheckBoxRenderCollision.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxRenderCollision.FlatAppearance.BorderSize = 2;
			this.CheckBoxRenderCollision.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CheckBoxRenderCollision.Location = new System.Drawing.Point(153, 160);
			this.CheckBoxRenderCollision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CheckBoxRenderCollision.Name = "CheckBoxRenderCollision";
			this.CheckBoxRenderCollision.Size = new System.Drawing.Size(135, 21);
			this.CheckBoxRenderCollision.TabIndex = 20;
			this.CheckBoxRenderCollision.Text = "Render collision";
			this.CheckBoxRenderCollision.UseVisualStyleBackColor = false;
			this.CheckBoxRenderCollision.CheckStateChanged += new System.EventHandler(this.RenderCollision);
			// 
			// GroupBoxCollisionLocation
			// 
			this.GroupBoxCollisionLocation.Controls.Add(this.NudCollisionY);
			this.GroupBoxCollisionLocation.Controls.Add(this.NudCollisionX);
			this.GroupBoxCollisionLocation.Controls.Add(this.LabelCollisionY);
			this.GroupBoxCollisionLocation.Controls.Add(this.LabelCollisionX);
			this.GroupBoxCollisionLocation.Location = new System.Drawing.Point(221, 23);
			this.GroupBoxCollisionLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.GroupBoxCollisionLocation.Name = "GroupBoxCollisionLocation";
			this.GroupBoxCollisionLocation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.GroupBoxCollisionLocation.Size = new System.Drawing.Size(187, 129);
			this.GroupBoxCollisionLocation.TabIndex = 19;
			this.GroupBoxCollisionLocation.TabStop = false;
			this.GroupBoxCollisionLocation.Text = "Collision location:";
			// 
			// NudCollisionY
			// 
			this.NudCollisionY.Location = new System.Drawing.Point(12, 97);
			this.NudCollisionY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NudCollisionY.Name = "NudCollisionY";
			this.NudCollisionY.Size = new System.Drawing.Size(160, 22);
			this.NudCollisionY.TabIndex = 21;
			this.NudCollisionY.ValueChanged += new System.EventHandler(this.RenderCollision);
			// 
			// NudCollisionX
			// 
			this.NudCollisionX.Location = new System.Drawing.Point(12, 47);
			this.NudCollisionX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NudCollisionX.Name = "NudCollisionX";
			this.NudCollisionX.Size = new System.Drawing.Size(160, 22);
			this.NudCollisionX.TabIndex = 19;
			this.NudCollisionX.ValueChanged += new System.EventHandler(this.RenderCollision);
			// 
			// LabelCollisionY
			// 
			this.LabelCollisionY.AutoSize = true;
			this.LabelCollisionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCollisionY.Location = new System.Drawing.Point(17, 75);
			this.LabelCollisionY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelCollisionY.Name = "LabelCollisionY";
			this.LabelCollisionY.Size = new System.Drawing.Size(136, 18);
			this.LabelCollisionY.TabIndex = 20;
			this.LabelCollisionY.Text = "Collision Y point:";
			// 
			// LabelCollisionX
			// 
			this.LabelCollisionX.AutoSize = true;
			this.LabelCollisionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCollisionX.Location = new System.Drawing.Point(17, 25);
			this.LabelCollisionX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelCollisionX.Name = "LabelCollisionX";
			this.LabelCollisionX.Size = new System.Drawing.Size(137, 18);
			this.LabelCollisionX.TabIndex = 19;
			this.LabelCollisionX.Text = "Collision X point:";
			// 
			// GroupBoxCollisionSize
			// 
			this.GroupBoxCollisionSize.Controls.Add(this.LabelCollisionHeight);
			this.GroupBoxCollisionSize.Controls.Add(this.NudCollisionHeight);
			this.GroupBoxCollisionSize.Controls.Add(this.NudCollisionWidth);
			this.GroupBoxCollisionSize.Controls.Add(this.LabelCollisionWidth);
			this.GroupBoxCollisionSize.Location = new System.Drawing.Point(17, 23);
			this.GroupBoxCollisionSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.GroupBoxCollisionSize.Name = "GroupBoxCollisionSize";
			this.GroupBoxCollisionSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.GroupBoxCollisionSize.Size = new System.Drawing.Size(187, 129);
			this.GroupBoxCollisionSize.TabIndex = 18;
			this.GroupBoxCollisionSize.TabStop = false;
			this.GroupBoxCollisionSize.Text = "Collision size:";
			// 
			// LabelCollisionHeight
			// 
			this.LabelCollisionHeight.AutoSize = true;
			this.LabelCollisionHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelCollisionHeight.Location = new System.Drawing.Point(15, 75);
			this.LabelCollisionHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelCollisionHeight.Name = "LabelCollisionHeight";
			this.LabelCollisionHeight.Size = new System.Drawing.Size(129, 18);
			this.LabelCollisionHeight.TabIndex = 18;
			this.LabelCollisionHeight.Text = "Collision height:";
			// 
			// NudCollisionHeight
			// 
			this.NudCollisionHeight.Location = new System.Drawing.Point(12, 97);
			this.NudCollisionHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NudCollisionHeight.Name = "NudCollisionHeight";
			this.NudCollisionHeight.Size = new System.Drawing.Size(160, 22);
			this.NudCollisionHeight.TabIndex = 17;
			this.NudCollisionHeight.ValueChanged += new System.EventHandler(this.RenderCollision);
			// 
			// NudCollisionWidth
			// 
			this.NudCollisionWidth.Location = new System.Drawing.Point(12, 44);
			this.NudCollisionWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NudCollisionWidth.Name = "NudCollisionWidth";
			this.NudCollisionWidth.Size = new System.Drawing.Size(160, 22);
			this.NudCollisionWidth.TabIndex = 16;
			this.NudCollisionWidth.ValueChanged += new System.EventHandler(this.RenderCollision);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonSave.Location = new System.Drawing.Point(516, 543);
			this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(100, 28);
			this.ButtonSave.TabIndex = 19;
			this.ButtonSave.Text = "Save";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// FolderBrowserImage
			// 
			this.FolderBrowserImage.FileName = "openFileDialog1";
			// 
			// WorldObjectEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.GroupBoxCollision);
			this.Controls.Add(this.CheckBoxIsInteractable);
			this.Controls.Add(this.LabelIsInteractable);
			this.Controls.Add(this.NudSize);
			this.Controls.Add(this.LabelSize);
			this.Controls.Add(this.ImageWObject);
			this.Controls.Add(this.LabelID);
			this.Controls.Add(this.TextBoxID);
			this.Controls.Add(this.LabelName);
			this.Controls.Add(this.TextBoxName);
			this.Controls.Add(this.LabelImagePath);
			this.Controls.Add(this.ButtonChooseImage);
			this.Controls.Add(this.TextBoxImagePath);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "WorldObjectEditor";
			this.Size = new System.Drawing.Size(1600, 800);
			((System.ComponentModel.ISupportInitialize)(this.ImageWObject)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NudSize)).EndInit();
			this.GroupBoxCollision.ResumeLayout(false);
			this.GroupBoxCollision.PerformLayout();
			this.GroupBoxCollisionLocation.ResumeLayout(false);
			this.GroupBoxCollisionLocation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionX)).EndInit();
			this.GroupBoxCollisionSize.ResumeLayout(false);
			this.GroupBoxCollisionSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NudCollisionWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageWObject;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelImagePath;
        private System.Windows.Forms.TextBox TextBoxImagePath;
        private System.Windows.Forms.Button ButtonChooseImage;
        private System.Windows.Forms.CheckBox ChechBoxHasCollision;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.NumericUpDown NudSize;
        private System.Windows.Forms.CheckBox CheckBoxIsInteractable;
        private System.Windows.Forms.Label LabelIsInteractable;
        private System.Windows.Forms.Label LabelCollisionWidth;
        private System.Windows.Forms.GroupBox GroupBoxCollision;
        private System.Windows.Forms.GroupBox GroupBoxCollisionSize;
        private System.Windows.Forms.GroupBox GroupBoxCollisionLocation;
        private System.Windows.Forms.Label LabelCollisionHeight;
        private System.Windows.Forms.NumericUpDown NudCollisionHeight;
        private System.Windows.Forms.NumericUpDown NudCollisionWidth;
        private System.Windows.Forms.CheckBox CheckBoxRenderCollision;
        private System.Windows.Forms.NumericUpDown NudCollisionY;
        private System.Windows.Forms.NumericUpDown NudCollisionX;
        private System.Windows.Forms.Label LabelCollisionY;
        private System.Windows.Forms.Label LabelCollisionX;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.OpenFileDialog FolderBrowserImage;
    }
}
