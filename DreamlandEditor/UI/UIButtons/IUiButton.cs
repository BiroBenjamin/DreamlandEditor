using DreamlandEditor.UI.UIPanels;

namespace DreamlandEditor.UI.UIButtons
{
    public interface IUiButton
    {
        void SetActive();
        void SetInactive();
        void SetDropdownPanel(UiPanel panel);
    }
}
