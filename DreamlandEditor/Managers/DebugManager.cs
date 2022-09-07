using ProjectDreamland.Controlers;
using ProjectDreamland.Data;
using System.Windows.Forms;

namespace ProjectDreamland.Managers {
    public static class DebugManager {
        private static DebugWindow debugWindow;

        public static void ShowWindow(Form parentForm) {
            if (SystemPrefsManager.SystemPrefs.IsDevMode) {
                debugWindow = new DebugWindow(parentForm);
                debugWindow.Show();
            }
        }
        public static void Log(string text) {
            debugWindow.AddLog(text);
        }
    }
}
