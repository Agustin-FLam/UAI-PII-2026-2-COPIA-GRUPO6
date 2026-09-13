using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    
    public partial class Form1 : Form
    {
        GestorListas ListaPacientes = new GestorListas();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void agregar_Click(object sender, EventArgs e)
        {
            ListaPacientes.AgregarPaciente(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MostrarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaPacientes.Eliminar(listBox1.SelectedIndex);
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = ListaPacientes.MostrarLista();
            listBox1 .SelectedIndex = -1;
            if (ListaPacientes.ContarPaciente() > 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaPacientes.Modificar(listBox1.SelectedIndex,int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MostrarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListaPacientes.AgregarSiguiente(listBox1.SelectedIndex,int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MostrarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
