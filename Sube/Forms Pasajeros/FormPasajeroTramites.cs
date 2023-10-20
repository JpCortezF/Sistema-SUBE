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
        Dictionary<string, Pasajero> dictionaryPassengers;
        List<Tramites> misTramites;
        Pasajero passenger;
        public FormPasajeroTramites(Pasajero passengerLoged, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.passenger = passengerLoged;
            this.dictionaryPassengers = passengers;
            string rutaT = @"..\..\..\Data";
            string nombreT = "MisTramites.xml";
            string pathT = Path.Combine(rutaT, nombreT);
            this.misTramites = Serializador.ReadXMLTramites(pathT);

            dataGridTramites.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridTramites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridTramites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridTramites.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            string dniUserLoged = passenger.ReturnrKey(dictionaryPassengers, passenger);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("Numero", typeof(string));
            dataTable.Columns.Add("Mensaje", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));
            foreach (Tramites miTramite in misTramites)
            {
                if (miTramite.DniClaimer == dniUserLoged)
                {
                    dataTable.Rows.Add(miTramite.ClaimComplete, miTramite.ClaimId, miTramite.ClaimMessage, miTramite.ClaimTime);
                }
            }
            dataGridTramites.DataSource = dataTable;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
