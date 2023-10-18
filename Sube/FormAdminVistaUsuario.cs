using Biblioteca_TarjetaSube;
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
    public partial class FormAdminVistaUsuario : Form
    {
        Pasajero selectedPassenger;
        public FormAdminVistaUsuario(Pasajero pasajero)
        {
            InitializeComponent();
            selectedPassenger = pasajero;
        }

        private void FormAdminVistaUsuario_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            txtNombre.Text = selectedPassenger.Name;
            txtApellido.Text = selectedPassenger.LastName;
            txtMail.Text = selectedPassenger.Email;
            txtNumTarjeta.Text = selectedPassenger.MySube.CardNumber;
            txtCredito.Text = selectedPassenger.MySube.Balance.ToString();
            dt.Columns.Add("Transporte", typeof(string));
            dt.Columns.Add("Linea", typeof(string));
            dt.Columns.Add("Kms", typeof(string));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Precio", typeof(string));
            foreach (var entry in selectedPassenger.MySube.QueueTravels)
            {
                dt.Rows.Add(entry.TipoTransporte, entry.LineasTransporte, entry.Kilometres, entry.Date, entry.TicketCost);
            }
            dataGridView1.DataSource = dt;
            foreach (var item in Enum.GetValues(typeof(ETarifaSocial)))
            {
                cmbTarifa.Items.Add(item);
            }
            for (int i = 0; i < cmbTarifa.Items.Count; i++)
            {
                if (cmbTarifa.Items[i].ToString() == selectedPassenger.MySube.TarifaSocial.ToString())
                {
                    cmbTarifa.SelectedIndex = i;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmergente form = new FormEmergente("Quiere guardar los cambios?");
            selectedPassenger.Name = txtNombre.Text;
            selectedPassenger.LastName = txtApellido.Text;
            selectedPassenger.Email = txtMail.Text;
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedPassenger.Name = txtNombre.Text;
                selectedPassenger.LastName = txtApellido.Text;
                selectedPassenger.Email = txtMail.Text;
                Close();
            }

        }
    }
}
