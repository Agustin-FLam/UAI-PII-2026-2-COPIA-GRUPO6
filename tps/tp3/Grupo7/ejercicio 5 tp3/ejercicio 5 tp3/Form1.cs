using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5_tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int minimo = int.Parse(txtMinimo.Text);
            int maximo = int.Parse(txtMaximo.Text);

            lstPrimos.Items.Clear();

            for (int numero = minimo; numero <= maximo; numero++)
            {
                int divisores = 0;

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    lstPrimos.Items.Add(numero);
                }
            }
        }
    }
}
