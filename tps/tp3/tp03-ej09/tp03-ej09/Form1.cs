using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej09
{
    public partial class Form1 : Form
    {
        Random dado = new Random();
        int totalTiradas = 0;
        public Form1()
        {
            InitializeComponent();
            dgv1.Rows.Add(2, 0, 0);
            dgv1.Rows.Add(3, 0, 0);
            dgv1.Rows.Add(4, 0, 0);
            dgv1.Rows.Add(5, 0, 0);
            dgv1.Rows.Add(6, 0, 0);
            dgv1.Rows.Add(7, 0, 0);
            dgv1.Rows.Add(8, 0, 0);
            dgv1.Rows.Add(9, 0, 0);
            dgv1.Rows.Add(10, 0, 0);
            dgv1.Rows.Add(11, 0, 0);
            dgv1.Rows.Add(12, 0, 0);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int dado1 = dado.Next(1, 7);
            int dado2 = dado.Next(1, 7);
            int suma = dado1 + dado2;

            totalTiradas++;

            int fila = suma - 2;
            int cantidad = int.Parse(dgv1.Rows[fila].Cells[1].Value.ToString());
            cantidad++;

            dgv1.Rows[fila].Cells[1].Value = cantidad;
            double porcentaje = cantidad * 100.0 / totalTiradas;
            dgv1.Rows[fila].Cells[2].Value = porcentaje.ToString("F2") + "%";
        }
    }
}
