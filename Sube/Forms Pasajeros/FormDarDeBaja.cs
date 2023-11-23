using Biblioteca_DataBase;
using Biblioteca_Tramites;
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
using Logica;

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
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
            Close();
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSeleccionado = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (radioButtonSeleccionado != null)
            {
                FormBajaUsuario bajaUsuario = new FormBajaUsuario(passenger);
                bajaUsuario.ShowDialog();
                if (bajaUsuario.DialogResult == DialogResult.OK)
                {
                    string radioButtonTramite = radioButtonSeleccionado.Text;
                    MessageBox.Show("¡Solicitud enviada!\n¡Listo! Su trámite se encuentra en revisión", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTramite.Enabled = false;
                    SistemaTramite sistema = new SistemaTramite();
                    sistema.InsertClaimIntoDataTable(passenger, radioButtonTramite, txtClaim.Text);
                }
            }
            else
            {
                MessageBox.Show("No se registro ninguna opcion marcada", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDarDeBaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.RosyBrown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
        }
    }
}
