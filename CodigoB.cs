using System;

namespace fire
{
	class Program
	{
		public static void Main()
		{
			
			Console.WriteLine("Insira a primeira data (dd/mm/yyyy): ");
			DateTime data1 = DateTime.Parse(Console.ReadLine());

			Console.WriteLine("Insira a segunda data (dd/mm/yyyy): ");
			DateTime data2 = DateTime.Parse(Console.ReadLine());
			
			TimeSpan datafinal = data1 - data2;
			
			double totaldias = Math.Abs(datafinal.TotalDays);

			Console.WriteLine("A diferença entre as datas é: {0} dias.", totaldias);
			Console.ReadKey(true);
		}
    
	}
  
}
