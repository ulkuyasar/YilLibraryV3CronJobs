using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
	public class Utils
	{
		public static string SetCharacterToLeftSite(string mainStr, string addingCharacter, int totalSize)
		{
			while (mainStr.Length < totalSize)
				mainStr = addingCharacter + mainStr;

			return mainStr;
		}

		public static float KelvinToCelcius(decimal kelvin)
		{
			return (float)(Convert.ToDouble( kelvin) - 273.15);
		}
	}
}
