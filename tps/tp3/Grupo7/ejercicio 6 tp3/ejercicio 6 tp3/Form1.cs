using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_6_tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            lstFibonacci.Items.Clear();

            int anterior = 0;
            int siguiente = 1;

            for (int i = 0; i < n; i++)
            {
                lstFibonacci.Items.Add(anterior);

                int auxiliar = anterior + siguiente;
                anterior = siguiente;
                siguiente = auxiliar;
            }
        }
    }
}
