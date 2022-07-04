using DreamlandEditor.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controlers {
    public partial class DebugWindow : Form {
        private readonly SystemPrefs systemPrefs;

        public DebugWindow(SystemPrefs systemPrefs, Form parentForm) {
            InitializeComponent();
            this.systemPrefs = systemPrefs;

            FormClosing += OnFormClosing;
            parentForm.FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, EventArgs ev)
        {
            try
            {
                CreateLogFile();
            }
            catch (DirectoryNotFoundException e)
            {
                Debug.WriteLine(e.Message);
                Directory.CreateDirectory(systemPrefs.debugLogPath);
                CreateLogFile();
            }
        }
        private void CreateLogFile() {
            if(ListBoxDebugMessages.Items.Count < 1) {
                return;
            }
            string fileName = String.Format("{0:MM-dd-yyyy_HH-mm-ss}.log", DateTime.Now);

            using (FileStream stream = File.Create(Path.Combine(systemPrefs.debugLogPath, fileName))) {
                using (StreamWriter writer = new StreamWriter(stream)){
                    foreach(var line in ListBoxDebugMessages.Items) {
                        writer.WriteLine(line.ToString());
                    }
                }
            }
            Debug.WriteLine(Path.Combine(systemPrefs.debugLogPath, fileName));
        }

        public void AddLog(string text) {
            try {
                ListBoxDebugMessages.Items.Add(String.Format("[{0:HH:mm:ss}] --- {1}", DateTime.Now, text));
            } catch(Exception e) {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
