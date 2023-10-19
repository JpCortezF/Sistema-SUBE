using Biblioteca_Usuarios;
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

namespace Sube
{
    public partial class FormIngreso : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        private FormPasajero parentForm;

        public FormIngreso(FormPasajero parent, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
            parentForm = parent;
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            cmbDni.Items.Add("DNI - Documento Nacional de Identidad");
            cmbDni.Items.Add("LE - Libreta Enrolamiento");
            cmbDni.Items.Add("LC - Libreta Cívica");
            cmbDni.Items.Add("DE - Documento Extranjero");
            txtDni.TextChanged += txt_TextChanged;
            txtPass.TextChanged += txt_TextChanged;
            cmbDni.SelectedIndex = 0;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool exist = false;
            if (!string.IsNullOrEmpty(txtDni.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
                {
                    if (kvp.Value is Pasajero passenger)
                    {
                        if (txtDni.Text == kvp.Key && txtPass.Text == passenger.Password)
                        {
                            exist = true;
                            MessageBox.Show("Ingreso correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicioPasajero inicio = new InicioPasajero(passenger, dictionaryPassengers);
                            inicio.Show();
                            MdiParent.Close();
                            Close();
                            break;
                        }
                    }
                }
            }
            if (!exist)
            {
                MessageBox.Show("No se encontro al usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblRegistro_Click_1(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro(dictionaryPassengers);
            registro.MdiParent = parentForm;
            registro.Show();
        }
        private void btnMostrarPass_Click_1(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '•')
            {
                txtPass.PasswordChar = '\0';
                btnMostrarPass.BackgroundImage = Properties.Resources.ojo_tachado;
            }
            else
            {
                txtPass.PasswordChar = '•';
                btnMostrarPass.BackgroundImage = Properties.Resources.view;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
            txtPass.Text = Regex.Replace(txtPass.Text, @"[^0-9]", "");
        }

        private void lblOlvideClave_Click(object sender, EventArgs e)
        {
            VentanaPassword ventanaPassword = new VentanaPassword(dictionaryPassengers);
            ventanaPassword.ShowDialog();
            if (ventanaPassword.DialogResult == DialogResult.Continue)
            {
                string clave = ventanaPassword.DevolverPass();
                if (ventanaPassword.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show($"La clave es:\n     {clave}", "Recuperar Clave!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{clave}", "Recuperar Clave!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHardcoce_Click(object sender, EventArgs e)
        {
            Pasajero passenger = new Pasajero();
            try
            {
                passenger = passenger.FindPassengerByEmail(dictionaryPassengers, "AleHardcode@gmail.com");
                if (passenger is not null)
                {
                    string dni = passenger.ReturnrKey(dictionaryPassengers, passenger);
                    txtDni.Text = dni;
                    txtPass.Text = passenger.Password;
                }
                else
                {
                    MessageBox.Show("Primero deberias registrarte", "Error ingreso hardcode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
