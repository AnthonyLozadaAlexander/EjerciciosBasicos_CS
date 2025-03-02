using System;

namespace EjerciciosSimplificacion
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcionC = 0;
            int opcionB = 0;
            double[] precioC = { 3.0, 1.50, 4.25, 2.30, 1.20 };
            double[] precioB = { 1.0, 1.0, 1.25, 1.25, 1 };
            string name = "";
            string respuesta = "";
            int cedula = 0;
            bool On = true;
            string[] comida = new string[5];
            string[] ingredientes = new string[5];
            string[] bebida = new string[5];

            comida[0] = "Hamburguesa";
            comida[1] = "PapasConPollo";
            comida[2] = "Pizza";
            comida[3] = "Tacos";
            comida[4] = "Ensalada Rusa";

            bebida[0] = "CocaCola";
            bebida[1] = "Pepsi";
            bebida[2] = "Fanta";
            bebida[3] = "Sprite";
            bebida[4] = "Agua";

            ingredientes[0] = "Pan, carne, lechuga, tomate, queso, aderezos";
            ingredientes[1] = "Papas, pollo, especias, aceite";
            ingredientes[2] = "Masa, salsa de tomate, queso, pepperoni";
            ingredientes[3] = "Tortillas, carne, cebolla, cilantro, limón, salsa";
            ingredientes[4] = "Papas, zanahorias, guisantes, huevo, mayonesa";


            Console.WriteLine("-------Registro De Datos---------");
            Console.Write("Ingrese su nombre: ");
            name = Console.ReadLine();
            Console.Write("Ingrese su cedula: ");
            cedula = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (On)
            {
                Console.WriteLine("--------------Datos--------------");
                Console.WriteLine($"Nombre: {name}");
                Console.WriteLine($"Cedula: {cedula}");
                Console.WriteLine("--------Bienvenido al Menu-------");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Hamburguesa");
                Console.WriteLine("2.- PapasConPollo");
                Console.WriteLine("3.- Pizza");
                Console.WriteLine("4.- Tacos");
                Console.WriteLine("5.- EnsaladaRusa");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- CocaCola");
                Console.WriteLine("2.- Pepsi");
                Console.WriteLine("3.- Fanta");
                Console.WriteLine("4.- Sprite");
                Console.WriteLine("5.- Agua");
                Console.WriteLine("---------------------------------");
                Console.Write("Eliga una opcion para la comida: ");
                opcionC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Eliga una opcion para la bebida: ");
                opcionB = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("----------------------------------------");

                for (int i = 0; i < 5; i++)
                {
                    if (i == (opcionC - 1))
                    {
                        Console.WriteLine($"Su Pedido es: {comida[i]}");
                        Console.WriteLine($"Precio: {precioC[i]}");
                    }
                }
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("----------------------------------------");

                for (int i = 0; i < 5; i++)
                {
                    if (i == (opcionB - 1))
                    {
                        Console.WriteLine($"Su Bebida es: {bebida[i]}");
                        Console.WriteLine($"Precio: {precioB[i]}");
                    }
                }

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-------IngredientesDeLaComida---------");
                if (opcionC == 1)
                {
                    string[] ingredientesHamburguesa = ingredientes[0].Split(", ");
                    Console.WriteLine($"{comida[0]}: ");
                    foreach (var ingrediente in ingredientesHamburguesa)
                    {
                        Console.WriteLine(ingrediente);
                    }
                }
                else if (opcionC == 2)
                {
                    string[] ingredientesPapasConPollo = ingredientes[1].Split(", ");
                    Console.WriteLine($"{comida[1]}: ");
                    foreach (var ingrediente in ingredientesPapasConPollo)
                    {
                        Console.WriteLine(ingrediente);
                    }
                }
                else if (opcionC == 3)
                {
                    string[] ingredientesPizza = ingredientes[2].Split(", ");
                    Console.WriteLine($"{comida[2]}: ");
                    foreach (var ingrediente in ingredientesPizza)
                    {
                        Console.WriteLine(ingrediente);
                    }
                }
                else if (opcionC == 4)
                {
                    string[] ingredientesTacos = ingredientes[3].Split(", ");
                    Console.WriteLine($"{comida[3]}: ");
                    foreach (var ingrediente in ingredientesTacos)
                    {
                        Console.WriteLine(ingrediente);
                    }
                }
                else if (opcionC == 5)
                {
                    string[] ingredientesEnsaladaRusa = ingredientes[4].Split(", ");
                    Console.WriteLine($"{comida[4]}: ");
                    foreach (var ingrediente in ingredientesEnsaladaRusa)
                    {
                        Console.WriteLine(ingrediente);
                    }
                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine("--------Precio Total---------");
                /*double total = (precioC[i] + precioB[i]);*/

                for (int i = 0; i < 5; i++)
                {
                    if (i == (opcionB - 1))
                    {
                        double total = (precioC[i] + precioB[i]);
                        Console.WriteLine($"Total: {total}$");
                    }
                }
                
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Desea Realizar Otro Pedido?");
                Console.WriteLine("Escriba Si Para Continuar.");
                Console.WriteLine("Escriba No Para Salir.");
                respuesta = Console.ReadLine();
                if (string.Equals(respuesta, "Si", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    On = true;
                }
                else if (string.Equals(respuesta, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Muchas Gracias Por Su Compra");
                    Console.WriteLine("----------------------------");
                    On = false;
                }
            }
        }

    }
}

