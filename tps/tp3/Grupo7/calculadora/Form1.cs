using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            lblResultado.AutoSize = true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double Numero1, out double Numero2))
            {
                // Si este cartel sale, sabremos 100% que la suma se calculó correctamente
                MessageBox.Show($"La suma da: {Numero1 + Numero2}");

                lblResultado.Text = $"Resultado: {Numero1 + Numero2}";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double Numero1, out double Numero2))
            {
                lblResultado.Text = $"Resultado: {Numero1 - Numero2} ";
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double Numero1, out double Numero2))
            {
                lblResultado.Text = $"Resultado: {Numero1 * Numero2} ";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double Numero1, out double Numero2))
            {
                if (Numero2 == 0)
                {
                    MessageBox.Show("No se puede dividir por cero", "Erro matematico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblResultado.Text = $"Resultado: {Numero1 / Numero2} ";
                }

            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double Numero1, out double Numero2))
            {
                lblResultado.Text = $"Resultado: {Math.Pow(Numero1, Numero2)} ";
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas(out double Numero1, out double Numero2))
            {
                if (Numero1 < 0)
                {
                    MessageBox.Show("No se puede calcular la raiz cuadrada de un numero negativo", "Error Negativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    lblResultado.Text = $"Resultado: {Math.Sqrt(Numero1)}";
                }
            }

            else
            {
                MessageBox.Show("Error, Ingres un numero valido en la primera casilla en blaco", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool ValidarEntradas(out double Numero1, out double Numero2)
        {
            bool esValido1 = double.TryParse(txtNumero1.Text, out Numero1);
            bool esValido2 = double.TryParse(txtNumero2.Text, out Numero2);

            if (!esValido1 || !esValido2)
            {
                MessageBox.Show("Fallo la validacion de entradas"); // Cartel de prueba
                return false;
            }

            return true;
        }
    } 
}
           
  
                