namespace EjercicioProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCompras = new ListBox();
            btn_agregar = new Button();
            btn_calcular = new Button();
            cbo_Productos = new ComboBox();
            btn_Salir = new Button();
            label1 = new Label();
            txt_Descuento = new TextBox();
            SuspendLayout();
            // 
            // listCompras
            // 
            listCompras.FormattingEnabled = true;
            listCompras.Location = new Point(23, 29);
            listCompras.Name = "listCompras";
            listCompras.Size = new Size(246, 289);
            listCompras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(311, 116);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(392, 116);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(115, 23);
            btn_calcular.TabIndex = 2;
            btn_calcular.Text = "Calcular Precio";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // cbo_Productos
            // 
            cbo_Productos.FormattingEnabled = true;
            cbo_Productos.Location = new Point(311, 72);
            cbo_Productos.Name = "cbo_Productos";
            cbo_Productos.Size = new Size(196, 23);
            cbo_Productos.TabIndex = 3;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(502, 12);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(60, 23);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 186);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 5;
            label1.Text = "Codigo De Descuento:";
            // 
            // txt_Descuento
            // 
            txt_Descuento.Location = new Point(442, 183);
            txt_Descuento.Name = "txt_Descuento";
            txt_Descuento.Size = new Size(100, 23);
            txt_Descuento.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 392);
            Controls.Add(txt_Descuento);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(cbo_Productos);
            Controls.Add(btn_calcular);
            Controls.Add(btn_agregar);
            Controls.Add(listCompras);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Productos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCompras;
        private Button btn_agregar;
        private Button btn_calcular;
        private ComboBox cbo_Productos;
        private Button btn_Salir;
        private Label label1;
        private TextBox txt_Descuento;
    }
}
