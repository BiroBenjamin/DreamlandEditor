using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using System.Windows.Forms;

namespace DreamlandEditor.Controls.Editors
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
