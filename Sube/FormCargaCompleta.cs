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
        Pasajero passenger;

        public FormCargaCompleta(Pasajero passenger, string amount)
        {
            InitializeComponent();
            this.passenger = passenger;
            lblAcreditado.Text = "Saldo acreditado $" + amount;
        }
        private void FormCargaCompleta_Load(object sender, EventArgs e)
        {
            double balance = passenger.MySube.Balance;
            lblSaldo.Text = $"${balance.ToString("F2")}";
        }

        private void lblContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
