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
  }
}
