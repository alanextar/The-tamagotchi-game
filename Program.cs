using System;
using System.Threading;

namespace tamagotchi
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Don't allow your lovely animal to die");
			
			//Create tamagotchi object
			Tamagotchi pikatchu = new Tamagotchi();
			pikatchu.DisplayState();
			pikatchu.showMenu();
			
			while(true)
			{
				string command = Console.ReadLine();
                if (command.Equals("5"))
                { 
                    Console.WriteLine("I'll miss you");
                    Thread.Sleep(500);
                    break;
                }
                pikatchu.HandleCommand(command);		
			}
		}
	}
}