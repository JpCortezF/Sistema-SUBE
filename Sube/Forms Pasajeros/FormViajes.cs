using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
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
        SistemaViajes sistema = new SistemaViajes();

        public FormViajes(InicioPasajero parent, Pasajero passenger, TarjetaSube sube)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.sube = sube;
            parentForm = parent;
        }
        private void FormViajes_Load(object sender, EventArgs e)
        {
            dataGridViajes.DataError += dataGridViajes_DataError;
            if (sube != null)
            {
                dataGridViajes.DataSource = sistema.SearchDataGridFromDataTable(sube, txtBusqueda.Text, 1);
                LoadDataGridView();

                double balance = sube.Balance;
                lblSaldo.Text = $"${balance.ToString("F2")}";

                if (dataGridViajes.Rows.Count == 0)
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
                dataGridViajes.DataSource = sistema.SearchDataGridFromDataTable(sube, txtBusqueda.Text, 2);
                lblFiltro.Visible = true;
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
        private void dataGridViajes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                MessageBox.Show($"Error en la celda {e.ColumnIndex + 1}, fila {e.RowIndex + 1}: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Otra opción: Ignorar el error y continuar
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el manejo de DataError: {ex.Message}");
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
            transporte.FormClosed += (s, args) =>
            {
                if (!Visible)
                {
                    Show();
                    Close();
                }
            };
            transporte.Show();
            Hide();
        }
        private void FormViajes_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
