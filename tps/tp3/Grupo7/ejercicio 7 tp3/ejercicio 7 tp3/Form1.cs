using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7_tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double tasa = double.Parse(txtTasa.Text);
            int dias = int.Parse(txtDias.Text);

            double interes = monto * tasa * dias / 36500;

            dgvResultado.Rows.Add(monto, tasa, dias, interes);
        }
    }
}
