namespace calculadora_figuras_geometricas
{
    partial class FormAreaRectangulo
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
            tb_lado = new TextBox();
            tb_base = new TextBox();
            tb_resultado = new TextBox();
            bt_ejecutar = new Button();
            labelLado = new Label();
            labelBase = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(183, 25);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(273, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Calcular área de un rectángulo";
            // 
            // tb_lado
            // 
            tb_lado.Location = new Point(123, 140);
            tb_lado.Name = "tb_lado";
            tb_lado.Size = new Size(100, 23);
            tb_lado.TabIndex = 2;
            tb_lado.KeyPress += tb_lado_KeyPress;
            // 
            // tb_base
            // 
            tb_base.Location = new Point(256, 140);
            tb_base.Name = "tb_base";
            tb_base.Size = new Size(100, 23);
            tb_base.TabIndex = 3;
            tb_base.KeyPress += tb_base_KeyPress;
            // 
            // tb_resultado
            // 
            tb_resultado.Enabled = false;
            tb_resultado.Location = new Point(389, 140);
            tb_resultado.Name = "tb_resultado";
            tb_resultado.Size = new Size(100, 23);
            tb_resultado.TabIndex = 4;
            // 
            // bt_ejecutar
            // 
            bt_ejecutar.Location = new Point(123, 202);
            bt_ejecutar.Name = "bt_ejecutar";
            bt_ejecutar.Size = new Size(100, 23);
            bt_ejecutar.TabIndex = 5;
            bt_ejecutar.Text = "ejecutar";
            bt_ejecutar.UseVisualStyleBackColor = true;
            bt_ejecutar.Click += bt_ejecutar_Click;
            // 
            // labelLado
            // 
            labelLado.AutoSize = true;
            labelLado.Location = new Point(123, 113);
            labelLado.Name = "labelLado";
            labelLado.Size = new Size(75, 15);
            labelLado.TabIndex = 8;
            labelLado.Text = "Ingresar lado";
            // 
            // labelBase
            // 
            labelBase.AutoSize = true;
            labelBase.Location = new Point(256, 113);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(76, 15);
            labelBase.TabIndex = 9;
            labelBase.Text = "Ingresar base";
            // 
            // FormAreaRectangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 411);
            Controls.Add(labelBase);
            Controls.Add(labelLado);
            Controls.Add(bt_ejecutar);
            Controls.Add(tb_resultado);
            Controls.Add(tb_base);
            Controls.Add(tb_lado);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAreaRectangulo";
            Text = "FormAreaTriangulo";
            Load += FormAreaRectangulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_lado;
        private TextBox tb_base;
        private TextBox tb_resultado;
        private Button bt_ejecutar;
        private Label labelLado;
        private Label labelBase;
    }
}