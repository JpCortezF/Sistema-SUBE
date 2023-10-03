using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Usuarios;

namespace Sube
{
    public partial class FormRegistro : Form
    {
        Dictionary<string, Usuario> dictonaryPassengers;
        string userCardNumber = "";
        

        public FormRegistro(Dictionary<string, Usuario> passengers)
        {
            InitializeComponent();
            this.dictonaryPassengers = passengers;
        }
        private void sUBEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPasajero formPasajero = new FormPasajero();
            formPasajero.Show();
            Close();
        }
        private void iNGRESARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormIngreso formIngreso = new FormIngreso();
            formIngreso.Show();
            Close();
        }
        private void FormRegistro_Load_1(object sender, EventArgs e)
        {
            lblTarjeta.Text = "El número de tarjeta debe tener 16 dígitos.";
            txtTarjeta2.KeyPress += txtTarjeta2_KeyPress;
            txtTarjeta3.KeyPress += txtTarjeta2_KeyPress;
            txtTarjeta4.KeyPress += txtTarjeta2_KeyPress;
        }
        private void txtTarjeta2_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número entero
            }
        }
        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            
            if (ValidarIngresoTextBox())
            {
                string document = txtDni.Text;
                string gender = "Masculino";
                string cardNumber = userCardNumber;
                string email = "pepito@gmail.com";

                Pasajero passenger = new Pasajero(document,gender,cardNumber,email,"4718");
                if(!dictonaryPassengers.ContainsKey(document))
                {
                    dictonaryPassengers[document] = passenger;
                    MessageBox.Show(passenger.ShowUsers(dictonaryPassengers));
                }
            }
            else
            {

            }
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }
        private bool ValidarIngresoTextBox()
        {
            bool camposCompletos = true;
            int totalLength = 0;
            List<string> cardNumbers = new List<string>();

            foreach (Control campo in grpTarjeta.Controls)
            {
                if (campo is TextBox textBox)
                {
                    totalLength += textBox.Text.Length;
                    
                    cardNumbers.Add(textBox.Text);
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        camposCompletos = false;
                        break;
                    }
                }
            }
            cardNumbers.Reverse();

            userCardNumber = string.Join("", cardNumbers);
            if (totalLength < 16)
            {
                lblTarjeta.Visible = true;
            }
            else
            {              
                lblTarjeta.Visible = false;
            }
            return camposCompletos;
        }
    }
}
