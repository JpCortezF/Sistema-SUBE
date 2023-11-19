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
    public partial class FormBajaUsuario : Form
    {
        Pasajero passenger;

        public FormBajaUsuario(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void FormBajaUsuario_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = ($"Al dar de baja tu tarjeta nº {passenger.IdSube}, quedará inhabilitada.\n¿Estás seguro de que querés continuar?\r\n\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
