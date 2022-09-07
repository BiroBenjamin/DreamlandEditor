using ProjectDreamland.Data.GameFiles;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjectDreamland.Managers
{
  public static class FileManager
  {
    public static void SaveFile<T>(T obj)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(T));
      try
      {
        using (StreamWriter writer = new StreamWriter((obj as BaseFile).FullFilePath))
        {

          serializer.Serialize(writer, obj);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Unexpected error during save.\nSee log file for further info.", "Error");
        DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
      }
    }

    public static BaseFile LoadFile<T>(string path)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(T));

      BaseFile loadedItem = default;
      using (StreamReader reader = new StreamReader(path))
      {
        try
        {
          loadedItem = (BaseFile)serializer.Deserialize(reader);
          loadedItem.FilePath = loadedItem.FilePath.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", "");
          loadedItem.FullFilePath = path;
          if(typeof(T) != typeof(Map))
          {
            loadedItem.ImagePath = loadedItem.ImagePath.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", "");
            loadedItem.FullImagePath = Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, loadedItem.ImagePath);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Unexpected error during Load.\nSee log file for further info.", "Error");
          DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
        }
      }

      return loadedItem;
    }
  }
}
