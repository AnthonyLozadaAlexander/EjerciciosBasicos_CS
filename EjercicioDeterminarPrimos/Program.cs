using System;

namespace EjercicioDeterminarPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 0;
            string invalidNum = "";
            Console.WriteLine("-----------------------------");
            Console.WriteLine("         BIENVENIDO");
            Console.WriteLine("-----------------------------");
            do
            {
                Console.WriteLine("Ingrese un numero");
                Console.Write("-> ");
                invalidNum = Console.ReadLine();
                if (!int.TryParse(invalidNum, out num))
                {
                    Console.WriteLine("\nError: Debe Ingresar Un Numero Entero\n");
                    continue;
                }

                if (num <= 1)
                {
                    Console.WriteLine($"\nError: Numero: {num} Invalido, Debe Ingresar Un Numero Entero Mayor a 1\n");
                }
                else
                {
                    Console.WriteLine("\nNumero Ingresado: " + num);
                }
            } while (num <= 1);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"El numero {num} es primo? = " + isPrimo(num));
            Console.WriteLine("-----------------------------------------");
        }

        public static bool isPrimo(int num)
        {
            if (num <= 1) // el numero no puede ser menor a 2 o igual a 1
            {
                return false;
            }

            for (int d = 2; d <= Math.Sqrt(num); d++)
            {
                if (num % d == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
