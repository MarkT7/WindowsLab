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
    public partial class Caso4Vec : Form
    {
        public Caso4Vec()
        {
            InitializeComponent();
        }

        private void Caso4Vec_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void VerAdultos()
        {
            string[] Nombres = {txtNombre1.Text,txtNombre2.Text,txtNombre3.Text,txtNombre4.Text,txtNombre5.Text};
            int[] Edades = { Int32.Parse(txtEdad1.Text), Int32.Parse(txtEdad2.Text), Int32.Parse(txtEdad3.Text),
                             Int32.Parse(txtEdad4.Text),Int32.Parse(txtEdad5.Text)};
            
            for(int i = 0; i < 5; i++)
            {
                if (Edades[i]<=18)
                {
                    MessageBox.Show(Nombres[i]+" es mayor de edad!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VerAdultos();
        }
    }
}
