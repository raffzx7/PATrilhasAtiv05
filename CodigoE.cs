using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{

		public static void Main()
		{
			Console.WriteLine("---------------------");
			Console.WriteLine("+      Jogar           +");
			Console.WriteLine("+      Opções          +");
			Console.WriteLine("+      Configurações   +");
			Console.WriteLine("---------------------");
			
			Console.WriteLine("Escolha uma das opções: ");
			string escolha = Console.ReadLine();
			
			switch (escolha)
			{	
				case "1": 
					Console.WriteLine("Você escolheu Jogar.");
					break;

				case "2": 
					Console.WriteLine("Você escolheu Opções.");
					break;					
				
				case "3":
					Console.WriteLine("Você escolheu Configurações.");
					break;
			}
			Console.ReadKey(true);
		}
    
	}
  
}
