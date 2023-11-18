using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections;
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
    public partial class FormViajes : Form
    {
        List<Viajes> viajes;
        Pasajero passenger;
        TarjetaSube sube;
        private InicioPasajero parentForm;

        public FormViajes(InicioPasajero parent, Pasajero passenger, TarjetaSube sube)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.sube = sube;
            parentForm = parent;
            string queryViajes = @"
            SELECT viajes.*, lineas.line AS LineValue
            FROM viajes 
            INNER JOIN lineas ON lineas.id = viajes.idLine
            WHERE viajes.idLine = @LineValue AND viajes.idCard = 6061938623643349";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@IdCardNumber", sube.CardNumber },
                { "@LineValue", 85 },
            };
            DataBase<Viajes> data = new DataBase<Viajes>();
            Viajes viaje = new Viajes();
            viajes = data.Select(queryViajes, parameters, Viajes.MapViajes);
        }
        private void FormViajes_Load(object sender, EventArgs e)
        {
            double balance = sube.Balance;
            lblSaldo.Text = $"${balance.ToString("F2")}";
            LoadDataGridView();

            if (viajes.Count == 0)
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
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
            if (txtBusqueda.Text != string.Empty)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("FECHA", typeof(DateTime));
                dt.Columns.Add("Linea", typeof(string));
                dt.Columns.Add("Transporte", typeof(ETransporte));
                dt.Columns.Add("Kilometros", typeof(int));
                dt.Columns.Add("Costo del boleto", typeof(float));
                dt.Columns.Add("Tarifa social", typeof(ETarifaSocial));
                foreach (Viajes viaje in viajes)
                {
                    if (txtBusqueda.Text == viaje.LineasTransporte.ToString())
                    {
                        dt.Rows.Add(viaje.Date, viaje.LineasTransporte, viaje.TipoTransporte, viaje.Kilometres, "-" + viaje.TicketCost, viaje.TarifaSocial);
                    }
                }
                lblFiltro.Visible = true;
                dataGridViajes.DataSource = dt;
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
            foreach (Viajes viaje in viajes)
            {
                dt.Rows.Add(viaje.Date, viaje.LineasTransporte, viaje.TipoTransporte, viaje.Kilometres, "-" + viaje.TicketCost, viaje.TarifaSocial);
            }

            dataGridViajes.DataSource = dt;
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            lblFiltro.Visible = false;
            txtBusqueda.Text = string.Empty;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            TomarTransporte transporte = new TomarTransporte(passenger, mySube);
            transporte.MdiParent = parentForm;
            transporte.Show();
            Close();
            */
        }

        private void FormViajes_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
