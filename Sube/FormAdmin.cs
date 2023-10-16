using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormAdmin : Form
    {
        Dictionary<string, Administrador> dictionaryAdmins;
        public FormAdmin()
        {
            InitializeComponent();
            this.dictionaryAdmins = new Dictionary<string, Administrador>();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = "MisAdmins.Json";
            string path = Path.Combine(ruta, nombre);
            dictionaryAdmins = Serializador.ReadJsonAdmin(path);
        }
        private void hOMEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPrincipal fp = new FormPrincipal();
            fp.Show();
            Close();
        }

        private void lblRegistroAdmin_Click(object sender, EventArgs e)
        {
            FormRegistroAdmin frm = new FormRegistroAdmin(dictionaryAdmins);
            frm.Show();
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool exist = false;
            if (!string.IsNullOrEmpty(txtDni.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                foreach (KeyValuePair<string, Administrador> kvp in dictionaryAdmins)
                {
                    if (kvp.Value is Administrador admin)
                    {
                        if (txtDni.Text == kvp.Key && txtPassword.Text == admin.Password && txtEmail.Text == admin.Email)
                        {
                            exist = true;
                            MessageBox.Show("Ingreso correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ContainerAdmin inicio = new ContainerAdmin();
                            inicio.Show();
                            this.Close();
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
    }
}
