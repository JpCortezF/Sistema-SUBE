using Biblioteca_Usuarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube.Forms_Pasajeros
{
    public partial class FormCompraOnline : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;

        public FormCompraOnline(Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool compraOnline = false;
            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            {
                if (kvp.Value is Pasajero passenger)
                {
                    if (txtDni.Text == kvp.Key && passenger.MySube.CardNumber == "DeBaja")
                    {
                        Random rnd = new Random();
                        int _rnd = rnd.Next(1000, 9999);
                        int _rnd2 = rnd.Next(1000, 9999);
                        int _rnd3 = rnd.Next(1000, 9999);
                        string newCardNumber = $"6061{_rnd}{_rnd2}{_rnd3}";

                        if (!passenger.CardNumberExist(dictionaryPassengers, newCardNumber))
                        {
                            passenger.MySube.CardNumber = newCardNumber;

                            string ruta = @"..\..\..\Data";
                            string nombre = "MisPasajeros.Json";
                            string path = Path.Combine(ruta, nombre);

                            Serializador.WriteJsonPassenger(path, dictionaryPassengers);

                            MessageBox.Show($"Tu nueva tarjeta es: {passenger.MySube.CardNumber}", "Nueva SUBE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        compraOnline = true;
                    }
                }
            }
            if (compraOnline == false)
            {
                MessageBox.Show("No puede tener más de una SUBE a su nombre", "Nueva SUBE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormCompraOnline_Load(object sender, EventArgs e)
        {
            cmbDni.Items.Add("DNI - Documento Nacional de Identidad");
            cmbDni.Items.Add("LE - Libreta Enrolamiento");
            cmbDni.Items.Add("LC - Libreta Cívica");
            cmbDni.Items.Add("DE - Documento Extranjero");
            txtDni.TextChanged += txt_TextChanged;
            cmbDni.SelectedIndex = 0;
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }

    }
}
