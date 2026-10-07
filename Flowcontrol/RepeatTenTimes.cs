using System;

namespace Flowcontrol
{
	internal static class RepeatTenTimes
	{

		public static void Repeat()
		{
			Console.WriteLine("\nEnter any text you want to repeat 10 times: ");
			string textInput = Console.ReadLine();

			for (int i = 0; i < 10; i++)
			{
				Console.Write($"{i + 1}. {textInput} ");
			}
		}

	}
}
