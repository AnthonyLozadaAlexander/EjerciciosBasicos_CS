using System;

namespace Ejercicio_CalculoPropinas
{
    class Program
    {
        public static void Main(string[] args)
        {
            float monto = 0, propina = 0, total = 0;
            int respuestaP = 0;
            string respuesta = "";
            bool Salir = false;
            bool On = true;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("\t-----BIENVENIDO-----");

                Console.Write("Ingrese el monto total de la cuenta: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("  Error: No puede estar vacio el monto");
                    Console.WriteLine("-----------------------------------------");
                }
                else if (!float.TryParse(input, out monto))
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("  Error: El Dato Ingresado No Es Numerico");
                    Console.WriteLine("-----------------------------------------");
                }
                else if (monto < 0 || monto == 0)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("El monto ingresado no es valido, por favor ingrese un monto valido");
                    Console.WriteLine("-----------------------------------------");

                }
                else
                {
                    validInput = true;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"            Monto: ${monto} ");
                    Console.WriteLine("       Ingresado Correctamente");
                    Console.WriteLine("-----------------------------------------");
                }

                if (!validInput)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.WriteLine("-----------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            do
            {

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Desea Agregar Propina? 1 = Si, 0 = No");
                Console.Write("-> ");
                string propInput = Console.ReadLine();

                if (!int.TryParse(propInput, out respuestaP))
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Error: No Puede Ser Texto");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Presiona Cualquier Tecla Para Continuar");
                    Console.ReadKey();
                    Console.Clear();
                    respuestaP = -1;
                    Salir = false;
                }


                if (respuestaP < 0 || respuestaP >= 2)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Error: Dato Invalido");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Presiona Cualquier Tecla Para Continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Salir = false;
                }
                else if (respuestaP == 1)
                {
                    do
                    {

                        Console.WriteLine("     --------PROPINAS--------");
                        Console.WriteLine("         Excelente: 20% ");
                        Console.WriteLine("         Bueno: 15% ");
                        Console.WriteLine("         Regular: 10% ");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese La Palabra Clave");
                        Console.Write("-> ");
                        respuesta = Console.ReadLine();

                        if(respuesta == "Excelente")
                        {
                            propina = monto * 0.20f;
                            total = monto + propina;
                            Console.WriteLine("------------------------------");
                            Console.WriteLine($"El monto es de: {monto}");
                            Console.WriteLine($"La propina es de: {propina}");
                            Console.WriteLine($"El MontoTotal es de: {total}");
                            Console.WriteLine("------------------------------");
                            On = false;
                            Salir = true;
                        }
                        else if(respuesta == "Bueno")
                        {
                            propina = monto * 0.15f;
                            total = monto + propina;
                            Console.WriteLine("------------------------------");
                            Console.WriteLine($"El monto es de: {monto}");
                            Console.WriteLine($"La propina es de: {propina}");
                            Console.WriteLine($"El MontoTotal es de: {total}");
                            Console.WriteLine("------------------------------");
                            On = false;
                            Salir = true;
                        }
                        else if(respuesta == "Regular")
                        {
                            propina = monto * 0.10f;
                            total = monto + propina;
                            Console.WriteLine("------------------------------");
                            Console.WriteLine($"El monto es de: {monto}");
                            Console.WriteLine($"La propina es de: {propina}");
                            Console.WriteLine($"El MontoTotal es de: {total}");
                            Console.WriteLine("------------------------------");
                            On = false;
                            Salir = true;
                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Error: Dato Invalido");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Presiona Cualquier Tecla Para Continuar");
                            Console.ReadKey();
                            Console.Clear();
                            On = true;

                        }
                    } while (On == true);

                }

                else if (respuestaP == 0)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Gracias Por Utilizar Nuestro Servicio");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Presiona Cualquier Tecla Para Salir");
                    Console.ReadKey();
                    Console.Clear();
                    Salir = true;
                }

            } while (Salir == false);
        }
    }
}
