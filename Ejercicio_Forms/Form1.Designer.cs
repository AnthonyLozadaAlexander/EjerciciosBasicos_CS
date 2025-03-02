namespace Ejercicio_Forms
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
            nud_Op1 = new NumericUpDown();
            btn_S = new Button();
            btn_R = new Button();
            btn_M = new Button();
            btn_D = new Button();
            txt_Resultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nud_Op2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Op1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Op2).BeginInit();
            SuspendLayout();
            // 
            // nud_Op1
            // 
            nud_Op1.Font = new Font("Miracode", 10F);
            nud_Op1.Location = new Point(119, 147);
            nud_Op1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Op1.Name = "nud_Op1";
            nud_Op1.Size = new Size(157, 22);
            nud_Op1.TabIndex = 0;
            // 
            // btn_S
            // 
            btn_S.Font = new Font("Miracode", 12F);
            btn_S.Location = new Point(117, 217);
            btn_S.Name = "btn_S";
            btn_S.Size = new Size(79, 31);
            btn_S.TabIndex = 2;
            btn_S.Text = "+";
            btn_S.UseVisualStyleBackColor = true;
            btn_S.Click += btn_S_Click;
            // 
            // btn_R
            // 
            btn_R.Font = new Font("Miracode", 12F);
            btn_R.Location = new Point(212, 217);
            btn_R.Name = "btn_R";
            btn_R.Size = new Size(79, 31);
            btn_R.TabIndex = 3;
            btn_R.Text = "-";
            btn_R.UseVisualStyleBackColor = true;
            btn_R.Click += btn_R_Click;
            // 
            // btn_M
            // 
            btn_M.Font = new Font("Miracode", 12F);
            btn_M.Location = new Point(302, 217);
            btn_M.Name = "btn_M";
            btn_M.Size = new Size(79, 31);
            btn_M.TabIndex = 4;
            btn_M.Text = "*";
            btn_M.UseVisualStyleBackColor = true;
            btn_M.Click += btn_M_Click;
            // 
            // btn_D
            // 
            btn_D.Font = new Font("Miracode", 12F);
            btn_D.Location = new Point(396, 217);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(79, 31);
            btn_D.TabIndex = 5;
            btn_D.Text = "/";
            btn_D.UseVisualStyleBackColor = true;
            btn_D.Click += btn_D_Click;
            // 
            // txt_Resultado
            // 
            txt_Resultado.Font = new Font("Miracode", 12F);
            txt_Resultado.Location = new Point(119, 321);
            txt_Resultado.Multiline = true;
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.Size = new Size(356, 31);
            txt_Resultado.TabIndex = 7;
            txt_Resultado.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miracode", 12F);
            label1.Location = new Point(144, 115);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 8;
            label1.Text = "Operando1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Miracode", 12F);
            label2.Location = new Point(324, 115);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 9;
            label2.Text = "Operando2";
            // 
            // nud_Op2
            // 
            nud_Op2.Font = new Font("Miracode", 10F);
            nud_Op2.Location = new Point(302, 147);
            nud_Op2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Op2.Name = "nud_Op2";
            nud_Op2.Size = new Size(157, 22);
            nud_Op2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Miracode", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(202, 44);
            label3.Name = "label3";
            label3.Size = new Size(179, 31);
            label3.TabIndex = 11;
            label3.Text = "Calculadora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Miracode", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(229, 281);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 12;
            label4.Text = "Resultado";
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Miracode", 10F);
            btn_exit.Location = new Point(496, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(82, 37);
            btn_exit.TabIndex = 13;
            btn_exit.Text = "Salir";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 476);
            Controls.Add(btn_exit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nud_Op2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Resultado);
            Controls.Add(btn_D);
            Controls.Add(btn_M);
            Controls.Add(btn_R);
            Controls.Add(btn_S);
            Controls.Add(nud_Op1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form:PCalculadora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Op1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Op2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_Op1;
        private Button btn_S;
        private Button btn_R;
        private Button btn_M;
        private Button btn_D;
        private TextBox txt_Resultado;
        private Label label1;
        private Label label2;
        private NumericUpDown nud_Op2;
        private Label label3;
        private Label label4;
        private Button btn_exit;
    }
}
