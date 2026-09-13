using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje3
{
    public partial class Form1 : Form
    {
        GestorClientes gestion = new GestorClientes();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int edad = random.Next(5, 60);
            double precio;
            if (edad >= 5 && edad <= 12)
            {
                precio = 5000;
            } else if (edad >= 13 && edad <= 17)
            {
                precio = 10000;
            } else
            {
                precio = 25000;
            }
            gestion.Agregar(textBox1.Text, edad, precio);
            Mostrar();

        }

        public void Mostrar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = gestion.MostrarLista();
            listBox1.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gestion.Eliminar(listBox1.SelectedIndex);
            Mostrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int edad = random.Next(5, 60);
            double precio;
            if (edad >= 5 && edad <= 12)
            {
                precio = 5000;
            }
            else if (edad >= 13 && edad <= 17)
            {
                precio = 10000;
            }
            else
            {
                precio = 25000;
            }
            gestion.Modificar(listBox1.SelectedIndex,textBox1.Text, edad, precio);
            Mostrar();

        }

        private void btnAgregarSiguiente_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int edad = random.Next(5, 60);
            double precio;
            if (edad >= 5 && edad <= 12)
            {
                precio = 5000;
            }
            else if (edad >= 13 && edad <= 17)
            {
                precio = 10000;
            }
            else
            {
                precio = 25000;
            }
            gestion.agregarSiguiente(listBox1.SelectedIndex, textBox1.Text, edad, precio);
            Mostrar();
        }
    }
}
