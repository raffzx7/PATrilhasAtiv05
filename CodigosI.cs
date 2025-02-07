using System;

namespace PATrilhasAtiv05
{
    class Program
    {
        public static void Main()
        {   
            int soma = 0;
            string sequencia;
            
            Console.WriteLine("Insira uma sequência de números (para encerrar, digite 'parar'):");

            sequencia = Console.ReadLine().Trim().ToLower();

            do 
            {
                int numero;
                
                if (int.TryParse(sequencia, out numero))
                {
                    soma += numero;
                }
                else if(sequencia != "parar") 
                {
                    Console.WriteLine("insira numeros inteiros ou digite parar.");
                }
                
                sequencia = Console.ReadLine().Trim().ToLower();
            } while (sequencia != "parar");
            
            Console.WriteLine("A soma dos números é {0}", soma);
            Console.ReadKey(true);
        }
      
    }
  
}
