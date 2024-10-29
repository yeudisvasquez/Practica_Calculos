using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Calculos
{
    public partial class Poligonos1 : Form
    {
        public Poligonos1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Inicio = new MenuPrincipal();
            Inicio.Show();
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double baseValue;
            double heightValue;
            bool isBaseValid = double.TryParse(txtBase.Text, out baseValue);
            bool isHeightValid = double.TryParse(txtAltura.Text, out heightValue);

            if (RdBtnTriangulo.Checked)
            {
                double area = 0.5 * baseValue * heightValue;
                txtArea.Text = $"{area}";
            }
            else if (RdBtnRectangulo.Checked)
            {
                double area = baseValue * heightValue;
                txtArea.Text = $"{area}";
            }
            else if (RdBtnCuadrado.Checked)
            {
                /*if (baseValue != heightValue)
                {
                    MessageBox.Show("La Base y Altura deben ser iguales");
                    txtAltura.Clear();
                    txtBase.Clear();
                    txtArea.Clear();
                    return;
                }*/
                double area = baseValue * baseValue;
                txtArea.Text = $"{area}";
            }
            else
            {
                MessageBox.Show("Seleccione una figura");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtBase.Clear();
            txtArea.Clear();
        }
    }
}
