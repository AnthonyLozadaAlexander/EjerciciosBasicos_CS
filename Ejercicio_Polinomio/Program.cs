using System;

namespace Ejercicio_Polinomio
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0, c=0, d=0;
            double x=0, resultado=0;
            string valor = "";

            do
            {
                Console.WriteLine("-----------------BIENVENIDO------------------");
                Console.WriteLine("Ingrese los datos para el siguiente Polinomio");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("           ax^3 + bx^2 + cx + d");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Ingrese el valor de a");
                Console.Write("-> ");
                valor = Console.ReadLine();
                a = Convert.ToInt32(valor);

                Console.WriteLine("Ingrese el valor de b");
                Console.Write("-> ");
                valor = Console.ReadLine();
                b = Convert.ToInt32(valor);

                Console.WriteLine("Ingrese el valor de c");
                Console.Write("-> ");
                valor = Console.ReadLine();
                c = Convert.ToInt32(valor);

                Console.WriteLine("Ingrese el valor de d");
                Console.Write("-> ");
                valor = Console.ReadLine();
                d = Convert.ToInt32(valor);

                Console.WriteLine("Ingrese el valor de x");
                Console.Write("-> ");
                valor = Console.ReadLine();
                x = Convert.ToDouble(valor);

                if (a == 0 || b == 0 || c == 0 || d == 0 || x == 0)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Error: Los valores de a, b, c y d no pueden ser iguales a 0");
                    Console.WriteLine("---------------------------------------------");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Datos Ingresados Correctamente");
                    Console.WriteLine("---------------------------------------------");
                }

            } while(a == 0 || b == 0 || c == 0 || d == 0 || x == 0);

            resultado = (a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + (c * x) + d);

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"El Resultado Del Polinomio de {a}({x})^3 + {b}({x})^2 + {c}({x}) + {d} es: {resultado}");
            Console.WriteLine("---------------------------------------------------------------------\n");

            string respuesta = "";
            Console.WriteLine("Desea Realizar Otra Operacion? (S/N)");
            Console.Write("-> ");
            respuesta = Console.ReadLine();
            if (respuesta == "S" || respuesta == "s")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Gracias Por Usar El Programa");
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
