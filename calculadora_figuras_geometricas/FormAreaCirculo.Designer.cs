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
            labelTitulo = new Label();
            tb_ingresar_radio = new TextBox();
            tb_salida_radio = new TextBox();
            tb_ingresar_diametro = new TextBox();
            tb_salida_diametro = new TextBox();
            bt_ejecutar_radio = new Button();
            bt_ejecutar_diametro = new Button();
            labelRadio = new Label();
            labelPerimetro = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(180, 26);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(238, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Calcular área de un círculo";
            // 
            // tb_ingresar_radio
            // 
            tb_ingresar_radio.Location = new Point(133, 125);
            tb_ingresar_radio.Name = "tb_ingresar_radio";
            tb_ingresar_radio.Size = new Size(100, 23);
            tb_ingresar_radio.TabIndex = 2;
            tb_ingresar_radio.KeyPress += tb_ingresar_radio_KeyPress;
            // 
            // tb_salida_radio
            // 
            tb_salida_radio.Enabled = false;
            tb_salida_radio.Location = new Point(266, 123);
            tb_salida_radio.Name = "tb_salida_radio";
            tb_salida_radio.Size = new Size(100, 23);
            tb_salida_radio.TabIndex = 3;
            // 
            // tb_ingresar_diametro
            // 
            tb_ingresar_diametro.Location = new Point(133, 197);
            tb_ingresar_diametro.Name = "tb_ingresar_diametro";
            tb_ingresar_diametro.Size = new Size(100, 23);
            tb_ingresar_diametro.TabIndex = 4;
            tb_ingresar_diametro.KeyPress += tb_ingresar_diametro_KeyPress;
            // 
            // tb_salida_diametro
            // 
            tb_salida_diametro.Enabled = false;
            tb_salida_diametro.Location = new Point(266, 198);
            tb_salida_diametro.Name = "tb_salida_diametro";
            tb_salida_diametro.Size = new Size(100, 23);
            tb_salida_diametro.TabIndex = 5;
            // 
            // bt_ejecutar_radio
            // 
            bt_ejecutar_radio.Location = new Point(395, 124);
            bt_ejecutar_radio.Name = "bt_ejecutar_radio";
            bt_ejecutar_radio.Size = new Size(75, 23);
            bt_ejecutar_radio.TabIndex = 6;
            bt_ejecutar_radio.Text = "ejecutar";
            bt_ejecutar_radio.UseVisualStyleBackColor = true;
            bt_ejecutar_radio.Click += bt_ejecutar_radio_Click;
            // 
            // bt_ejecutar_diametro
            // 
            bt_ejecutar_diametro.Location = new Point(395, 198);
            bt_ejecutar_diametro.Name = "bt_ejecutar_diametro";
            bt_ejecutar_diametro.Size = new Size(75, 23);
            bt_ejecutar_diametro.TabIndex = 7;
            bt_ejecutar_diametro.Text = "ejecutar";
            bt_ejecutar_diametro.UseVisualStyleBackColor = true;
            bt_ejecutar_diametro.Click += bt_ejecutar_diametro_Click;
            // 
            // labelRadio
            // 
            labelRadio.AutoSize = true;
            labelRadio.Location = new Point(133, 107);
            labelRadio.Name = "labelRadio";
            labelRadio.Size = new Size(79, 15);
            labelRadio.TabIndex = 10;
            labelRadio.Text = "Ingresar radio";
            // 
            // labelPerimetro
            // 
            labelPerimetro.AutoSize = true;
            labelPerimetro.Location = new Point(133, 179);
            labelPerimetro.Name = "labelPerimetro";
            labelPerimetro.Size = new Size(100, 15);
            labelPerimetro.TabIndex = 11;
            labelPerimetro.Text = "Ingresar diametro";
            labelPerimetro.Click += labelPerimetro_Click;
            // 
            // FormAreaCirculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 411);
            Controls.Add(labelPerimetro);
            Controls.Add(labelRadio);
            Controls.Add(bt_ejecutar_diametro);
            Controls.Add(bt_ejecutar_radio);
            Controls.Add(tb_salida_diametro);
            Controls.Add(tb_ingresar_diametro);
            Controls.Add(tb_salida_radio);
            Controls.Add(tb_ingresar_radio);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAreaCirculo";
            Text = "FormAreaCirculo";
            Load += FormAreaCirculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_ingresar_radio;
        private TextBox tb_salida_radio;
        private TextBox tb_ingresar_diametro;
        private TextBox tb_salida_diametro;
        private Button bt_ejecutar_radio;
        private Button bt_ejecutar_diametro;
        private Label labelRadio;
        private Label labelPerimetro;
    }
}