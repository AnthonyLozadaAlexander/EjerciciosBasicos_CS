namespace EjercicioNumerosPrimos
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
            btn_Calcular = new Button();
            label1 = new Label();
            listBox_Primos = new ListBox();
            SuspendLayout();
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Miracode", 14.25F);
            btn_Calcular.Location = new Point(104, 207);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(135, 61);
            btn_Calcular.TabIndex = 0;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miracode", 14.25F);
            label1.Location = new Point(74, 158);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
            label1.TabIndex = 1;
            label1.Text = "Numeros Primos";
            // 
            // listBox_Primos
            // 
            listBox_Primos.FormattingEnabled = true;
            listBox_Primos.Location = new Point(339, 22);
            listBox_Primos.Name = "listBox_Primos";
            listBox_Primos.Size = new Size(368, 439);
            listBox_Primos.TabIndex = 2;
            listBox_Primos.SelectedIndexChanged += listBox_Primos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 482);
            Controls.Add(listBox_Primos);
            Controls.Add(label1);
            Controls.Add(btn_Calcular);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calcular;
        private Label label1;
        private ListBox listBox_Primos;
    }
}
