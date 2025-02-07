using System;
namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{	
			int contador = 0;
			
			Console.WriteLine("Insira um número: ");
			var numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Os números pares entre 0 e {0} são: " ,numero);
			
			do {
					contador++;	
					
				if (contador % 2 == 0 && contador != numero)
				{
					Console.Write(" " +contador);
				}
				
			} while (contador < numero );
			Console.WriteLine( );
			Console.ReadKey(true);
		}
    
	}
  
}
