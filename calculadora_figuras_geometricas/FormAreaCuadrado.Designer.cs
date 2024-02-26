namespace calculadora_figuras_geometricas
{
    partial class FormAreaCuadrado
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
            this.labelLado = new System.Windows.Forms.Label();
            this.tb_ingreso_lado = new System.Windows.Forms.TextBox();
            this.tb_salida_lado = new System.Windows.Forms.TextBox();
            this.labelIgual1 = new System.Windows.Forms.Label();
            this.tb_ingreso_diagonal = new System.Windows.Forms.TextBox();
            this.labelDiagonal = new System.Windows.Forms.Label();
            this.tb_salida_diagonal = new System.Windows.Forms.TextBox();
            this.labelIgual2 = new System.Windows.Forms.Label();
            this.bt_ejecutar_lado = new System.Windows.Forms.Button();
            this.bt_ejecutar_diagonal = new System.Windows.Forms.Button();
            this.labelPerimetro = new System.Windows.Forms.Label();
            this.tb_ingreso_perimetro = new System.Windows.Forms.TextBox();
            this.tb_salida_perimetro = new System.Windows.Forms.TextBox();
            this.labelIgual3 = new System.Windows.Forms.Label();
            this.bt_ejecutar_perimetro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(184, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(261, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Calcular área de un cuadrado";
            // 
            // labelLado
            // 
            this.labelLado.AutoSize = true;
            this.labelLado.Location = new System.Drawing.Point(100, 96);
            this.labelLado.Name = "labelLado";
            this.labelLado.Size = new System.Drawing.Size(89, 15);
            this.labelLado.TabIndex = 1;
            this.labelLado.Text = "Insertar un lado";
            // 
            // tb_ingreso_lado
            // 
            this.tb_ingreso_lado.Location = new System.Drawing.Point(100, 123);
            this.tb_ingreso_lado.Name = "tb_ingreso_lado";
            this.tb_ingreso_lado.Size = new System.Drawing.Size(114, 23);
            this.tb_ingreso_lado.TabIndex = 2;
            this.tb_ingreso_lado.TextChanged += new System.EventHandler(this.tb_ingreso_lado_TextChanged);
            this.tb_ingreso_lado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingreso_lado_KeyPress);
            // 
            // tb_salida_lado
            // 
            this.tb_salida_lado.Enabled = false;
            this.tb_salida_lado.Location = new System.Drawing.Point(241, 123);
            this.tb_salida_lado.Name = "tb_salida_lado";
            this.tb_salida_lado.Size = new System.Drawing.Size(114, 23);
            this.tb_salida_lado.TabIndex = 3;
            // 
            // labelIgual1
            // 
            this.labelIgual1.AutoSize = true;
            this.labelIgual1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIgual1.Location = new System.Drawing.Point(214, 125);
            this.labelIgual1.Name = "labelIgual1";
            this.labelIgual1.Size = new System.Drawing.Size(21, 21);
            this.labelIgual1.TabIndex = 4;
            this.labelIgual1.Text = "=";
            this.labelIgual1.Click += new System.EventHandler(this.labelIgual1_Click);
            // 
            // tb_ingreso_diagonal
            // 
            this.tb_ingreso_diagonal.Location = new System.Drawing.Point(100, 215);
            this.tb_ingreso_diagonal.Name = "tb_ingreso_diagonal";
            this.tb_ingreso_diagonal.Size = new System.Drawing.Size(114, 23);
            this.tb_ingreso_diagonal.TabIndex = 5;
            this.tb_ingreso_diagonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingreso_diagonal_KeyPress);
            // 
            // labelDiagonal
            // 
            this.labelDiagonal.AutoSize = true;
            this.labelDiagonal.Location = new System.Drawing.Point(100, 187);
            this.labelDiagonal.Name = "labelDiagonal";
            this.labelDiagonal.Size = new System.Drawing.Size(107, 15);
            this.labelDiagonal.TabIndex = 6;
            this.labelDiagonal.Text = "Insertar la diagonal";
            this.labelDiagonal.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_salida_diagonal
            // 
            this.tb_salida_diagonal.Enabled = false;
            this.tb_salida_diagonal.Location = new System.Drawing.Point(241, 215);
            this.tb_salida_diagonal.Name = "tb_salida_diagonal";
            this.tb_salida_diagonal.Size = new System.Drawing.Size(114, 23);
            this.tb_salida_diagonal.TabIndex = 7;
            // 
            // labelIgual2
            // 
            this.labelIgual2.AutoSize = true;
            this.labelIgual2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIgual2.Location = new System.Drawing.Point(214, 217);
            this.labelIgual2.Name = "labelIgual2";
            this.labelIgual2.Size = new System.Drawing.Size(21, 21);
            this.labelIgual2.TabIndex = 8;
            this.labelIgual2.Text = "=";
            // 
            // bt_ejecutar_lado
            // 
            this.bt_ejecutar_lado.Location = new System.Drawing.Point(370, 123);
            this.bt_ejecutar_lado.Name = "bt_ejecutar_lado";
            this.bt_ejecutar_lado.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar_lado.TabIndex = 9;
            this.bt_ejecutar_lado.Text = "ejecutar";
            this.bt_ejecutar_lado.UseVisualStyleBackColor = true;
            this.bt_ejecutar_lado.Click += new System.EventHandler(this.bt_ejecutar_lado_Click);
            // 
            // bt_ejecutar_diagonal
            // 
            this.bt_ejecutar_diagonal.Location = new System.Drawing.Point(370, 215);
            this.bt_ejecutar_diagonal.Name = "bt_ejecutar_diagonal";
            this.bt_ejecutar_diagonal.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar_diagonal.TabIndex = 10;
            this.bt_ejecutar_diagonal.Text = "ejecutar";
            this.bt_ejecutar_diagonal.UseVisualStyleBackColor = true;
            this.bt_ejecutar_diagonal.Click += new System.EventHandler(this.bt_ejecutar_diagonal_Click);
            // 
            // labelPerimetro
            // 
            this.labelPerimetro.AutoSize = true;
            this.labelPerimetro.Location = new System.Drawing.Point(100, 278);
            this.labelPerimetro.Name = "labelPerimetro";
            this.labelPerimetro.Size = new System.Drawing.Size(113, 15);
            this.labelPerimetro.TabIndex = 11;
            this.labelPerimetro.Text = "Insertar el perimetro";
            // 
            // tb_ingreso_perimetro
            // 
            this.tb_ingreso_perimetro.Location = new System.Drawing.Point(100, 307);
            this.tb_ingreso_perimetro.Name = "tb_ingreso_perimetro";
            this.tb_ingreso_perimetro.Size = new System.Drawing.Size(114, 23);
            this.tb_ingreso_perimetro.TabIndex = 12;
            this.tb_ingreso_perimetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingreso_perimetro_KeyPress);
            // 
            // tb_salida_perimetro
            // 
            this.tb_salida_perimetro.Enabled = false;
            this.tb_salida_perimetro.Location = new System.Drawing.Point(241, 308);
            this.tb_salida_perimetro.Name = "tb_salida_perimetro";
            this.tb_salida_perimetro.Size = new System.Drawing.Size(114, 23);
            this.tb_salida_perimetro.TabIndex = 13;
            // 
            // labelIgual3
            // 
            this.labelIgual3.AutoSize = true;
            this.labelIgual3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIgual3.Location = new System.Drawing.Point(214, 310);
            this.labelIgual3.Name = "labelIgual3";
            this.labelIgual3.Size = new System.Drawing.Size(21, 21);
            this.labelIgual3.TabIndex = 14;
            this.labelIgual3.Text = "=";
            // 
            // bt_ejecutar_perimetro
            // 
            this.bt_ejecutar_perimetro.Location = new System.Drawing.Point(370, 308);
            this.bt_ejecutar_perimetro.Name = "bt_ejecutar_perimetro";
            this.bt_ejecutar_perimetro.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar_perimetro.TabIndex = 15;
            this.bt_ejecutar_perimetro.Text = "ejecutar";
            this.bt_ejecutar_perimetro.UseVisualStyleBackColor = true;
            this.bt_ejecutar_perimetro.Click += new System.EventHandler(this.bt_ejecutar_perimetro_Click);
            // 
            // FormAreaCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.bt_ejecutar_perimetro);
            this.Controls.Add(this.labelIgual3);
            this.Controls.Add(this.tb_salida_perimetro);
            this.Controls.Add(this.tb_ingreso_perimetro);
            this.Controls.Add(this.labelPerimetro);
            this.Controls.Add(this.bt_ejecutar_diagonal);
            this.Controls.Add(this.bt_ejecutar_lado);
            this.Controls.Add(this.labelIgual2);
            this.Controls.Add(this.tb_salida_diagonal);
            this.Controls.Add(this.labelDiagonal);
            this.Controls.Add(this.tb_ingreso_diagonal);
            this.Controls.Add(this.labelIgual1);
            this.Controls.Add(this.tb_salida_lado);
            this.Controls.Add(this.tb_ingreso_lado);
            this.Controls.Add(this.labelLado);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(661, 450);
            this.MinimumSize = new System.Drawing.Size(661, 450);
            this.Name = "FormAreaCuadrado";
            this.Text = "FormAreaCuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Label labelLado;
        private TextBox tb_ingreso_lado;
        private TextBox tb_salida_lado;
        private Label labelIgual1;
        private TextBox tb_ingreso_diagonal;
        private Label labelDiagonal;
        private TextBox tb_salida_diagonal;
        private Label labelIgual2;
        private Button bt_ejecutar_lado;
        private Button bt_ejecutar_diagonal;
        private Label labelPerimetro;
        private TextBox tb_ingreso_perimetro;
        private TextBox tb_salida_perimetro;
        private Label labelIgual3;
        private Button bt_ejecutar_perimetro;
    }
}