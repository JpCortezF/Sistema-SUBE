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

namespace Sube.Forms_Admin
{
    public partial class FormAdminEstadoTramite : Form
    {
        bool bajaTarjeta;
        Pasajero selectedPassenger;
        Tramites tramiteAuxACambiar;
        List<Tramites> tramitesReales;
        public FormAdminEstadoTramite(Pasajero pasajero, Tramites tramiteAux, List<Tramites> tramites)
        {
            InitializeComponent();
            selectedPassenger = pasajero;
            tramiteAuxACambiar = tramiteAux;
            tramitesReales = tramites;
        }

        private void FormAdminEstadoTramite_Load(object sender, EventArgs e)
        {
            cmbTarifa.Items.Clear();
            txtNombre.Text = selectedPassenger.Name;
            txtApellido.Text = selectedPassenger.LastName;
            txtMail.Text = selectedPassenger.Email;
            //txtNumTarjeta.Text = selectedPassenger.MySube.CardNumber;
            //txtCredito.Text = selectedPassenger.MySube.Balance.ToString();
            txtReclamo.Text = tramiteAuxACambiar.ClaimMessage;
            foreach (ETarifaSocial item in Enum.GetValues(typeof(ETarifaSocial)))
            {
                string itemString = Enum.GetName(typeof(ETarifaSocial), item);
                cmbTarifa.Items.Add(itemString);
            }
            for (int i = 0; i < cmbTarifa.Items.Count; i++)
            {
                /*
                if (cmbTarifa.Items[i].ToString() == selectedPassenger.MySube.TarifaSocial.ToString())
                {
                    cmbTarifa.SelectedIndex = i;
                    break;
                }
                */
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
                tramiteAuxACambiar.ClaimComplete = EClaimStatus.Completado;
                if(cmbTarifa.SelectedItem != null)
                {
                    if (Enum.TryParse(cmbTarifa.SelectedItem.ToString(), out ETarifaSocial tarifaSocial))
                    {
                        //selectedPassenger.MySube.TarifaSocial = tarifaSocial;
                    }
                }
                if (bajaTarjeta == true)
                {
                    /*
                    this.bajaTarjeta = true;
                    selectedPassenger.MySube.CardNumber = "DeBaja";
                    selectedPassenger.MySube.QueueTravels.Clear();
                    selectedPassenger.MySube.Balance = 0;
                    selectedPassenger.MySube.TarifaSocial = ETarifaSocial.Ninguna;
                    */
                    string select = @"SELECT idClaim FROM tramites VALUES (@IdClaim) WHERE idClaim = @IdClaim";
                    DataBase<object> data = new DataBase<object>();
                    string update = @"UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE dniClaimer = @Dni;
                    UPDATE pasajeros SET idSube = NULL WHERE id = @idSube";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@Dni", selectedPassenger.Dni },
                        { "@UpdateClaimStatus", EClaimStatus.Completado },
                        { "@idSube", DBNull.Value }
                    };
                    data.Update(update, parameters);
                }
                foreach (Tramites list in tramitesReales)
                {
                    if (tramiteAuxACambiar.ClaimId == list.ClaimId && tramiteAuxACambiar.ClaimComplete != list.ClaimComplete)
                    {
                        list.ClaimComplete = tramiteAuxACambiar.ClaimComplete;
                    }
                }
                Close();
            }
        }

        private void btnDenegate_Click(object sender, EventArgs e)
        {
            FormEmergente form = new FormEmergente("Desea denegar el tramite?", "Cancelar");
            if (form.ShowDialog() == DialogResult.OK)
            {
                tramiteAuxACambiar.ClaimComplete = EClaimStatus.Rechazado;
                foreach (Tramites list in tramitesReales)
                {
                    if (tramiteAuxACambiar.ClaimId == list.ClaimId && tramiteAuxACambiar.ClaimComplete != list.ClaimComplete)
                    {
                        list.ClaimComplete = tramiteAuxACambiar.ClaimComplete;
                    }
                }
                Close();
            }
        }

    }
}
