using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class InicioPasajero : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        Pasajero passenger;
        public InicioPasajero(Pasajero passenger, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.dictionaryPassengers = passengers;
        }

        private void InicioPasajero_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("SALIR");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.Control;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
            lblNombre.Text = $"¡Hola {passenger.Name + " " + passenger.LastName}!";
        }
        private void itemSalir_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                Close();
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
        }
        private void vIAJARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TomarTransporte transporte = new TomarTransporte();
            transporte.ShowDialog();
            if(transporte.DialogResult == DialogResult.OK)
            {

            }
        }
        private void subeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            FormSubePasajero miSube = new FormSubePasajero(passenger, dictionaryPassengers);

            miSube.MdiParent = this;

            miSube.Show();
        }
        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            FormViajes viajes = new FormViajes();
            viajes.ShowDialog();
            if (viajes.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
