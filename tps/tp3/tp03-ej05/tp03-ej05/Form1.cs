using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtMin.Text);
            int numero2 = int.Parse(txtMax.Text);

            for (int i = numero1; i <= numero2; i++) {
                bool esPrimo = true;
                for (int divisor = 2; divisor < i; divisor++) {
                    if (i % divisor == 0) {
                        esPrimo = false;
                    } 
                }
                if (esPrimo == true)
                {
                    lstResultado.Items.Add(i);
                }
            }
        }
    }
}
