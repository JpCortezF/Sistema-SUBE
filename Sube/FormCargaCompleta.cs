using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormCargaCompleta : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        private static FormCargaCompleta instancia = null;
        Pasajero passenger;

        public static FormCargaCompleta VentanaUnica(Pasajero passenger, string amount, Dictionary<string, Pasajero> dictionaryPassengers)
        {
            if (instancia == null)
            {
                instancia = new FormCargaCompleta(passenger, amount, dictionaryPassengers);
            }
            return instancia;
        }
        public FormCargaCompleta(Pasajero passenger, string amount, Dictionary<string, Pasajero> dictionaryPassengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.dictionaryPassengers = dictionaryPassengers;
            lblAcreditado.Text = "Saldo acreditado $" + amount;
        }
        private void FormCargaCompleta_Load(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = @".\MisPasajeros.Json";
            string path = ruta + nombre;

            lblSaldo.Text = $"$ {passenger.MySube.Balance}";

            Serializador.WriteJsonPassenger(path, dictionaryPassengers);
        }

        private void lblContinuar_Click(object sender, EventArgs e)
        {
            instancia = null;
            DialogResult = DialogResult.OK;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            instancia = null;
            DialogResult = DialogResult.OK;
        }
    }
}
