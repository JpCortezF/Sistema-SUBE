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
    public partial class CargaSube : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        private static CargaSube instancia = null;
        Pasajero passenger;

        public static CargaSube VentanaUnica(Pasajero passenger, Dictionary<string, Pasajero> dictionaryPassengers)
        {
            if (instancia == null)
            {
                instancia = new CargaSube(passenger, dictionaryPassengers);
            }
            return instancia;
        }
        public CargaSube(Pasajero passenger, Dictionary<string, Pasajero> dictionaryPassengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.dictionaryPassengers = dictionaryPassengers;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            instancia = null;
        }

        private void txtCarga_TextChanged(object sender, EventArgs e)
        {
            txtCarga.Text = Regex.Replace(txtCarga.Text, @"[^0-9]", "");
        }

        private void CargaSube_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = $"$ {passenger.MySube.Balance}";
            txtCarga.TextChanged += txtCarga_TextChanged;
            groupBox1.Parent = panel2;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                float balance = passenger.MySube.Balance;
                if (float.TryParse(txtCarga.Text, out balance))
                {
                    passenger.MySube.Balance += balance;
                }

                FormCargaCompleta formCargaCompleta = FormCargaCompleta.VentanaUnica(passenger, txtCarga.Text, dictionaryPassengers);

                formCargaCompleta.Show();
                formCargaCompleta.BringToFront();
                instancia = null;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
