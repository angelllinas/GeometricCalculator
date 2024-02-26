namespace calculadora_figuras_geometricas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void bt_area_cuadrado_Click(object sender, EventArgs e)
        {
            panelOperatos.Controls.Clear();
            FormAreaCuadrado fac = new FormAreaCuadrado();
            fac.TopLevel= false;
            panelOperatos.Controls.Add(fac);
            fac.Show();
        }

        private void bt_area_rectangulo_Click(object sender, EventArgs e)
        {
            panelOperatos.Controls.Clear();
            FormAreaRectangulo far = new FormAreaRectangulo();
            far.TopLevel= false;
            panelOperatos.Controls.Add(far);
            far.Show();
        }

        private void bt_area_circulo_Click(object sender, EventArgs e)
        {
            panelOperatos.Controls.Clear();
            FormAreaCirculo fac = new FormAreaCirculo();
            fac.TopLevel= false;
            panelOperatos.Controls.Add(fac);
            fac.Show();
        }

        private void bt_calcular_area_triangulo_Click(object sender, EventArgs e)
        {
            panelOperatos.Controls.Clear();
            FormAreaTrianguloEquilatero fate = new FormAreaTrianguloEquilatero();
            fate.TopLevel= false;
            panelOperatos.Controls.Add(fate);
            fate.Show();
        }

        private void bt_hipotenusa_triangulo_rectangulo_Click(object sender, EventArgs e)
        {
            panelOperatos.Controls.Clear();
            FormHipotenusaTrianguloRectangulo fhtr = new FormHipotenusaTrianguloRectangulo();
            fhtr.TopLevel= false;
            panelOperatos.Controls.Add(fhtr);
            fhtr.Show();
        }
    }
}