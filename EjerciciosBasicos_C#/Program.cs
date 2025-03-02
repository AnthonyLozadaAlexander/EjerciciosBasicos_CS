using System;

namespace EjerciciosBasico
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcionC = 0;
            int opcionB = 0;
            double[] precioC = new double[1];
            double[] precioB = new double[1];
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
                precioC[0] = 0;
                precioB[0] = 0;

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
                if (opcionC == 1)
                {
                    precioC[0] = 2.50;
                    Console.WriteLine($"Su Pedido De Comida es: {comida[0]}");
                    Console.WriteLine($"Precio: ${precioC[0]}");
                }
                else if (opcionC == 2)
                {
                    precioC[0] = 2.00;
                    Console.WriteLine($"Su Pedido De Comida es: {comida[1]}");
                    Console.WriteLine($"Precio: ${precioC[0]}");
                }
                else if (opcionC == 3)
                {
                    precioC[0] = 3.00;
                    Console.WriteLine($"Su Pedido De Comida es: {comida[2]}");
                    Console.WriteLine($"Precio: ${precioC[0]}");
                }
                else if (opcionC == 4)
                {
                    precioC[0] = 2.50;
                    Console.WriteLine($"Su Pedido De Comida es: {comida[3]}");
                    Console.WriteLine($"Precio: ${precioC[0]}");
                }
                else if (opcionC == 5)
                {
                    precioC[0] = 2.00;
                    Console.WriteLine($"Su Pedido De Comida es: {comida[4]}");
                    Console.WriteLine($"Precio: ${precioC[0]}");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
                Console.WriteLine("---------------------------------------");

                if (opcionB == 1)
                {
                    precioB[0] = 1.50;
                    Console.WriteLine($"Su Bebida es: {bebida[0]}");
                    Console.WriteLine($"Precio: ${precioB[0]}");
                }
                else if (opcionB == 2)
                {
                    precioB[0] = 1.50;
                    Console.WriteLine($"Su Bebida es: {bebida[1]}");
                    Console.WriteLine($"Precio: ${precioB[0]}");
                }
                else if (opcionB == 3)
                {
                    precioB[0] = 1.50;
                    Console.WriteLine($"Su Bebida es: {bebida[2]}");
                    Console.WriteLine($"Precio: ${precioB[0]}");
                }
                else if (opcionB == 4)
                {
                    precioB[0] = 1.50;
                    Console.WriteLine($"Su Bebida es: {bebida[3]}");
                    Console.WriteLine($"Precio: ${precioB[0]}");
                }
                else if (opcionB == 5)
                {
                    precioB[0] = 1.00;
                    Console.WriteLine($"Su Bebida es: {bebida[4]}");
                    Console.WriteLine($"Precio: ${precioB[0]}");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
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
                double total = (precioC[0] + precioB[0]);
                Console.WriteLine($"Total: ${total}");
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

