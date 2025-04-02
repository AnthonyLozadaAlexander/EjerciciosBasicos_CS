namespace EjercicioRectangulo
{
    class Program
    {
        static float perimetroR(float Base, float Altura)
        {
            float R = 0f;
            R = (float) Math.Pow(Base, 2) + (float) Math.Pow(Altura, 2);
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
                    Console.WriteLine("Datos Ingresados: ");
                    Console.WriteLine("Base: " + Base);
                    Console.WriteLine("Altura: " + Altura);
                }
            } while (Base < 0 || Altura < 0);

            Console.WriteLine("\n El Area Del Rectangulo es: " + areaR(Base, Altura));
            Console.WriteLine("\nEl Perimetro Del Rectangulo es: " + perimetroR(Base, Altura));
        }
    }
}