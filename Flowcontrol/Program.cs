using System;

namespace Flowcontrol
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MainMenu();

		}


		public static void MainMenu()
		{

			Console.WriteLine("\n===== Main menu =====");
			Console.WriteLine("\nChoose an option by entering the corresponding number and pressing \"Enter\".");
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
					default:
						Console.WriteLine("Invalid input");
						break;
				}

			}

		}
	}
}
