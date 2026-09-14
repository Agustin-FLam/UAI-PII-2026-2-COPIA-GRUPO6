using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt1.Text);
            double numero2 = double.Parse(txt2.Text);
            double resultado = numero1 + numero2;
            lbl1.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt1.Text);
            double numero2 = double.Parse(txt2.Text);
            double resultado = numero1 - numero2;
            lbl1.Text = resultado.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt1.Text);
            double numero2 = double.Parse(txt2.Text);
            double resultado = numero1 * numero2;
            lbl1.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt1.Text);
            double numero2 = double.Parse(txt2.Text);
            double resultado = numero1 / numero2;
            lbl1.Text = resultado.ToString();
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt1.Text);
            double numero2 = double.Parse(txt2.Text);
            double resultado = Math.Pow(numero1, numero2);
            lbl1.Text = resultado.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt1.Text);
            double numero2 = double.Parse(txt1.Text);
            double resultado = Math.Sqrt(numero1);
            lbl1.Text = resultado.ToString();
        }
    }
}
