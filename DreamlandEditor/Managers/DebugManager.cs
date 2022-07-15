using DreamlandEditor.Controlers;
using DreamlandEditor.Data;
using System.Windows.Forms;

namespace DreamlandEditor.Managers {
    public static class DebugManager {
        private static DebugWindow debugWindow;
        //public static SystemPrefs SystemPrefs { get; set; } = new SystemPrefs();

        public static void ShowWindow(Form parentForm) {
            if (SystemPrefsManager.SystemPrefs.isDevMode) {
                debugWindow = new DebugWindow(SystemPrefsManager.SystemPrefs, parentForm);
                debugWindow.Show();
            }
        }
        public static void Log(string text) {
            debugWindow.AddLog(text);
        }
    }
}
