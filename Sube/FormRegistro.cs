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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sube
{
    public partial class FormRegistro : Form
    {
        List<Usuario> listaUsuarios;
        private string gender;
        private bool buttonGenderClicked;


        public FormRegistro(List<Usuario> usuarios)
        {
            InitializeComponent();
            this.listaUsuarios = usuarios;
            this.gender = "";
            btnMasculino.Click += ButtonGender_Click;
            btnFemenino.Click += ButtonGender_Click;
            btnX.Click += ButtonGender_Click;
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
            int i = 0;
            string tarjeta = "";
            foreach (Control campo in grpTarjeta.Controls)
            {
                if (campo is TextBox textBox)
                {
                    i += textBox.Text.Length;
                    tarjeta += textBox.Text ;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        camposCompletos = false;
                        break;
                    }
                }
            }
            if (buttonGenderClicked == false)
            {
                label9.Text = "Error Ingrese un genero";
                label9.Visible = true;
            }
            else
            {
                MessageBox.Show(this.gender);
            }

            tarjeta.Reverse();
            if (i < 16)
            {
                lblTarjeta.Visible = true;
                MessageBox.Show(tarjeta);
            }
            else
            {
                lblTarjeta.Visible = false;
            }
            if (camposCompletos)
            {
                // Usuario usuario = new Pasajero(this.txtDni.Text,);
            }


        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }

        private void ButtonGender_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
                this.gender = clickedButton.Text;
            this.buttonGenderClicked = true;
        }


    }
}
