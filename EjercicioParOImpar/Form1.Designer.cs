namespace EjercicioParOImpar
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
            txt_num = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btn_verificar = new Button();
            SuspendLayout();
            // 
            // txt_num
            // 
            txt_num.Font = new Font("Miracode", 10F);
            txt_num.Location = new Point(165, 107);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(100, 22);
            txt_num.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miracode", 12F);
            label1.Location = new Point(105, 107);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 3;
            label1.Text = "num:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Miracode", 12F);
            label3.Location = new Point(55, 42);
            label3.Name = "label3";
            label3.Size = new Size(296, 23);
            label3.TabIndex = 5;
            label3.Text = "VERIFICADOR DE PAR O IMPAR";
            // 
            // btn_verificar
            // 
            btn_verificar.Font = new Font("Miracode", 12F);
            btn_verificar.Location = new Point(140, 162);
            btn_verificar.Name = "btn_verificar";
            btn_verificar.Size = new Size(125, 34);
            btn_verificar.TabIndex = 6;
            btn_verificar.Text = "Verificar";
            btn_verificar.UseVisualStyleBackColor = true;
            btn_verificar.Click += btn_verificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 268);
            Controls.Add(btn_verificar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_num);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num;
        private Label label1;
        private Label label3;
        private Button btn_verificar;
    }
}
