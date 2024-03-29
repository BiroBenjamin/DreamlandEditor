﻿namespace DreamlandEditor.Controls.Editors
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
      this.CheckBoxHasCollision = new System.Windows.Forms.CheckBox();
      this.LabelWidth = new System.Windows.Forms.Label();
      this.NudWidth = new System.Windows.Forms.NumericUpDown();
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
      this.OpenFileDialogImage = new System.Windows.Forms.OpenFileDialog();
      this.NudHeight = new System.Windows.Forms.NumericUpDown();
      this.LabelHeight = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.ImageWObject)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudWidth)).BeginInit();
      this.GroupBoxCollision.SuspendLayout();
      this.GroupBoxCollisionLocation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudCollisionY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudCollisionX)).BeginInit();
      this.GroupBoxCollisionSize.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NudCollisionHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudCollisionWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudHeight)).BeginInit();
      this.SuspendLayout();
      // 
      // ImageWObject
      // 
      this.ImageWObject.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.ImageWObject.BackColor = System.Drawing.Color.White;
      this.ImageWObject.Location = new System.Drawing.Point(330, 155);
      this.ImageWObject.Name = "ImageWObject";
      this.ImageWObject.Size = new System.Drawing.Size(200, 200);
      this.ImageWObject.TabIndex = 0;
      this.ImageWObject.TabStop = false;
      // 
      // TextBoxID
      // 
      this.TextBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxID.Enabled = false;
      this.TextBoxID.Location = new System.Drawing.Point(330, 376);
      this.TextBoxID.Name = "TextBoxID";
      this.TextBoxID.Size = new System.Drawing.Size(200, 20);
      this.TextBoxID.TabIndex = 1;
      // 
      // LabelID
      // 
      this.LabelID.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelID.AutoSize = true;
      this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelID.Location = new System.Drawing.Point(333, 358);
      this.LabelID.Name = "LabelID";
      this.LabelID.Size = new System.Drawing.Size(25, 15);
      this.LabelID.TabIndex = 2;
      this.LabelID.Text = "ID:";
      // 
      // TextBoxName
      // 
      this.TextBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxName.Location = new System.Drawing.Point(330, 415);
      this.TextBoxName.Name = "TextBoxName";
      this.TextBoxName.Size = new System.Drawing.Size(200, 20);
      this.TextBoxName.TabIndex = 3;
      // 
      // LabelName
      // 
      this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelName.AutoSize = true;
      this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelName.Location = new System.Drawing.Point(333, 397);
      this.LabelName.Name = "LabelName";
      this.LabelName.Size = new System.Drawing.Size(49, 15);
      this.LabelName.TabIndex = 4;
      this.LabelName.Text = "Name:";
      // 
      // LabelImagePath
      // 
      this.LabelImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelImagePath.AutoSize = true;
      this.LabelImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelImagePath.Location = new System.Drawing.Point(559, 159);
      this.LabelImagePath.Name = "LabelImagePath";
      this.LabelImagePath.Size = new System.Drawing.Size(51, 15);
      this.LabelImagePath.TabIndex = 5;
      this.LabelImagePath.Text = "Image:";
      // 
      // TextBoxImagePath
      // 
      this.TextBoxImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.TextBoxImagePath.Enabled = false;
      this.TextBoxImagePath.Location = new System.Drawing.Point(556, 178);
      this.TextBoxImagePath.Name = "TextBoxImagePath";
      this.TextBoxImagePath.Size = new System.Drawing.Size(199, 20);
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
      this.ButtonChooseImage.Location = new System.Drawing.Point(724, 179);
      this.ButtonChooseImage.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonChooseImage.Name = "ButtonChooseImage";
      this.ButtonChooseImage.Size = new System.Drawing.Size(30, 18);
      this.ButtonChooseImage.TabIndex = 7;
      this.ButtonChooseImage.Text = "...";
      this.ButtonChooseImage.UseVisualStyleBackColor = false;
      this.ButtonChooseImage.Click += new System.EventHandler(this.ButtonChooseImage_Click);
      // 
      // CheckBoxHasCollision
      // 
      this.CheckBoxHasCollision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.CheckBoxHasCollision.AutoSize = true;
      this.CheckBoxHasCollision.BackColor = System.Drawing.Color.White;
      this.CheckBoxHasCollision.Checked = true;
      this.CheckBoxHasCollision.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CheckBoxHasCollision.FlatAppearance.BorderSize = 2;
      this.CheckBoxHasCollision.Location = new System.Drawing.Point(308, 9);
      this.CheckBoxHasCollision.Name = "ChechBoxHasCollision";
      this.CheckBoxHasCollision.Size = new System.Drawing.Size(15, 14);
      this.CheckBoxHasCollision.TabIndex = 9;
      this.CheckBoxHasCollision.UseVisualStyleBackColor = false;
      this.CheckBoxHasCollision.CheckedChanged += new System.EventHandler(this.ChechBoxHasCollision_CheckedChanged);
      this.CheckBoxHasCollision.CheckStateChanged += new System.EventHandler(this.RenderCollision);
      // 
      // LabelWidth
      // 
      this.LabelWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelWidth.AutoSize = true;
      this.LabelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelWidth.Location = new System.Drawing.Point(559, 206);
      this.LabelWidth.Name = "LabelWidth";
      this.LabelWidth.Size = new System.Drawing.Size(47, 15);
      this.LabelWidth.TabIndex = 10;
      this.LabelWidth.Text = "Width:";
      // 
      // NudWidth
      // 
      this.NudWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.NudWidth.Enabled = false;
      this.NudWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.NudWidth.Location = new System.Drawing.Point(610, 204);
      this.NudWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudWidth.Name = "NudWidth";
      this.NudWidth.Size = new System.Drawing.Size(42, 20);
      this.NudWidth.TabIndex = 11;
      this.NudWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // CheckBoxIsInteractable
      // 
      this.CheckBoxIsInteractable.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.CheckBoxIsInteractable.AutoSize = true;
      this.CheckBoxIsInteractable.Location = new System.Drawing.Point(740, 230);
      this.CheckBoxIsInteractable.Name = "CheckBoxIsInteractable";
      this.CheckBoxIsInteractable.Size = new System.Drawing.Size(15, 14);
      this.CheckBoxIsInteractable.TabIndex = 13;
      this.CheckBoxIsInteractable.UseVisualStyleBackColor = true;
      // 
      // LabelIsInteractable
      // 
      this.LabelIsInteractable.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelIsInteractable.AutoSize = true;
      this.LabelIsInteractable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelIsInteractable.Location = new System.Drawing.Point(559, 230);
      this.LabelIsInteractable.Name = "LabelIsInteractable";
      this.LabelIsInteractable.Size = new System.Drawing.Size(102, 15);
      this.LabelIsInteractable.TabIndex = 12;
      this.LabelIsInteractable.Text = "Is interactable:";
      // 
      // LabelCollisionWidth
      // 
      this.LabelCollisionWidth.AutoSize = true;
      this.LabelCollisionWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCollisionWidth.Location = new System.Drawing.Point(11, 18);
      this.LabelCollisionWidth.Name = "LabelCollisionWidth";
      this.LabelCollisionWidth.Size = new System.Drawing.Size(105, 15);
      this.LabelCollisionWidth.TabIndex = 15;
      this.LabelCollisionWidth.Text = "Collision width:";
      // 
      // GroupBoxCollision
      // 
      this.GroupBoxCollision.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBoxCollision.Controls.Add(this.CheckBoxRenderCollision);
      this.GroupBoxCollision.Controls.Add(this.GroupBoxCollisionLocation);
      this.GroupBoxCollision.Controls.Add(this.GroupBoxCollisionSize);
      this.GroupBoxCollision.Controls.Add(this.CheckBoxHasCollision);
      this.GroupBoxCollision.Location = new System.Drawing.Point(545, 253);
      this.GroupBoxCollision.Name = "GroupBoxCollision";
      this.GroupBoxCollision.Size = new System.Drawing.Size(326, 157);
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
      this.CheckBoxRenderCollision.Location = new System.Drawing.Point(109, 130);
      this.CheckBoxRenderCollision.Name = "CheckBoxRenderCollision";
      this.CheckBoxRenderCollision.Size = new System.Drawing.Size(107, 18);
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
      this.GroupBoxCollisionLocation.Location = new System.Drawing.Point(166, 19);
      this.GroupBoxCollisionLocation.Name = "GroupBoxCollisionLocation";
      this.GroupBoxCollisionLocation.Size = new System.Drawing.Size(140, 105);
      this.GroupBoxCollisionLocation.TabIndex = 19;
      this.GroupBoxCollisionLocation.TabStop = false;
      this.GroupBoxCollisionLocation.Text = "Collision location:";
      // 
      // NudCollisionY
      // 
      this.NudCollisionY.Location = new System.Drawing.Point(9, 79);
      this.NudCollisionY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudCollisionY.Name = "NudCollisionY";
      this.NudCollisionY.Size = new System.Drawing.Size(120, 20);
      this.NudCollisionY.TabIndex = 21;
      this.NudCollisionY.ValueChanged += new System.EventHandler(this.RenderCollision);
      // 
      // NudCollisionX
      // 
      this.NudCollisionX.Location = new System.Drawing.Point(9, 38);
      this.NudCollisionX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudCollisionX.Name = "NudCollisionX";
      this.NudCollisionX.Size = new System.Drawing.Size(120, 20);
      this.NudCollisionX.TabIndex = 19;
      this.NudCollisionX.ValueChanged += new System.EventHandler(this.RenderCollision);
      // 
      // LabelCollisionY
      // 
      this.LabelCollisionY.AutoSize = true;
      this.LabelCollisionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCollisionY.Location = new System.Drawing.Point(13, 61);
      this.LabelCollisionY.Name = "LabelCollisionY";
      this.LabelCollisionY.Size = new System.Drawing.Size(115, 15);
      this.LabelCollisionY.TabIndex = 20;
      this.LabelCollisionY.Text = "Collision Y point:";
      // 
      // LabelCollisionX
      // 
      this.LabelCollisionX.AutoSize = true;
      this.LabelCollisionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCollisionX.Location = new System.Drawing.Point(13, 20);
      this.LabelCollisionX.Name = "LabelCollisionX";
      this.LabelCollisionX.Size = new System.Drawing.Size(116, 15);
      this.LabelCollisionX.TabIndex = 19;
      this.LabelCollisionX.Text = "Collision X point:";
      // 
      // GroupBoxCollisionSize
      // 
      this.GroupBoxCollisionSize.Controls.Add(this.LabelCollisionHeight);
      this.GroupBoxCollisionSize.Controls.Add(this.NudCollisionHeight);
      this.GroupBoxCollisionSize.Controls.Add(this.NudCollisionWidth);
      this.GroupBoxCollisionSize.Controls.Add(this.LabelCollisionWidth);
      this.GroupBoxCollisionSize.Location = new System.Drawing.Point(13, 19);
      this.GroupBoxCollisionSize.Name = "GroupBoxCollisionSize";
      this.GroupBoxCollisionSize.Size = new System.Drawing.Size(140, 105);
      this.GroupBoxCollisionSize.TabIndex = 18;
      this.GroupBoxCollisionSize.TabStop = false;
      this.GroupBoxCollisionSize.Text = "Collision size:";
      // 
      // LabelCollisionHeight
      // 
      this.LabelCollisionHeight.AutoSize = true;
      this.LabelCollisionHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCollisionHeight.Location = new System.Drawing.Point(11, 61);
      this.LabelCollisionHeight.Name = "LabelCollisionHeight";
      this.LabelCollisionHeight.Size = new System.Drawing.Size(111, 15);
      this.LabelCollisionHeight.TabIndex = 18;
      this.LabelCollisionHeight.Text = "Collision height:";
      // 
      // NudCollisionHeight
      // 
      this.NudCollisionHeight.Location = new System.Drawing.Point(9, 79);
      this.NudCollisionHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudCollisionHeight.Name = "NudCollisionHeight";
      this.NudCollisionHeight.Size = new System.Drawing.Size(120, 20);
      this.NudCollisionHeight.TabIndex = 17;
      this.NudCollisionHeight.ValueChanged += new System.EventHandler(this.RenderCollision);
      // 
      // NudCollisionWidth
      // 
      this.NudCollisionWidth.Location = new System.Drawing.Point(9, 36);
      this.NudCollisionWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudCollisionWidth.Name = "NudCollisionWidth";
      this.NudCollisionWidth.Size = new System.Drawing.Size(120, 20);
      this.NudCollisionWidth.TabIndex = 16;
      this.NudCollisionWidth.ValueChanged += new System.EventHandler(this.RenderCollision);
      // 
      // ButtonSave
      // 
      this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.ButtonSave.Location = new System.Drawing.Point(387, 441);
      this.ButtonSave.Name = "ButtonSave";
      this.ButtonSave.Size = new System.Drawing.Size(75, 23);
      this.ButtonSave.TabIndex = 19;
      this.ButtonSave.Text = "Save";
      this.ButtonSave.UseVisualStyleBackColor = true;
      this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
      // 
      // OpenFileDialogImage
      // 
      this.OpenFileDialogImage.FileName = "openFileDialog1";
      // 
      // NudHeight
      // 
      this.NudHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.NudHeight.Enabled = false;
      this.NudHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.NudHeight.Location = new System.Drawing.Point(715, 206);
      this.NudHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.NudHeight.Name = "NudHeight";
      this.NudHeight.Size = new System.Drawing.Size(42, 20);
      this.NudHeight.TabIndex = 20;
      this.NudHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // LabelHeight
      // 
      this.LabelHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.LabelHeight.AutoSize = true;
      this.LabelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelHeight.Location = new System.Drawing.Point(658, 206);
      this.LabelHeight.Name = "LabelHeight";
      this.LabelHeight.Size = new System.Drawing.Size(53, 15);
      this.LabelHeight.TabIndex = 21;
      this.LabelHeight.Text = "Height:";
      // 
      // WorldObjectEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.Controls.Add(this.LabelHeight);
      this.Controls.Add(this.NudHeight);
      this.Controls.Add(this.ButtonSave);
      this.Controls.Add(this.GroupBoxCollision);
      this.Controls.Add(this.CheckBoxIsInteractable);
      this.Controls.Add(this.LabelIsInteractable);
      this.Controls.Add(this.NudWidth);
      this.Controls.Add(this.LabelWidth);
      this.Controls.Add(this.ImageWObject);
      this.Controls.Add(this.LabelID);
      this.Controls.Add(this.TextBoxID);
      this.Controls.Add(this.LabelName);
      this.Controls.Add(this.TextBoxName);
      this.Controls.Add(this.LabelImagePath);
      this.Controls.Add(this.ButtonChooseImage);
      this.Controls.Add(this.TextBoxImagePath);
      this.Name = "WorldObjectEditor";
      this.Size = new System.Drawing.Size(1200, 650);
      ((System.ComponentModel.ISupportInitialize)(this.ImageWObject)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NudWidth)).EndInit();
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
      ((System.ComponentModel.ISupportInitialize)(this.NudHeight)).EndInit();
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
        private System.Windows.Forms.CheckBox CheckBoxHasCollision;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.NumericUpDown NudWidth;
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
        private System.Windows.Forms.OpenFileDialog OpenFileDialogImage;
        private System.Windows.Forms.NumericUpDown NudHeight;
        private System.Windows.Forms.Label LabelHeight;
    }
}
