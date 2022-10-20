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
    public partial class Caso6 : Form
    {
        public Caso6()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            int AñoNacimiento = Int16.Parse(txtFechaNacimiento.Text);
            DateTime FechaActual = DateTime.Today;
            int Edad = FechaActual.Year - AñoNacimiento;

            MessageBox.Show(Nombre + " " + Apellido + " tiene " + Edad + " años de edad");
        }
    }
}
