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
    public partial class FormAreaCirculo : Form
    {
        public FormAreaCirculo()
        {
            InitializeComponent();
        }

        private void FormAreaCirculo_Load(object sender, EventArgs e)
        {

        }

        private void bt_ejecutar_radio_Click(object sender, EventArgs e)
        {
            if (tb_ingresar_radio.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el radio");
            }
            else
            {
                double radio = Convert.ToDouble(tb_ingresar_radio.Text);
                double area = Math.PI * (Math.Pow(radio, 2));
                tb_salida_radio.Text = area.ToString();
            }
        }

        private void bt_ejecutar_diametro_Click(object sender, EventArgs e)
        {
            if (tb_ingresar_diametro.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el diametro"); 
            }
            else
            {
                double diametro = Convert.ToDouble(tb_ingresar_diametro.Text);
                double area = (Math.PI / 4) * Math.Pow(diametro, 2);
                tb_salida_diametro.Text = area.ToString();
            }
        }

        private void tb_ingresar_radio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_ingresar_diametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void labelPerimetro_Click(object sender, EventArgs e)
        {

        }
    }
}
