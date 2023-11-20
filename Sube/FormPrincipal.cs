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

namespace Sube
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Desarrollamos la tecnología para simplificar y mejorar el acceso al transporte público.";
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

            int radio = 15; // Ajusta el radio según tus preferencias

            this.Region = new Region(CrearRegionConEsquinasRedondeadas(this.Width, this.Height, radio));
            btnAdmin.Region = new Region(CrearRegionConEsquinasRedondeadas(btnAdmin.Width, btnAdmin.Height, radio));
            btnPasajero.Region = new Region(CrearRegionConEsquinasRedondeadas(btnPasajero.Width, btnPasajero.Height, radio));
            btnSalir.Region = new Region(CrearRegionConEsquinasRedondeadas(btnSalir.Width, btnSalir.Height, radio));
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ContainerLoginAdmin admin = new ContainerLoginAdmin();
            admin.Show();
            Hide();
        }
        private void btnPasajero_Click(object sender, EventArgs e)
        {
            FormPasajero formPasajero = new FormPasajero();
            formPasajero.Show();
            Hide();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
