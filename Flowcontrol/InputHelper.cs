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

	}
}
