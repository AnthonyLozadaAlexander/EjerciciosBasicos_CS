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
            bool validInput = false;

            while (!validInput){
                Console.WriteLine("\t-----BIENVENIDO-----");
            
                Console.Write("Ingrese el monto total de la cuenta: ");
                string input = Console.ReadLine(); 

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("  Error: No puede estar vacio el monto");
                    Console.WriteLine("-----------------------------------------");
                }
                else if(!float.TryParse(input, out monto))
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("\tError: El Dato Ingresado No Es Numerico");
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

            do { 
            
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Desea Agregar Propina? 1 = Si, 0 = No");
            
                Console.Write("-> ");
                respuestaP = Int32.Parse(Console.ReadLine());

                if (!int.TryParse(Console.ReadLine(), out respuestaP)){
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Error: No Puede Ser Texto");
                    Console.WriteLine("-----------------------------------------");
                    Salir = false;
                }
                else if(respuestaP < 0 || respuestaP > 1)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Error: Dato Invalido");
                    Console.WriteLine("-----------------------------------------");
                }
                else if(respuestaP == 1)
                {

                }
                else if(respuestaP == 0)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Gracias Por Utilizar Nuestro Servicio");
                    Console.WriteLine("-----------------------------------------");
                    Salir = true;
                }

            }while(Salir == false);
        }
    }
}
