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
    public partial class ContainerAdmin : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        List<Tramites> tramites;

        private bool isBuscadorFormOpen = false;
        private bool isNotificacionesFormClosed = false;

        public ContainerAdmin()
        {
            InitializeComponent();
            this.dictionaryPassengers = new Dictionary<string, Pasajero>();
            this.tramites = new List<Tramites>();
            string ruta = @"..\..\..\Data";
            string nombre = "MisPasajeros.Json";
            string path = Path.Combine(ruta, nombre);
            dictionaryPassengers = Serializador.ReadJsonPassenger(path);
            string rutaT = @"..\..\..\Data";
            string nombreT = "MisTramites.Json";
            string pathT = Path.Combine(rutaT, nombreT);
            tramites = Serializador.ReadJsonTramites(pathT);
        }

        private void ContainerAdmin_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("SALIR");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                string ruta = @"..\..\..\Data";
                string nombre = "MisPasajeros.Json";
                string path = Path.Combine(ruta, nombre);
                Serializador.WriteJsonPassenger(path, dictionaryPassengers);
                string rutaT = @"..\..\..\Data";
                string nombreT = "MisTramites.Json";
                string pathT = Path.Combine(rutaT, nombreT);
                Serializador.WriteJsonTramites(pathT, tramites);
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

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isNotificacionesFormClosed)
            {
                FormTramites notificaciones = new FormTramites(tramites, dictionaryPassengers);
                notificaciones.MdiParent = this;
                notificaciones.Show();
                isNotificacionesFormClosed = true;
                notificaciones.FormClosed += (s, args) =>
                {
                    isBuscadorFormOpen = false;
                };
            }
        }
    }
}
