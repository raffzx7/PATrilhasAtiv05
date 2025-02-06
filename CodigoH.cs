using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{
		public static void Main()
		{	
			Console.WriteLine("Insira um número: ");
			string opcao = (Console.ReadLine());
			
			switch (opcao)
			{	
				case "1": 
					Console.WriteLine("O dia inserido é domingo.");
					break;

				case "2": 
					Console.WriteLine("O dia inserido é segunda-feira.");
					break;					
				
				case "3":
					Console.WriteLine("O dia inserido é terça-feira.");
					break;
				
				case "4":
					Console.WriteLine("O dia inserido é quarta-feira.");
					break;					
				
				case "5":
					Console.WriteLine("O dia inserido é quinta-feira.");
					break;
				
				case "6":
					Console.WriteLine("O dia inserido é sexta-feira.");
					break;
				
				case "7":
					Console.WriteLine("O dia inserido é sábado.");
					break;
					
				default:
					Console.WriteLine("É uma consoante.");
					break;
			}
			Console.ReadKey(true);
		}
    
	}
  
}
