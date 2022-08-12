using System;
using System.Collections.Generic;
using System.Drawing;

namespace DreamlandEditor.Data
{
    [Serializable]
	public class Map : BaseFile
	{
		public List<WorldObject> WorldObjects { get; set; }
		public Size Size { get; set; }
		public Map()
		{
			WorldObjects = new List<WorldObject>();
		}
	}
}
