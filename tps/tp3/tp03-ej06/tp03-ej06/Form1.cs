using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            lst1.Items.Clear();
            int anterior = 0;
            int actual = 1;
            for (int i = 0; i < numero; i++ ) {
                lst1.Items.Add(anterior);

                int siguiente = anterior + actual;

                anterior = actual;
                actual = siguiente;
            }
        }
    }
}
