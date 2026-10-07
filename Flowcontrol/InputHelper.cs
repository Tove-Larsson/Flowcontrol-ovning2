using System;
using System.Collections.Generic;
using System.Text;

namespace Flowcontrol
{
	internal class InputHelper
	{

		public static int ValidateInputIsInt()
		{
			while (true)
			{
				string input = Console.ReadLine();

				if (int.TryParse(input, out int result))
				{
					return result;
				}
				Console.WriteLine("Please enter a valid number.");

			}
		}

		public static bool HasAtLeastThreeWords(string sentence)
		{
			var words = sentence.Split(' ');

			if (words.Length >= 3)
			{
				return true;
			}
			else
			{
				Console.WriteLine("\nThe sentence you entered was less than 3 words, please try again.");
				return false;
			}
		}
	}
}
