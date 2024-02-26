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
    public partial class FormAreaTrianguloEquilatero : Form
    {
        public FormAreaTrianguloEquilatero()
        {
            InitializeComponent();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void bt_ejecutar1_Click(object sender, EventArgs e)
        {
            if (tb_ingresar_lado1.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el lado");
            }
            else
            {
                double lado = Convert.ToDouble(tb_ingresar_lado1.Text);
                lado = Math.Pow(lado, 2);
                double r = Math.Sqrt(3);
                double area = (lado * r) / 4;
                area = Math.Round(area, 2);
                tb_salida1.Text = area.ToString();
            }
        }

        private void bt_ejecutar2_Click(object sender, EventArgs e)
        {
            if (tb_ingresar_lado2.Text == "" && tb_ingresar_altura.Text == "")
            {
                MessageBox.Show("Se necesita ingresar los datos de lado y altura");
            }
            else if (tb_ingresar_lado2.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el lado");
            }
            else if (tb_ingresar_altura.Text == "")
            {
                MessageBox.Show("Se necesita ingresar la altura");
            }
            else
            {
                double lado = Convert.ToDouble(tb_ingresar_lado2.Text);
                double altura = Convert.ToDouble(tb_ingresar_altura.Text);
                double area = (lado * altura) / 2;
                tb_salida2.Text = area.ToString();
            }
        }

        private void tb_ingresar_lado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_ingresar_lado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_ingresar_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
