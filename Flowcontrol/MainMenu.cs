using System;

namespace Flowcontrol
{
	internal static class MainMenu
	{
		public static void Show()
		{
			bool running = true;

			while (running)
			{
				Console.WriteLine("\n===== Main menu =====");
				Console.WriteLine("\nChoose an option by entering the corresponding number and pressing \"Enter\".");
				Console.WriteLine("\n1. Youth or pensioner?");
				Console.WriteLine("\n2. Calculate price for a group");
				Console.WriteLine("\n3. Repeat 10 times");
				Console.WriteLine("\n4. The third word");
				Console.WriteLine("\n0. Exit main menu");

				int actionTaken = InputHelper.ValidateInputIsInt();

				switch (actionTaken)
				{
					case 0:
						running = false;
						Console.WriteLine("You chose to exit the program, goodbye!");
						break;
					case 1:
						TicketPricing.CheckAgeAndPrice();
						break;
					case 2:
						TicketPricing.CalculateGroupPrice();
						break;
					case 3:
						RepeatTenTimes.Repeat();
						break;
					case 4:
						WordExtractor.OutputThirdWord();
						break;
					default:
						Console.WriteLine("Invalid input");
						break;
				}

			}
		}

	}
}