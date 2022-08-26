using DreamlandEditor.Data.Attributes;
using System.ComponentModel;

namespace DreamlandEditor.Data.Enums
{
	public enum TileTypesEnum
	{
		[Description("Grass")]
		Grass,
		[Description("Dirt")]
		Dirt,
		[Description("Dirt Cliff"), ElevatedTile]
		DirtCliff,
	}
}
