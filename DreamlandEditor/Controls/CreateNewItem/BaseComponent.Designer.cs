namespace DreamlandEditor.Controls.CreateNewItem
{
  partial class BaseComponent
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
      this.PanelBaseData = new System.Windows.Forms.Panel();
      this.LabelFileType = new System.Windows.Forms.Label();
      this.ComboboxFileType = new System.Windows.Forms.ComboBox();
      this.LabelFileID = new System.Windows.Forms.Label();
      this.TextboxFileID = new System.Windows.Forms.TextBox();
      this.TextboxFileName = new System.Windows.Forms.TextBox();
      this.LabelFileName = new System.Windows.Forms.Label();
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.ButtonCancel = new System.Windows.Forms.Button();
      this.ButtonAccept = new System.Windows.Forms.Button();
      this.PanelBaseData.SuspendLayout();
      this.PanelButtons.SuspendLayout();
      this.SuspendLayout();
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
      this.PanelBaseData.Name = "PanelBaseData";
      this.PanelBaseData.Size = new System.Drawing.Size(378, 106);
      this.PanelBaseData.TabIndex = 7;
      // 
      // LabelFileType
      // 
      this.LabelFileType.AutoSize = true;
      this.LabelFileType.ForeColor = System.Drawing.Color.White;
      this.LabelFileType.Location = new System.Drawing.Point(197, 11);
      this.LabelFileType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.LabelFileType.Name = "LabelFileType";
      this.LabelFileType.Size = new System.Drawing.Size(53, 13);
      this.LabelFileType.TabIndex = 5;
      this.LabelFileType.Text = "File Type:";
      // 
      // ComboboxFileType
      // 
      this.ComboboxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboboxFileType.FormattingEnabled = true;
      this.ComboboxFileType.Location = new System.Drawing.Point(200, 27);
      this.ComboboxFileType.Name = "ComboboxFileType";
      this.ComboboxFileType.Size = new System.Drawing.Size(147, 21);
      this.ComboboxFileType.Sorted = true;
      this.ComboboxFileType.TabIndex = 4;
      // 
      // LabelFileID
      // 
      this.LabelFileID.AutoSize = true;
      this.LabelFileID.ForeColor = System.Drawing.Color.White;
      this.LabelFileID.Location = new System.Drawing.Point(17, 11);
      this.LabelFileID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.LabelFileID.Name = "LabelFileID";
      this.LabelFileID.Size = new System.Drawing.Size(57, 13);
      this.LabelFileID.TabIndex = 3;
      this.LabelFileID.Text = "File Name:";
      // 
      // TextboxFileID
      // 
      this.TextboxFileID.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.TextboxFileID.Location = new System.Drawing.Point(20, 27);
      this.TextboxFileID.Margin = new System.Windows.Forms.Padding(2);
      this.TextboxFileID.Name = "TextboxFileID";
      this.TextboxFileID.Size = new System.Drawing.Size(147, 20);
      this.TextboxFileID.TabIndex = 2;
      // 
      // TextboxFileName
      // 
      this.TextboxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.TextboxFileName.Location = new System.Drawing.Point(20, 72);
      this.TextboxFileName.Margin = new System.Windows.Forms.Padding(2);
      this.TextboxFileName.Name = "TextboxFileName";
      this.TextboxFileName.Size = new System.Drawing.Size(147, 20);
      this.TextboxFileName.TabIndex = 6;
      // 
      // LabelFileName
      // 
      this.LabelFileName.AutoSize = true;
      this.LabelFileName.ForeColor = System.Drawing.Color.White;
      this.LabelFileName.Location = new System.Drawing.Point(17, 58);
      this.LabelFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.LabelFileName.Name = "LabelFileName";
      this.LabelFileName.Size = new System.Drawing.Size(86, 13);
      this.LabelFileName.TabIndex = 6;
      this.LabelFileName.Text = "PLACEHOLDER";
      // 
      // PanelButtons
      // 
      this.PanelButtons.Controls.Add(this.ButtonCancel);
      this.PanelButtons.Controls.Add(this.ButtonAccept);
      this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PanelButtons.Location = new System.Drawing.Point(0, 458);
      this.PanelButtons.Name = "PanelButtons";
      this.PanelButtons.Size = new System.Drawing.Size(378, 30);
      this.PanelButtons.TabIndex = 8;
      // 
      // ButtonCancel
      // 
      this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.ButtonCancel.Location = new System.Drawing.Point(187, 5);
      this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
      this.ButtonCancel.Name = "ButtonCancel";
      this.ButtonCancel.Size = new System.Drawing.Size(56, 19);
      this.ButtonCancel.TabIndex = 1;
      this.ButtonCancel.Text = "Cancel";
      this.ButtonCancel.UseVisualStyleBackColor = true;
      // 
      // ButtonAccept
      // 
      this.ButtonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonAccept.Location = new System.Drawing.Point(127, 5);
      this.ButtonAccept.Margin = new System.Windows.Forms.Padding(2);
      this.ButtonAccept.Name = "ButtonAccept";
      this.ButtonAccept.Size = new System.Drawing.Size(56, 19);
      this.ButtonAccept.TabIndex = 0;
      this.ButtonAccept.Text = "Ok";
      this.ButtonAccept.UseVisualStyleBackColor = true;
      // 
      // BaseComponent
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.Controls.Add(this.PanelBaseData);
      this.Controls.Add(this.PanelButtons);
      this.Name = "BaseComponent";
      this.Size = new System.Drawing.Size(378, 488);
      this.PanelBaseData.ResumeLayout(false);
      this.PanelBaseData.PerformLayout();
      this.PanelButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PanelBaseData;
    private System.Windows.Forms.Label LabelFileType;
    private System.Windows.Forms.ComboBox ComboboxFileType;
    private System.Windows.Forms.Label LabelFileID;
    private System.Windows.Forms.TextBox TextboxFileID;
    private System.Windows.Forms.TextBox TextboxFileName;
    private System.Windows.Forms.Label LabelFileName;
    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.Button ButtonCancel;
    private System.Windows.Forms.Button ButtonAccept;
  }
}
