/*
 * Created by SharpDevelop.
 * User: ALEX
 * Date: 22.09.2018
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tamagotchi
{

    public class Tamagotchi
    {
        public int hunger{ get; set; }
        public int boredom { get; set; }
        public int tiredness{ get; set; }

		public void DisplayState()
		{
			Console.WriteLine("*********************");
			Console.WriteLine("Hunger: {0}", hunger);
			Console.WriteLine("Boredom: {0}", boredom);
			Console.WriteLine("Tiredness: {0}", tiredness);
			Console.WriteLine("*********************");
		}
		
		
		public void showMenu()
		{
			Console.WriteLine("Choose what you want to do with your pet:");
			Console.WriteLine("1.eat");
			Console.WriteLine("2.sleep");
			Console.WriteLine("3.play");
			Console.WriteLine("4.nothing");
			Console.WriteLine("5.exit");
		}
		
		
		public void HandleCommand(string command)
		{
			//for Nick
			// I know that it is poor but I don't know how to parse user's input more easily
			if( command == "1" || command == "2" || command == "3" || command == "4" || command == "5")
			{
				Tick();
			}
			switch(command)
			{
				case "1":
					SetHunger();
					break;
				case "2":
					SetTiredness();
					break;
				case "3":
					SetBoredom();
					break;
				case "4":
					Tick();
					break;
				case "5":
					break;
				default:
					System.Media.SystemSounds.Exclamation.Play();
        			Console.WriteLine("Wrong choice. Use only numbers from 1 to 5");
       				break;
			}
			
			//poor again
			if( command == "1" || command == "2" || command == "3" || command == "4" || command == "5")
			{
				DisplayState();
				Complaint();
			}
			showMenu();
		}
		
		
		public void Tick()
		{
			hunger++;
			boredom++;
			tiredness++;
		}
		
		//for Nick
		//due to the task these methods must be in GetPointState but I can't find how to push them into last one
		public int SetHunger()
		{
			if (hunger > 0 && hunger <=4)
			{
				return hunger--;
			}
			else if (hunger == 0)
			{
				AddBoredom();
				return hunger;
			}
			return hunger -= 2;
		}
		
		public int SetBoredom()
		{
			if (boredom > 0 && boredom <=4)
			{
				return boredom--;
			}
			else if (boredom == 0)
			{
				AddHunger();
				AddTiredness();
				return boredom;
			}
			return boredom -= 2;
		}
		
		public int SetTiredness()
		{
			if (tiredness > 0 && tiredness <=4)
			{
				return tiredness--;
			}
			else if (tiredness == 0 && boredom == 0)
			{
				AddHunger();
				return tiredness;
			}
			return tiredness -= 2;
		}
		
		public void Complaint()
		{
			if(hunger > 3 || boredom > 3 || tiredness > 3)
			{
				Console.WriteLine("!!!!!!!");
				Console.WriteLine("I feel close to suicide. Kill me :((((((");
				Console.WriteLine("!!!!!!!");
			}
		}
		
			
		public int AddBoredom()
		{
			return boredom++;
		}
		public int AddHunger()
		{
			return hunger++;
		}
		public int AddTiredness()
		{
			return tiredness++;
		}
	}
}
