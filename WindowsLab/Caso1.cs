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
    public partial class Caso1 : Form
    {
        public Caso1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int Base = Int16.Parse(txtBase.Text);
            int Altura = Int16.Parse(txtAltura.Text);
            int Area = Base * Altura;

            MessageBox.Show("El area del rectangulo es " + Area);

        }
    }
}
