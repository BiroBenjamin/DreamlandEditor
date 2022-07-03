namespace DreamlandEditor.UI.Editors {
    class CharacterEditor : BaseEditor {
        public CharacterEditor() : base() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // CharacterEditor
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.Name = "CharacterEditor";
            this.Size = new System.Drawing.Size(1248, 806);
            this.ResumeLayout(false);

        }
    }
}
