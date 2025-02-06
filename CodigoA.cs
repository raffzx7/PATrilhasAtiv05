using System;

namespace fire
{
	class Program
	{
		public static void Main(string[] args)
		{
			var date = DateTime.Now;
			Console.WriteLine(date);
			
			Console.Write("precione para sair");
			Console.ReadKey(true);
		}
	}
}
