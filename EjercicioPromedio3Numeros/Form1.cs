namespace EjercicioPromedio3Numeros
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_num1.Text) ||
                string.IsNullOrWhiteSpace(txt_num2.Text) ||
                string.IsNullOrWhiteSpace(txt_num3.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir a números
            if (!double.TryParse(txt_num1.Text, out double num1) ||
                !double.TryParse(txt_num2.Text, out double num2) ||
                !double.TryParse(txt_num3.Text, out double num3))
            {
                MessageBox.Show("Solo se pueden ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num1 < 0 || num2 < 0 || num3 < 0)
            {
                MessageBox.Show("No se permiten números negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                MessageBox.Show("No se permiten números iguales a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double promedio = (num1 + num2 + num3) / 3;
            MessageBox.Show("El promedio es: " + promedio.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
