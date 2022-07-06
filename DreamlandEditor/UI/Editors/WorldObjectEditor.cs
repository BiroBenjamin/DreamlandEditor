using DreamlandEditor.UI.UIPanels;
using System.Windows.Forms;

namespace DreamlandEditor.UI.Editors {
    class WorldObjectEditor : BaseEditor {
        private UiPanel uiPanel1;

        public WorldObjectEditor() : base() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.uiPanel1 = new DreamlandEditor.UI.UIPanels.UiPanel();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.uiPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiPanel1.Location = new System.Drawing.Point(110, 110);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(200, 100);
            this.uiPanel1.TabIndex = 0;
            // 
            // ItemEditor
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Name = "WorldObjectEditor";
            this.Size = new System.Drawing.Size(1248, 806);
            this.ResumeLayout(false);

        }
    }
}
