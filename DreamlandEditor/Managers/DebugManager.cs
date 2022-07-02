using DreamlandEditor.Controlers;
using System.Windows.Forms;

namespace DreamlandEditor.Managers {
    public static class DebugManager {
        private static DebugWindow debugWindow = new DebugWindow();
        
        public static void ShowWindow() {
            //if(systemPrefs.isDevMode)
                debugWindow.Show();
        }
        public static void Log(string text) {
            debugWindow.AddLog(text);
        }
    }
}
