namespace EjercicioParOImpar
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

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txt_num.Text))
            {
                MessageBox.Show("Debe ingresar un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!Int32.TryParse(txt_num.Text, out int num))
            {
                MessageBox.Show("Debe ingresar un numero entero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num < 0)
            {
                MessageBox.Show("Debe ingresar un numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (num % 2 == 0)
                {
                    MessageBox.Show("El numero ingresado es par", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El numero ingresado es impar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
