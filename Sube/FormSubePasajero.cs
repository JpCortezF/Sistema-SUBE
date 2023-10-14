using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sube
{
    public partial class FormSubePasajero : Form
    {
        private static FormSubePasajero instancia = null;
        Dictionary<string, Pasajero> dictionaryPassengers;
        Pasajero passenger;

        public static FormSubePasajero VentanaUnica(Pasajero passenger, Dictionary<string, Pasajero> passengers)
        {
            if (instancia == null)
            {
                instancia = new FormSubePasajero(passenger, passengers);
            }
            return instancia;
        }
        public FormSubePasajero(Pasajero passenger, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.dictionaryPassengers = passengers;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            instancia = null;
        }

        private void FormSubePasajero_Load(object sender, EventArgs e)
        {
            lblTarjeta.Text = $"{passenger.MySube.CardNumber}";
            lblName.Text = $"{passenger.Name + " " + passenger.LastName}";
            lblSaldo.Text = $"$ {passenger.MySube.Balance}";
            cmbBaja.Items.Add("Perdida");
            cmbBaja.Items.Add("Robo");
            cmbBaja.Items.Add("Rotura");
            lblTarjeta.Location = new Point(30, 120);
            lblName.Location = new Point(30, 158);
            pictureBox1.Controls.Add(lblTarjeta);
            pictureBox1.Controls.Add(lblName);
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Close();
            instancia = null;
            try
            {
                CargaSube cargarSube = CargaSube.VentanaUnica(passenger, dictionaryPassengers);
                cargarSube.ShowDialog();
                if(cargarSube.DialogResult == DialogResult.OK)
                {
                    string amount = cargarSube.DevolverMonto();

                    FormCargaCompleta subeCargada = FormCargaCompleta.VentanaUnica(passenger, amount, dictionaryPassengers);
                    subeCargada.ShowDialog();

                    if(subeCargada.DialogResult == DialogResult.OK)
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
    }
}
