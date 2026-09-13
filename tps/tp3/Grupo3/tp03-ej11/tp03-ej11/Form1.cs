using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_ej11
{
    public partial class Form1 : Form
    {

        string jugador = "X";



        public Form1()
        {
            
            InitializeComponent();

        }

        private void VerificarGanador()
        {
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }

            if (btn7.Text == "X" && btn5.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("Ganó X");
            }
            // Combinaciones de O
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }

            if (btn7.Text == "O" && btn5.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("Ganó O");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (btn1.Text == "")
            {
                btn1.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                btn3.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }
            VerificarGanador();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.Text = jugador;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
                VerificarGanador();
            }
        }
    }
}
