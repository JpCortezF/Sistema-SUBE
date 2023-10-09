using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Usuarios;
using Biblioteca_TarjetaSube;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sube
{
    public partial class FormRegistro : Form
    {
        private string gender = "";
        private bool buttonGenderClicked;

        Dictionary<string, Pasajero> dictionaryPassengers;
        string userCardNumber = "";


        public FormRegistro(Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
        }
        private void sUBEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPasajero formPasajero = new FormPasajero();
            formPasajero.Show();
            Close();
        }
        private void iNGRESARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormIngreso formIngreso = new FormIngreso(dictionaryPassengers);
            formIngreso.Show();
            Close();
        }
        private void FormRegistro_Load_1(object sender, EventArgs e)
        {
            lblTarjeta.Text = "El número de tarjeta debe tener 16 dígitos.";
            lblDni.Text = "El número de documento debe tener 8 dígitos";
            lblCorreo.Text = "Por favor, ingresá tu correo electrónico.";
            lblClave.Text = "Las claves no coinciden";
            cmbTipoPasajero.Items.Add(EnumTarifaSocial.Ninguna);
            cmbTipoPasajero.Items.Add(EnumTarifaSocial.Jubilado);
            cmbTipoPasajero.Items.Add(EnumTarifaSocial.Estudiantil);
            cmbTipoPasajero.Items.Add(EnumTarifaSocial.Malvinas);
            cmbTipoPasajero.Items.Add(EnumTarifaSocial.Discapacitado);
            cmbTipoPasajero.SelectedIndex = 0;
            txtTarjeta2.KeyPress += txtTarjeta_KeyPress;
            txtTarjeta3.KeyPress += txtTarjeta_KeyPress;
            txtTarjeta4.KeyPress += txtTarjeta_KeyPress;
            btnMasculino.Click += ButtonGender_Click;
            btnFemenino.Click += ButtonGender_Click;
            btnX.Click += ButtonGender_Click;
        }
        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número entero
            }
        }
        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = @".\MisPasajeros.Json";
            string path = ruta + nombre;
            try
            {
                string email = txtCorreo.Text;
                string password = txtClave.Text;
                if (ValidarIngresoTarjeta() && ValidarIngresoTextBox() && ValidarEmail(email))
                {
                    string document = txtDni.Text;
                    string cardNumber = userCardNumber;
                    EnumTarifaSocial tarifa = (EnumTarifaSocial)cmbTipoPasajero.SelectedItem;

                    TarjetaSube newSube = new TarjetaSube(cardNumber, tarifa);
                    Pasajero passenger = new Pasajero(gender, email, password, newSube);
                    if (!passenger.PassengerExist(passenger, dictionaryPassengers, document))
                    {
                        dictionaryPassengers[document] = passenger;
                        MessageBox.Show($"Se registro exitosamente!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Serializador.WriteJson(path, dictionaryPassengers);
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya se encuentra registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }
        private void ButtonGender_Click(object sender, EventArgs e)
        {
            btnMasculino.BackColor = Color.WhiteSmoke;
            btnFemenino.BackColor = Color.WhiteSmoke;
            btnX.BackColor = Color.WhiteSmoke;
            if (sender is Button clickedButton)
            {
                this.gender = clickedButton.Text;
                clickedButton.BackColor = Color.LightGray;
                this.buttonGenderClicked = true;
            }
        }

        private bool ValidarIngresoTarjeta()
        {
            bool allCompleted = true;
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
                        allCompleted = false;
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

            return allCompleted;
        }
        private bool ValidarIngresoTextBox()
        {
            bool allCompleted = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        allCompleted = false;
                        break;
                    }
                }
            }
            if (txtDni.Text.Length < 8)
            {
                lblDni.Visible = true;
            }
            else
            {
                lblDni.Visible = false;
            }
            if (txtClave.Text != txtRepetirClave.Text)
            {
                lblClave.Visible = true;
            }
            else
            {
                lblClave.Visible = false;
            }
            return allCompleted;
        }
        private bool ValidarEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
            bool result = Regex.IsMatch(email, pattern);

            if (!result)
            {
                lblCorreo.Visible = true;
            }
            else
            {
                lblCorreo.Visible = false;
            }
            return result;
        }

        private void btnMostrarCargados_Click(object sender, EventArgs e)
        {
            foreach (Pasajero pasajero in dictionaryPassengers.Values)
            {
                MessageBox.Show(pasajero.ShowUser(pasajero));
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.Text = Regex.Replace(txtClave.Text, @"[^0-9]", "");
        }

        private void txtRepetirClave_TextChanged(object sender, EventArgs e)
        {
            txtRepetirClave.Text = Regex.Replace(txtRepetirClave.Text, @"[^0-9]", "");
        }
    }
}
