using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Sube.Forms_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sube
{
    public partial class ContainerAdmin : Form
    {
        //SerializadorJSON<Dictionary<string, Pasajero>> serializadorPasajero = new SerializadorJSON<Dictionary<string, Pasajero>>();
        //SerializadorXML<List<Tramites>> serializeTramite = new SerializadorXML<List<Tramites>>();
        List<Pasajero> listPassengers;
        List<Tramites> tramites;

        private Form currentChildForm = null;

        public ContainerAdmin()
        {
            InitializeComponent();
            this.tramites = new List<Tramites>();
            string ruta = @"..\..\..\Data";
            string nombre = "MisPasajeros.Json";
            string path = Path.Combine(ruta, nombre);
            listPassengers = Serializador.ReadJsonPassenger(path);
            //listPassengers = serializadorPasajero.Deserialize(path);
            string rutaT = @"..\..\..\Data";
            string nombreT = "MisTramites.xml";
            string pathT = Path.Combine(rutaT, nombreT);
            tramites = Serializador.ReadXMLTramites(pathT);
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
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?", "Salir");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                string ruta = @"..\..\..\Data";
                string nombre = "MisPasajeros.Json";
                string path = Path.Combine(ruta, nombre);
                Serializador.WriteJsonPassenger(path, listPassengers);
                //serializadorPasajero.Serialize(path, dictionaryPassengers);
                string rutaT = @"..\..\..\Data";
                string nombreT = "MisTramites.xml";
                string pathT = Path.Combine(rutaT, nombreT);
                //serializeTramite.Serialize(pathT, tramites);
                Serializador.WriteXMLTramites(pathT, tramites);
                Close();
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
        }
        /// <summary>
        /// Abre un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="childForm">El formulario hijo que se abrirá.</param>
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.MdiParent = this;
            childForm.Location = new Point(0, 0);
            childForm.FormClosed += (s, args) =>
            {
                currentChildForm = null;
            };
            childForm.Show();
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el elemento de menú "Buscador". Abre el formulario de búsqueda de usuarios como un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (en este caso, el elemento de menú "Buscador").</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buscadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormBuscarUser))
            {
                FormBuscarUser buscador = new FormBuscarUser(this, listPassengers);
                OpenChildForm(buscador);
            }
        }

        /// <summary>
        /// Maneja el evento de hacer clic en el elemento de menú "Notificaciones". Abre el formulario de tramites como un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (en este caso, el elemento de menú "Notificaciones").</param>
        /// <param name="e">Argumentos del evento.</param>
        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ChartMenu notificaciones = new ChartMenu();
            notificaciones.Show();
            */
            
            if (currentChildForm is null || !(currentChildForm is FormTramites))
            {
                FormTramites notificaciones = new FormTramites(this, tramites, listPassengers);
                OpenChildForm(notificaciones);
            }
            
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
