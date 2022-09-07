﻿using ProjectDreamland.Data.Enums;
using ProjectDreamland.ExtensionClasses;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace ProjectDreamland.Data.GameFiles
{
  [Serializable]
  public class Map : BaseFile
  {
    public List<WorldObject> WorldObjects { get; set; } = new List<WorldObject>();
    public List<Tile> Tiles { get; set; } = new List<Tile>();
    public Size Size { get; set; }

    public Map(){}
    public Map(BaseFile baseFile) :
      base(baseFile){}

    public BaseFile DoesItemIntersectOthers(BaseFile item)
    {
      Tile tileItem = item as Tile;
      if (tileItem.FileType == FileTypesEnum.Tile.GetDescription())
      {
        foreach (Tile tile in Tiles)
        {
          if (new Rectangle(tileItem.Position, tileItem.Size).IntersectsWith(new Rectangle(tile.Position, tile.Size)))
          {
            return tile;
          }
        }
      }
      Tile objectItem = item as Tile;
      if (objectItem.FileType == FileTypesEnum.WorldObject.GetDescription())
      {
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

    public override BaseFile Clone()
    {
      Map map = new Map(base.Clone());
      map.WorldObjects = WorldObjects;
      map.Tiles = Tiles;
      map.Size = Size;
      return map;
    }
  }
}
