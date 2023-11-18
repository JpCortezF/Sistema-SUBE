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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sube
{
    public partial class FormBuscarUser : Form
    {
        List<Pasajero> listPassengers;
        private ContainerAdmin parentForm;

        public FormBuscarUser(ContainerAdmin parent, List<Pasajero> listPassengers)
        {
            InitializeComponent();
            this.listPassengers = listPassengers;
            cmbBuscar.SelectedIndex = 0;
            parentForm = parent;
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
            /*
            foreach (Pasajero pasajero in listPassengers)
            {
                if (pasajero.Dni.ToString().StartsWith(txtDni.Text, StringComparison.OrdinalIgnoreCase) || pasajero.MySube.CardNumber.StartsWith(txtDni.Text, StringComparison.OrdinalIgnoreCase) || pasajero.LastName.StartsWith(txtDni.Text, StringComparison.OrdinalIgnoreCase))
                {
                    dt.Rows.Add(pasajero.Dni, pasajero.Name, pasajero.LastName, pasajero.Gender, pasajero.MySube.CardNumber, pasajero.MySube.Balance);
                }               
            }
            */
            dataGridView.DataSource = dt;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    label2.Text = "N° de documento a buscar:";
                    txtDni.MaxLength = 8;
                    txtName.Visible = false;
                    txtDni.Visible = true;
                    break;
                case 1:
                    label2.Text = "Ingrese nombre o apellido a buscar:";
                    txtName.MaxLength = 50;
                    txtDni.Visible = false;
                    txtName.Visible = true;
                    break;
                case 2:
                    label2.Text = "N° de tarjeta a buscar:";
                    txtDni.MaxLength = 16;
                    txtName.Visible = false;
                    txtDni.Visible = true;
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                foreach (Pasajero passenger in listPassengers)
                {
                    if (selectedRow.Cells["DNI"].Value.ToString() == passenger.Dni.ToString())
                    {
                        FormAdminVistaUsuario editarUsuario = new FormAdminVistaUsuario(passenger);
                        editarUsuario.MdiParent = parentForm;
                        editarUsuario.Show();
                    }               
                }
            }
        }
        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DNI", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Genero", typeof(string));
            dt.Columns.Add("N° de Tarjeta", typeof(string));
            dt.Columns.Add("Saldo actual", typeof(string));
            /*
            foreach (Pasajero pasajero in listPassengers)
            {
                dt.Rows.Add(pasajero.Dni, pasajero.Name, pasajero.LastName, pasajero.Gender, pasajero.MySube.CardNumber, pasajero.MySube.Balance);
            }
            dataGridView.DataSource = dt;
            dataGridView.Parent = panel1;
            */
        }

        private void FormBuscarUser_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = Regex.Replace(txtName.Text, "[^a-zA-Z ]", "");
        }
    }
}
