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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Binarios = new Convertidor();
            Binarios.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Poligonos = new Poligonos1();
            Poligonos.Show();
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnJuegos_Click(object sender, EventArgs e)
        {
            Form Players = new Juego();
            Players.Show();
            this.Hide();
        }
    }
}
