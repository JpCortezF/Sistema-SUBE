using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Biblioteca_Tramites;
using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sube.Forms_Admin
{
    public partial class FormAdminEstadoTramite : Form
    {
        public event EventHandler UpdateDataGridViewEvent;
        SistemaSube sistemaSube = new SistemaSube();
        SistemaTramite sistemaTramite = new SistemaTramite();

        bool bajaTarjeta;
        Pasajero selectedPassenger;
        Tramites tramite;
        TarjetaSube sube;
        public FormAdminEstadoTramite(Pasajero pasajero, Tramites tramite)
        {
            InitializeComponent();
            selectedPassenger = pasajero;
            this.tramite = tramite;
            sube = sistemaSube.GetSubeFromPasajero(pasajero);
        }


        private void FormAdminEstadoTramite_Load(object sender, EventArgs e)
        {
            cmbTarifa.Items.Clear();
            txtNombre.Text = selectedPassenger.Name;
            txtApellido.Text = selectedPassenger.LastName;
            txtMail.Text = selectedPassenger.Email;
            txtNumTarjeta.Text = sube.CardNumber;
            txtCredito.Text = sube.Balance.ToString();
            txtReclamo.Text = tramite.ClaimMessage;
            foreach (ETarifaSocial item in Enum.GetValues(typeof(ETarifaSocial)))
            {
                string itemString = Enum.GetName(typeof(ETarifaSocial), item);
                cmbTarifa.Items.Add(itemString);
            }
            for (int i = 0; i < cmbTarifa.Items.Count; i++)
            {
                if (cmbTarifa.Items[i].ToString() == sube.TarifaSocial.ToString())
                {
                    cmbTarifa.SelectedIndex = i;
                    break;
                }
            }
        }


        private void btnBajaTarjeta_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Esta seguro dar de baja?\nRecuerde Aprobar los cambios", "Baja de Tarjeta");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                this.bajaTarjeta = true;
            }
        }

        private void btnAprobe_Click(object sender, EventArgs e)
        {
            FormEmergente form = new FormEmergente("Quiere aprobar los cambios?", "Guardar");
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (cmbTarifa.SelectedItem != null)
                {
                    if (Enum.TryParse(cmbTarifa.SelectedItem.ToString(), out ETarifaSocial tarifaSocial))
                    {
                        sube.TarifaSocial = tarifaSocial;
                    }
                }
                if (bajaTarjeta == true)
                {
                    sistemaTramite.TramiteDeleteSube(selectedPassenger);
                }
                else
                {
                    sistemaTramite.UpdateSocialRateSube(sube, tramite.ClaimId, EClaimStatus.Completado);
                }
                OnUpdateDataGridViewEvent(EventArgs.Empty);
                Close();
            }
        }

        private void btnDenegate_Click(object sender, EventArgs e)
        {
            FormEmergente form = new FormEmergente("Desea denegar el tramite?", "Cancelar");
            if (form.ShowDialog() == DialogResult.OK)
            {
                sistemaTramite.UpdateTramiteStatus(tramite.ClaimId, EClaimStatus.Rechazado);
                OnUpdateDataGridViewEvent(EventArgs.Empty);
                Close();
            }
        }
        protected virtual void OnUpdateDataGridViewEvent(EventArgs e)
        {
            UpdateDataGridViewEvent?.Invoke(this, e);
        }

        private void FormAdminEstadoTramite_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateDataGridViewEvent?.Invoke(this, e);
        }
    }
}
