namespace DreamlandEditor.Controls
{
  partial class MapObjectEditor
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
      this.LabelCommand = new System.Windows.Forms.Label();
      this.TextBoxCommands = new System.Windows.Forms.TextBox();
      this.ButtonSave = new System.Windows.Forms.Button();
      this.ButtonClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LabelCommand
      // 
      this.LabelCommand.AutoSize = true;
      this.LabelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.LabelCommand.ForeColor = System.Drawing.Color.White;
      this.LabelCommand.Location = new System.Drawing.Point(27, 23);
      this.LabelCommand.Name = "LabelCommand";
      this.LabelCommand.Size = new System.Drawing.Size(88, 16);
      this.LabelCommand.TabIndex = 0;
      this.LabelCommand.Text = "Commands:";
      // 
      // TextBoxCommands
      // 
      this.TextBoxCommands.Location = new System.Drawing.Point(12, 53);
      this.TextBoxCommands.Multiline = true;
      this.TextBoxCommands.Name = "TextBoxCommands";
      this.TextBoxCommands.Size = new System.Drawing.Size(358, 351);
      this.TextBoxCommands.TabIndex = 1;
      // 
      // ButtonSave
      // 
      this.ButtonSave.Location = new System.Drawing.Point(82, 418);
      this.ButtonSave.Name = "ButtonSave";
      this.ButtonSave.Size = new System.Drawing.Size(75, 23);
      this.ButtonSave.TabIndex = 2;
      this.ButtonSave.Text = "Save";
      this.ButtonSave.UseVisualStyleBackColor = true;
      this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
      // 
      // ButtonClose
      // 
      this.ButtonClose.Location = new System.Drawing.Point(216, 418);
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.Size = new System.Drawing.Size(75, 23);
      this.ButtonClose.TabIndex = 3;
      this.ButtonClose.Text = "Close";
      this.ButtonClose.UseVisualStyleBackColor = true;
      this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
      // 
      // MapObjectEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.ClientSize = new System.Drawing.Size(382, 453);
      this.ControlBox = false;
      this.Controls.Add(this.ButtonClose);
      this.Controls.Add(this.ButtonSave);
      this.Controls.Add(this.TextBoxCommands);
      this.Controls.Add(this.LabelCommand);
      this.Name = "MapObjectEditor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Edit - MAP_OBJECT";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label LabelCommand;
        private System.Windows.Forms.TextBox TextBoxCommands;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
    }
}