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
    public partial class Caso5 : Form
    {
        public Caso5()
        {
            InitializeComponent();
        }

        private string ValidarDatos()
        {
            string Usuario = txtUsuario.Text.ToUpper();
            string Sexo = txtSexo.Text.ToUpper();
            string TipoUsuario = txtTipoUsuario.Text.ToUpper();

            if (Usuario == "MARCOS" && Sexo == "MASCULINO" && TipoUsuario == "ADMINISTRADOR")
            {
                return("Bienvenido!" + "\n" +
                       "Usuario: " + Usuario + "\n" +
                       "Sexo: " + Sexo + "\n" +
                       "Rol: " + TipoUsuario);
            }
            else
            {
                return("Datos no validos" + "\n" +
                       "Usuario: " + Usuario + "\n" +
                       "Sexo: " + Sexo + "\n" +
                       "Rol: " + TipoUsuario);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ValidarDatos());
        }

    }
}
