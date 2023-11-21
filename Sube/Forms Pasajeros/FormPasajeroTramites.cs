using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
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
    public partial class FormPasajeroTramites : Form
    {
        Pasajero passenger;
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<DataTable> data = new DataBase<DataTable>();

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
            dataGridTramites.DataError += dataGridTramites_DataError;
            parameters.Clear();

            string query = @"SELECT tramites.idClaim AS N°Reclamo, pasajeros.dni AS DNI, tramites.claimMessage AS MensajeReclamo, tramites.claimTime AS Fecha, estadoreclamo.name AS Estado
            FROM tramites 
            INNER JOIN
                  pasajeros ON pasajeros.dni = tramites.dniClaimer
            LEFT JOIN
                  estadoreclamo ON estadoreclamo.id = tramites.idClaimStatus
            WHERE 
                tramites.dniClaimer = @Dni";
            parameters.Add("@Dni", passenger.Dni);
            dataGridTramites.DataSource = data.Data(query, parameters);

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
        }
        private void dataGridTramites_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                MessageBox.Show($"Error en la celda {e.ColumnIndex + 1}, fila {e.RowIndex + 1}: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Otra opción: Ignorar el error y continuar
                //e.ThrowException = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el manejo de DataError: {ex.Message}");
            }
        }
    }
}
