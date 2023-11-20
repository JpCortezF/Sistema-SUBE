using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using NPOI.POIFS.Crypt.Dsig;
using Org.BouncyCastle.Asn1.X509;
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
        TarjetaSube sube;
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<DataTable> data = new DataBase<DataTable>();
        DataBase<TarjetaSube> dataSube = new DataBase<TarjetaSube>();

        public FormAdminVistaUsuario(Pasajero pasajero, TarjetaSube sube)
        {
            InitializeComponent();
            selectedPassenger = pasajero;
            this.sube = sube;
            List<TarjetaSube> listSube = new List<TarjetaSube>();

            string queryTarjeta = @"
                SELECT tarifassociales.rate
                FROM tarjetas
                INNER JOIN 
                    tarifassociales ON tarifassociales.id = tarjetas.id
                WHERE 
                    tarifassociales.rate = @SocialRate";
            parameters.Add("@SocialRate", sube.TarifaSocial);

            listSube = dataSube.Select(queryTarjeta, parameters, TarjetaSube.MapTarjetaSube);
            sube = listSube.FirstOrDefault();



            parameters.Clear();
            string query = @"
                SELECT transportes.transport AS Transporte, lineas.line AS Linea, tarifassociales.rate AS TarifaSocial, viajes.ticketCost AS Boleto, viajes.kilometres AS Kilometros, viajes.date AS Fecha
                FROM viajes
                INNER JOIN
                    tarifassociales ON tarifassociales.id = viajes.idSocialRate
                INNER JOIN
                    transportes ON transportes.id = viajes.idTransport
                LEFT JOIN
                    lineas ON lineas.id = viajes.idLine
                WHERE viajes.idCard = @idSube";
            parameters.Add("@idSube", selectedPassenger.IdSube);
            dataGridView1.DataSource = data.Data(query, parameters);
        }

        private void FormAdminVistaUsuario_Load(object sender, EventArgs e)
        {
            cmbTarifa.Items.Clear();
            txtNombre.Text = selectedPassenger.Name;
            txtApellido.Text = selectedPassenger.LastName;
            txtMail.Text = selectedPassenger.Email;
            txtNumTarjeta.Text = selectedPassenger.IdSube;
            txtCredito.Text = sube.Balance.ToString();
            cmbTarifa.Text = sube.TarifaSocial.ToString();


            DataTable dt = new DataTable();
            dt.Columns.Add("Transporte", typeof(string));
            dt.Columns.Add("Linea", typeof(string));
            dt.Columns.Add("Kms", typeof(string));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Precio", typeof(string));

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
    }
}
