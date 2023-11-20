using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
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

        private void SubeONLINE_Load(object sender, EventArgs e)
        {

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
                DataBase<TarjetaSube> dataSube = new DataBase<TarjetaSube>();
                DataBase<Pasajero> data = new DataBase<Pasajero>();

                CamionEmergente camion = new CamionEmergente();
                camion.ShowDialog();

                string insertSube = @"INSERT INTO tarjetas (id, balance, socialRate) VALUES (@tarjeta, @balance, @tarifaSocial);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@tarjeta", passenger.IdSube },
                    { "@balance", 0 },
                    { "@tarifaSocial", ETarifaSocial.Ninguna },
                };
                dataSube.Insert(insertSube, parameters);
                string query = @"UPDATE pasajeros SET idSube = @newCardNumber WHERE dni = @Dni";
                parameters.Clear();
                parameters.Add("@newCardNumber", passenger.IdSube);
                parameters.Add("@Dni", passenger.Dni);
                data.Update(query, parameters);
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
