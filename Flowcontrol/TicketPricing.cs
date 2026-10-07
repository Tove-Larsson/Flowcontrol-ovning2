using System;

namespace Flowcontrol
{
	internal static class TicketPricing
	{
		const int youthPrice = 80;
		const int pensionerPrice = 90;
		const int standardPrice = 120;

		public static void CheckAgeAndPrice()
		{
			Console.WriteLine("Enter your age:");

			int age = InputHelper.ValidateNonNegativeInt();

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
			int groupSize = InputHelper.ValidateNonNegativeInt();
			Console.WriteLine("\nPlease enter the age of every person in the group: ");

			// Loop through the group and calculate the price for each person.
			for (int i = 0; i < groupSize; i++)
			{
				Console.WriteLine("Enter age:");
				int age = InputHelper.ValidateNonNegativeInt();
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

	}
}
