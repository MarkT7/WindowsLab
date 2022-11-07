using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab.PracticaVectores
{
    public partial class Caso3Vec : Form
    {
        public Caso3Vec()
        {
            InitializeComponent();
        }
        private void Mensaje() {
            string[] Nombres = { txtOperario1.Text, txtOperario2.Text, txtOperario3.Text, txtOperario4.Text};
            double[] Sueldos1 = { Convert.ToDouble(txtO1S1.Text), Convert.ToDouble(txtO1S2.Text), Convert.ToDouble(txtO1S3.Text) };
            double[] Sueldos2 = { Convert.ToDouble(txtO2S1.Text), Convert.ToDouble(txtO2S2.Text), Convert.ToDouble(txtO2S3.Text) };
            double[] Sueldos3 = { Convert.ToDouble(txtO3S1.Text), Convert.ToDouble(txtO3S2.Text), Convert.ToDouble(txtO3S3.Text) };
            double[] Sueldos4 = { Convert.ToDouble(txtO4S1.Text), Convert.ToDouble(txtO4S2.Text), Convert.ToDouble(txtO4S3.Text) };

            double[] SumaSueldos = { Sueldos1.Sum(), Sueldos2.Sum(), Sueldos3.Sum(), Sueldos4.Sum() };

            int a = 0;
            int indice = 0;

            for (int i = 0; i< 4; i++)
            {
                MessageBox.Show("El total pagado en 3 meses de "+Nombres[i]+" es "+SumaSueldos[i]);

                if (SumaSueldos[i] > a)
                {
                    a = (int) SumaSueldos[i];
                    indice = i;
                }
            }
            MessageBox.Show("El operario con mayores ingresos fue "+Nombres[indice]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensaje();
        }
    }
}
