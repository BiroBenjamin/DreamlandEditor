using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
