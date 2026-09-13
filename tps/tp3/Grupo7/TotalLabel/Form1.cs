using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalLabel
{
    public partial class ResultadoLabel : Form
    {
        public ResultadoLabel()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtNum1.Text, out double Num1) && double.TryParse(txtNum2.Text, out double Num2))
            {
                double Suma = Num1 + Num2;

                lblResultado.Text = $"Resultado: {Suma}";
            }
            else
            {
                lblResultado.Text = "Error, Ingrese un numeros valido. ";

            }
        }
    }
}
