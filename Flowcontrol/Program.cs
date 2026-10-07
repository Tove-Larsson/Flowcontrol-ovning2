using System;

namespace Flowcontrol
{
	internal class Program
	{
		const int youthPrice = 80;
		const int pensionerPrice = 90;
		const int standardPrice = 120;

		static void Main(string[] args)
		{
			MainMenu();

		}


		public static void MainMenu()
		{

			Console.WriteLine("\n===== Main menu =====");
			Console.WriteLine("\nChoose an option by entering the corresponding number and pressing \"Enter\".");
			Console.WriteLine("\n1. Youth or pensioner?");
			Console.WriteLine("\n0. Exit main menu");

			bool running = true;

			while (running)
			{
				int actionTaken = int.Parse(Console.ReadLine());

				switch (actionTaken)
				{
					case 0:
						running = false;
						Console.WriteLine("You chose to exit the program, goodbye!"); 
						break;
					case 1:
						CheckAgeAndPrice();
						break;
					default:
						Console.WriteLine("Invalid input");
						break;
				}

			}

		}

		public static void CheckAgeAndPrice()
		{
			Console.WriteLine("Enter your age:");

			int age = int.Parse(Console.ReadLine());

			if (age < 20)
			{
				Console.WriteLine($"Youth price: {youthPrice}Kr");
			}
			else
			{
				if (age > 64)
				{
					Console.WriteLine($"Pensioner price: {pensionerPrice}Kr");
				}
				else
				{
					Console.WriteLine($"Standard price: {standardPrice}Kr");
				}
			}
		}
	}
}
