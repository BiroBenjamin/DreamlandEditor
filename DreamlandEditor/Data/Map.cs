using DreamlandEditor.Data.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamlandEditor.Data
{
	[Serializable]
	public class Map : BaseFile
	{
		public List<BaseFile> Objects { get; set; }
		public Size Size { get; set; }
		public string TerrainType { get; set; }
		public Map()
		{

		}
	}
}
