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
    public partial class FormPasajero : Form
    {
        public FormPasajero()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
            Close();
        }
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            FormIngreso formIngreso = new FormIngreso();
            formIngreso.Show();
            Close();
        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            Close();
        }
    }
}
