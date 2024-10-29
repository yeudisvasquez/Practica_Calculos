using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Calculos
{
    public partial class Juego : Form
    {
        private int player1Wins = 0;
        private int player2Wins = 0;
        public Juego()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string player1Choice = txtPlayer1.Text.Trim().ToUpper();
            string player2Choice = txtPlayer2.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(player1Choice) || string.IsNullOrWhiteSpace(player2Choice))
            {
                MessageBox.Show("Por favor entre la eleccion de cada jugador.");
                return;
            }

            // Validate choices
            if (!IsValidChoice(player1Choice) || !IsValidChoice(player2Choice))
            {
                MessageBox.Show("Eleccion invalida. Por favor entre R, P, or S.");
                return;
            }

            // Add entry to ListBox
            string entry = $"({player1Choice}, {player2Choice})";
            listBox1.Items.Add(entry);

            // Clear textboxes after adding
            txtPlayer1.Clear();
            txtPlayer2.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Clear previous results
            player1Wins = 0;
            player2Wins = 0;
            txtResultados.Text = string.Empty;

            // Process each game round
            foreach (string result in listBox1.Items)
            {
                string[] parts = result.Trim('(', ')').Split(',');
                if (parts.Length != 2)
                {
                    MessageBox.Show("Entrada de datos incorrecta.");
                    return;
                }

                string player1Choice = parts[0].Trim();
                string player2Choice = parts[1].Trim();

                // Determine the winner of this round
                if (IsPlayer1Winner(player1Choice, player2Choice))
                {
                    player1Wins++;
                }
                else if (IsPlayer2Winner(player1Choice, player2Choice))
                {
                    player2Wins++;
                }
            }

            // Determine the overall winner
            if (player1Wins > player2Wins)
            {
                txtResultados.Text = $"{txtPlayer1.Text} Jugador 1 Ganador!";
            }
            else if (player2Wins > player1Wins)
            {
                txtResultados.Text = $"{txtPlayer2.Text} Jugador 2 Ganador!";
            }
            else
            {
                txtResultados.Text = "Empate!";
            }
        }

        private bool IsValidChoice(string choice)
        {
            return choice == "R" || choice == "P" || choice == "S";
        }

        private bool IsPlayer1Winner(string player1Choice, string player2Choice)
        {
            return (player1Choice == "R" && player2Choice == "S") ||
                   (player1Choice == "P" && player2Choice == "R") ||
                   (player1Choice == "S" && player2Choice == "P");
        }

        private bool IsPlayer2Winner(string player1Choice, string player2Choice)
        {
            return (player2Choice == "R" && player1Choice == "S") ||
                   (player2Choice == "P" && player1Choice == "R") ||
                   (player2Choice == "S" && player1Choice == "P");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form Cerrar = new MenuPrincipal();
            Cerrar.Show();
            this.Close();
        }
    }
}

