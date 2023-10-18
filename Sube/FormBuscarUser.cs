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
    public partial class FormBuscarUser : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;

        public FormBuscarUser(Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
            cmbBuscar.SelectedIndex = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DNI", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Genero", typeof(string));
            dt.Columns.Add("N° de Tarjeta", typeof(string));
            dt.Columns.Add("Saldo actual", typeof(string));

            foreach (var entry in dictionaryPassengers)
            {
                if (entry.Key.Contains(txtDni.Text, StringComparison.OrdinalIgnoreCase) || entry.Value.Name.StartsWith(txtDni.Text, StringComparison.OrdinalIgnoreCase) || entry.Value.LastName.StartsWith(txtDni.Text, StringComparison.OrdinalIgnoreCase))
                {
                    dt.Rows.Add(entry.Key, entry.Value.Name, entry.Value.LastName, entry.Value.Gender, entry.Value.MySube.CardNumber, entry.Value.MySube.Balance);
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    label2.Text = "N° de documento a buscar:";
                    break;
                case 1:
                    label2.Text = "Ingrese nombre o apellido a buscar:";
                    break;
                case 2:
                    label2.Text = "N° de tarjeta a buscar:";
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
                {
                    if (kvp.Value is Pasajero passenger)
                    {
                        if (selectedRow.Cells["DNI"].Value.ToString() == kvp.Key)
                        {
                            FormAdminVistaUsuario editarUsuario = new FormAdminVistaUsuario(passenger);
                            editarUsuario.Show();
                        }
                    }
                }
            }
        }
    }
}
