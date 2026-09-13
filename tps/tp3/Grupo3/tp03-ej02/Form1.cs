using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            int suma = numero1 + numero2;

            lbl1.Text = "El resultado es: " + suma;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
