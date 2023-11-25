using Biblioteca_TarjetaSube;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace Sube.Forms_Pasajeros
{
    public partial class EnViaje : Form
    {
        Viajes viaje;
        int remainingTime;

        public EnViaje(TarjetaSube sube, LineasTransporte miLinea, Viajes miViaje)
        {
            InitializeComponent();
            TransportPicture(miViaje.TipoTransporte);
            viaje = miViaje;
            SistemaSube sistema = new SistemaSube();
            Task countdownTask;
            sistema.LoadTravelWithTimer(sube, miViaje.TipoTransporte, miLinea, miViaje);

            // Obtener el tiempo restante del temporizador
            remainingTime = LabelTimer(viaje.Kilometres);

            // Iniciar el Task en un segundo hilo
            countdownTask = Task.Run(() => Countdown());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                // Actualizar el Label con el tiempo restante
                lblViaje.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss");

                // Restar un segundo al tiempo restante
                remainingTime--;
            }
            else
            {
                // Cuando el tiempo llega a cero, establecer DialogResult.OK
                DialogResult = DialogResult.OK;
            }
        }
        private int LabelTimer(float kilometres)
        {
            int time = 0;
            switch (kilometres)
            {
                case float k when k >= 0 && k <= 3:
                    time = 5;
                    break;
                case float k when k >= 3 && k <= 6:
                    time = 10;
                    break;
                case float k when k >= 6 && k <= 12:
                    time = 13;
                    break;
                case float k when k >= 12 && k <= 27:
                    time = 16;
                    break;
            }
            return time;
        }
        private void UpdateLabel()
        {
            if (lblViaje.InvokeRequired)
            {
                lblViaje.Invoke((MethodInvoker)delegate { UpdateLabel(); });
            }
            else
            {
                lblViaje.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss");
            }
        }
        private void Countdown()
        {
            // Esperar hasta que el formulario esté listo
            while (!IsHandleCreated || IsDisposed)
            {
                Thread.Sleep(100); // Puedes ajustar el intervalo de espera según tus necesidades
            }

            // Ahora que el formulario está listo, podemos mostrar el Label
            if (lblViaje.InvokeRequired)
            {
                lblViaje.Invoke((MethodInvoker)delegate
                {
                    lblViaje.Visible = true;
                });
            }
            else
            {
                lblViaje.Visible = true;
            }
            // Continuar con el resto del código para el contador de tiempo
            while (remainingTime > 0)
            {
                // Verificar si el formulario y el control aún existen
                if (!IsDisposed && lblViaje.IsHandleCreated)
                {
                    // Actualizar el Label con el tiempo restante
                    UpdateLabel();
                }

                // Restar un segundo al tiempo restante
                remainingTime--;

                // Esperar un segundo
                Thread.Sleep(1000);
            }
            // Cuando el tiempo llega a cero, establecer DialogResult.OK
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
            }
        }
        private void TransportPicture(ETransporte transporte)
        {
            switch (transporte)
            {
                case ETransporte.Colectivo:
                    Image gifImage = Properties.Resources.busGif;
                    pictureBox1.Image = gifImage;
                    break;
                case ETransporte.Subte:
                    gifImage = Properties.Resources.subwayGif;
                    pictureBox1.Image = gifImage;
                    break;
                case ETransporte.Tren:
                    gifImage = Properties.Resources.trainGif;
                    pictureBox1.Image = gifImage;
                    break;
            }
        }
    }
}
