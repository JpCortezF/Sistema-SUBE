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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            instancia = null;
            FormSubePasajero sube = new FormSubePasajero(passenger, dictionaryPassengers);
            sube.Show();
        }

        private void FormCargaCompleta_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = $"$ {passenger.MySube.Balance}";
        }
    }
}
