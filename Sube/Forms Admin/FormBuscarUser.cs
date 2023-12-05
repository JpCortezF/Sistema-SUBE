using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NPOI.HSSF.Util.HSSFColor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sube
{
    public partial class FormBuscarUser : Form
    {
        TarjetaSube sube;
        List<Pasajero> listPassengers;
        private ContainerAdmin parentForm;
        DataBase<DataTable> data = new DataBase<DataTable>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        SistemaPasajero sistemaPasajero = new SistemaPasajero();
        SistemaSube sistemaSube = new SistemaSube();
        public FormBuscarUser(ContainerAdmin parent)
        {
            InitializeComponent();
            cmbBuscar.SelectedIndex = 0;
            parentForm = parent;
            listPassengers = sistemaPasajero.GetAllPasajeros();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            parameters.Clear();
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    int.TryParse(txtDni.Text, out int dni);
                    dataGridView.DataSource = sistemaPasajero.LoadDataTableWithDniSearch(dni);
                    break;
                case 1:
                    dataGridView.DataSource = sistemaPasajero.LoadDataTableWithNameSearch(txtName.Text, txtName.Text);
                    break;
                case 2:
                    dataGridView.DataSource = sistemaPasajero.LoadDataTableWithSubeSearch(txtDni.Text);
                    break;
            }
            LoadDataGridView();
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
                        sube = sistemaSube.GetSubeFromPasajero(passenger);
                        FormAdminVistaUsuario editarUsuario = new FormAdminVistaUsuario(passenger, sube);
                        editarUsuario.MdiParent = parentForm;
                        editarUsuario.Show();
                        break;
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
        }

        private void FormBuscarUser_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = sistemaPasajero.LoadDataTableWithAllPassengers();
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

        private void FormBuscarUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContainerAdmin admin = (ContainerAdmin)this.MdiParent;
            admin.ShowPictureBox();
        }
    }
}
