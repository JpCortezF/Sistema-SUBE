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
    public partial class FormTramites : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        List<Tramites> listTramites = new List<Tramites>();
        public FormTramites(List<Tramites> tramites, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
            this.listTramites = tramites;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            this.dataGridView1.DataSource = tramites;
            lblCount.Text = tramites.Count.ToString();
        }
        /*
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
                {
                    if (kvp.Value is Pasajero passenger)
                    {
                        if (selectedRow.Cells["DniClaimer"].Value.ToString() == kvp.Key)
                        {               
                            FormAdminVistaUsuario editarUsuario = new FormAdminVistaUsuario(passenger);
                            editarUsuario.Show();
                        }
                    }
                }
                listTramites.RemoveAt(selectedRow.Index);
            }

        }
        */

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string selectedDni = selectedRow.Cells["DniClaimer"].Value.ToString();
                int selectedIndex = listTramites.FindIndex(tramite => tramite.DniClaimer == selectedDni);

                foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
                {
                    if (kvp.Value is Pasajero passenger && selectedDni == kvp.Key)
                    {
                        FormAdminVistaUsuario editarUsuario = new FormAdminVistaUsuario(passenger);
                        editarUsuario.Show();
                        break;
                    }
                }
                if(selectedRow.Cells is not null)
                {
                    listTramites.RemoveAt(selectedIndex);
                }
            }
        }

    }
}
