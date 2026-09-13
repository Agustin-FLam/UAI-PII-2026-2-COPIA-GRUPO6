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

namespace tp03_ej01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            String dato1 = Interaction.InputBox("Ingrese el primer dato");
            String dato2 = Interaction.InputBox("Ingrese el segundo dato");

            int numero1 = int.Parse(dato1);
            int numero2 = int.Parse(dato2);
            int suma = numero1 + numero2;

            MessageBox.Show("La suma es: " + suma);
        }
    }
}
