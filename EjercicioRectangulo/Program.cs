namespace EjercicioRectangulo
{
    class Program
    {
        static float perimetroR(float Base, float Altura)
        {
            float R = 0f;
            R = (Base * 2) + (Altura * 2); // Correccion De Formula
            return R;
        }

        static float areaR(float Base, float Altura)
        {
            float R = 0f;
            R = Base * Altura;
            return R;
        }
        
        static void Main(string[] args)
        {
            float Base = 0f, Altura = 0f;
            do
            {
                Console.WriteLine("\nIngrese La Base Del Rectangulo");
                Console.Write("-> ");
                Base = float.Parse(Console.ReadLine());
                
                Console.WriteLine("\nIngrese La Altura Del Rectangulo");
                Console.Write("-> ");
                Altura = float.Parse(Console.ReadLine());

                if (Base < 0 || Altura < 0)
                {
                    Console.WriteLine("\nError: Debe Ingresar Valores Positivos\n");
                }
                else
                {
                    Console.WriteLine("\nDatos Ingresados: ");
                    Console.WriteLine("Base: " + Base);
                    Console.WriteLine("Altura: " + Altura + "\n");
                }
            } while (Base < 0 || Altura < 0);

            Console.WriteLine("\nEl Area Del Rectangulo es: " + areaR(Base, Altura));
            Console.WriteLine("\nEl Perimetro Del Rectangulo es: " + perimetroR(Base, Altura));
        }
    }
}