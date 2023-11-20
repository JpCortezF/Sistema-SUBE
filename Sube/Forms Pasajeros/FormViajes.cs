using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormViajes : Form
    {
        Pasajero passenger;
        TarjetaSube sube;
        private InicioPasajero parentForm;
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<DataTable> data = new DataBase<DataTable>();

        public FormViajes(InicioPasajero parent, Pasajero passenger, TarjetaSube sube)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.sube = sube;
            parentForm = parent;
        }
        private void FormViajes_Load(object sender, EventArgs e)
        {
            parameters.Clear();
            if (sube != null)
            {
                string query = @"
                SELECT transportes.transport AS Transporte, lineas.line AS Linea, tarifassociales.rate AS TarifaSocial, viajes.ticketCost AS Boleto, viajes.kilometres AS Kilometros, viajes.date AS Fecha
                FROM viajes
                INNER JOIN
                    tarifassociales ON tarifassociales.id = viajes.idSocialRate
                INNER JOIN
                    transportes ON transportes.id = viajes.idTransport
                LEFT JOIN
                    lineas ON lineas.id = viajes.idLine
                WHERE viajes.idCard = @idCardNumber";
                parameters.Add("@idCardNumber", sube.CardNumber);


                dataGridViajes.DataSource = data.Data(query, parameters);
                LoadDataGridView();

                double balance = sube.Balance;
                lblSaldo.Text = $"${balance.ToString("F2")}";
            
                if (dataGridViajes.Rows.Count == 1)
                {
                    dataGridViajes.Visible = false;
                    pictureBox1.Visible = true;
                    lblViajes.Visible = true;
                    linkLabel1.Visible = true;
                }
                else
                {
                    dataGridViajes.Visible = true;
                    pictureBox1.Visible = false;
                    lblViajes.Visible = false;
                    linkLabel1.Visible = false;
                }
            }
            else
            {
                lblSaldo.Text = "  $0";
            }
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
            if (txtBusqueda.Text != string.Empty)
            {
                dataGridViajes.DataSource = null;
                dataGridViajes.Refresh();
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
                WHERE viajes.idCard = @idCardNumber AND lineas.line = @linea";
                parameters.Add("@idCardNumber", sube.CardNumber);
                parameters.Add("@linea", txtBusqueda.Text);

                lblFiltro.Visible = true;
                dataGridViajes.DataSource = data.Data(query, parameters);
                LoadDataGridView();
            }         
        }
        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FECHA", typeof(DateTime));
            dt.Columns.Add("Linea", typeof(string));
            dt.Columns.Add("Transporte", typeof(ETransporte));
            dt.Columns.Add("Kilometros", typeof(int));
            dt.Columns.Add("Costo del boleto", typeof(float));
            dt.Columns.Add("Tarifa social", typeof(ETarifaSocial));

            dataGridViajes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViajes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViajes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridViajes.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {
            FormViajes_Load(sender, e);
            lblFiltro.Visible = false;
            txtBusqueda.Text = string.Empty;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TomarTransporte transporte = new TomarTransporte(passenger, sube);
            transporte.MdiParent = parentForm;
            transporte.Show();
        }

        private void FormViajes_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
