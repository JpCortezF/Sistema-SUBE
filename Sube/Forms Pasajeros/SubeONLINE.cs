using Biblioteca_Usuarios;
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
        List<Pasajero> listPassengers;
        Pasajero passenger;
        public SubeONLINE(List<Pasajero> listPassengers, Pasajero passenger, string newCardNumber)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.passenger.MySube.CardNumber = newCardNumber;
            this.listPassengers = listPassengers;
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
                CamionEmergente camion = new CamionEmergente();
                camion.ShowDialog();
                string ruta = @"..\..\..\Data";
                string nombre = "MisPasajeros.Json";
                string path = Path.Combine(ruta, nombre);

                //Serializador.WriteJsonPassenger(path, dictionaryPassengers);
                SerializadorJSON<List<Pasajero>> serializadorPasajero = new SerializadorJSON<List<Pasajero>>();
                serializadorPasajero.Serialize(path, listPassengers);
            }
        }
    }
}
