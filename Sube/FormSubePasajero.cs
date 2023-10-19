using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void cmbBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormBajaUsuario bajaUser = new FormBajaUsuario(passenger);
            bajaUser.ShowDialog();
            if (bajaUser.DialogResult == DialogResult.OK)
            {
                try
                {
                    string key = passenger.ReturnrKey(dictionaryPassengers, passenger);
                    dictionaryPassengers.Remove(key);

                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string nombre = @".\MisPasajeros.Json";
                    string path = ruta + nombre;

                    Serializador.WriteJsonPassenger(path, dictionaryPassengers);

                    this.MdiParent.Close();
                    this.Close();

                    FormPasajero homePasajero = new FormPasajero();
                    homePasajero.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
