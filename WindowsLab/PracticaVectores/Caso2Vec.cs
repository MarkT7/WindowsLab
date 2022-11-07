using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace WindowsLab.Practica_de_Vectores
{
    public partial class Caso2Vec : Form
    {

        List<int> ListaPrecios = new List<int>();
        int Suma = 0;

        private void SumarLista()
        {
            if (ListaPrecios.Count < 8)
            {
                Int16 x = 0;
                Int16.TryParse(txtPrecio.Text, out x);
                ListaPrecios.Add(x);
            }
            else
            {
                foreach (var elemento in ListaPrecios)
                {
                    var i = (int)elemento;
                    Suma = Suma + i;
                }

                MessageBox.Show("La suma de los precios es : " + Suma);
            }
        }
        public Caso2Vec()
        {
            InitializeComponent();
        }

        private void Caso2Vec_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            SumarLista();
        }
    }
}
