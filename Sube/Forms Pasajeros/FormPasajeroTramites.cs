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
        List<Pasajero> listPassengers;
        List<Tramites> misTramites;
        Pasajero passenger;
        public FormPasajeroTramites(Pasajero passengerLoged, List<Pasajero> listPassengers)
        {
            InitializeComponent();
            this.passenger = passengerLoged;
            this.listPassengers = listPassengers;
            string rutaT = @"..\..\..\Data";
            string nombreT = "MisTramites.xml";
            string pathT = Path.Combine(rutaT, nombreT);
            //SerializadorXML<List<Tramites>> serializeTramite = new SerializadorXML<List<Tramites>>();

            this.misTramites = Serializador.ReadXMLTramites(pathT);
            //this.misTramites = serializeTramite.Deserialize(pathT);
            if (misTramites != null)
            {
                dataGridTramites.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridTramites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridTramites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                foreach (DataGridViewColumn column in dataGridTramites.Columns)
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
           
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Estado", typeof(string));
                dataTable.Columns.Add("Numero", typeof(string));
                dataTable.Columns.Add("Mensaje", typeof(string));
                dataTable.Columns.Add("Fecha", typeof(DateTime));
                foreach (Tramites miTramite in misTramites)
                {
                    if (miTramite.DniClaimer == passengerLoged.Dni)
                    {
                        dataTable.Rows.Add(miTramite.ClaimComplete, miTramite.ClaimId, miTramite.ClaimMessage, miTramite.ClaimTime);
                    }
                }
                dataGridTramites.DataSource = dataTable;
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
    }
}
