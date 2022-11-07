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
    public partial class Caso5Vec : Form
    {
        public Caso5Vec()
        {
            InitializeComponent();
        }

        private void VerInforme()
        {
            string[] Provincias = {txtProvincia1.Text, txtProvincia2.Text, txtProvincia3.Text, txtProvincia4.Text};

            double[] Temperaturas1 = { Convert.ToDouble(txtP1Temp1.Text), Convert.ToDouble(txtP2Temp1.Text), Convert.ToDouble(txtP3Temp1.Text), Convert.ToDouble(txtP4Temp1.Text) };
            double[] Temperaturas2 = { Convert.ToDouble(txtP1Temp2.Text), Convert.ToDouble(txtP2Temp2.Text), Convert.ToDouble(txtP3Temp2.Text), Convert.ToDouble(txtP4Temp2.Text) };
            double[] Temperaturas3 = { Convert.ToDouble(txtP1Temp3.Text), Convert.ToDouble(txtP2Temp3.Text), Convert.ToDouble(txtP3Temp3.Text), Convert.ToDouble(txtP4Temp3.Text) };

            double[] Medias = {1,2,3,4 };
            double max = 0;
            int indice = 0;

            for(int i = 0; i<4; i++)
            {
                Medias[i] = (Temperaturas1[i] + Temperaturas2[i] + Temperaturas3[i]) / 4;

                if (((Temperaturas1[i] + Temperaturas2[i] + Temperaturas3[i]) / 4) > max)
                {
                    max = ((Temperaturas1[i] + Temperaturas2[i] + Temperaturas3[i]) / 4);
                    indice = i;
                }

                MessageBox.Show("Provincia: " + Provincias[i] + "\n" +
                                "Temperatura del mes 1: " + Temperaturas1[i] + "\n" +
                                "Temperatura del mes 2: " + Temperaturas2[i] + "\n" +
                                "Temperatura del mes 3: " + Temperaturas3[i] + "\n" +
                                "Temperatura media trimestral: " + (Temperaturas1[i] + Temperaturas2[i] + Temperaturas3[i]) / 4
                                );
            }

            MessageBox.Show("La provincia con temperatura media trimestral maxima es "+ Provincias[indice]);
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            VerInforme();
        }
    }
}
