using DreamlandEditor.Data.Enums;
using DreamlandEditor.ExtensionClasses;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace DreamlandEditor.Data.GameFiles
{
    [Serializable]
	public class Map : IBaseFile
	{
        public string FileType { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        [XmlIgnore] public string ImagePath { get; set; }
        public string FilePath { get; set; }
        [XmlIgnore] public Texture2D Texture { get; set; }
        [XmlIgnore] public Point Position { get; set; }
        public List<WorldObject> WorldObjects { get; set; } = new List<WorldObject>();
        public List<WorldObject> Tiles { get; set; } = new List<WorldObject>();
        public Size Size { get; set; }

        public Map()
		{
		}

        public WorldObject DoesItemIntersectOthers(WorldObject item)
		{
            if(item.FileType == FileTypesEnum.Tile.GetDescription())
			{
                foreach(WorldObject tile in Tiles)
				{
                    if(new Rectangle(item.Position, item.Size).IntersectsWith(new Rectangle(tile.Position, tile.Size)))
					{
                        return tile;
					}
				}
			}
            if (item.FileType == FileTypesEnum.WorldObject.GetDescription())
            {
                foreach (WorldObject obj in WorldObjects)
                {
                    if (new Rectangle(item.Position, item.Size).IntersectsWith(new Rectangle(obj.Position, obj.Size)))
                    {
                        return obj;
                    }
                }
            }
            return null;
        }

        public IBaseFile Clone()
        {
            return new Map()
            {
                WorldObjects =WorldObjects,
                Tiles = Tiles,
                FilePath = FilePath,
                FileType = FileType,
                ID = ID,
                ImagePath = ImagePath,
                Name = Name,
                Position = Position,
                Size = Size,
                Texture = Texture,
            };
        }
    }
}
