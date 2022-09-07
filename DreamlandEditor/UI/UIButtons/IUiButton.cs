using ProjectDreamland.UI.UIPanels;
using System;
using System.Windows.Forms;

namespace ProjectDreamland.UI.UIButtons
{
    public interface IUiButton
    {
        string ButtonFor { get; set; }

        event EventHandler Click;
    }
}
