using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
using Org.BouncyCastle.Asn1.X509;
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

namespace Sube.Forms_Pasajeros
{
    public partial class SubeONLINE : Form
    {
        Pasajero passenger;

        public SubeONLINE(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }
        private GraphicsPath CrearRegionConEsquinasRedondeadas(int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(btnComprar.Width - (radio * 2), 0, radio * 2, radio * 2, 270, 90); // Esquina superior derecha
            path.AddArc(btnComprar.Width - (radio * 2), btnComprar.Height - (radio * 2), radio * 2, radio * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, btnComprar.Height - (radio * 2), radio * 2, radio * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radio = 15; // Ajusta el radio según tus preferencias

            btnComprar.Region = new Region(CrearRegionConEsquinasRedondeadas(radio));
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtDomicilio.Text != string.Empty)
            {
                CamionEmergente camion = new CamionEmergente();
                camion.ShowDialog();
                SistemaPasajero sistema = new SistemaPasajero();
                sistema.InsertSube(passenger);
                sistema.SetNewCardNumber(passenger);
                Close();
            }
        }
        private void SubeONLINE_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPasajero formPasajero = (FormPasajero)this.MdiParent;
            formPasajero.ItemsMdiParentVisibles();

        }
    }
}
