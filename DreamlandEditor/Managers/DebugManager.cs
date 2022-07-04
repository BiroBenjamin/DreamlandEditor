using DreamlandEditor.Controlers;
using DreamlandEditor.Data;
using System.Windows.Forms;

namespace DreamlandEditor.Managers {
    public static class DebugManager {
        private static DebugWindow debugWindow;

        public static void ShowWindow(SystemPrefs systemPrefs, Form parentForm) {
            if (systemPrefs.isDevMode) {
                debugWindow = new DebugWindow(systemPrefs, parentForm);
                debugWindow.Show();
            }
        }
        public static void Log(string text) {
            debugWindow.AddLog(text);
        }
    }
}
