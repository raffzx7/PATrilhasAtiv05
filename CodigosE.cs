using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{	
			int soma = 0;
			string sequencia;
			
			Console.WriteLine("Insira uma sequência de números inteiros(para encerrar a sequência digete algum núemro negativo): ");
		
			while (true)
			{
				sequencia = Console.ReadLine();
				int numero;
				
				if (int.TryParse(sequencia, out numero) )
				{
					if (numero < 0) {
						break;
				    }
					soma += numero;
				}
				
				else {
				    	Console.WriteLine("Insira somente numero interios.");
				    }
				}
			Console.WriteLine("\A soma dos números é {0}", soma);
			Console.ReadKey(true);
		}
    
	}
  
}
