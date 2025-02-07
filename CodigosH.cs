using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{	
			int contador = 0;
			
			Console.WriteLine("insira um número: ");
			var numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("A tabuada do número {0} é: " ,numero);
				
			do {
				int tabuada = numero * contador;
				Console.WriteLine( +numero+ " · " +contador+ " = " +tabuada );
				contador++;	
			} while (contador < 11 );
			
			Console.WriteLine( );
			Console.ReadKey(true);
		}
    
	}
  
}
