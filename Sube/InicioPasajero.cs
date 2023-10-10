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
        string document;
        public InicioPasajero(Dictionary<string, Pasajero> passengers, string document)
        {
            InitializeComponent();
            dictionaryPassengers = passengers;
            this.document = document;
            passenger = new Pasajero();
        }

        private void InicioPasajero_Load(object sender, EventArgs e)
        {
            lblPasajero.BackColor = Color.FromArgb(0, 255, 255, 255); // Establece el canal alfa a 0 para hacer el fondo transparente
            lblPasajero.Text = $"{passenger.FindNameByKey(dictionaryPassengers)}";

            ToolStripMenuItem itemSalir = new ToolStripMenuItem("SALIR");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.Control;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
        }

        private void mISUBEToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
        private void mISUBEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
