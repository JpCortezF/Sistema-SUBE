using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Sube.Forms_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sube
{
    public partial class FormTramites : Form
    {
        List<Pasajero> listPassengers;
        List<Tramites> listTramites = new List<Tramites>();
        List<Tramites> listTramitesAux = new List<Tramites>();
        private ContainerAdmin parentForm;
        public FormTramites(ContainerAdmin parent, List<Tramites> tramites, List<Pasajero> listPassengers)
        {
            InitializeComponent();
            parentForm = parent;
            this.listPassengers = listPassengers;
            this.listTramites = tramites;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            foreach (Tramites tramite in tramites)
            {
                if (tramite.ClaimComplete == EClaimStatus.EnRevision || tramite.ClaimComplete == EClaimStatus.EnProceso)
                {
                    listTramitesAux.Add(tramite);   
                    
                }
            }
            this.dataGridView1.DataSource = listTramitesAux;
            lblCount.Text = listTramitesAux.Count.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                
                string selectedDni = null;
                int selectedIndex = -1;
                int selectedClaimId = 0;
                listTramitesAux.Clear();
                foreach (Tramites tramite in listTramites)
                {
                    if (tramite.ClaimComplete == EClaimStatus.EnRevision || tramite.ClaimComplete == EClaimStatus.EnProceso)
                    {
                        listTramitesAux.Add(tramite);

                    }
                }
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    if (selectedRow.Cells["DniClaimer"].Value != null)
                    {
                        selectedDni = selectedRow.Cells["DniClaimer"].Value.ToString();
                        selectedClaimId = (int)(selectedRow.Cells["ClaimId"].Value);
                        selectedIndex = listTramitesAux.FindIndex(tramite => tramite.ClaimId == selectedClaimId);
                        listTramitesAux[selectedIndex].ClaimComplete = EClaimStatus.EnRevision;
                    }
                    foreach (Pasajero passenger in listPassengers)
                    {
                        if (selectedDni == passenger.Dni.ToString())
                        {
                            FormAdminEstadoTramite editarUsuario = new FormAdminEstadoTramite(passenger, listTramitesAux[selectedIndex], listTramites);
                            editarUsuario.MdiParent = parentForm;
                            editarUsuario.Show();
                            Close();
                            break;
                        }
                    }

                    foreach (Tramites list in listTramites)
                    {
                        if (listTramitesAux[selectedIndex].ClaimId == list.ClaimId && listTramitesAux[selectedIndex].ClaimComplete != list.ClaimComplete)
                        {
                            list.ClaimComplete = listTramitesAux[selectedIndex].ClaimComplete;
                        }
                    }

                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
