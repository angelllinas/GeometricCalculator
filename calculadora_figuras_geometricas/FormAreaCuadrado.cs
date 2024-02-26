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
    public partial class FormAreaCuadrado : Form
    {
        public FormAreaCuadrado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_ejecutar_lado_Click(object sender, EventArgs e)
        {
            if (tb_ingreso_lado.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el lado");
            }
            else
            {
                double lado = Convert.ToDouble(tb_ingreso_lado.Text);
                double area = Math.Pow(lado, 2);
                tb_salida_lado.Text = area.ToString();
            }
        }

        private void bt_ejecutar_diagonal_Click(object sender, EventArgs e)
        {
            if (tb_ingreso_diagonal.Text == "")
            {
                MessageBox.Show("Se necesita ingresar la diagonal");
            }
            else
            {

                double diagonal = Convert.ToDouble(tb_ingreso_diagonal.Text);
                double area = (Math.Pow(diagonal, 2)) / 2;
                tb_salida_diagonal.Text = area.ToString();
            }
        }

        private void bt_ejecutar_perimetro_Click(object sender, EventArgs e)
        {
            if (tb_ingreso_perimetro.Text == "")
            {
                MessageBox.Show("Se nesecita ingresar el perimetro");
            }
            else
            {
                double area = Convert.ToDouble(tb_ingreso_perimetro.Text);
                area = (Math.Pow(area, 2)) / 16;
                tb_salida_perimetro.Text = area.ToString();
            }
        }

        private void tb_ingreso_lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_ingreso_lado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ingreso_diagonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) 
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_ingreso_perimetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void labelIgual1_Click(object sender, EventArgs e)
        {

        }
    }
}
