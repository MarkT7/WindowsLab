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
    public partial class Caso2 : Form
    {
        public Caso2()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int Edad = Int32.Parse(txtEdad.Text);

            switch (Edad)
            {
                case int n when(n == 0):
                    MessageBox.Show("ERROR");
                    break;
                case int n when(n > 0 && n < 18):
                    MessageBox.Show("Usted es menor de edad");
                    break;
                case int n when(n >= 18 && n < 60):
                    MessageBox.Show("Usted es mayor de edad");
                    break;
                case int n when(n > 60):
                    MessageBox.Show("Usted es un adulto mayor");
                    break;
            }
        }
    }   
}
