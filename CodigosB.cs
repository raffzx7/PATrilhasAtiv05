using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("insira um número: ");
			int numero = Convert.ToInt32(Console.ReadLine());
			
			int contador = 0;
			
			Console.WriteLine("A tabuada do número {0} é: " ,numero);
			
			while (contador < 11 ) 
			{
				int tabuada = numero * contador;				
				Console.WriteLine( +numero+ " · " +contador+ " = " +tabuada );
				contador++;
		}
			Console.ReadKey(true);
		}
    
	}
  
}
