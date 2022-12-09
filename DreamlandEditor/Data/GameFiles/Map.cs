using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using DreamlandEditor.Data.GameFiles.Objects;
using DreamlandEditor.Data.GameFiles.Characters;

namespace DreamlandEditor.Data.GameFiles
{
  [Serializable]
  public class Map : BaseFile
  {
    public List<WorldObject> WorldObjects { get; set; } = new List<WorldObject>();
    public List<Tile> Tiles { get; set; } = new List<Tile>();
    public List<BaseCharacter> Characters { get; set; } = new List<BaseCharacter>();
    public Size Size { get; set; }

    public Map() { }
    public Map(BaseFile baseFile) : base(baseFile) { }
    public Map(Map map) : base(map)
    {
      WorldObjects = map.WorldObjects;
      Tiles = map.Tiles;
      Characters = map.Characters;
      Size = map.Size;
    }

    public BaseFile DoesItemIntersectOthers(BaseFile item)
    {
      if (item.FileType == FileTypesEnum.Tile.GetDescription())
      {
        Tile tileItem = item as Tile;
        foreach (Tile tile in Tiles)
        {
          if (new Rectangle(tileItem.Position, tileItem.Size).IntersectsWith(new Rectangle(tile.Position, tile.Size)))
          {
            return tile;
          }
        }
      }
      if (item.FileType == FileTypesEnum.WorldObject.GetDescription())
      {
        WorldObject objectItem = item as WorldObject;
        foreach (WorldObject obj in WorldObjects)
        {
          if (new Rectangle(objectItem.Position, objectItem.Size).IntersectsWith(new Rectangle(obj.Position, obj.Size)))
          {
            return obj;
          }
        }
      }
      return null;
    }
  }
}
