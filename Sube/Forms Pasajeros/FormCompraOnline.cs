using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
using Microsoft.Win32;
using NPOI.POIFS.Crypt.Dsig;
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
        private FormPasajero parentForm;
        Pasajero passenger = new Pasajero();
        SistemaSube sistemaSube = new SistemaSube();
        SistemaPasajero sistema = new SistemaPasajero();

        public FormCompraOnline(FormPasajero parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != string.Empty)
            {
                int.TryParse(txtDni.Text, out int dni);
                passenger = sistema.PassengerNullSube(dni);
                if (passenger != null)
                {
                    passenger.IdSube = sistema.NewCardNumberToPassenger();
                    if (!sistemaSube.CardNumberExits(passenger.IdSube))
                    {
                        SubeONLINE subeOnline = new SubeONLINE(passenger);
                        subeOnline.MdiParent = parentForm;
                        subeOnline.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Felicitaciones, lograste crear una SUBE ya existente! jaja", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No puede tener más de una SUBE a su nombre", "Nueva SUBE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
