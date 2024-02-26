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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tb_ingresar_lado1 = new System.Windows.Forms.TextBox();
            this.tb_salida1 = new System.Windows.Forms.TextBox();
            this.labelLado = new System.Windows.Forms.Label();
            this.labelIgual = new System.Windows.Forms.Label();
            this.tb_ingresar_lado2 = new System.Windows.Forms.TextBox();
            this.tb_ingresar_altura = new System.Windows.Forms.TextBox();
            this.tb_salida2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_ejecutar1 = new System.Windows.Forms.Button();
            this.bt_ejecutar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(126, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(351, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Calcular área de un triángulo equilatero";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // tb_ingresar_lado1
            // 
            this.tb_ingresar_lado1.Location = new System.Drawing.Point(73, 131);
            this.tb_ingresar_lado1.Name = "tb_ingresar_lado1";
            this.tb_ingresar_lado1.Size = new System.Drawing.Size(122, 23);
            this.tb_ingresar_lado1.TabIndex = 2;
            this.tb_ingresar_lado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingresar_lado1_KeyPress);
            // 
            // tb_salida1
            // 
            this.tb_salida1.Enabled = false;
            this.tb_salida1.Location = new System.Drawing.Point(228, 131);
            this.tb_salida1.Name = "tb_salida1";
            this.tb_salida1.Size = new System.Drawing.Size(122, 23);
            this.tb_salida1.TabIndex = 3;
            // 
            // labelLado
            // 
            this.labelLado.AutoSize = true;
            this.labelLado.Location = new System.Drawing.Point(73, 113);
            this.labelLado.Name = "labelLado";
            this.labelLado.Size = new System.Drawing.Size(75, 15);
            this.labelLado.TabIndex = 4;
            this.labelLado.Text = "Ingresar lado";
            // 
            // labelIgual
            // 
            this.labelIgual.AutoSize = true;
            this.labelIgual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIgual.Location = new System.Drawing.Point(201, 133);
            this.labelIgual.Name = "labelIgual";
            this.labelIgual.Size = new System.Drawing.Size(21, 21);
            this.labelIgual.TabIndex = 5;
            this.labelIgual.Text = "=";
            // 
            // tb_ingresar_lado2
            // 
            this.tb_ingresar_lado2.Location = new System.Drawing.Point(73, 201);
            this.tb_ingresar_lado2.Name = "tb_ingresar_lado2";
            this.tb_ingresar_lado2.Size = new System.Drawing.Size(122, 23);
            this.tb_ingresar_lado2.TabIndex = 6;
            this.tb_ingresar_lado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingresar_lado2_KeyPress);
            // 
            // tb_ingresar_altura
            // 
            this.tb_ingresar_altura.Location = new System.Drawing.Point(228, 201);
            this.tb_ingresar_altura.Name = "tb_ingresar_altura";
            this.tb_ingresar_altura.Size = new System.Drawing.Size(122, 23);
            this.tb_ingresar_altura.TabIndex = 7;
            this.tb_ingresar_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingresar_altura_KeyPress);
            // 
            // tb_salida2
            // 
            this.tb_salida2.Enabled = false;
            this.tb_salida2.Location = new System.Drawing.Point(383, 203);
            this.tb_salida2.Name = "tb_salida2";
            this.tb_salida2.Size = new System.Drawing.Size(122, 23);
            this.tb_salida2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingresar lado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresar altura";
            // 
            // bt_ejecutar1
            // 
            this.bt_ejecutar1.Location = new System.Drawing.Point(372, 131);
            this.bt_ejecutar1.Name = "bt_ejecutar1";
            this.bt_ejecutar1.Size = new System.Drawing.Size(86, 23);
            this.bt_ejecutar1.TabIndex = 13;
            this.bt_ejecutar1.Text = "ejecutar";
            this.bt_ejecutar1.UseVisualStyleBackColor = true;
            this.bt_ejecutar1.Click += new System.EventHandler(this.bt_ejecutar1_Click);
            // 
            // bt_ejecutar2
            // 
            this.bt_ejecutar2.Location = new System.Drawing.Point(528, 204);
            this.bt_ejecutar2.Name = "bt_ejecutar2";
            this.bt_ejecutar2.Size = new System.Drawing.Size(86, 23);
            this.bt_ejecutar2.TabIndex = 14;
            this.bt_ejecutar2.Text = "ejecutar";
            this.bt_ejecutar2.UseVisualStyleBackColor = true;
            this.bt_ejecutar2.Click += new System.EventHandler(this.bt_ejecutar2_Click);
            // 
            // FormAreaTrianguloEquilatero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.bt_ejecutar2);
            this.Controls.Add(this.bt_ejecutar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_salida2);
            this.Controls.Add(this.tb_ingresar_altura);
            this.Controls.Add(this.tb_ingresar_lado2);
            this.Controls.Add(this.labelIgual);
            this.Controls.Add(this.labelLado);
            this.Controls.Add(this.tb_salida1);
            this.Controls.Add(this.tb_ingresar_lado1);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaTrianguloEquilatero";
            this.Text = "FormAreaTrianguloEquilatero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_ingresar_lado1;
        private TextBox tb_salida1;
        private Label labelLado;
        private Label labelIgual;
        private TextBox tb_ingresar_lado2;
        private TextBox tb_ingresar_altura;
        private TextBox tb_salida2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_ejecutar1;
        private Button bt_ejecutar2;
    }
}