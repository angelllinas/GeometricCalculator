namespace calculadora_figuras_geometricas
{
    partial class FormAreaTrianguloEquilatero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            tb_ingresar_lado1 = new TextBox();
            tb_salida1 = new TextBox();
            labelLado = new Label();
            tb_ingresar_lado2 = new TextBox();
            tb_ingresar_altura = new TextBox();
            tb_salida2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            bt_ejecutar1 = new Button();
            bt_ejecutar2 = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(126, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(351, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Calcular área de un triángulo equilatero";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // tb_ingresar_lado1
            // 
            tb_ingresar_lado1.Location = new Point(73, 131);
            tb_ingresar_lado1.Name = "tb_ingresar_lado1";
            tb_ingresar_lado1.Size = new Size(122, 23);
            tb_ingresar_lado1.TabIndex = 2;
            tb_ingresar_lado1.KeyPress += tb_ingresar_lado1_KeyPress;
            // 
            // tb_salida1
            // 
            tb_salida1.Enabled = false;
            tb_salida1.Location = new Point(228, 131);
            tb_salida1.Name = "tb_salida1";
            tb_salida1.Size = new Size(122, 23);
            tb_salida1.TabIndex = 3;
            // 
            // labelLado
            // 
            labelLado.AutoSize = true;
            labelLado.Location = new Point(73, 113);
            labelLado.Name = "labelLado";
            labelLado.Size = new Size(75, 15);
            labelLado.TabIndex = 4;
            labelLado.Text = "Ingresar lado";
            // 
            // tb_ingresar_lado2
            // 
            tb_ingresar_lado2.Location = new Point(73, 201);
            tb_ingresar_lado2.Name = "tb_ingresar_lado2";
            tb_ingresar_lado2.Size = new Size(122, 23);
            tb_ingresar_lado2.TabIndex = 6;
            tb_ingresar_lado2.KeyPress += tb_ingresar_lado2_KeyPress;
            // 
            // tb_ingresar_altura
            // 
            tb_ingresar_altura.Location = new Point(228, 201);
            tb_ingresar_altura.Name = "tb_ingresar_altura";
            tb_ingresar_altura.Size = new Size(122, 23);
            tb_ingresar_altura.TabIndex = 7;
            tb_ingresar_altura.KeyPress += tb_ingresar_altura_KeyPress;
            // 
            // tb_salida2
            // 
            tb_salida2.Enabled = false;
            tb_salida2.Location = new Point(383, 203);
            tb_salida2.Name = "tb_salida2";
            tb_salida2.Size = new Size(122, 23);
            tb_salida2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 183);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 11;
            label3.Text = "Ingresar lado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 183);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 12;
            label4.Text = "Ingresar altura";
            // 
            // bt_ejecutar1
            // 
            bt_ejecutar1.Location = new Point(372, 131);
            bt_ejecutar1.Name = "bt_ejecutar1";
            bt_ejecutar1.Size = new Size(86, 23);
            bt_ejecutar1.TabIndex = 13;
            bt_ejecutar1.Text = "ejecutar";
            bt_ejecutar1.UseVisualStyleBackColor = true;
            bt_ejecutar1.Click += bt_ejecutar1_Click;
            // 
            // bt_ejecutar2
            // 
            bt_ejecutar2.Location = new Point(528, 204);
            bt_ejecutar2.Name = "bt_ejecutar2";
            bt_ejecutar2.Size = new Size(86, 23);
            bt_ejecutar2.TabIndex = 14;
            bt_ejecutar2.Text = "ejecutar";
            bt_ejecutar2.UseVisualStyleBackColor = true;
            bt_ejecutar2.Click += bt_ejecutar2_Click;
            // 
            // FormAreaTrianguloEquilatero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(bt_ejecutar2);
            Controls.Add(bt_ejecutar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_salida2);
            Controls.Add(tb_ingresar_altura);
            Controls.Add(tb_ingresar_lado2);
            Controls.Add(labelLado);
            Controls.Add(tb_salida1);
            Controls.Add(tb_ingresar_lado1);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAreaTrianguloEquilatero";
            Text = "FormAreaTrianguloEquilatero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_ingresar_lado1;
        private TextBox tb_salida1;
        private Label labelLado;
        private TextBox tb_ingresar_lado2;
        private TextBox tb_ingresar_altura;
        private TextBox tb_salida2;
        private Label label3;
        private Label label4;
        private Button bt_ejecutar1;
        private Button bt_ejecutar2;
    }
}