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
    public partial class FormAreaRectangulo : Form
    {
        public FormAreaRectangulo()
        {
            InitializeComponent();
        }

        private void FormAreaRectangulo_Load(object sender, EventArgs e)
        {

        }

        private void bt_ejecutar_Click(object sender, EventArgs e)
        {
            if (tb_lado.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el lado");
            }
            else if (tb_base.Text == "")
            {
                MessageBox.Show("Se necesita ingresar la base");
            }
            else
            {
                double lado = Convert.ToDouble(tb_lado.Text);
                double bas = Convert.ToDouble(tb_base.Text);
                double area = lado * bas;
                tb_resultado.Text = area.ToString();
            }

        }

        private void tb_lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void tb_base_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                DialogResult dialogResult = MessageBox.Show("Solo se pueden ingresar número");
                e.Handled = true;
                return;
            }
        }

        private void labelSuma_Click(object sender, EventArgs e)
        {

        }
    }
}
