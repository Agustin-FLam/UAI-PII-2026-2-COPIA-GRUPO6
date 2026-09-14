using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double tasa = double.Parse(txtTasa.Text);
            double dias = double.Parse(txtDias.Text);

            double interes = monto * tasa * dias / 36500;

            dgvResultado.Rows.Add(monto, tasa, dias, interes.ToString("F2"));
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
