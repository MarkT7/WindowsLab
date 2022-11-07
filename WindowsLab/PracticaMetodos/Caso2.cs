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

        private string EvaluarEdad() {

            int Edad = Int32.Parse(txtEdad.Text);

            switch (Edad)
            {
                case int n when (n == 0):
                    return("ERROR");
                case int n when (n > 0 && n < 18):
                    return("Usted es menor de edad");
                case int n when (n >= 18 && n < 60):
                    return("Usted es mayor de edad");
                case int n when (n > 60 && n<120):
                    return("Usted es un adulto mayor");
                default:
                    return "La edad debe ser mayor a 0 y menor a 120";
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EvaluarEdad());
        }
    }   
}
