using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{
		public static void Main()
		{		
			Console.Write("Escolha o seu tamanho (P, M, G): ");
			string tamanhos = Console.ReadLine();
			string tamanhoscorrigidos = tamanhos.ToUpper();
			
			switch (tamanhoscorrigidos)
			{	
				case "P": 
					Console.WriteLine("O tamanho é P e o preço é R$32,00.");
					break;

				case "M": 
					Console.WriteLine("O tamanho é M e o preço é R$36,00.");
					break;					
				
				case "G":
					Console.WriteLine("O tamanho é G e o preço é R$42,00.");
					break;
					
				default:
					Console.WriteLine("Tamanho inválido.");
					break;
			}
			Console.ReadKey(true);
		}
    
	}
  
}
