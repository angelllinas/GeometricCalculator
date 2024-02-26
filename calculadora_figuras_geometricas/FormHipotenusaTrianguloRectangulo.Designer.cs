namespace calculadora_figuras_geometricas
{
    partial class FormHipotenusaTrianguloRectangulo
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
            this.tb_cateto_opuesto1 = new System.Windows.Forms.TextBox();
            this.tb_cateto_adyasente1 = new System.Windows.Forms.TextBox();
            this.tb_respuesta1 = new System.Windows.Forms.TextBox();
            this.tb_angulo_seno = new System.Windows.Forms.TextBox();
            this.tb_angulo_coseno = new System.Windows.Forms.TextBox();
            this.tb_cateto_opuesto2 = new System.Windows.Forms.TextBox();
            this.tb_respuesta2 = new System.Windows.Forms.TextBox();
            this.tb_cateto_adyasente2 = new System.Windows.Forms.TextBox();
            this.tb_respuesta3 = new System.Windows.Forms.TextBox();
            this.bt_ejecutar1 = new System.Windows.Forms.Button();
            this.bt_ejecutar2 = new System.Windows.Forms.Button();
            this.bt_ejecutar3 = new System.Windows.Forms.Button();
            this.labelCatetoOpuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(88, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(414, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Calcular hipotenusa de un triángulo rectángulo";
            // 
            // tb_cateto_opuesto1
            // 
            this.tb_cateto_opuesto1.Location = new System.Drawing.Point(88, 122);
            this.tb_cateto_opuesto1.Name = "tb_cateto_opuesto1";
            this.tb_cateto_opuesto1.Size = new System.Drawing.Size(100, 23);
            this.tb_cateto_opuesto1.TabIndex = 2;
            this.tb_cateto_opuesto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cateto_opuesto1_KeyPress);
            // 
            // tb_cateto_adyasente1
            // 
            this.tb_cateto_adyasente1.Location = new System.Drawing.Point(228, 122);
            this.tb_cateto_adyasente1.Name = "tb_cateto_adyasente1";
            this.tb_cateto_adyasente1.Size = new System.Drawing.Size(100, 23);
            this.tb_cateto_adyasente1.TabIndex = 3;
            this.tb_cateto_adyasente1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cateto_adyasente1_KeyPress);
            // 
            // tb_respuesta1
            // 
            this.tb_respuesta1.Enabled = false;
            this.tb_respuesta1.Location = new System.Drawing.Point(368, 122);
            this.tb_respuesta1.Name = "tb_respuesta1";
            this.tb_respuesta1.Size = new System.Drawing.Size(100, 23);
            this.tb_respuesta1.TabIndex = 4;
            // 
            // tb_angulo_seno
            // 
            this.tb_angulo_seno.Location = new System.Drawing.Point(88, 200);
            this.tb_angulo_seno.Name = "tb_angulo_seno";
            this.tb_angulo_seno.Size = new System.Drawing.Size(100, 23);
            this.tb_angulo_seno.TabIndex = 5;
            this.tb_angulo_seno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_angulo_seno_KeyPress);
            // 
            // tb_angulo_coseno
            // 
            this.tb_angulo_coseno.Location = new System.Drawing.Point(88, 275);
            this.tb_angulo_coseno.Name = "tb_angulo_coseno";
            this.tb_angulo_coseno.Size = new System.Drawing.Size(100, 23);
            this.tb_angulo_coseno.TabIndex = 6;
            this.tb_angulo_coseno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_angulo_coseno_KeyPress);
            // 
            // tb_cateto_opuesto2
            // 
            this.tb_cateto_opuesto2.Location = new System.Drawing.Point(228, 200);
            this.tb_cateto_opuesto2.Name = "tb_cateto_opuesto2";
            this.tb_cateto_opuesto2.Size = new System.Drawing.Size(100, 23);
            this.tb_cateto_opuesto2.TabIndex = 7;
            this.tb_cateto_opuesto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cateto_opuesto2_KeyPress);
            // 
            // tb_respuesta2
            // 
            this.tb_respuesta2.Enabled = false;
            this.tb_respuesta2.Location = new System.Drawing.Point(368, 200);
            this.tb_respuesta2.Name = "tb_respuesta2";
            this.tb_respuesta2.Size = new System.Drawing.Size(100, 23);
            this.tb_respuesta2.TabIndex = 8;
            // 
            // tb_cateto_adyasente2
            // 
            this.tb_cateto_adyasente2.Location = new System.Drawing.Point(228, 275);
            this.tb_cateto_adyasente2.Name = "tb_cateto_adyasente2";
            this.tb_cateto_adyasente2.Size = new System.Drawing.Size(100, 23);
            this.tb_cateto_adyasente2.TabIndex = 9;
            this.tb_cateto_adyasente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cateto_adyasente2_KeyPress);
            // 
            // tb_respuesta3
            // 
            this.tb_respuesta3.Enabled = false;
            this.tb_respuesta3.Location = new System.Drawing.Point(368, 275);
            this.tb_respuesta3.Name = "tb_respuesta3";
            this.tb_respuesta3.Size = new System.Drawing.Size(100, 23);
            this.tb_respuesta3.TabIndex = 10;
            // 
            // bt_ejecutar1
            // 
            this.bt_ejecutar1.Location = new System.Drawing.Point(504, 122);
            this.bt_ejecutar1.Name = "bt_ejecutar1";
            this.bt_ejecutar1.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar1.TabIndex = 11;
            this.bt_ejecutar1.Text = "ejecutar";
            this.bt_ejecutar1.UseVisualStyleBackColor = true;
            this.bt_ejecutar1.Click += new System.EventHandler(this.bt_ejecutar1_Click);
            // 
            // bt_ejecutar2
            // 
            this.bt_ejecutar2.Location = new System.Drawing.Point(504, 200);
            this.bt_ejecutar2.Name = "bt_ejecutar2";
            this.bt_ejecutar2.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar2.TabIndex = 12;
            this.bt_ejecutar2.Text = "ejecutar";
            this.bt_ejecutar2.UseVisualStyleBackColor = true;
            this.bt_ejecutar2.Click += new System.EventHandler(this.bt_ejecutar2_Click);
            // 
            // bt_ejecutar3
            // 
            this.bt_ejecutar3.Location = new System.Drawing.Point(504, 275);
            this.bt_ejecutar3.Name = "bt_ejecutar3";
            this.bt_ejecutar3.Size = new System.Drawing.Size(75, 23);
            this.bt_ejecutar3.TabIndex = 13;
            this.bt_ejecutar3.Text = "ejecutar";
            this.bt_ejecutar3.UseVisualStyleBackColor = true;
            this.bt_ejecutar3.Click += new System.EventHandler(this.bt_ejecutar3_Click);
            // 
            // labelCatetoOpuesto
            // 
            this.labelCatetoOpuesto.AutoSize = true;
            this.labelCatetoOpuesto.Location = new System.Drawing.Point(77, 95);
            this.labelCatetoOpuesto.Name = "labelCatetoOpuesto";
            this.labelCatetoOpuesto.Size = new System.Drawing.Size(131, 15);
            this.labelCatetoOpuesto.TabIndex = 14;
            this.labelCatetoOpuesto.Text = "Ingresar cateto opuesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingresar cateto adyasente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingresar cateto opuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingresar cateto adyasente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ingresar angulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ingresar angulo";
            // 
            // FormHipotenusaTrianguloRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCatetoOpuesto);
            this.Controls.Add(this.bt_ejecutar3);
            this.Controls.Add(this.bt_ejecutar2);
            this.Controls.Add(this.bt_ejecutar1);
            this.Controls.Add(this.tb_respuesta3);
            this.Controls.Add(this.tb_cateto_adyasente2);
            this.Controls.Add(this.tb_respuesta2);
            this.Controls.Add(this.tb_cateto_opuesto2);
            this.Controls.Add(this.tb_angulo_coseno);
            this.Controls.Add(this.tb_angulo_seno);
            this.Controls.Add(this.tb_respuesta1);
            this.Controls.Add(this.tb_cateto_adyasente1);
            this.Controls.Add(this.tb_cateto_opuesto1);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHipotenusaTrianguloRectangulo";
            this.Text = "FormHipotenusaTrianguloRectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private TextBox tb_cateto_opuesto1;
        private TextBox tb_cateto_adyasente1;
        private TextBox tb_respuesta1;
        private TextBox tb_angulo_seno;
        private TextBox tb_angulo_coseno;
        private TextBox tb_cateto_opuesto2;
        private TextBox tb_respuesta2;
        private TextBox tb_cateto_adyasente2;
        private TextBox tb_respuesta3;
        private Button bt_ejecutar1;
        private Button bt_ejecutar2;
        private Button bt_ejecutar3;
        private Label labelCatetoOpuesto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}