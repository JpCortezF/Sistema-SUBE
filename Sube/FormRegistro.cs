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
        List<Usuario> listaUsuarios;

        public FormRegistro(List<Usuario> usuarios)
        {
            InitializeComponent();
            this.listaUsuarios = usuarios;
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
            bool camposCompletos = true;
            foreach (Control campo in grpTarjeta.Controls)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        camposCompletos = false;
                        break;
                    }
                }
            }
            if(grpTarjeta.Text.Length < 16)
            {
                lblTarjeta.Visible = true;
            }
            if(camposCompletos)
            {

            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }
    }
}
