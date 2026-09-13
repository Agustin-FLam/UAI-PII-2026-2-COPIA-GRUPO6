using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje2
{
    public partial class Form1 : Form
    {

        GestorAlumno gestion = new GestorAlumno();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            gestion.AgregarAlumno(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text),textBox4.Text,textBox5.Text,textBox6.Text);
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = gestion.MostrarLista();
            listBox1.SelectedIndex = -1;
        }

        private void btnEliminarAluSelec_Click(object sender, EventArgs e)
        {
            gestion.EliminarAlumno(listBox1.SelectedIndex);
            MostrarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gestion.Modificar(listBox1.SelectedIndex, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
            MostrarLista();
        }

        private void btnAgregarAnterior_Click(object sender, EventArgs e)
        {
            gestion.AgregarAnterior(listBox1.SelectedIndex, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
            MostrarLista();
        }

        private void btnAgregarSiguiente_Click(object sender, EventArgs e)
        {
            gestion.AgregarSiguiente(listBox1.SelectedIndex, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
            MostrarLista();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            gestion.MostrarLista();
        }
    }
}
