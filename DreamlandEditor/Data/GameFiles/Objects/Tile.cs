using System;
using System.Drawing;

namespace DreamlandEditor.Data.GameFiles.Objects
{
  [Serializable]
  public class Tile : BaseObject
  {
    public string TileType { get; set; }

    public Tile() { }
    public Tile(BaseObject baseObject) : base(baseObject) { }
    public Tile(Tile tile) : base(tile) 
    {
      TileType = tile.TileType;
    }
  }
}
