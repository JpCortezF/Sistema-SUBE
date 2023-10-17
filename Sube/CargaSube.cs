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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sube
{
    public partial class CargaSube : Form
    {
        Pasajero passenger;

        public CargaSube(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }
        private void lblContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void txtCarga_TextChanged(object sender, EventArgs e)
        {
            txtCarga.Text = Regex.Replace(txtCarga.Text, @"[^0-9]", "");
        }

        private void CargaSube_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "Carga tu SUBE de forma virtual desde Mercado Pago";
            lblSaldo.Text = $"$ {passenger.MySube.Balance}";

            txtCarga.TextChanged += txtCarga_TextChanged;
        }
        public string DevolverMonto()
        {
            return txtCarga.Text;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                float balance = passenger.MySube.Balance;
                if (!string.IsNullOrEmpty(txtCarga.Text))
                {
                    DialogResult = DialogResult.OK;
                    if (float.TryParse(txtCarga.Text, out balance))
                    {
                        passenger.MySube.Balance += balance;
                    }
                    Close();
                }
                else
                {
                    txtCarga.BackColor = Color.RosyBrown;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
