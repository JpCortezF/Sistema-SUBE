using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Biblioteca_Tramites;
using Logica;
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
        SistemaTramite sistemaTramite = new SistemaTramite();
        SistemaPasajero sistemaPasajero = new SistemaPasajero();

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
                        Pasajero passenger = sistemaPasajero.GetPasajeroByDni(dniPassenger);
                        FormAdminEstadoTramite editarUsuario = new FormAdminEstadoTramite(passenger, listTramites[selectedIndex]);
                        editarUsuario.MdiParent = parentForm;
                        sistemaTramite.UpdateTramiteStatus(selectedClaimId, EClaimStatus.EnRevision);
                        editarUsuario.UpdateDataGridViewEvent += FormTramites_Load;
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

        private async void FormTramites_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            Loading gif = new Loading();
            gif.Show(this);

            DataTable result = await GetDataAsync();

            await Task.Delay(2000);

            gif.Close();

            dataGridView1.DataSource = result;

            lblCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private async Task<DataTable> GetDataAsync()
        {
            return await Task.Run(() => sistemaTramite.LoadDataTable());
        }

        private void FormTramites_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContainerAdmin admin = (ContainerAdmin)this.MdiParent;
            admin.ShowPictureBox();
        }
    }
}
