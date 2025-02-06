using System;
using System.Collections.Generic;

namespace fire
{	
	class Program
  {
		public static void Main()
		{
			List<DateTime> feriadosnacionais = new List<DateTime> 
			{
				new DateTime(DateTime.Now.Year, 1 ,1), 
				new DateTime(DateTime.Now.Year, 4, 21),
				new DateTime(DateTime.Now.Year, 9, 7),
				new DateTime(DateTime.Now.Year, 10, 12),
				new DateTime(DateTime.Now.Year, 11, 15),
				new DateTime(DateTime.Now.Year, 12, 25)	
			};
			
			Console.WriteLine("Insira uma data (dd/mm/yyyy): ");
			DateTime data = DateTime.Parse(Console.ReadLine());
					
			if (feriadosnacionais.Contains(data))
			{	
				Console.WriteLine("Feriado nacional");
			}
			
			else{
				Console.WriteLine("Não é um feriado nacional");
			}
			Console.ReadKey(true);
		}
    
	}
  
}
