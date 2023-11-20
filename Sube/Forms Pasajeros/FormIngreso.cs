using Biblioteca_DataBase;
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
        List<Pasajero> listPassengers;
        private FormPasajero parentForm;

        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<Pasajero> data = new DataBase<Pasajero>();
        public FormIngreso(FormPasajero parent)
        {
            InitializeComponent();
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
                string query = "SELECT * FROM pasajeros WHERE dni = @dni AND password = @password";
                parameters["@dni"] = txtDni.Text;
                parameters["@password"] = txtPass.Text;
                listPassengers = data.Select(query, parameters, Pasajero.MapPasajero);
                if (listPassengers.Count > 0)
                {
                    Pasajero passenger = listPassengers.FirstOrDefault();
                    MessageBox.Show("Ingreso correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    exist = true;

                    InicioPasajero inicio = new InicioPasajero(passenger);
                    inicio.Show();
                    MdiParent.Close();
                    Close();
                }
            }
            if (!exist)
            {
                MessageBox.Show("No se encontro al usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblRegistro_Click_1(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
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
            VentanaPassword ventanaPassword = new VentanaPassword();
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
            try
            {
                string queryHarcode = "SELECT * FROM pasajeros WHERE dni = @dni AND password = @password";
                parameters["@dni"] = 33202790;
                parameters["@password"] = 2790;
                listPassengers = data.Select(queryHarcode, parameters, Pasajero.MapPasajero);
                if(listPassengers.Count > 0)
                {
                    txtDni.Text = "33202790";
                    txtPass.Text = "2790";
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
