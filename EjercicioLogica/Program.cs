using System;

namespace EjercicioLogica
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("          BIENVENIDO");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Multiplos de 3: \"Fizz\"");
            Console.WriteLine("Multiplos de 5: \"Buzz\"");
            Console.WriteLine("Multiplos de 3 y 5: \"FizzBuzz\"");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i <= 100; i++) 
            {
                if(i % 3 == 0 && i % 5 == 0) // si i es multiplo de 3 y 5
                {
                    Console.WriteLine($"\n{i} = \"FizzBuzz\"");
                }
                else if (i % 3 == 0) // si i es multiplo de 3
                {
                    Console.WriteLine($"\n{i} = \"Fizz\"");
                }
                else if (i % 5 == 0) // si i es multiplo de 5
                {
                    Console.WriteLine($"\n{i} = \"Buzz\"");
                }
                
            }
        }

    }
}
