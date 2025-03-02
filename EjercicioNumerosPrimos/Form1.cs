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
            listBox_Primos.Items.Clear();

            double numero;
            for (numero = 2; numero <= 100; numero++)
            {
                bool esPrimo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    listBox_Primos.Items.Add(numero);
                }
            }
        }

        private void listBox_Primos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
