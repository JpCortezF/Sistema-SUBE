using Biblioteca_Usuarios;
using Sube.Forms_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sube
{
    public partial class FormAdmin : Form
    {
        Dictionary<string, Administrador> dictionaryAdmins;

        public FormAdmin(ContainerLoginAdmin parent)
        {
            InitializeComponent();
            this.dictionaryAdmins = new Dictionary<string, Administrador>();
            string ruta = @"..\..\..\Data";
            string nombre = "MisAdmins.Json";
            string path = Path.Combine(ruta, nombre);
            dictionaryAdmins = Serializador.ReadJsonAdmin(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radio = 15; // Ajusta el radio según tus preferencias

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(Width - (radio * 2), 0, radio * 2, radio * 2, -90, 90); // Esquina superior derecha
            path.AddArc(Width - (radio * 2), Height - (radio * 2), radio * 2, radio * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, Height - (radio * 2), radio * 2, radio * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);
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
            frm.MdiParent = this.MdiParent;
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
                            MdiParent.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "eze@hotmail.com";
            txtDni.Text = "41709030";
            txtPassword.Text = "1234";
            txtRepeatPassword.Text = "1234";
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
