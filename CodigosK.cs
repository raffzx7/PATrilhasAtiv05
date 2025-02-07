using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{
		public static void Main()
		{	
			int contador1 = 0;
			string sequencia;
			int soma = 0;
			
			Console.WriteLine("Insira uma sequência de números inteiros, se quiser parar insira um número negativo: ");
			
			do {
				sequencia = Console.ReadLine();
				
				int numero;
				
				if (int.TryParse(sequencia, out numero)){
				
					if (numero < 0) {
						break;
				    }
				
					soma += numero;
				}
				else {
					Console.WriteLine("numero inválido");
				}
				
				contador1++;
				
			} while(true);
			
			Console.WriteLine("A soma dos números é {0}.", soma);
			Console.ReadKey(true);
		}
    
	}
  
}
