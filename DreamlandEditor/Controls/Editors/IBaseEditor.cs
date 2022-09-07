using ProjectDreamland.Data;
using ProjectDreamland.Data.Enums;
using ProjectDreamland.ExtensionClasses;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectDreamland.Controls.Editors 
{
    public interface IBaseEditor
    {
        string EditorFor { get; set; }
    }
}
