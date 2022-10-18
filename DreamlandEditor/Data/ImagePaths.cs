using System.IO;

namespace DreamlandEditor.Data
{
	public static class ImagePaths
    {
        private static readonly string IconsFolder = @"..\\..\\Content\\Icons";

        public static readonly string OpenFolder = Path.Combine(IconsFolder, "folder-open-icon.png");
        public static readonly string CloseFolder = Path.Combine(IconsFolder, "folder-close-icon.png");
        public static readonly string Plus = Path.Combine(IconsFolder, "plus-icon.png");
        public static readonly string Refresh = Path.Combine(IconsFolder, "refresh-icon.png");
        public static readonly string Save = Path.Combine(IconsFolder, "save-icon.png");
        public static readonly string NotFound = Path.Combine(IconsFolder, "not-found.png");
    }
}
