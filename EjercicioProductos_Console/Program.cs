float Pantalon, Camisa, Zapatos, Total = 0;
int Opcion = 0, Flag = 0;
String cupon = " ", opcionCupon, opcionContinuar;
Pantalon = 20;
Camisa = 35;
Zapatos = 40;

do
{
    Console.WriteLine("----------Bienvenido---------");
    Console.WriteLine("-----ArticulosDisponibles----");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("\t1. Pantalon: 20");
    Console.WriteLine("\t2. Camisa: 35");
    Console.WriteLine("\t3. Zapatos: 40");
    Console.WriteLine("\t4. Salir");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Digite el Articulo A Comprar: ");
    Opcion = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    if(Opcion == 0 || Opcion < 0 || Opcion >= 5)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("\nError: Elija Una Opcion Valida");
        Console.WriteLine("--------------------------------");
    }
    else
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Dato Ingresado Correctamente");
        Console.WriteLine("------------------------------");
    }

    if(Opcion == 1)
    {
        Total = Total + Pantalon;
    }
    else if(Opcion == 2)
    {
        Total = Total + Camisa;
    }
    else if(Opcion == 3)
    {
        Total = Total + Zapatos;
    }
    else
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Gracias Por Su Usar El Sistema");
        Console.WriteLine("------------------------------");
        Flag = 4;
    }

    Console.WriteLine("Desea Ingresar Un Cupon de Descuento? (S/N): ");
    opcionCupon = Console.ReadLine();

    if(opcionCupon == "S" || opcionCupon == "s"){

        Console.WriteLine("Ingrese El Cupon: ");
        cupon = Console.ReadLine();

        if(cupon == "NAVIDAD")
        {

            float Porcentaje = Total * 0.10f;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total: " + Total);
            Console.WriteLine("Descuento: " + Porcentaje);
            Console.WriteLine($"Total Con El Descuento Del 10%: {Total - Porcentaje}");
            Console.WriteLine("------------------------------------------");

        }
        else
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Cupon Invalido");
            Console.WriteLine("Total A Pagar: " + Total);
            Console.WriteLine("------------------------------------------");
        }
        
    }
    else
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Total A Pagar: " + Total);
        Console.WriteLine("------------------------------------------");
    }

    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Desea Continuar Comprando Articulos");
    Console.WriteLine("1. Si");
    Console.WriteLine("2. No");
    Console.WriteLine("------------------------------------------");
    opcionContinuar = Console.ReadLine();

    if(opcionContinuar == "1")
    {
        Flag = 0;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Gracias Por Su Usar El Sistema");
        Console.WriteLine("------------------------------");
        Flag = 4;
    }

} while(Flag != 4);

Console.ReadKey();


