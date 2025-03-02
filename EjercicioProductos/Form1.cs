namespace EjercicioProductos
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
            // Agregar productos al combobox

            cbo_Productos.Items.Add("Pantalon");
            cbo_Productos.Items.Add("Camisa");
            cbo_Productos.Items.Add("Zapatos");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // boton para agregar productos al listbox
            string productoSeleccionado = cbo_Productos.SelectedItem.ToString();
            listCompras.Items.Add(productoSeleccionado);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Pantalon $20, Camisa $35, Zapatos = 24
            double Pantalon = 20, Camisa = 35, Zapatos = 24;
            double precioFinal = 0; // acumulador de precioTotal
            // double descuento = 0;
            string Cupon = txt_Descuento.Text; // cupon de descuento

            int totalProductosCargados = listCompras.Items.Count; // cantidad de productos cargados

            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = listCompras.Items[i].ToString();
                
                if(productoElegido == "Pantalon")
                {
                    precioFinal = precioFinal + Pantalon; // Pantalon = 20
                }

                if(productoElegido == "Camisa")
                {
                    precioFinal = precioFinal + Camisa; // Camisa = 35
                }

                if(productoElegido == "Zapatos")
                {
                    precioFinal = precioFinal + Zapatos; // Zapatos = 24
                }

            }

            if(Cupon == "Navidad" || Cupon == "NAVIDAD" || Cupon == "navidad")
            {
                //descuento = precioFinal * 0.10;
                precioFinal = precioFinal - (precioFinal * 0.10);
                MessageBox.Show($"El precio final junto con el cupon de descuento del 10% es de: ${precioFinal}", "Pago", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show($"El precio final es de: ${precioFinal}", "Pago", MessageBoxButtons.OK);

            }
        }
    }
}
