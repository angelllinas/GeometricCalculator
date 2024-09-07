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
            labelTitulo = new Label();
            labelLado = new Label();
            tb_ingreso_lado = new TextBox();
            tb_salida_lado = new TextBox();
            tb_ingreso_diagonal = new TextBox();
            labelDiagonal = new Label();
            tb_salida_diagonal = new TextBox();
            bt_ejecutar_lado = new Button();
            bt_ejecutar_diagonal = new Button();
            labelPerimetro = new Label();
            tb_ingreso_perimetro = new TextBox();
            tb_salida_perimetro = new TextBox();
            bt_ejecutar_perimetro = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(184, 24);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(261, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Calcular área de un cuadrado";
            // 
            // labelLado
            // 
            labelLado.AutoSize = true;
            labelLado.Location = new Point(100, 96);
            labelLado.Name = "labelLado";
            labelLado.Size = new Size(89, 15);
            labelLado.TabIndex = 1;
            labelLado.Text = "Insertar un lado";
            // 
            // tb_ingreso_lado
            // 
            tb_ingreso_lado.Location = new Point(100, 123);
            tb_ingreso_lado.Name = "tb_ingreso_lado";
            tb_ingreso_lado.Size = new Size(114, 23);
            tb_ingreso_lado.TabIndex = 2;
            tb_ingreso_lado.TextChanged += tb_ingreso_lado_TextChanged;
            tb_ingreso_lado.KeyPress += tb_ingreso_lado_KeyPress;
            // 
            // tb_salida_lado
            // 
            tb_salida_lado.Enabled = false;
            tb_salida_lado.Location = new Point(241, 123);
            tb_salida_lado.Name = "tb_salida_lado";
            tb_salida_lado.Size = new Size(114, 23);
            tb_salida_lado.TabIndex = 3;
            // 
            // tb_ingreso_diagonal
            // 
            tb_ingreso_diagonal.Location = new Point(100, 215);
            tb_ingreso_diagonal.Name = "tb_ingreso_diagonal";
            tb_ingreso_diagonal.Size = new Size(114, 23);
            tb_ingreso_diagonal.TabIndex = 5;
            tb_ingreso_diagonal.KeyPress += tb_ingreso_diagonal_KeyPress;
            // 
            // labelDiagonal
            // 
            labelDiagonal.AutoSize = true;
            labelDiagonal.Location = new Point(100, 187);
            labelDiagonal.Name = "labelDiagonal";
            labelDiagonal.Size = new Size(107, 15);
            labelDiagonal.TabIndex = 6;
            labelDiagonal.Text = "Insertar la diagonal";
            labelDiagonal.Click += label1_Click;
            // 
            // tb_salida_diagonal
            // 
            tb_salida_diagonal.Enabled = false;
            tb_salida_diagonal.Location = new Point(241, 215);
            tb_salida_diagonal.Name = "tb_salida_diagonal";
            tb_salida_diagonal.Size = new Size(114, 23);
            tb_salida_diagonal.TabIndex = 7;
            // 
            // bt_ejecutar_lado
            // 
            bt_ejecutar_lado.Location = new Point(370, 123);
            bt_ejecutar_lado.Name = "bt_ejecutar_lado";
            bt_ejecutar_lado.Size = new Size(75, 23);
            bt_ejecutar_lado.TabIndex = 9;
            bt_ejecutar_lado.Text = "ejecutar";
            bt_ejecutar_lado.UseVisualStyleBackColor = true;
            bt_ejecutar_lado.Click += bt_ejecutar_lado_Click;
            // 
            // bt_ejecutar_diagonal
            // 
            bt_ejecutar_diagonal.Location = new Point(370, 215);
            bt_ejecutar_diagonal.Name = "bt_ejecutar_diagonal";
            bt_ejecutar_diagonal.Size = new Size(75, 23);
            bt_ejecutar_diagonal.TabIndex = 10;
            bt_ejecutar_diagonal.Text = "ejecutar";
            bt_ejecutar_diagonal.UseVisualStyleBackColor = true;
            bt_ejecutar_diagonal.Click += bt_ejecutar_diagonal_Click;
            // 
            // labelPerimetro
            // 
            labelPerimetro.AutoSize = true;
            labelPerimetro.Location = new Point(100, 278);
            labelPerimetro.Name = "labelPerimetro";
            labelPerimetro.Size = new Size(113, 15);
            labelPerimetro.TabIndex = 11;
            labelPerimetro.Text = "Insertar el perimetro";
            // 
            // tb_ingreso_perimetro
            // 
            tb_ingreso_perimetro.Location = new Point(100, 307);
            tb_ingreso_perimetro.Name = "tb_ingreso_perimetro";
            tb_ingreso_perimetro.Size = new Size(114, 23);
            tb_ingreso_perimetro.TabIndex = 12;
            tb_ingreso_perimetro.KeyPress += tb_ingreso_perimetro_KeyPress;
            // 
            // tb_salida_perimetro
            // 
            tb_salida_perimetro.Enabled = false;
            tb_salida_perimetro.Location = new Point(241, 308);
            tb_salida_perimetro.Name = "tb_salida_perimetro";
            tb_salida_perimetro.Size = new Size(114, 23);
            tb_salida_perimetro.TabIndex = 13;
            // 
            // bt_ejecutar_perimetro
            // 
            bt_ejecutar_perimetro.Location = new Point(370, 308);
            bt_ejecutar_perimetro.Name = "bt_ejecutar_perimetro";
            bt_ejecutar_perimetro.Size = new Size(75, 23);
            bt_ejecutar_perimetro.TabIndex = 15;
            bt_ejecutar_perimetro.Text = "ejecutar";
            bt_ejecutar_perimetro.UseVisualStyleBackColor = true;
            bt_ejecutar_perimetro.Click += bt_ejecutar_perimetro_Click;
            // 
            // FormAreaCuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(bt_ejecutar_perimetro);
            Controls.Add(tb_salida_perimetro);
            Controls.Add(tb_ingreso_perimetro);
            Controls.Add(labelPerimetro);
            Controls.Add(bt_ejecutar_diagonal);
            Controls.Add(bt_ejecutar_lado);
            Controls.Add(tb_salida_diagonal);
            Controls.Add(labelDiagonal);
            Controls.Add(tb_ingreso_diagonal);
            Controls.Add(tb_salida_lado);
            Controls.Add(tb_ingreso_lado);
            Controls.Add(labelLado);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(661, 450);
            MinimumSize = new Size(661, 450);
            Name = "FormAreaCuadrado";
            Text = "FormAreaCuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelLado;
        private TextBox tb_ingreso_lado;
        private TextBox tb_salida_lado;
        private TextBox tb_ingreso_diagonal;
        private Label labelDiagonal;
        private TextBox tb_salida_diagonal;
        private Button bt_ejecutar_lado;
        private Button bt_ejecutar_diagonal;
        private Label labelPerimetro;
        private TextBox tb_ingreso_perimetro;
        private TextBox tb_salida_perimetro;
        private Button bt_ejecutar_perimetro;
    }
}