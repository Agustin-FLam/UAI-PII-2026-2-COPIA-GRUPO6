using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acumulacion
{

    public partial class ListaNumeros : Form
    {
        private double SumaTotal = 0;

        public ListaNumeros()
        {
            InitializeComponent();
        }
        private void label1_Click()
        {

        }
        private void Suma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double numeroIngresados))
            {
                SumaTotal += numeroIngresados;
                txtListaNumeros.Text += $"{numeroIngresados}{Environment.NewLine}";
                lblMostrar.Text = $"suma Toal: {SumaTotal} ";
                txtNumero.Clear();
                txtNumero.Focus();

            }
            else
            { 
               MessageBox.Show("Ingrese un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}






