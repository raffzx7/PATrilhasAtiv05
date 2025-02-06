using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{

		public static void Main()
		{
			Console.WriteLine("Insira um número: ");
			string numero =Console.ReadLine(); 
			
			switch (numero)    
			{	
				case "-1": 
					Console.WriteLine("O número é negativo.");
					break;

				case "0": 
					Console.WriteLine("O número é neutro.");
					break;					
				
				case "1":
					Console.WriteLine("O numero é positivo.");
					break;
				default:
					Console.WriteLine("numero Invalido.");
					break;
			}
			Console.ReadKey(true);
		}
    
	}
  
}
