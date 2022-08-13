using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.ExtensionClasses;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DreamlandEditor.Managers
{
    public static class ItemsManager
    {
        public static ICollection<WorldObject> WorldObjects= new List<WorldObject>();

        public static IBaseFile GetById(string id)
        {
            return WorldObjects.Where(x => x.ID == id).FirstOrDefault();
        }

        public static ICollection<WorldObject> FilterByObjectType(string objectType)
        {
            List<WorldObject> filteredItems = new List<WorldObject>();
            foreach (var item in WorldObjects)
            {
                if (objectType.Contains((item).ObjectType))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }

        public static void LoadItems()
        {
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(SystemPrefsManager.SystemPrefs.rootPath, "Objects"));
            CycleDirectories(directory);
        }
        private static void CycleDirectories(DirectoryInfo directory)
        {
            foreach (DirectoryInfo dir in DirectoryManager.GetDirectories(directory))
            {
                if (dir.GetDirectories().Length == 0)
                {
                    if (dir.GetFiles().Length != 0)
                    {
                        WorldObjects.AddRange(CycleFiles(dir));
                    }

                    continue;
                }
                CycleDirectories(dir);
            }
        }
        private static List<WorldObject> CycleFiles(DirectoryInfo folder)
        {
            List<WorldObject> files = new List<WorldObject>();
            foreach (FileInfo file in folder.GetFiles())
            {
                if (!SystemPrefsManager.SystemPrefs.extensions.Contains(file.Extension.Remove(0, 1))) continue;
                string fileName = Path.Combine(folder.FullName, file.Name);
                files.Add(FileManager<WorldObject>.LoadFile(fileName));
            }
            return files;
        }
    }
}
