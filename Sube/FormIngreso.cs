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
        public FormIngreso(Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            groupBox1.Parent = panel1;
            cmbDni.Items.Add("DNI - Documento Nacional de Identidad");
            cmbDni.Items.Add("LE - Libreta Enrolamiento");
            cmbDni.Items.Add("LC - Libreta Cívica");
            cmbDni.Items.Add("DE - Documento Extranjero");
            txtDni.TextChanged += txt_TextChanged;
            txtPass.TextChanged += txt_TextChanged;
            cmbDni.SelectedIndex = 0;
        }
        private void iNICIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
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
                            DialogResult = DialogResult.OK;
                            Close();

                            InicioPasajero inicio = new InicioPasajero(passenger, dictionaryPassengers);
                            inicio.Show();
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
            Close();

            FormRegistro frm = new FormRegistro(dictionaryPassengers);
            frm.ShowDialog();
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
            if (ventanaPassword.DialogResult == DialogResult.OK)
            {
                string clave = ventanaPassword.DevolverPass();
                MessageBox.Show($"La clave es:\n     {clave}", "Recuperar Clave!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
