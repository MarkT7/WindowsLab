using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Caso4 : Form
    {
        public Caso4()
        {
            InitializeComponent();
        }

        private string RectanguloArea() {
            int Base = Int16.Parse(txtBaseODiametro.Text);
            int Altura = Int16.Parse(txtAltura.Text);

            return("El Area del rectangulo es " + Base * Altura);
        }

        private string TrianguloArea() {
            int Base = Int16.Parse(txtBaseODiametro.Text);
            int Altura = Int16.Parse(txtAltura.Text);

            return("El Area del triangulo es " + Base * Altura / 2);
        }

        private string CirculoArea() {
            double Diametro = Double.Parse(txtBaseODiametro.Text);
            double Area = 3.14 * Math.Pow(Diametro / 2, 2);

            return("El Area del circulo es " + Area);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RectanguloArea());
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TrianguloArea());
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CirculoArea());
        }
    }
}
