using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormSubePasajero : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        Pasajero passenger;

        public FormSubePasajero(Pasajero passenger, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.dictionaryPassengers = passengers;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSubePasajero_Load(object sender, EventArgs e)
        {
            lblTransportes.Text = "Información sobre los transportes";
            lblTarjeta.Text = $"{passenger.MySube.CardNumber}";
            lblName.Text = $"{passenger.Name + " " + passenger.LastName}";
            double balance = passenger.MySube.Balance;
            lblSaldo.Text = $"${balance.ToString("F2")}";
            lblActualTarifa.Text = $"Tarifa Social: {passenger.MySube.TarifaSocial}";
            lblTarifa.Text = "Acceder a tarifa social --->";
            lblTarjeta.Location = new Point(30, 120);
            lblName.Location = new Point(30, 158);
            pictureBox1.Controls.Add(lblTarjeta);
            pictureBox1.Controls.Add(lblName);
            lbl0to3Km.Text = $"De 0 a 3Km: ${PrecioViajes.ValorColectivo0To3Km}";
            lbl3to6Km.Text = $"De 3 a 6Km: ${PrecioViajes.ValorColectivo3To6Km}";
            lbl6to12km.Text = $"De 6 a 12Km: ${PrecioViajes.ValorColectivo6To12Km}";
            lbl12to27km.Text = $"De 12 a 27: ${PrecioViajes.ValorColectivo12To27Km}";
            lblSubte.Text = $"Todas las lineas: ${PrecioViajes.ValorSubte}";
            lblTren.Text = $"Todas las lineas: ${PrecioViajes.ValorTren}";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crea una región con esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            int radio = 15; // Ajusta el radio según tus preferencias

            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(this.Width - (radio * 2), 0, radio * 2, radio * 2, 270, 90); // Esquina superior derecha
            path.AddArc(this.Width - (radio * 2), this.Height - (radio * 2), radio * 2, radio * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, this.Height - (radio * 2), radio * 2, radio * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            try
            {
                CargaSube cargarSube = new CargaSube(passenger);
                cargarSube.ShowDialog();
                if (cargarSube.DialogResult == DialogResult.OK)
                {
                    string amount = cargarSube.DevolverMonto();

                    FormCargaCompleta subeCargada = new FormCargaCompleta(passenger, amount);
                    subeCargada.ShowDialog();

                    if (subeCargada.DialogResult == DialogResult.OK)
                    {
                        InicioPasajero inicio = new InicioPasajero(passenger, dictionaryPassengers);
                        Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void lblTarifa_Click(object sender, EventArgs e)
        {
            Close();

            FormTarifaSocial tarifaSocial = new FormTarifaSocial(passenger, dictionaryPassengers);
            tarifaSocial.ShowDialog();
        }
    }
}
