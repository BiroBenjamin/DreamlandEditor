using DreamlandEditor.Controlers;
using DreamlandEditor.Data;

namespace DreamlandEditor.Managers {
    public static class DebugManager {
        private static DebugWindow debugWindow = new DebugWindow();
        public static SystemPrefs SystemPrefs { get; set; } = new SystemPrefs();


        public static void ShowWindow() {
            if (SystemPrefs.isDevMode) {
                debugWindow.Show();
                debugWindow.AddPrefFile(SystemPrefs);
            }
        }
        public static void Log(string text) {
            debugWindow.AddLog(text);
        }
    }
}
