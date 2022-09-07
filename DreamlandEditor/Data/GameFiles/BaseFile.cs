using Microsoft.Xna.Framework.Graphics;
using System.Drawing;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles
{
  public class BaseFile
  {
    public string FileType { get; set; }
    public string ID { get; set; }
    public string Name { get; set; }
    public int ZIndex { get; set; }
    [XmlIgnore] public string FullImagePath { get; set; }
    public string ImagePath { get; set; }
    [XmlIgnore] public string FullFilePath { get; set; }
    public string FilePath { get; set; }
    [XmlIgnore] public Texture2D Texture { get; set; }
    public Point Position { get; set; }

    public BaseFile(){}
    public BaseFile(BaseFile baseFile)
    {
      FileType = baseFile.FileType;
      ID = baseFile.ID;
      Name = baseFile.Name;
      ZIndex = baseFile.ZIndex;
      FullImagePath = baseFile.FullImagePath;
      ImagePath = baseFile.ImagePath;
      FullFilePath = baseFile.FullFilePath;
      FilePath = baseFile.FilePath;
      Texture = baseFile.Texture;
      Position = baseFile.Position;

    }

    public virtual BaseFile Clone()
    {
      return new BaseFile()
      {
        FileType = FileType,
        ID = ID,
        Name = Name,
        ZIndex = ZIndex,
        FullImagePath = FullImagePath,
        ImagePath = ImagePath,
        FullFilePath = FullFilePath,
        FilePath = FilePath,
        Texture = Texture,
        Position = Position,
      };
    }
  }
}
