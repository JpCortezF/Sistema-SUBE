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
    public partial class ContainerAdmin : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;

        private bool isBuscadorFormOpen = false;

        public ContainerAdmin()
        {
            InitializeComponent();
            this.dictionaryPassengers = new Dictionary<string, Pasajero>();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = "MisPasajeros.Json";
            string path = Path.Combine(ruta, nombre);
            dictionaryPassengers = Serializador.ReadJsonPassenger(path);
        }

        private void ContainerAdmin_Load(object sender, EventArgs e)
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

        private void buscadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBuscadorFormOpen)
            {
                FormBuscarUser buscador = new FormBuscarUser(dictionaryPassengers);
                buscador.MdiParent = this;
                buscador.Show();
                isBuscadorFormOpen = true;
                buscador.FormClosed += (s, args) =>
                {
                    isBuscadorFormOpen = false;
                };
            }
        }

    }
}
