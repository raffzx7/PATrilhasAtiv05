using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{
		public static void Main()
		{	
			Console.WriteLine("===================== ");
			Console.WriteLine("+      Azul         +");
			Console.WriteLine("+      Verde        +");
			Console.WriteLine("+      Vermelha     +");
			Console.WriteLine("===================== ");			
			
			Console.WriteLine("Escolha uma das três cores: ");
			string cor =Console.ReadLine(); 
			
			switch (cor)    
			{	
				case "Azul": 
					Console.WriteLine("Você escolheu azul.");
					break;

				case "Verde": 
					Console.WriteLine("Você escolheu verde.");
					break;					
				
				case "Vermelha":
					Console.WriteLine("Você escolheu vermelha.");
					break;
				default:
					Console.WriteLine("Cor não existente nas opções.");
					break;
			}
			Console.ReadKey(true);
		}
    
	}
  
}
