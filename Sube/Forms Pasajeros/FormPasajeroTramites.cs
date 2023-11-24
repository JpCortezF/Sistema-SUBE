using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
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
    public partial class FormPasajeroTramites : Form
    {
        Pasajero passenger;
        SistemaTramite sistema = new SistemaTramite();
        public FormPasajeroTramites(Pasajero passengerLoged)
        {
            InitializeComponent();
            this.passenger = passengerLoged;
        }
        public class LimitedTextBox : TextBox
        {
            public LimitedTextBox()
            {
                this.MaxLength = 140;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
            Close();
        }

        private void FormPasajeroTramites_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }

        private void FormPasajeroTramites_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("Numero", typeof(string));
            dataTable.Columns.Add("Mensaje", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));
            dataGridTramites.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridTramites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridTramites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridTramites.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            if(dataGridTramites.Rows.Count == 0)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            dataGridTramites.DataSource = sistema.LoadClaimDataTable(passenger);
        }
    }
}
