using System.ComponentModel;

namespace DreamlandEditor.Data.Enums
{
    public enum FileTypesEnum
	{
		[Description("Map")]
		Map,
		[Description("Character")]
		Character,
		[Description("World Object")]
		WorldObject,
		[Description("Tile")]
		Tile,
	}
}
