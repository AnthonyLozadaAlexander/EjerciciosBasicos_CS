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
                Area = (float)Math.Pow(altura, 2);
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

        static bool esCuadrado(float countLados)
        {
            // Verifica que el numero de lados sea 4 para que sea un cuadrado 
            return (countLados == 4);
        }

        public static void Main(string[] args)
        {
            float lados, altura, countLados;
            string opc;
            Console.WriteLine("----------------------------");
            Console.WriteLine("         BIENVENIDO");
            Console.WriteLine("----------------------------");
            
            Console.WriteLine("Escoga El Poligono A Calcular");
            do{
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.- Triangulo");
            Console.WriteLine("2.- Cuadrado");
            Console.WriteLine("3.- Salir");
            Console.WriteLine("----------------------------");
            
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
                    Console.WriteLine("Ingrese Cuantos Lados Tiene El Cuadrado");
                    Console.Write("-> ");
                    countLados = float.Parse(Console.ReadLine());
                    // verificara si es un Cuadrado
                    if (esCuadrado(countLados) == true)
                    {
                        Console.WriteLine("Ingrese El Tamaño De Los Lados Del Cuadrado");
                        Console.Write("-> ");
                        lados = float.Parse(Console.ReadLine());
                        
                        // en este caso altura, sera la longitud del cuadrado y lados la cantidad de lados para verificar la condicion
                        Console.WriteLine("\nEl Area Del Cuadrado Es: " + areaPoligono(4, lados) + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nError: El Poligono Ingresado No Es Un Cuadrado\n");
                    }
                }
                else if (opc == "3")
                {
                    Console.WriteLine("\nGracias Por Usar El Programa\n");
                    Console.WriteLine("Ingrese Un Boton Para Salir");
                    break;
                }
                else
                {
                    Console.WriteLine("\nError: Ingrese Una Opcion Valida\n");
                }
            } while (opc == String.Empty || opc == "1" || opc == "2" || (opc != "1" && opc != "2"));
            
            Console.ReadKey();
        }
    }
}