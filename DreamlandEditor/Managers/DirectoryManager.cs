using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DreamlandEditor.Managers
{
    public static class DirectoryManager
    {
        public static DirectoryInfo[] GetDirectories(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                Directory.CreateDirectory(directory.FullName);
            }
            return directory.GetDirectories();
        }

        public static List<string> GetDirectoryNamesOnThatLevel(string path)
        {
            List<string> names = new List<string>();
            if (!Directory.Exists(path)) return null;
            foreach(string item in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly))
            {
                string[] subStrings = item.Split('\\');
                names.Add(subStrings[subStrings.Length - 1]);
            }
            return names;
        }
    }
}
