using DreamlandEditor.UI.UIPanels;
using System;
using System.Windows.Forms;

namespace DreamlandEditor.UI.UIButtons
{
    public interface IUiButton
    {
        event EventHandler Click;
        void SetActive();
        void SetInactive();
        void SetDropdownPanel(UiPanel panel);
    }
}
