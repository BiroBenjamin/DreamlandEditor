using DreamlandEditor.Controlers;
using System.Windows.Forms;

namespace DreamlandEditor.Managers
{
  public static class DebugManager
  {
    private static DebugWindow debugWindow;

    public static void Initialize(Form parentForm)
    {
      debugWindow = new DebugWindow(parentForm);
      debugWindow.Visible = false;
    }

    public static void ShowWindow()
    {
      if (SystemPrefsManager.SystemPrefs.IsDevMode)
      {
        debugWindow.Visible = true;
      }
    }

    public static void Log(string text)
    {
      debugWindow.AddLog(text);
    }
  }
}
