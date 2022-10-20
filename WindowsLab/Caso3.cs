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
    public partial class Caso3 : Form
    {
        public Caso3()
        {
            InitializeComponent();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            int Numero = Int16.Parse(txtNumero.Text);

            MessageBox.Show(Numero + " * 1 = " + Numero * 1 + "\n" +
                            Numero + " * 2 = " + Numero * 2 + "\n" +
                            Numero + " * 3 = " + Numero * 3 + "\n" +
                            Numero + " * 4 = " + Numero * 4 + "\n" +
                            Numero + " * 5 = " + Numero * 5 + "\n" +
                            Numero + " * 6 = " + Numero * 6 + "\n" +
                            Numero + " * 7 = " + Numero * 7 + "\n" +
                            Numero + " * 8 = " + Numero * 8 + "\n" +
                            Numero + " * 9 = " + Numero * 9 + "\n");
        }
    }
}
