using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Calculos
{
    public partial class Convertidor : Form
    {
        public Convertidor()
        {
            InitializeComponent();
        }

        private void BtnBinario_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;
            try
            {
                // Check if the input is an IP address
                if (IPAddress.TryParse(input, out IPAddress ipAddress))
                {
                    byte[] bytes = ipAddress.GetAddressBytes();
                    string binaryString = string.Join(".", Array.ConvertAll(bytes, b => Convert.ToString(b, 2).PadLeft(8, '0')));
                    txtResult.Text = $" {binaryString}";
                }
                else
                {
                    // Check if the input is an integer
                    if (int.TryParse(input, out int number))
                    {
                        txtResult.Text = $"Binary (Integer): {Convert.ToString(number, 2)}";
                    }
                    else
                    {
                        txtResult.Text = "Por favor entre un entero o un decimal.";
                    }
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Error: {ex.Message}";
            }
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;
            try
            {
                // Check if the input is a binary IP address or integer
                if (input.Contains("."))
                {
                    // Handle binary IP address conversion
                    string[] binaryOctets = input.Split('.');
                    if (binaryOctets.Length == 4)
                    {
                        byte[] decimalBytes = new byte[4];
                        for (int i = 0; i < 4; i++)
                        {
                            decimalBytes[i] = Convert.ToByte(binaryOctets[i], 2);
                        }
                        IPAddress ipAddress = new IPAddress(decimalBytes);
                        txtResult.Text = $" {ipAddress}";
                    }
                    else
                    {
                        txtResult.Text = "Por favor entre un Binario correcto.";
                    }
                }
                else
                {
                    // Handle binary integer conversion
                    int number = Convert.ToInt32(input, 2);
                    txtResult.Text = $" {number}";
                }
            }
            catch (FormatException)
            {
                txtResult.Text = "Formato Binario Invalido.";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Error: {ex.Message}";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtResult.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form Inicio = new MenuPrincipal();
            Inicio.Show();
            this.Close();
        }
    }
}
