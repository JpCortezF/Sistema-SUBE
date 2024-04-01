using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Sube.Forms_Pasajeros;
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

namespace Sube
{
    public partial class FormPasajero : Form
    {
        private Form currentChildForm = null;

        public FormPasajero()
        {
            InitializeComponent();
        }
        private void FormPasajero_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("| SALIR |");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = Color.MediumSlateBlue;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
            Image backgroundImage = Properties.Resources.fondoPasajero;

            // Establece la imagen como fondo del Panel
            panel1.BackgroundImage = backgroundImage;

            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private GraphicsPath CrearRegionConEsquinasRedondeadas(int width, int height, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(width - (radio * 2), 0, radio * 2, radio * 2, 270, 90); // Esquina superior derecha
            path.AddArc(width - (radio * 2), height - (radio * 2), radio * 2, radio * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, height - (radio * 2), radio * 2, radio * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radio = 10; // Ajusta el radio según tus preferencias

            btnIngresar.Region = new Region(CrearRegionConEsquinasRedondeadas(btnIngresar.Width, btnIngresar.Height, radio));
            btnRegistrar.Region = new Region(CrearRegionConEsquinasRedondeadas(btnRegistrar.Width, btnRegistrar.Height, radio));
            btnOnline.Region = new Region(CrearRegionConEsquinasRedondeadas(btnOnline.Width, btnOnline.Height, radio));
            this.Region = new Region(CrearRegionConEsquinasRedondeadas(this.Width, this.Height, radio));
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
                FormIngreso formIngreso = new FormIngreso(this);
                formIngreso.Opacity = 0.50;
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
                FormRegistro formRegistro = new FormRegistro();
                OpenChildForm(formRegistro);
            }
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormCompraOnline))
            {
                FormCompraOnline compraSube = new FormCompraOnline(this);
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
        public void ItemsMdiParentVisibles()
        {
            panel1.Visible = true;
        }
    }
}
