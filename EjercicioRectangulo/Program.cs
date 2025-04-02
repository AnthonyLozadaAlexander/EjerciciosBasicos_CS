namespace EjercicioRectangulo
{
    class Program
    {
        static float areaR(float Base, float Altura)
        {
            float R = 0f;
            R = (float) Math.Pow(Base, 2) + (float) Math.Pow(Altura, 2);
            return R;
        }
        
        static void Main(string[] args)
        {
            float Base = 0f, Altura = 0f;
            do
            {

            } while (Base < 0 || Altura < 0);
        }
    }
}