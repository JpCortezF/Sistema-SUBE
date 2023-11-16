using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using NPOI.SS.Formula.Functions;
using Sube.Forms_Admin;
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
using System.Xml.Linq;

namespace Sube
{
    public partial class FormRegistroAdmin : Form
    {
        List<Administrador> listAdmins;
        public FormRegistroAdmin(List<Administrador> admins)
        {
            InitializeComponent();
            this.listAdmins = admins;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string ruta = @"..\..\..\Data";
            string nombre = @".\MisAdmins.Json";
            string path = ruta + nombre;

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
                    if (!admin.AdminExist(admin, listAdmins))
                    {
                        listAdmins.Add(admin);
                        MessageBox.Show($"Se registro exitosamente!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //SerializadorJSON<Dictionary<string, Administrador>> serializadorAdmin = new SerializadorJSON<Dictionary<string, Administrador>>();
                        //serializadorAdmin.Serialize(path, dictionaryAdmins);
                        Serializador.WriteJsonAdmin(path, listAdmins);
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
    }
}
