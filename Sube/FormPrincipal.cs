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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Desarrollamos la tecnología para simplificar y mejorar el acceso al transporte público.";
        }
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPasajero_Click_1(object sender, EventArgs e)
        {
            FormPasajero formPasajero = new FormPasajero();
            formPasajero.Show();
            Hide();
        }
    }
}
