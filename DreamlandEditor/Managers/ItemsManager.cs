using DreamlandEditor.Data.GameFiles.Objects;
using Microsoft.Xna.Framework.Graphics;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.Data.GameFiles.Characters;
using DreamlandEditor.ExtensionClasses;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DreamlandEditor.Managers
{
  public static class ItemsManager
  {
    public static ICollection<WorldObject> WorldObjects = new List<WorldObject>();
    public static IDictionary<string, List<Tile>> Tiles = new Dictionary<string, List<Tile>>();
    public static ICollection<BaseCharacter> Characters = new List<BaseCharacter>();
    public static ICollection<Map> Maps = new List<Map>();

    public static List<BaseObject> GetObjectById(string id, bool fullMatch)
    {
      List<BaseObject> objects = new List<BaseObject>();
      objects.AddRange(WorldObjects);
      objects.AddRange(GetTiles());
      objects.AddRange(Characters);
      if (fullMatch)
      {
        return objects.Where(x => x.ID == id).ToList();
      }
      return objects.Where(x => x.ID.ToLower().Contains(id.ToLower())).ToList();
    }
    public static List<Map> GetMapById(string id, bool fullMatch)
    {
      if (fullMatch)
      {
        return Maps.Where(x => x.ID == id).ToList();
      }
      return Maps.Where(x => x.ID.ToLower().Contains(id.ToLower())).ToList();
    }

    public static void UpdateInMaps<T>(T obj)
    {
      bool changed;
      foreach (Map map in Maps)
      {
        changed = false;
        if (typeof(T) != typeof(WorldObject)) continue;
        for (int i = 0; i < map.WorldObjects.Count(); i++)
        {
          if (map.WorldObjects[i].ID != (obj as WorldObject).ID) continue;
          WorldObject mapObject = map.WorldObjects[i];
          Point position = mapObject.Position;
          int zIndex = mapObject.ZIndex;
          map.WorldObjects[i] = new WorldObject(obj as WorldObject);
          map.WorldObjects[i].Position = position;
          map.WorldObjects[i].ZIndex = zIndex;
          changed = true;
        }
        if (!changed) continue;
        FileManager.SaveFile(map);
      }
    }

    public static void AddTile(Tile tile)
    {
      string[] tilePathSplit = tile.FilePath.Split('\\');
      string tileTypeName = tilePathSplit.Length > 2 ?
        tilePathSplit[tilePathSplit.Length - 2] :
        tilePathSplit[tilePathSplit.Length - 1];
      FileManager.SaveFile(tile);
      if (!Tiles.ContainsKey(tileTypeName))
      {
        Tiles.Add(tileTypeName, new List<Tile>());
        Tiles[tileTypeName].Add(tile);
        return;
      }
      Tiles[tileTypeName].Add(tile);
      return;
    }
    public static ICollection<Tile> GetTileByTileType(string type)
    {
      return Tiles[type];
    }
    public static ICollection<Tile> GetTiles()
    {
      List<Tile> tiles = new List<Tile>();
      foreach (var keyValuePairs in Tiles)
      {
        foreach (Tile tile in keyValuePairs.Value)
        {
          tiles.Add(tile);
        }
      }
      return tiles;
    }

    public static void RemoveItem<T>(T item)
    {
      //GetCollectionByType(item.GetType()).Cast<BaseFile>().ToList().Remove(item);
      if (item is WorldObject) WorldObjects.Remove(WorldObjects.Where(x => x.ID == (item as WorldObject).ID).FirstOrDefault());
      else if (item is Tile) GetTiles().Remove(GetTiles().Where(x => x.ID == (item as Tile).ID).FirstOrDefault());
      else if (item is Map) Maps.Remove(Maps.Where(x => x.ID == (item as Map).ID).FirstOrDefault());
      else if (item is BaseCharacter) Characters.Remove(Characters.Where(x => x.ID == (item as BaseCharacter).ID).FirstOrDefault());
    }

    public static IEnumerable<object> GetCollectionByType(string fileType)
    {
      if (fileType == FileTypesEnum.WorldObject.GetDescription())
      {
        return WorldObjects;
      }
      else if (fileType == FileTypesEnum.Tile.GetDescription())
      {
        return GetTiles();
      }
      else if (fileType == FileTypesEnum.Map.GetDescription())
      {
        return Maps;
      }
      else if (fileType == FileTypesEnum.Character.GetDescription())
      {
        return Characters;
      }
      return new List<object>();
    }

    public static void SaveItems()
    {
      string errors = "";
      foreach (WorldObject item in WorldObjects)
      {
        if (string.IsNullOrEmpty(item.FilePath))
        {
          errors.Concat($"The following WorldObject: {item.ID} doesn't have a file path!\r\n{item.ID} has not been saved!");
          continue;
        }
        FileManager.SaveFile(item);
      }
      foreach (Map item in Maps)
      {
        if (string.IsNullOrEmpty(item.FilePath))
        {
          errors.Concat($"The following WorldObject: {item.ID} doesn't have a file path!\r\n{item.ID} has not been saved!");
          continue;
        }
        FileManager.SaveFile(item);
      }

      if (errors.Length > 0)
      {
        MessageBox.Show(errors, "Error while saving");
        DebugManager.Log(errors);
        return;
      }
      MessageBox.Show("Save succesfull!", "Save");
    }

    public static void SortItems()
    {
      WorldObjects = WorldObjects.OrderByDescending(x => x.ID).ToList();
      Maps = Maps.OrderByDescending(x => x.ID).ToList();
      Characters = Characters.OrderByDescending(x => x.ID).ToList();
    }
  }
}
