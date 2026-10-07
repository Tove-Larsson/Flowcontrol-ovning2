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
			Console.WriteLine("\n2. Calculate price for a group");
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
					case 2:
						CalculateGroupPrice();
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

		public static void CalculateGroupPrice()
		{
			int totalCost = 0;

			Console.WriteLine("Enter how many you will be: ");
			int groupSize = int.Parse(Console.ReadLine());
			Console.WriteLine("\nPlease enter the age of every person in the group: ");

			for (int i = 0; i < groupSize; i++)
			{
				Console.WriteLine("Enter age:");
				int age = int.Parse(Console.ReadLine());
				int price = GetPriceForAge(age);
				totalCost += price;
			}

			Console.WriteLine(totalCost.ToString());
		}


		public static int GetPriceForAge(int age)
		{
			if (age < 20)
			{
				return youthPrice;
			}
			else
			{
				if (age > 64)
				{
					return pensionerPrice;
				}
				else
				{
					return standardPrice;
				}
			}
		}
	}
}
