using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3ej11
{
    public partial class Form1 : Form
    {
        bool turnoPlayer1 = true;
        int turnos = 0;

        public Form1()
        {
            InitializeComponent();
            AsignarEventos();
        }

        private void AsignarEventos()
        {
            button1.Click += Boton_Click;
            button2.Click += Boton_Click;
            button3.Click += Boton_Click;
            button4.Click += Boton_Click;
            button5.Click += Boton_Click;
            button6.Click += Boton_Click;
            button7.Click += Boton_Click;
            button8.Click += Boton_Click;
            button9.Click += Boton_Click;

            btnReiniciar.Click += BtnReiniciar_Click;
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (turnoPlayer1)
            {
                boton.Text = "X";
            }
            else
            {
                boton.Text = "O";
            }

            boton.Enabled = false;
            turnos++;

            if (VerificarGanador())
            {
                string ganador = turnoPlayer1 ? "PLAYER 1" : "PLAYER 2";
                MessageBox.Show($"¡Ganó el {ganador}!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeshabilitarTablero();
                return;
            }

            if (turnos == 9)
            {
                MessageBox.Show("EMPATE", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            turnoPlayer1 = !turnoPlayer1;
            lblTurno.Text = turnoPlayer1 ? "TURNO DEL PLAYER 1" : "TURNO DEL PLAYER 2";
        }

        private bool VerificarGanador()
        {
            if (Comparar(button1, button2, button3)) return true;
            if (Comparar(button4, button5, button6)) return true;
            if (Comparar(button7, button8, button9)) return true;

            if (Comparar(button1, button4, button7)) return true;
            if (Comparar(button2, button5, button8)) return true;
            if (Comparar(button3, button6, button9)) return true;

            if (Comparar(button1, button5, button9)) return true;
            if (Comparar(button3, button5, button7)) return true;

            return false;
        }

        private bool Comparar(Button b1, Button b2, Button b3)
        {
            return (b1.Text != "") && (b1.Text == b2.Text) && (b2.Text == b3.Text);
        }

        private void DeshabilitarTablero()
        {
            Button[] tablero = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button b in tablero)
            {
                b.Enabled = false;
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Button[] tablero = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button b in tablero)
            {
                b.Text = "";
                b.Enabled = true;
            }

            turnoPlayer1 = true;
            turnos = 0;
            lblTurno.Text = "TURNO DEL PLAYER 1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}