using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{

		public static void Main()
		{		
			Console.WriteLine("Digite uma letra: ");
			string letra = Console.ReadLine();
			string vogal = letra.ToLower();
			
			switch (vogal)
			{	
				case "a": 
					Console.WriteLine("É uma vogal.");
					break;

				case "e": 
					Console.WriteLine("É uma vogal.");
					break;					
				
				case "i":
					Console.WriteLine("É uma vogal.");
					break;
				
				case "o":
					Console.WriteLine("É uma vogal.");
					break;					
				
				case "u":
					Console.WriteLine("É uma vogal.");
					break;
				default:
					Console.WriteLine("É uma consoante.");
					break;
			}
			Console.ReadKey(true);
		}
		
	}
	
}
