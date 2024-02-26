namespace calculadora_figuras_geometricas
{
    partial class FormAreaCirculo
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
            this.tb_ingresar_radio = new System.Windows.Forms.TextBox();
            this.tb_salida_radio = new System.Windows.Forms.TextBox();
            this.tb_ingresar_diametro = new System.Windows.Forms.TextBox();
            this.tb_salida_diametro = new System.Windows.Forms.TextBox();
            this.bt_ejecutar_radio = new System.Windows.Forms.Button();
            this.bt_ejecutar_diametro = new System.Windows.Forms.Button();
            this.labelIgual1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRadio = new System.Windows.Forms.Label();
            this.labelPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(180, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(238, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Calcular área de un círculo";
            // 
            // tb_ingresar_radio
            // 
            this.tb_ingresar_radio.Location = new System.Drawing.Point(133, 125);
            this.tb_ingresar_radio.Name = "tb_ingresar_radio";
            this.tb_ingresar_radio.Size = new System.Drawing.Size(100, 23);
            this.tb_ingresar_radio.TabIndex = 2;
            this.tb_ingresar_radio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingresar_radio_KeyPress);
            // 
            // tb_salida_radio
            // 
            this.tb_salida_radio.Enabled = false;
            this.tb_salida_radio.Location = new System.Drawing.Point(266, 123);
            this.tb_salida_radio.Name = "tb_salida_radio";
            this.tb_salida_radio.Size = new System.Drawing.Size(100, 23);
            this.tb_salida_radio.TabIndex = 3;
            // 
            // tb_ingresar_diametro
            // 
            this.tb_ingresar_diametro.Location = new System.Drawing.Point(133, 197);
            this.tb_ingresar_diametro.Name = "tb_ingresar_diametro";
            this.tb_ingresar_diametro.Size = new System.Drawing.Size(100, 23);
            this.tb_ingresar_diametro.TabIndex = 4;
            this.tb_ingresar_diametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ingresar_diametro_KeyPress);
            // 
            // tb_salida_diametro
            // 
            this.tb_salida_diametro.Enabled = false;
            this.tb_salida_diametro.Location = new System.Drawing.Point(266, 198);
            this.tb_salida_diametro.Name = "tb_salida_diametro";
            this.tb_salida_diametro.Size = new System.Drawing.Size(100, 23);
            this.tb_salida_diametro.TabIndex = 5;
            // 
            // bt_ejecutar_radio
            // 
            this.bt_ejecutar_radio.Location = new System.Drawing.Point(395, 124);
            this.bt_ejecutar_radio.Name = "bt_ejecutar_radio";
            this.bt_ejecutar_radio.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar_radio.TabIndex = 6;
            this.bt_ejecutar_radio.Text = "ejecutar";
            this.bt_ejecutar_radio.UseVisualStyleBackColor = true;
            this.bt_ejecutar_radio.Click += new System.EventHandler(this.bt_ejecutar_radio_Click);
            // 
            // bt_ejecutar_diametro
            // 
            this.bt_ejecutar_diametro.Location = new System.Drawing.Point(395, 198);
            this.bt_ejecutar_diametro.Name = "bt_ejecutar_diametro";
            this.bt_ejecutar_diametro.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar_diametro.TabIndex = 7;
            this.bt_ejecutar_diametro.Text = "ejecutar";
            this.bt_ejecutar_diametro.UseVisualStyleBackColor = true;
            this.bt_ejecutar_diametro.Click += new System.EventHandler(this.bt_ejecutar_diametro_Click);
            // 
            // labelIgual1
            // 
            this.labelIgual1.AutoSize = true;
            this.labelIgual1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIgual1.Location = new System.Drawing.Point(239, 125);
            this.labelIgual1.Name = "labelIgual1";
            this.labelIgual1.Size = new System.Drawing.Size(21, 21);
            this.labelIgual1.TabIndex = 8;
            this.labelIgual1.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Location = new System.Drawing.Point(133, 107);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(79, 15);
            this.labelRadio.TabIndex = 10;
            this.labelRadio.Text = "Ingresar radio";
            // 
            // labelPerimetro
            // 
            this.labelPerimetro.AutoSize = true;
            this.labelPerimetro.Location = new System.Drawing.Point(133, 179);
            this.labelPerimetro.Name = "labelPerimetro";
            this.labelPerimetro.Size = new System.Drawing.Size(100, 15);
            this.labelPerimetro.TabIndex = 11;
            this.labelPerimetro.Text = "Ingresar diametro";
            this.labelPerimetro.Click += new System.EventHandler(this.labelPerimetro_Click);
            // 
            // FormAreaCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 411);
            this.Controls.Add(this.labelPerimetro);
            this.Controls.Add(this.labelRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIgual1);
            this.Controls.Add(this.bt_ejecutar_diametro);
            this.Controls.Add(this.bt_ejecutar_radio);
            this.Controls.Add(this.tb_salida_diametro);
            this.Controls.Add(this.tb_ingresar_diametro);
            this.Controls.Add(this.tb_salida_radio);
            this.Controls.Add(this.tb_ingresar_radio);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAreaCirculo";
            this.Text = "FormAreaCirculo";
            this.Load += new System.EventHandler(this.FormAreaCirculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_ingresar_radio;
        private TextBox tb_salida_radio;
        private TextBox tb_ingresar_diametro;
        private TextBox tb_salida_diametro;
        private Button bt_ejecutar_radio;
        private Button bt_ejecutar_diametro;
        private Label labelIgual1;
        private Label label1;
        private Label labelRadio;
        private Label labelPerimetro;
    }
}