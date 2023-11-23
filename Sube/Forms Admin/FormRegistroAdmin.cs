using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using MySql.Data.MySqlClient;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Asn1.X509;
using Sube.Forms_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logica;

namespace Sube
{
    public partial class FormRegistroAdmin : Form
    {
        SistemaAdmin sistemaAdmin = new SistemaAdmin();
        public FormRegistroAdmin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                string email = txtEmail.Text;
                string name = txtName.Text;
                string lastname = txtLastName.Text;
                string password = txtPassword.Text;
                if (ValidarIngresoTextBox() && ValidarEmail(email) && EsSoloTexto(name) && EsSoloTexto(lastname) && !lblClave.Visible)
                {

                    string document = txtDNI.Text;
                    int.TryParse(document, out int dni);
                    Administrador admin = new Administrador(dni, email, password, name, lastname);

                    if(sistemaAdmin.GenerateNewAdmin(admin))
                    { 
                        MessageBox.Show($"Se registro exitosamente!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ContainerAdmin inicio = new ContainerAdmin(admin);
                        inicio.Show();
                        MdiParent.Close();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("El usuario ya se encuentra registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Error al cargar los datos!", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Ocurrió un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (txtDNI.Text.Length < 8)
            {
                lblDNI.Visible = true;
            }
            else
            {
                lblDNI.Visible = false;
            }
            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                lblClave.Text = "Las contraseñas no coinciden";
                lblClave.Visible = true;
            }
            else if (txtPassword.Text.Length < 4)
            {
                lblClave.Text = "La contraseña debe tener por lo menos 4 caracteres";
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
                lblEmail.Visible = true;
            }
            else
            {
                lblEmail.Visible = false;
            }
            return result;
        }
        private bool EsSoloTexto(string texto)
        {
            return Regex.IsMatch(texto, "^[a-zA-Z ]+$");
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
                btnMostrarPass.BackgroundImage = Properties.Resources.ojo_tachado;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                btnMostrarPass.BackgroundImage = Properties.Resources.view;
            }
        }

        private void FormRegistroAdmin_Load(object sender, EventArgs e)
        {
            lblEmail.Text = "Ingrese un email valido";
            lblDNI.Text = "Ingrese un DNI valido";

        }
    }
}
