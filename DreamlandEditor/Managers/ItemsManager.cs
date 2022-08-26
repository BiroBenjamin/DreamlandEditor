using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
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
        public static IDictionary<string, List<WorldObject>> Tiles = new Dictionary<string, List<WorldObject>>();
        public static ICollection<Map> Maps = new List<Map>();

        public static List<WorldObject> GetWorldObjectById(string id, bool fullMatch)
        {
			if (fullMatch)
			{
                return WorldObjects.Where(x => x.ID == id).ToList();
			}
            return WorldObjects.Where(x => x.ID.ToLower().Contains(id.ToLower())).ToList();
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
            foreach(Map map in Maps)
			{
                if(typeof(T) == typeof(WorldObject))
				{
                    for(int i = 0; i < map.WorldObjects.Count(); i++)
					{
                        if (map.WorldObjects[i].ID != (obj as WorldObject).ID) continue;
                        Point position = (obj as WorldObject).Position;
                        map.WorldObjects[i] = (obj as WorldObject);
                        map.WorldObjects[i].Position = position;
                    }
				}
            }
		}

        public static void AddTile(WorldObject tile)
		{
            string[] tilePathSplit = tile.FilePath.Split('\\');
            string tileTypeName = tilePathSplit.Length > 2 ?
                tilePathSplit[tilePathSplit.Length - 2] :
                tilePathSplit[tilePathSplit.Length - 1];
            FileManager.SaveFile(tile);
            if (!Tiles.ContainsKey(tileTypeName))
            {
                Tiles.Add(tileTypeName, new List<WorldObject>());
                Tiles[tileTypeName].Add(tile);
                return;
            }
            Tiles[tileTypeName].Add(tile);
            return;
        }
        public static ICollection<WorldObject> GetTileByTileType(string type)
		{
            return Tiles[type];
		}
        public static ICollection<WorldObject> GetTiles()
		{
            List<WorldObject> tiles = new List<WorldObject>();
            foreach(var keyValuePairs in Tiles)
			{
                foreach(WorldObject tile in keyValuePairs.Value)
				{
                    tiles.Add(tile);
				}
			}
            return tiles;
		}

        public static void RemoveItem(IBaseFile item)
		{
            GetCollectionByType(item.FileType).Cast<IBaseFile>().ToList().Remove(item);
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
            return new List<object>();
        }
        /*public static ICollection<WorldObject> FilterByObjectType(string objectType)
        {
            if(objectType == FileTypesEnum.WorldObject.GetDescription())
			{
                return WorldObjects;
            }
            else if (objectType == FileTypesEnum.Tile.GetDescription())
			{
                return GetTiles();
			}
            return new List<WorldObject>();
        }*/

        public static void SaveItems()
        {
            string errors = "";
            foreach(WorldObject item in WorldObjects)
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

            if(errors.Length > 0)
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
        }
    }
}
