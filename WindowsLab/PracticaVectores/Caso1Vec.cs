using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab.Practica_de_Metodos
{
    public partial class Caso1Vec : Form
    {
        public Caso1Vec()
        {
            InitializeComponent();
        }

        private void EvaluarNotas()
        {
            string[] Nombres = { txtAlumno1.Text, txtAlumno2.Text, txtAlumno3.Text, txtAlumno4.Text };
            double[] Notas1 = { Convert.ToDouble(txtMateria1A1.Text), Convert.ToDouble(txtMateria2A1.Text), Convert.ToDouble(txtMateria3A1.Text) };
            double[] Notas2 = { Convert.ToDouble(txtMateria1A2.Text), Convert.ToDouble(txtMateria2A2.Text), Convert.ToDouble(txtMateria3A2.Text) };
            double[] Notas3 = { Convert.ToDouble(txtMateria1A3.Text), Convert.ToDouble(txtMateria2A3.Text), Convert.ToDouble(txtMateria3A3.Text) };
            double[] Notas4 = { Convert.ToDouble(txtMateria1A4.Text), Convert.ToDouble(txtMateria2A4.Text), Convert.ToDouble(txtMateria3A4.Text) };

            double[] Promedios = { Math.Round(Notas1.Average(), 2), Math.Round(Notas2.Average(), 2), Math.Round(Notas3.Average(), 2), Math.Round(Notas4.Average(), 2) };
            string[] Devoluciones = { "a", "b", "c", "d" };
            double[] MaxNotas = { Notas1.Max(), Notas2.Max(), Notas3.Max(), Notas4.Max() };

            for (int j = 0; j < 4; j++)
            {
                switch (Promedios[j])
                {
                    case double n when (n <= 4):
                        Devoluciones[j] = "Debe ir a recuperatorio";
                        break;
                    case double n when (n > 4 && n < 7):
                        Devoluciones[j] = "Bien";
                        break;
                    case double n when (n >= 7):
                        Devoluciones[j] = "Muy bien!";
                        break;
                    default:
                        Devoluciones[j] = "ERROR";
                        break;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                MessageBox.Show("Alumno: " + Nombres[i] + "\n" + "Mayor nota: " + MaxNotas[i] + "\n" + "Promedio: " + Promedios[i] + "\n" + Devoluciones[i]);
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            EvaluarNotas();
            
        }
    }
}
