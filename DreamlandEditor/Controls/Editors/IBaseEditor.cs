using DreamlandEditor.Data;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using System.Drawing;
using System.Windows.Forms;

namespace DreamlandEditor.Controls.Editors 
{
    public interface IBaseEditor
    {
        string EditorFor { get; set; }
    }
}
