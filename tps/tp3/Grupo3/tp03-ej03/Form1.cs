using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej03
{
    public partial class Form1 : Form
    {
        int suma = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAcargar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            {
                int numero = int.Parse(txtAcargar.Text);

                txtCargados.Text += numero + Environment.NewLine;

                suma += numero;

                contador++;

                lblResultado.Text = "El resultado es: " + suma;

                txtAcargar.Clear();
                txtAcargar.Focus();
            }


        }
    }
}
