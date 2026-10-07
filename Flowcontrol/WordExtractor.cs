using System;

namespace Flowcontrol
{
	internal static class WordExtractor
	{
		public static void OutputThirdWord()
		{
			string sentence;
			Console.WriteLine($"\nPlease write a sentence with at least 3 words: ");

			// Keep asking until the user enters a sentence with at least three words.
			while (true)
			{
				sentence = Console.ReadLine();

				if (InputHelper.HasAtLeastThreeWords(sentence))
				{
					break;
				}
			}

			// Split the sentence into individual words using spaces
			var words = sentence.Split(' ');

			Console.WriteLine($"\nThe third word is: {words[2]}");

		}

	}
}
