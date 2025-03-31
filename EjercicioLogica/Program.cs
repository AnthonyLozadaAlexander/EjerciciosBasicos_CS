using System;

namespace EjercicioLogica
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte countMultiplos3 = 0;
            byte countMultiplos5 = 0;
            byte countMultiplos3y5 = 0;
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
                    countMultiplos3y5++;
                }
                else if (i % 3 == 0) // si i es multiplo de 3
                {
                    Console.WriteLine($"\n{i} = \"Fizz\"");
                    countMultiplos3++;
                }
                else if (i % 5 == 0) // si i es multiplo de 5
                {
                    Console.WriteLine($"\n{i} = \"Buzz\"");
                    countMultiplos5++;
                }
                
            }

            byte[] FizzBuzz = new byte[countMultiplos3y5];
            byte[] Fizz = new byte[countMultiplos3];
            byte[] Buzz = new byte[countMultiplos5];

            Console.WriteLine("-------------------------------");
            for (byte i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) // si i es multiplo de 3 y 5
                {
                    FizzBuzz[i] = i; // En El Array FizzBuzz se almacena los multiplos de 3 y 5
                }
                else if (i % 3 == 0) // si i es multiplo de 3
                {
                    Fizz[i] = i; // En el Array Fizz se almacena los multiplos de 3
                }
                else if (i % 5 == 0) // si i es multiplo de 5
                {
                    Buzz[i] = i; // En el Array Buzz se almacena los multiplos de 5
                }

            }

            Console.WriteLine("Dentro Del Array FizzBuzz Estan Los Elementos");
            for(int i = 0; i < FizzBuzz.Length; i++)
            {
                Console.WriteLine($"FizzBuzz[{i}] -> {FizzBuzz[i]}");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dentro Del Array Fizz Estan Los Elementos");
            for (int j = 0; j < Fizz.Length; j++)
            {
                Console.WriteLine($"Fizz[{j}] -> {Fizz[j]}");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dentro Del Array Fizz Estan Los Elementos");
            for (int j = 0; j < Fizz.Length; j++)
            {
                Console.WriteLine($"Fizz[{j}] -> {Fizz[j]}");
            }
            Console.WriteLine("-------------------------------");

            Console.ReadKey();

        }

    }
}
