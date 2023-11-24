using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube.Forms_Pasajeros
{
    public partial class SubeGold : Form
    {
        public SubeGold()
        {
            InitializeComponent();
        }

        private void SubeGold_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "¿Deseas suscribirte a Sube GOLD?\nIngrese sus datos (Dni y N° Tajeta Sube";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubeGold_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
