using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioNumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string resultado = "";
            double num = 2;
            int count = 0;

            MessageBox.Show("Calculando numeros primos del 1 al 100", "Aviso", MessageBoxButtons.OK);

            while (count < 100)
            {
                if(esNumeroPrimo(num))
                {
                    resultado = resultado + num + ",";
                    listBox_Primos.Items.Add(num.ToString()); // Agrega los numeros primos al listBox_Primos
                    count = count + 1; // Incrementa el contador del bucle hasta llegar a 100
                }

                //if(esNumeroPrimo(num))
                //{
                //    listBox_Primos.Items.Add(num.ToString());
                //    count = count + 1;
                //}

                num = num + 1; // Incrementa el numero de candidatos a ser primos
            }

            MessageBox.Show(resultado + "" ,"Aviso", MessageBoxButtons.OK);
        }

        private bool esNumeroPrimo(double numero)
        {
            if (numero < 2)
            {
                // retorna esNumeroPrimo = false, si el numero es menor a 2, por lo tanto no es primo
                return false;
            }

            // Only need to check up to the square root of the number.
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    // retorna esNumeroPrimo = false, si el residuo del numero es 0, por lo tanto no es primo
                    return false;
                }
            }

            // retorna esNumeroPrimo = true si el numero es primo
            return true;
        }

        private void listBox_Primos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
