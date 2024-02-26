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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tb_lado = new System.Windows.Forms.TextBox();
            this.tb_base = new System.Windows.Forms.TextBox();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.bt_ejecutar = new System.Windows.Forms.Button();
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelIgual = new System.Windows.Forms.Label();
            this.labelLado = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(183, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(273, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Calcular área de un rectángulo";
            // 
            // tb_lado
            // 
            this.tb_lado.Location = new System.Drawing.Point(123, 140);
            this.tb_lado.Name = "tb_lado";
            this.tb_lado.Size = new System.Drawing.Size(100, 23);
            this.tb_lado.TabIndex = 2;
            this.tb_lado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lado_KeyPress);
            // 
            // tb_base
            // 
            this.tb_base.Location = new System.Drawing.Point(256, 140);
            this.tb_base.Name = "tb_base";
            this.tb_base.Size = new System.Drawing.Size(100, 23);
            this.tb_base.TabIndex = 3;
            this.tb_base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_base_KeyPress);
            // 
            // tb_resultado
            // 
            this.tb_resultado.Enabled = false;
            this.tb_resultado.Location = new System.Drawing.Point(389, 140);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(100, 23);
            this.tb_resultado.TabIndex = 4;
            // 
            // bt_ejecutar
            // 
            this.bt_ejecutar.Location = new System.Drawing.Point(123, 202);
            this.bt_ejecutar.Name = "bt_ejecutar";
            this.bt_ejecutar.Size = new System.Drawing.Size(100, 23);
            this.bt_ejecutar.TabIndex = 5;
            this.bt_ejecutar.Text = "ejecutar";
            this.bt_ejecutar.UseVisualStyleBackColor = true;
            this.bt_ejecutar.Click += new System.EventHandler(this.bt_ejecutar_Click);
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSuma.Location = new System.Drawing.Point(229, 142);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(21, 21);
            this.labelSuma.TabIndex = 6;
            this.labelSuma.Text = "+";
            // 
            // labelIgual
            // 
            this.labelIgual.AutoSize = true;
            this.labelIgual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIgual.Location = new System.Drawing.Point(362, 142);
            this.labelIgual.Name = "labelIgual";
            this.labelIgual.Size = new System.Drawing.Size(21, 21);
            this.labelIgual.TabIndex = 7;
            this.labelIgual.Text = "=";
            // 
            // labelLado
            // 
            this.labelLado.AutoSize = true;
            this.labelLado.Location = new System.Drawing.Point(123, 113);
            this.labelLado.Name = "labelLado";
            this.labelLado.Size = new System.Drawing.Size(75, 15);
            this.labelLado.TabIndex = 8;
            this.labelLado.Text = "Ingresar lado";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(256, 113);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(76, 15);
            this.labelBase.TabIndex = 9;
            this.labelBase.Text = "Ingresar base";
            // 
            // FormAreaRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 411);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.labelLado);
            this.Controls.Add(this.labelIgual);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.bt_ejecutar);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.tb_base);
            this.Controls.Add(this.tb_lado);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaRectangulo";
            this.Text = "FormAreaTriangulo";
            this.Load += new System.EventHandler(this.FormAreaRectangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_lado;
        private TextBox tb_base;
        private TextBox tb_resultado;
        private Button bt_ejecutar;
        private Label labelSuma;
        private Label labelIgual;
        private Label labelLado;
        private Label labelBase;
    }
}