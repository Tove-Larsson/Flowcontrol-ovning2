using System;

namespace Flowcontrol
{
	internal static class WordExtractor
	{
		public static void OutputThirdWord()
		{
			Console.WriteLine("Please write a sentence with at least 3 words: ");
			var sentence = Console.ReadLine();

			// Split the sentence into individual words using spaces
			var words = sentence.Split(' ');

			Console.WriteLine($"\nThe third word is: {words[2]}");

		}

	}
}
