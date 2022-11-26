using DreamlandEditor.Data.GameFiles.Objects;
using DreamlandEditor.Data.GameFiles;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DreamlandEditor.Managers
{
  public static class FileManager
  {
    public static void SaveFile<T>(T obj)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(T));
      try
      {
        BaseFile baseFile = obj as BaseFile;
        string path = Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, baseFile.FilePath);
        using (StreamWriter writer = new StreamWriter(path))
        {

          serializer.Serialize(writer, obj);
        }
      }
      catch (UnauthorizedAccessException ex)
      {
        MessageBox.Show("Unauthorized acces to file.\r\nPlease open application as administrator!", "Error");
        DebugManager.Log($"{ex.Message}\r\n{ex.InnerException}\r\n{ex.StackTrace}");
        Environment.Exit(1009);
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
          if(typeof(T) != typeof(Map))
          {
            BaseObject baseObject = (BaseObject)loadedItem;
            baseObject.ImagePath = baseObject.ImagePath.Replace(SystemPrefsManager.SystemPrefs.RootPath + "\\", "");
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
