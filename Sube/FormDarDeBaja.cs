using Biblioteca_TarjetaSube;
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
    public partial class FormDarDeBaja : Form
    {
        Pasajero passenger;

        public FormDarDeBaja(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void FormDarDeBaja_Load(object sender, EventArgs e)
        {
            lblMotivos.Text = "Está por iniciar el trámite para dar de baja su tarjeta SUBE";
            lblAdvertencia.Text = "Tene en cuenta que si das de baja tu SUBE\nTe va a extrañar :(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
