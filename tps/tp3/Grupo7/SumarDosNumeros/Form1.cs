using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SumarDosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Numero1 = Microsoft.VisualBasic.Interaction.InputBox("ingrese el primer Numero ", "Numero1", "0");
            string Numero2 = Microsoft.VisualBasic.Interaction.InputBox("ingrese el segundo Numero ", "Numero2", "0");

            if (double.TryParse(Numero1, out double Num1) && double.TryParse(Numero2, out double Num2))
            {
                double suma = Num1 + Num2;

                MessageBox.Show($"la suma es: {suma}", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingrese valores numericos validos ","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}
