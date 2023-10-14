using Biblioteca_TarjetaSube;
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
using System.Xml.Linq;

namespace Sube
{
    public partial class FormRegistroAdmin : Form
    {
        Dictionary<string, Administrador> dictionaryAdmins;
        public FormRegistroAdmin(Dictionary<string, Administrador> admins)
        {
            InitializeComponent();
            this.dictionaryAdmins = admins;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = @".\MisAdmins.Json";
            string path = ruta + nombre;

            try
            {
                string email = txtEmail.Text;
                string name = txtName.Text;
                string lastname = txtLastName.Text;
                string password = txtPassword.Text;
                if (ValidarIngresoTextBox() && ValidarEmail(email) && EsSoloTexto(name) && EsSoloTexto(lastname))
                {
                    string document = txtDNI.Text;
                    Administrador admin = new Administrador(email, password, name, lastname);
                    if (!admin.AdminExist(admin, dictionaryAdmins, document))
                    {
                        dictionaryAdmins[document] = admin;
                        MessageBox.Show($"Se registro exitosamente!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Serializador.WriteJsonAdmin(path, dictionaryAdmins);
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

    }
}
