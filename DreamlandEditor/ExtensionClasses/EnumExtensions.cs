﻿using System;
using System.ComponentModel;

namespace DreamlandEditor.ExtensionClasses
{
	public static class EnumExtensions
	{
		public static string GetDescription(this Enum enumValue)
		{
			var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
			var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
			return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
		}
	}
}
