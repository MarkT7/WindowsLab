using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab.PracticaMetodos
{
    public partial class Caso1 : Form
    {
        public Caso1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string AreaTriangulo() {

            int Base = Int16.Parse(txtBase.Text);
            int Altura = Int16.Parse(txtAltura.Text);
            int Area = Base * Altura;

            return ("El area del rectangulo es " + Area);

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AreaTriangulo());

        }
    }
}
