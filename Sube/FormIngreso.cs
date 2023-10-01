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
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "¡Hola! Te damos la bienvenida a tu cuenta SUBE";
            cmbDni.Items.Add("DNI - Documento Nacional de Identidad");
            cmbDni.Items.Add("LE - Libreta Enrolamiento");
            cmbDni.Items.Add("LC - Libreta Cívica");
            cmbDni.Items.Add("DE - Documento Extranjero");

            cmbDni.SelectedIndex = 0;
            lblMensaje.Parent = pictureBox1;
            lblMensaje.BackColor = Color.Transparent;
        }
        private void iNICIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPasajero formPasajero = new FormPasajero();
            formPasajero.Show();
            Close();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
        private void lblRegistro_Click_1(object sender, EventArgs e)
        {
            FormRegistro frm = new FormRegistro();
            frm.Show();
            Close();
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
        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {
            txtPass.Text = Regex.Replace(txtPass.Text, @"[^0-9]", "");

        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }
    }
}
