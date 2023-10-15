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
            try
            {
                CargaSube cargarSube = CargaSube.VentanaUnica(passenger, dictionaryPassengers);
                cargarSube.ShowDialog();
                if (cargarSube.DialogResult == DialogResult.OK)
                {
                    string amount = cargarSube.DevolverMonto();

                    FormCargaCompleta subeCargada = FormCargaCompleta.VentanaUnica(passenger, amount, dictionaryPassengers);
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
            FormBajaUsuario bajaUser = new FormBajaUsuario(dictionaryPassengers, passenger);
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

                    FormIngreso ingreso = new FormIngreso(dictionaryPassengers);
                    ingreso.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
