using DreamlandEditor.Data;
using DreamlandEditor.Managers;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DreamlandEditor.Controlers 
{
    public partial class DebugWindow : Form 
    {
        public DebugWindow(Form parentForm) 
        {
            InitializeComponent();
            FormClosing += OnFormClosing;
            parentForm.FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, EventArgs ev)
        {
            if (!Directory.Exists(SystemPrefsManager.SystemPrefs.DebugLogPath))
            {
                Directory.CreateDirectory(SystemPrefsManager.SystemPrefs.DebugLogPath);
            }
            CreateLogFile();
            /*try
            {
                CreateLogFile();
            }
            catch (DirectoryNotFoundException e)
            {
                Debug.WriteLine(e.Message);
                Directory.CreateDirectory(SystemPrefsManager.SystemPrefs.debugLogPath);
                CreateLogFile();
            }*/
        }
        private void CreateLogFile() 
        {
            if(TextBoxLogboard.Text.Length < 1) return;
            string fileName = String.Format("{0:MM-dd-yyyy_HH-mm-ss}.log", DateTime.Now);
            using (FileStream stream = File.Create(Path.Combine(SystemPrefsManager.SystemPrefs.DebugLogPath, fileName))) 
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(TextBoxLogboard.Text);
                }
            }
        }

        public void AddLog(string text) 
        {
            TextBoxLogboard.AppendText(String.Format("[{0:HH:mm:ss}] \r\n {1}", DateTime.Now, text));
            TextBoxLogboard.AppendText(Environment.NewLine);
            /*try 
            {
                TextBoxLogboard.AppendText(String.Format("[{0:HH:mm:ss}] \r\n {1}", DateTime.Now, text));
                TextBoxLogboard.AppendText(Environment.NewLine);
            }
            catch(Exception e) 
            {
                Debug.WriteLine(e.Message);
            }*/
        }
    }
}
