using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
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
        SistemaAdmin sistemaAdmin = new SistemaAdmin();

        public FormAdminVistaUsuario(Pasajero pasajero, TarjetaSube sube)
        {
            InitializeComponent();
            selectedPassenger = pasajero;
            this.sube = sube;
            dataGridView1.DataSource = sistemaAdmin.ShowPassengerTravels(pasajero);
        }

        private void FormAdminVistaUsuario_Load(object sender, EventArgs e)
        {
           
            cmbTarifa.Items.Clear();
            txtNombre.Text = selectedPassenger.Name;
            txtApellido.Text = selectedPassenger.LastName;
            txtMail.Text = selectedPassenger.Email;
            txtNumTarjeta.Text = selectedPassenger.IdSube;
            if(sube==null)
            {
                txtCredito.Text = string.Empty;
                cmbTarifa.Text = string.Empty;
            }else
            {
                txtCredito.Text = sube.Balance.ToString();
                cmbTarifa.Text = sube.TarifaSocial.ToString();
            }



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
