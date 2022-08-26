using DreamlandEditor.Data.Attributes;
using System.ComponentModel;

namespace DreamlandEditor.Data.Enums
{
    public enum FileTypesEnum
	{
		[Description("Map")]
		Map,
		[Description("Character"), Displayable]
		Character,
		[Description("World Object"), Displayable]
		WorldObject,
		[Description("Tile"), Displayable]
		Tile,
	}
}
