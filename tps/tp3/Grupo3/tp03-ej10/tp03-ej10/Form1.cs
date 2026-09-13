using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double temperatura = double.Parse(txtTemperatura.Text);

            double celsius = 0;

            if (cmbInicial.Text == "Celsius")
            {
                celsius = temperatura;
            }
            else if (cmbInicial.Text == "Fahrenheit")
            {
                celsius = (temperatura - 32) * 5 / 9;
            }
            else if (cmbInicial.Text == "Kelvin")
            {
                celsius = temperatura - 273.15;
            }
            else if (cmbInicial.Text == "Rankine")
            {
                celsius = (temperatura - 491.67) * 5 / 9;
            }

            double resultado = 0;

            if (cmbFinal.Text == "Celsius")
            {
                resultado = celsius;
            }
            else if (cmbFinal.Text == "Fahrenheit")
            {
                resultado = celsius * 9 / 5 + 32;
            }
            else if (cmbFinal.Text == "Kelvin")
            {
                resultado = celsius + 273.15;
            }
            else if (cmbFinal.Text == "Rankine")
            {
                resultado = (celsius + 273.15) * 9 / 5;
            }
            dgv1.Rows.Add(
            cmbInicial.Text,
            temperatura,
            cmbFinal.Text,
            resultado
);
        }
    }
}
