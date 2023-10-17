using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class TomarTransporte : Form
    {
        Pasajero passenger;
        Viajes miViaje;
        ETransporte miTransporte;
        public TomarTransporte(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void TomarTransporte_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "¡Viaja con tu SUBE!";
            lblKilometres.Text = "Ingrese cantidad de kilometros";
            comboBox1.Items.Add(ETransporte.Colectivo);
            comboBox1.Items.Add(ETransporte.Subte);
            comboBox1.Items.Add(ETransporte.Tren);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transporte = comboBox1.SelectedItem.ToString();
            if (Enum.TryParse(transporte, out ETransporte tipoTransporte))
            {
                miTransporte = tipoTransporte;
            }
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarIngresoTextBox())
                {

                    if (float.TryParse(txtKilometros.Text, out float kilometros))
                    {
                        TarjetaSube sube = new TarjetaSube();
                        string lineaTransporte = txtLinea.Text;
                        miViaje = new Viajes(kilometros, DateTime.Now, miTransporte, lineaTransporte);

                        TarifaSocialPasajero boletoViaje = new TarifaSocialPasajero(passenger.MySube.TarifaSocial, miViaje);
                        miViaje.TicketCost = boletoViaje.ReturnTicketCost(miTransporte);

                        passenger.MySube.Balance -= boletoViaje.ReturnTicketCost(miTransporte);
                        passenger.MySube.QueueTravels.Enqueue(miViaje);

                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool ValidarIngresoTextBox()
        {
            bool allCompleted = true;
            foreach (Control control in grpTransporte.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        allCompleted = false;
                        break;
                    }
                }
            }
            return allCompleted;
        }
        private void txtKilometros_TextChanged(object sender, EventArgs e)
        {
            txtKilometros.Text = Regex.Replace(txtKilometros.Text, @"[^0-9]", "");
        }
    }
}
