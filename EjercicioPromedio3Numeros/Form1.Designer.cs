namespace EjercicioPromedio3Numeros
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
            txt_num1 = new TextBox();
            label1 = new Label();
            num1 = new Label();
            label2 = new Label();
            txt_num2 = new TextBox();
            label3 = new Label();
            txt_num3 = new TextBox();
            btn_calcular = new Button();
            SuspendLayout();
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(144, 73);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miracode", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 21);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 1;
            label1.Text = "PROMEDIOS";
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Font = new Font("Miracode", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num1.Location = new Point(84, 75);
            num1.Name = "num1";
            num1.Size = new Size(50, 21);
            num1.TabIndex = 2;
            num1.Text = "num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Miracode", 11.25F);
            label2.Location = new Point(84, 119);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 4;
            label2.Text = "num2";
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(144, 116);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Miracode", 11.25F);
            label3.Location = new Point(84, 163);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 6;
            label3.Text = "num3";
            // 
            // txt_num3
            // 
            txt_num3.Location = new Point(144, 160);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(100, 23);
            txt_num3.TabIndex = 5;
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("Miracode", 11.25F);
            btn_calcular.Location = new Point(141, 205);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(103, 35);
            btn_calcular.TabIndex = 7;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 270);
            Controls.Add(btn_calcular);
            Controls.Add(label3);
            Controls.Add(txt_num3);
            Controls.Add(label2);
            Controls.Add(txt_num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Controls.Add(txt_num1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num1;
        private Label label1;
        private Label num1;
        private Label label2;
        private TextBox txt_num2;
        private Label label3;
        private TextBox txt_num3;
        private Button btn_calcular;
    }
}
