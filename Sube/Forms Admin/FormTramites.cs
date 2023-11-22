using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Sube.Forms_Admin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sube
{
    public delegate void UpdateTramiteStatus(int claimId, EClaimStatus nuevoEstado);

    public partial class FormTramites : Form
    {
        List<Tramites> listTramites = new List<Tramites>();
        DataBase<object> data = new DataBase<object>();
        DataBase<Pasajero> dataPassenger = new DataBase<Pasajero>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();


        private ContainerAdmin parentForm;
        public FormTramites(ContainerAdmin parent, List<Tramites> tramites)
        {
            InitializeComponent();
            parentForm = parent;
            this.listTramites = tramites;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedClaimId = 0;
            int selectedIndex = -1;
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    if (selectedRow.Cells["DNI"].Value != null)
                    {
                        int dniPassenger = Convert.ToInt32(selectedRow.Cells["DNI"].Value);
                        
                        selectedClaimId = (int)(selectedRow.Cells["IdReclamo"].Value);
                        selectedIndex = listTramites.FindIndex(tramite => tramite.ClaimId == selectedClaimId);
                        Pasajero passenger = GetPasajeroByDni(dniPassenger);
                        FormAdminEstadoTramite editarUsuario = new FormAdminEstadoTramite(passenger, listTramites[selectedIndex]);
                        editarUsuario.MdiParent = parentForm;
                        //editarUsuario.ActualizarEstadoReclamo += UpdateTramiteStatus;
                        UpdateTramiteStatus(selectedClaimId, EClaimStatus.EnRevision);
                        editarUsuario.UpdateDataGridViewEvent += FormAdminEstadoTramite_UpdateDataGridViewEvent; 
                        editarUsuario.Show();
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
        private void UpdateTramiteStatus(int selectedClaimId, EClaimStatus newStatus)
        {
            string queryUpdate = "UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE idClaim = @idClaim";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UpdateClaimStatus", newStatus },
                { "@idClaim", selectedClaimId }
            };
            data.Update(queryUpdate, parameters);
        }
        private Pasajero GetPasajeroByDni(int dniPassenger)
        {
            string query = "SELECT * FROM pasajeros WHERE dni = @selectedDni";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@selectedDni", dniPassenger }
            };
            List<Pasajero> listPassengers = dataPassenger.Select(query, parameters, Pasajero.MapPasajero);
            return listPassengers.FirstOrDefault();
        }
        private async void FormAdminEstadoTramite_UpdateDataGridViewEvent(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
        private async void FormTramites_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            parameters.Clear();

            string query = @"SELECT tramites.idClaim AS IdReclamo, tramites.dniClaimer AS DNI, tramites.claimMessage AS Mensaje, tramites.claimTime AS Fecha, estadoreclamo.name AS Estado
            FROM tramites
            INNER JOIN
                estadoreclamo ON estadoreclamo.id = tramites.idClaimStatus
            WHERE tramites.idClaimStatus = @Revision OR tramites.idClaimStatus = @Proceso";
            parameters.Add("@Revision", EClaimStatus.EnRevision);
            parameters.Add("@Proceso", EClaimStatus.EnProceso);

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            await Task.Delay(2000);

            DataTable result = await GetDataAsync(query, parameters);

            dataGridView1.DataSource = result;

            lblCount.Text = dataGridView1.Rows.Count.ToString();

            Loading gif = new Loading();
            gif.ShowDialog();
            if (gif.DialogResult == DialogResult.OK)
            {

            }
        }
        private async Task<DataTable> GetDataAsync(string query, Dictionary<string, object> parameters)
        {
            return await Task.Run(() => data.Data(query, parameters));
        }
    }
}
