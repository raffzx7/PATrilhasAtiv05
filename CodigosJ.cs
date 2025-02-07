using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
	{
		public static void Main()
		{	
			int contador1 = 0;
			int contador2 = 3;
			string senhacorreta;
			
			Console.Write("Crie uma senha: ");
			string senha = Console.ReadLine();
			
			Console.WriteLine("Insira sua senha (3 tentativas).");
			
			do {
				Console.Write("|{0} tentativa|:", contador2);
				senhacorreta = Console.ReadLine();
				
				if (senhacorreta == senha) {
					Console.WriteLine("Senha correta!");
					break;
				}
				else {
					Console.WriteLine("senha incorreta!");
				}
				
				contador2--;
				contador1++;
				
			} while(contador1 < 3 && contador2 > 0);
			Console.ReadKey(true);
		}
    
	}
  
}
