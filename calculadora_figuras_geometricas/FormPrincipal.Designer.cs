namespace calculadora_figuras_geometricas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.bt_hipotenusa_triangulo_rectangulo = new System.Windows.Forms.Button();
            this.bt_area_circulo = new System.Windows.Forms.Button();
            this.bt_area_rectangulo = new System.Windows.Forms.Button();
            this.bt_area_cuadrado = new System.Windows.Forms.Button();
            this.bt_calcular_area_triangulo = new System.Windows.Forms.Button();
            this.panelOperatos = new System.Windows.Forms.Panel();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelOptions.Controls.Add(this.bt_hipotenusa_triangulo_rectangulo);
            this.panelOptions.Controls.Add(this.bt_area_circulo);
            this.panelOptions.Controls.Add(this.bt_area_rectangulo);
            this.panelOptions.Controls.Add(this.bt_area_cuadrado);
            this.panelOptions.Controls.Add(this.bt_calcular_area_triangulo);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(139, 450);
            this.panelOptions.TabIndex = 0;
            // 
            // bt_hipotenusa_triangulo_rectangulo
            // 
            this.bt_hipotenusa_triangulo_rectangulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_hipotenusa_triangulo_rectangulo.Location = new System.Drawing.Point(0, 120);
            this.bt_hipotenusa_triangulo_rectangulo.Name = "bt_hipotenusa_triangulo_rectangulo";
            this.bt_hipotenusa_triangulo_rectangulo.Size = new System.Drawing.Size(139, 30);
            this.bt_hipotenusa_triangulo_rectangulo.TabIndex = 4;
            this.bt_hipotenusa_triangulo_rectangulo.Text = "hipotenusa triángulo rectángulo";
            this.bt_hipotenusa_triangulo_rectangulo.UseVisualStyleBackColor = true;
            this.bt_hipotenusa_triangulo_rectangulo.Click += new System.EventHandler(this.bt_hipotenusa_triangulo_rectangulo_Click);
            // 
            // bt_area_circulo
            // 
            this.bt_area_circulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_area_circulo.Location = new System.Drawing.Point(0, 90);
            this.bt_area_circulo.Name = "bt_area_circulo";
            this.bt_area_circulo.Size = new System.Drawing.Size(139, 30);
            this.bt_area_circulo.TabIndex = 3;
            this.bt_area_circulo.Text = "área círculo";
            this.bt_area_circulo.UseVisualStyleBackColor = true;
            this.bt_area_circulo.Click += new System.EventHandler(this.bt_area_circulo_Click);
            // 
            // bt_area_rectangulo
            // 
            this.bt_area_rectangulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_area_rectangulo.Location = new System.Drawing.Point(0, 60);
            this.bt_area_rectangulo.Name = "bt_area_rectangulo";
            this.bt_area_rectangulo.Size = new System.Drawing.Size(139, 30);
            this.bt_area_rectangulo.TabIndex = 2;
            this.bt_area_rectangulo.Text = "área rectangulo";
            this.bt_area_rectangulo.UseVisualStyleBackColor = true;
            this.bt_area_rectangulo.Click += new System.EventHandler(this.bt_area_rectangulo_Click);
            // 
            // bt_area_cuadrado
            // 
            this.bt_area_cuadrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_area_cuadrado.Location = new System.Drawing.Point(0, 30);
            this.bt_area_cuadrado.Name = "bt_area_cuadrado";
            this.bt_area_cuadrado.Size = new System.Drawing.Size(139, 30);
            this.bt_area_cuadrado.TabIndex = 1;
            this.bt_area_cuadrado.Text = "calcular área cuadrado";
            this.bt_area_cuadrado.UseVisualStyleBackColor = true;
            this.bt_area_cuadrado.Click += new System.EventHandler(this.bt_area_cuadrado_Click);
            // 
            // bt_calcular_area_triangulo
            // 
            this.bt_calcular_area_triangulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_calcular_area_triangulo.Location = new System.Drawing.Point(0, 0);
            this.bt_calcular_area_triangulo.Name = "bt_calcular_area_triangulo";
            this.bt_calcular_area_triangulo.Size = new System.Drawing.Size(139, 30);
            this.bt_calcular_area_triangulo.TabIndex = 0;
            this.bt_calcular_area_triangulo.Text = "calcular área triángulo";
            this.bt_calcular_area_triangulo.UseVisualStyleBackColor = true;
            this.bt_calcular_area_triangulo.Click += new System.EventHandler(this.bt_calcular_area_triangulo_Click);
            // 
            // panelOperatos
            // 
            this.panelOperatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperatos.Location = new System.Drawing.Point(139, 0);
            this.panelOperatos.Name = "panelOperatos";
            this.panelOperatos.Size = new System.Drawing.Size(661, 450);
            this.panelOperatos.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOperatos);
            this.Controls.Add(this.panelOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelOptions;
        private Panel panelOperatos;
        private Button bt_hipotenusa_triangulo_rectangulo;
        private Button bt_area_circulo;
        private Button bt_area_rectangulo;
        private Button bt_area_cuadrado;
        private Button bt_calcular_area_triangulo;
    }
}