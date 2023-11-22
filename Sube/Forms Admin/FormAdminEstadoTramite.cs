using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
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

namespace Sube.Forms_Admin
{
    public partial class FormAdminEstadoTramite : Form
    {
        // public event UpdateTramiteStatus ActualizarEstadoReclamo;
        public event EventHandler UpdateDataGridViewEvent;


        bool bajaTarjeta;
        Pasajero selectedPassenger;
        Tramites tramite;
        TarjetaSube sube;
        public FormAdminEstadoTramite(Pasajero pasajero, Tramites tramite)
        {
            InitializeComponent();
            selectedPassenger = pasajero;
            this.tramite = tramite;
            string querySube = @"SELECT * FROM pasajeros INNER JOIN tarjetas ON tarjetas.id = pasajeros.idSube WHERE idSube = @IdSube AND id = @IdCardNumber";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@IdSube", pasajero.IdSube },
                { "@IdCardNumber", pasajero.IdSube },
            };
            DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();
            List<TarjetaSube> listSube = new List<TarjetaSube>();
            listSube = data.Select(querySube, parameters, TarjetaSube.MapTarjetaSube);
            sube = listSube.FirstOrDefault();
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
                DataBase<object> data = new DataBase<object>();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (cmbTarifa.SelectedItem != null)
                {
                    if (Enum.TryParse(cmbTarifa.SelectedItem.ToString(), out ETarifaSocial tarifaSocial))
                    {
                        sube.TarifaSocial = tarifaSocial;
                    }
                }
                if (bajaTarjeta == true)
                {
                    string update = @"UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE dniClaimer = @Dni;
                    UPDATE pasajeros SET idSube = @idSubeNull WHERE idSube = @idSubeNotNull";

                    parameters.Add("@Dni", selectedPassenger.Dni);
                    parameters.Add("@UpdateClaimStatus", EClaimStatus.Completado);
                    parameters.Add("@idSubeNull", DBNull.Value);
                    parameters.Add("@idSubeNotNull", selectedPassenger.IdSube);

                    data.Update(update, parameters);
                    parameters.Clear();
                    string delete = @"DELETE FROM viajes WHERE idCard = @idSube;
                    DELETE FROM tarjetas WHERE id = @CardNumber";
                    parameters.Add("@idSube", selectedPassenger.IdSube);
                    parameters.Add("@CardNumber", selectedPassenger.IdSube);
                    data.Delete(delete, parameters);
                    parameters.Clear();
                }
                else
                {
                    parameters.Clear();
                    string update = @"
                        UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE idClaim = @IdClaim;
                        UPDATE tarjetas SET socialRate =  @IdSocialRate";
                    parameters.Add("@IdClaim", tramite.ClaimId);
                    parameters.Add("@UpdateClaimStatus", EClaimStatus.Completado);
                    parameters.Add("@IdSocialRate", sube.TarifaSocial);
                    data.Update(update, parameters);
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
                DataBase<object> data = new DataBase<object>();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Clear();
                string update = @"
                        UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE idClaim = @IdClaim;";
                parameters.Add("@IdClaim", tramite.ClaimId);
                parameters.Add("@UpdateClaimStatus", EClaimStatus.Rechazado);
                data.Update(update, parameters);
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
