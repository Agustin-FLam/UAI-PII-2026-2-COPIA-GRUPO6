using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3ej10
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int[] conteo = new int[7];
        private int totalTiradas = 0;

        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);

            lblDado1.Text = dado1.ToString();
            lblDado2.Text = dado2.ToString();

            conteo[dado1]++;
            conteo[dado2]++;

            totalTiradas++;
            int totalDados = totalTiradas * 2;

            dataGridView1.Rows.Clear();

            for (int i = 1; i <= 6; i++)
            {
                int cantidad = conteo[i];
                double porcentaje = ((double)cantidad / totalDados) * 100;

                dataGridView1.Rows.Add(i, cantidad, porcentaje.ToString("F2") + "%");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
