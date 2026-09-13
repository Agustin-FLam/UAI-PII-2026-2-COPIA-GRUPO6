using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3ej9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !double.TryParse(textBox1.Text, out double valorInicial))
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listInicial.SelectedItem == null || listFinal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione ambas escalas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string escalaInicial = listInicial.SelectedItem.ToString();
            string escalaFinal = listFinal.SelectedItem.ToString();

            double valorEnCelsius = ConvertirACelsius(valorInicial, escalaInicial);
            double resultado = ConvertirDesdeCelsius(valorEnCelsius, escalaFinal);

            dataGridView1.Rows.Add(valorInicial, escalaInicial, escalaFinal, resultado.ToString("F2"));
        }

        private double ConvertirACelsius(double valor, string escala)
        {
            switch (escala)
            {
                case "Celsius":
                    return valor;
                case "Farenheit":
                case "Fahrenheit":
                    return (valor - 32) * 5 / 9;
                case "Kelvin":
                    return valor - 273.15;
                case "Rankine":
                    return (valor - 491.67) * 5 / 9;
                default:
                    return valor;
            }
        }

        private double ConvertirDesdeCelsius(double celsius, string escala)
        {
            switch (escala)
            {
                case "Celsius":
                    return celsius;
                case "Farenheit":
                case "Fahrenheit":
                    return (celsius * 9 / 5) + 32;
                case "Kelvin":
                    return celsius + 273.15;
                case "Rankine":
                    return (celsius + 273.15) * 9 / 5;
                default:
                    return celsius;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}