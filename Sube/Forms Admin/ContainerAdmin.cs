using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Biblioteca_Tramites;
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
using Logica;

namespace Sube
{
    public partial class ContainerAdmin : Form
    {
        List<Tramites> tramites;
        SistemaTramite sistemaTramite = new SistemaTramite();
        private Form currentChildForm = null;

        public ContainerAdmin(Administrador admin)
        {
            InitializeComponent();
            this.tramites = sistemaTramite.GetAllTramites();
        }

        private void ContainerAdmin_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("SALIR");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;

            label1.Text = GenerateTips();
            label1.Location = new Point(316, 451);
            pictureBox1.Controls.Add(label1);
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?", "Salir");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
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
            label1.Visible = false;
            pictureBox1.Visible = false;
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
                FormBuscarUser buscador = new FormBuscarUser(this);
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
                FormTramites notificaciones = new FormTramites(this, tramites);
                OpenChildForm(notificaciones);
            }

        }
        private string GenerateTips()
        {
            string tip;
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.WriteLine($"Número aleatorio: {randomNumber}");

            switch (randomNumber)
            {
                case 1:
                    tip = "Debajo de toda esa piedra, hay diamantes.";
                    break;
                case 2:
                    tip = "Todos vivimos en el mismo planeta, pero cada quien en su mundo.";
                    break;
                case 3:
                    tip = "No todo lo que brilla es valioso.";
                    break;
                case 4:
                    tip = "¿La gente lee estas cosas?";
                    break;
                case 5:
                    tip = "No borres el mundo entero por un mal momento.";
                    break;
                case 6:
                    tip = "No dejes árboles flotando.";
                    break;
                case 7:
                    tip = "Entre más bella y rara sea la espada, más daño te hará.";
                    break;
                case 8:
                    tip = "Trata bien a los animales.";
                    break;
                case 9:
                    tip = "Si activas los trucos se desactivan los logros.";
                    break;
                case 10:
                    tip = "No habla de Minecraft, habla de la vida.";
                    break;
                default:
                    tip = "Número no esperado.";
                    break;
            }
            return tip;
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
        public void ShowPictureBox()
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
        }
    }
}
