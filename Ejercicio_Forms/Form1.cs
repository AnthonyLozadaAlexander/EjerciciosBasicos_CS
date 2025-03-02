namespace Ejercicio_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            decimal n1 = this.nud_Op1.Value;
            decimal n2 = this.nud_Op2.Value;

            decimal total = (n1 + n2);

            this.txt_Resultado.Text = total + "";
        }

        private void btn_R_Click(object sender, EventArgs e)
        {

            decimal n1 = this.nud_Op1.Value;
            decimal n2 = this.nud_Op2.Value;

            decimal total = (n1 - n2);

            this.txt_Resultado.Text = total + "";
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            decimal n1 = this.nud_Op1.Value;
            decimal n2 = this.nud_Op2.Value;

            decimal total = (n1 * n2);

            this.txt_Resultado.Text = total + "";
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            decimal n1 = this.nud_Op1.Value;
            decimal n2 = this.nud_Op2.Value;

            if (n2 == 0)
            {
                MessageBox.Show("Error: No se puede dividir por 0");
            }
            else
            {
                decimal total = (n1 / n2);
                this.txt_Resultado.Text = total + "";
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
