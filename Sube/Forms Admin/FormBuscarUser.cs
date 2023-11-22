using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
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
        public FormBuscarUser(ContainerAdmin parent)
        {
            InitializeComponent();
            cmbBuscar.SelectedIndex = 0;
            parentForm = parent;

            DataBase<Pasajero> data = new DataBase<Pasajero>();
            string query = "SELECT * FROM pasajeros";
            Pasajero pasajero = new Pasajero();
            listPassengers = data.Select(query, parameters, pasajero.Map);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo FROM pasajeros INNER JOIN generos ON generos.id = pasajeros.idGender LEFT JOIN tarjetas ON tarjetas.id = pasajeros.idSube";
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            parameters.Clear();
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    int.TryParse(txtDni.Text, out int dni);
                    query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                    FROM pasajeros
                    INNER JOIN
                        generos ON generos.id = pasajeros.idGender
                    LEFT JOIN
                       tarjetas ON tarjetas.id = pasajeros.idSube
                    WHERE 
                    pasajeros.dni LIKE @dniSearch";
                    parameters.Add("@dniSearch", "%" + dni + "%");
                    break;
                case 1:
                    query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                    FROM pasajeros
                    INNER JOIN
                        generos ON generos.id = pasajeros.idGender
                    LEFT JOIN
                       tarjetas ON tarjetas.id = pasajeros.idSube
                    WHERE 
                    pasajeros.name LIKE @Name OR pasajeros.lastname LIKE @LastName";
                    parameters.Add("@Name", "%" + txtName.Text + "%");
                    parameters.Add("@LastName", "%" + txtName.Text + "%");
                    break;
                case 2:
                    query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                    FROM pasajeros
                    INNER JOIN
                        generos ON generos.id = pasajeros.idGender
                    LEFT JOIN
                       tarjetas ON tarjetas.id = pasajeros.idSube
                    WHERE
                    pasajeros.idSube LIKE @Sube";
                    parameters.Add("@Sube", "%" + txtDni.Text + "%");
                    break;
            }
            dataGridView.DataSource = data.Data(query, parameters);
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
                        string querySube = @"SELECT * FROM pasajeros INNER JOIN tarjetas ON tarjetas.id = pasajeros.idSube WHERE idSube = @IdSube AND id = @IdCardNumber";

                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@IdSube", passenger.IdSube },
                            { "@IdCardNumber", passenger.IdSube },
                        };
                        DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();
                        List<TarjetaSube> listSube = new List<TarjetaSube>();
                        listSube = data.Select(querySube, parameters, TarjetaSube.MapTarjetaSube);
                        sube = listSube.FirstOrDefault();

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
            string query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo FROM pasajeros INNER JOIN generos ON generos.id = pasajeros.idGender LEFT JOIN tarjetas ON tarjetas.id = pasajeros.idSube";

            dataGridView.DataSource = data.Data(query, parameters);
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
