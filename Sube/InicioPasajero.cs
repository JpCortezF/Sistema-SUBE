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
        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void subeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubePasajero miSube = FormSubePasajero.VentanaUnica(passenger, dictionaryPassengers);

            miSube.MdiParent = this;

            miSube.Show();
            miSube.BringToFront();
        }
    }
}
