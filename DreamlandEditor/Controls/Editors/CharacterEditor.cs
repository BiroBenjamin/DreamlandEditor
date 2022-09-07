using ProjectDreamland.Data.Enums;
using ProjectDreamland.ExtensionClasses;
using System.Windows.Forms;

namespace ProjectDreamland.Controls.Editors
{
    partial class CharacterEditor : UserControl, IBaseEditor 
    {
        public string EditorFor { get; set; }

        public CharacterEditor() : base() 
        {
            InitializeComponent();
            EditorFor = FileTypesEnum.Character.ToString();
        }
    }
}
