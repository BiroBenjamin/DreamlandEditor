using DreamlandEditor.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controlers {
    public partial class DebugWindow : Form {
        SystemPrefs systemPrefs;
        private string path;

        public DebugWindow() {
            InitializeComponent();

            FormClosing += (sender, ev) => {
                try {
                    CreateLogFile();
                } catch(DirectoryNotFoundException e) {
                    Debug.WriteLine(e.Message);
                    Directory.CreateDirectory(path);
                    CreateLogFile();
                }
            };
        }

        private void CreateLogFile() {
            if(ListBoxDebugMessages.Items.Count < 1) {
                return;
            }
            string fileName = String.Format("{0:MM-dd-yyyy_HH-mm-ss}.log", DateTime.Now);

            using (FileStream stream = File.Create(Path.Combine(path, fileName))) {
                using (StreamWriter writer = new StreamWriter(stream)){
                    foreach(var line in ListBoxDebugMessages.Items) {
                        writer.WriteLine(line.ToString());
                    }
                }
            }
            Debug.WriteLine(Path.Combine(path, fileName));
        }

        public void AddLog(string text) {
            try {
                ListBoxDebugMessages.Items.Add(String.Format("[{0:HH:mm:ss}] --- {1}", DateTime.Now, text));
            } catch(Exception e) {
                Debug.WriteLine(e.Message);
            }
        }

        public void AddPrefFile(SystemPrefs SystemPrefs) {
            systemPrefs = SystemPrefs;
            path = systemPrefs.debugLogPath;
        }
    }
}
