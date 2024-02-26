using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_figuras_geometricas
{
    public partial class FormHipotenusaTrianguloRectangulo : Form
    {
        public FormHipotenusaTrianguloRectangulo()
        {
            InitializeComponent();
        }

        private void bt_ejecutar1_Click(object sender, EventArgs e)
        {
            if (tb_cateto_opuesto1.Text == "" && tb_cateto_adyasente1.Text == "")
            {
                MessageBox.Show("Se necesita ingresar los datos del cateto opuesto y adyasente");
            }
            else if (tb_cateto_opuesto1.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el cateto opuesto");
            }
            else if (tb_cateto_adyasente1.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el cateto adyasente");
            }
            else
            {
                double cateto_opuesto = Convert.ToDouble(tb_cateto_opuesto1.Text);
                double cateto_adyasente = Convert.ToDouble(tb_cateto_adyasente1.Text);
                double area = (Math.Pow(cateto_opuesto, 2)) + (Math.Pow(cateto_adyasente, 2));
                area = Math.Sqrt(area);
                tb_respuesta1.Text = area.ToString();
            }
        }

        private void bt_ejecutar2_Click(object sender, EventArgs e)
        {
            if (tb_angulo_seno.Text == "" && tb_cateto_opuesto2.Text == "")
            {
                MessageBox.Show("Se necesita ingresar los datos del cateto y angulo");
            }
            else if (tb_angulo_seno.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el angulo seno");
            }
            else if (tb_cateto_opuesto2.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el cateto opuesto");
            }
            else
            {
                double grado = Convert.ToDouble(tb_angulo_seno.Text);
                double cateto_opuesto = Convert.ToDouble(tb_cateto_opuesto2.Text);
                double seno = Math.Sin(grado * Math.PI / 180);
                double hipotenusa = cateto_opuesto / seno;
                hipotenusa = Math.Round(hipotenusa, 2); tb_respuesta2.Text = hipotenusa.ToString();
            }
        }

        private void bt_ejecutar3_Click(object sender, EventArgs e)
        {
            if (tb_angulo_coseno.Text == "" && tb_cateto_adyasente2.Text == "")
            {
                MessageBox.Show("Se necesita ingresar los datos del angulo y cateto");
            }
            else if (tb_angulo_coseno.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el angulo coseno");
            }
            else if (tb_cateto_adyasente2.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el cateto adyasente");
            }
            else
            {
                double grado = Convert.ToDouble(tb_angulo_coseno.Text);
                double cateto_adyasente = Convert.ToDouble(tb_cateto_adyasente2.Text);
                double cos = Math.Cos(grado * Math.PI / 180);
                double hipotenusa = cateto_adyasente / cos;
                hipotenusa = Math.Round(hipotenusa, 2);
                tb_respuesta3.Text = hipotenusa.ToString();
            }
        }

        private void tb_cateto_opuesto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_cateto_adyasente1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_angulo_seno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_cateto_opuesto2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_angulo_coseno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_cateto_adyasente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }
    }
}
