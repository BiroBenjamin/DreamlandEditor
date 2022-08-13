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
        public string ImagePath { get; set; }
        public string FilePath { get; set; }
        [XmlIgnore] public Texture2D Texture { get; set; }
        public Point Position { get; set; }
        public List<WorldObject> WorldObjects { get; set; } = new List<WorldObject>();
        public Size Size { get; set; }

        public Map()
		{
		}

        public IBaseFile Clone()
        {
            return new Map()
            {
                WorldObjects = new List<WorldObject>(),
                FilePath = this.FilePath,
                FileType = this.FileType,
                ID = this.ID,
                ImagePath = this.ImagePath,
                Name = this.Name,
                Position = this.Position,
                Size = this.Size,
                Texture = this.Texture,
            };
        }
    }
}
