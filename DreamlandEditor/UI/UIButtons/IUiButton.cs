using DreamlandEditor.UI.UIPanels;
using System;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons
{
    public interface IUiButton
    {
        string ButtonFor { get; set; }

        event EventHandler Click;
    }
}
