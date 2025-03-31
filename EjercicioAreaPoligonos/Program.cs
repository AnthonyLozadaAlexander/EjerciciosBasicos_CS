using System;

namespace EjercicioAreaPoligonos
{
    class Program
    {
        static float areaPoligono(float lados, float altura)
        {
            float Area;
            bool Triangulo;
            bool Cuadrado;
            Triangulo = esTriangulo(lados, altura);
            Cuadrado = esCuadrado(lados);
            if (Triangulo == true)
            {
                Area = (1 / 2.0f) * lados * altura;
                return Area;
            }

            if (Cuadrado == true)
            {
                Area = (float)Math.Pow(lados, 2);
                return Area;
            }
            else
            {
                return 0;
            }
        }

        static bool esTriangulo(float lados, float altura)
        {
            // Verifica que el número de lados sea 3 y que la altura sea un valor positivo.
            return (lados == 3 && altura > 0);
        }

        static bool esCuadrado(float lados)
        {
            return (lados == 4);
        }

        public static void Main(string[] args)
        {
            float lados, altura;
            string opc;
            Console.WriteLine("----------------------------");
            Console.WriteLine("         BIENVENIDO");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Escoga El Poligono A Calcular");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.- Triangulo");
            Console.WriteLine("2.- Cuadrado");
            Console.WriteLine("----------------------------");
            do
            {
                Console.WriteLine("Digite La Opcion");
                Console.Write("-> ");
                opc = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(opc) || String.IsNullOrEmpty(opc))
                {
                    Console.WriteLine("\nError: Elija Una Opcion\n");
                }
                else if (opc == "1")
                {
                    Console.WriteLine("Ingrese los lados del triangulo");
                    Console.Write("-> ");
                    lados = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo");
                    Console.Write("-> ");
                    altura = float.Parse(Console.ReadLine());
                    // verificara si es un triangulo
                    if (esTriangulo(lados, altura) == true)
                    {
                        Console.WriteLine("\nEl Area Del Triangulo Es: " + areaPoligono(lados, altura) + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nError: El Poligono Ingresado No Es Un Triangulo\n");
                    }
                }
                else if (opc == "2")
                {

                }
                else
                {
                    Console.WriteLine("\nError: Ingrese Una Opcion Valida\n");
                }
            } while (opc == String.Empty || opc == "1" || opc == "2" || (opc != "1" && opc != "2"));
        }
    }
}