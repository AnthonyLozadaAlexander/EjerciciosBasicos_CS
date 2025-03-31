using System;

namespace EjercicioLogica
{
    class Program
    {
        public static void Main(string[] args)
        {
            int countMultiplos3 = 0;
            int countMultiplos5 = 0;
            int countMultiplos3y5 = 0;
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

            int[] FizzBuzz = new int[101];
            int[] Fizz = new int[101];
            int[] Buzz = new int[101];
            int countFizzBuzz = 0;
            int countFizz = 0;
            int countBuzz = 0;
            Console.WriteLine("-------------------------------");
            for (int i = 0; i <= 100; i++)
            {
                if(i < FizzBuzz.Length)
                {

                    if (i % 3 == 0 && i % 5 == 0) // si i es multiplo de 3 y 5
                    {
                        FizzBuzz[countFizzBuzz] = i; // En El Array FizzBuzz se almacena los multiplos de 3 y 5
                        countFizzBuzz++;   

                    }
                }

                if(i < Fizz.Length)
                {
                    if (i % 3 == 0) // si i es multiplo de 3
                    {
                        Fizz[countFizz] = i; // En el Array Fizz se almacena los multiplos de 3
                        countFizz++;
                    }
                }

                if (i < Buzz.Length) {

                    if (i % 5 == 0) // si i es multiplo de 5
                    {
                        Buzz[countBuzz] = i; // En el Array Buzz se almacena los multiplos de 5
                        countBuzz++;
                    }
                }

            }

            Console.WriteLine("Dentro Del Array FizzBuzz Estan Los Elementos:");
            Console.WriteLine("Multiplos De 3 y 5:");
            for(int i = 0; i < FizzBuzz.Length; i++)
            {
                if (FizzBuzz[i] != 0)
                {
                    Console.WriteLine($"FizzBuzz[{i}] -> {FizzBuzz[i]}");
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Multiplos De 3:");
            Console.WriteLine("Dentro Del Array Fizz Estan Los Elementos:");
            for (int j = 0; j < Fizz.Length; j++)
            {
                if (Fizz[j] != 0)
                {
                    Console.WriteLine($"Fizz[{j}] -> {Fizz[j]}");
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dentro Del Array Buzz Estan Los Elementos:");
            Console.WriteLine("Multiplos De 5:");
            for (int k = 0; k < Buzz.Length; k++)
            {
                if (Buzz[k] != 0)
                {
                    Console.WriteLine($"Fizz[{k}] -> {Buzz[k]}");
                }
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Presione Una Tecla Para Salir");
            Console.ReadKey();

        }

    }
}
