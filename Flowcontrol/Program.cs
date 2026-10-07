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
			bool running = true;

			while (running)
			{
				Console.WriteLine("\n===== Main menu =====");
				Console.WriteLine("\nChoose an option by entering the corresponding number and pressing \"Enter\".");
				Console.WriteLine("\n1. Youth or pensioner?");
				Console.WriteLine("\n2. Calculate price for a group");
				Console.WriteLine("\n3. Repeat 10 times");
				Console.WriteLine("\n0. Exit main menu");

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
					case 3:
						RepeatTenTimes();
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

			// Loop through the group and calculate the price for each person.
			for (int i = 0; i < groupSize; i++)
			{
				Console.WriteLine("Enter age:");
				int age = int.Parse(Console.ReadLine());
				int price = GetPriceForAge(age);
				totalCost += price;
			}

			Console.WriteLine($"Number of people: {groupSize}");
			Console.WriteLine($"Total cost: {totalCost}kr");
		}

		// Returns the ticket price based on the person's age.
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

		public static void RepeatTenTimes()
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
