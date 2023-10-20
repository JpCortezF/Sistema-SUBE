using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Sube.Forms_Pasajeros;
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
    public partial class FormPasajero : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        private Form currentChildForm = null;

        public FormPasajero()
        {
            InitializeComponent();
            this.dictionaryPassengers = new Dictionary<string, Pasajero>();
            string ruta = @"..\..\..\Data";
            string nombre = "MisPasajeros.Json";
            string path = Path.Combine(ruta, nombre);
            dictionaryPassengers = Serializador.ReadJsonPassenger(path);
        }
        private void FormPasajero_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("| SALIR |");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;

            Image backgroundImage = Properties.Resources.logo_sube_blanco_sombra_web;

            // Establece la imagen como fondo del Panel
            panel1.BackgroundImage = backgroundImage;

            panel1.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void itemSalir_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?", "Salir");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                Close();
            }
        }
        /// <summary>
        /// Abre un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="childForm">El formulario hijo que se abrirá.</param>
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormIngreso))
            {
                FormIngreso formIngreso = new FormIngreso(this, dictionaryPassengers);
                OpenChildForm(formIngreso);
            }
        }
        /// <summary>
        /// Maneja el evento de hacer clic en el elemento de menú "Notificaciones". Abre el formulario de tramites como un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (en este caso, el elemento de menú "Notificaciones").</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormRegistro))
            {
                FormRegistro formRegistro = new FormRegistro(dictionaryPassengers);
                OpenChildForm(formRegistro);
            }
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormCompraOnline))
            {
                FormCompraOnline compraSube = new FormCompraOnline(this, dictionaryPassengers);
                OpenChildForm(compraSube);
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.MdiParent = this;
            childForm.Location = new Point(0, 0);
            panel1.Visible = false;
            childForm.FormClosed += (s, args) =>
            {
                currentChildForm = null;
            };
            childForm.Show();
        }
        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
                panel1.Visible = true;
            }
        }
    }
}
