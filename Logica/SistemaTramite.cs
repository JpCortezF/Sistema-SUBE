using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Tramites;
using Biblioteca_Usuarios;
using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SistemaTramite
    {
        DataBase<object> data = new DataBase<object>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        /// <summary>
        /// Carga un DataTable con información de reclamos, incluyendo ID de reclamo, DNI del reclamante, mensaje del reclamo, fecha y estado del reclamo.
        /// Filtra los reclamos por los estados En Revisión y En Proceso.
        /// </summary>
        /// <returns>Un DataTable con la información de los reclamos filtrados.</returns>
        public DataTable LoadDataTable()
        {
            DataTable dt = new DataTable();

            parameters.Clear();

            string query = @"SELECT tramites.idClaim AS IdReclamo, tramites.dniClaimer AS DNI, tramites.claimMessage AS Mensaje, tramites.claimTime AS Fecha, estadoreclamo.name AS Estado
            FROM tramites
            INNER JOIN
                estadoreclamo ON estadoreclamo.id = tramites.idClaimStatus
            WHERE tramites.idClaimStatus = @Revision OR tramites.idClaimStatus = @Proceso";
            parameters.Add("@Revision", EClaimStatus.EnRevision);
            parameters.Add("@Proceso", EClaimStatus.EnProceso);

            dt = data.Data(query, parameters);

            return dt;
        }
        /// <summary>
        /// Inserta un nuevo reclamo en la base de datos asociado a un pasajero, un tipo de reclamo específico y un mensaje de reclamo.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero asociado al reclamo.</param>
        /// <param name="radioButtonTramite">Tipo de reclamo o tarifa social asociada al reclamo.</param>
        /// <param name="claim">Mensaje del reclamo.</param>
        public void InsertClaimIntoDataTable(Pasajero passenger, string radioButtonTramite, string claim)
        {
            string query = @"INSERT INTO tramites (dniClaimer, claimMessage, claimTime, idClaimStatus) 
            VALUES (@Dni, @ClaimMessage, @ClaimTime, @IdClaimStatus)";
            parameters.Add("@Dni", passenger.Dni);
            parameters.Add("@ClaimMessage", $"Reclamo: {radioButtonTramite}  " + claim);
            parameters.Add("@ClaimTime", DateTime.Now);
            parameters.Add("@IdClaimStatus", EClaimStatus.EnProceso);
            data.Update(query, parameters);
        }
        /// <summary>
        /// Inserta un nuevo reclamo en la base de datos asociado a un pasajero, una tarifa social específica y un mensaje de reclamo.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero asociado al reclamo.</param>
        /// <param name="tarifaSocial">Tipo de tarifa social asociada al reclamo.</param>
        /// <param name="claim">Mensaje del reclamo.</param>
        public void InsertClaimIntoDataTable(Pasajero passenger, ETarifaSocial tarifaSocial, string claim)
        {
            string query = @"INSERT INTO tramites (dniClaimer, claimMessage, claimTime, idClaimStatus)
            VALUES (@Dni, @ClaimMessage, @ClaimTime, @IdClaimStatus)";

            parameters.Add("@Dni", passenger.Dni);
            parameters.Add("@ClaimMessage", $"Reclamo: {tarifaSocial}  " + claim);
            parameters.Add("@ClaimTime", DateTime.Now);
            parameters.Add("@IdClaimStatus", EClaimStatus.EnProceso);
            data.Update(query, parameters);
        }
        /// <summary>
        /// Carga un DataTable con información de reclamos asociados a un pasajero específico.
        /// Incluye el número de reclamo, DNI del reclamante, mensaje del reclamo, fecha y estado del reclamo.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero asociado a los reclamos.</param>
        /// <returns>Un DataTable con la información de los reclamos del pasajero.</returns>
        public DataTable LoadClaimDataTable(Pasajero passenger)
        {
            string query = @"SELECT tramites.idClaim AS N°Reclamo, pasajeros.dni AS DNI, tramites.claimMessage AS MensajeReclamo, tramites.claimTime AS Fecha, estadoreclamo.name AS Estado
            FROM tramites 
            INNER JOIN
                  pasajeros ON pasajeros.dni = tramites.dniClaimer
            LEFT JOIN
                  estadoreclamo ON estadoreclamo.id = tramites.idClaimStatus
            WHERE 
                tramites.dniClaimer = @Dni";
            parameters.Add("@Dni", passenger.Dni);

            return data.Data(query, parameters);
        }

        public void UpdateTramiteStatus(int selectedClaimId, EClaimStatus newStatus)
        {
            string queryUpdate = "UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE idClaim = @idClaim";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@UpdateClaimStatus", newStatus },
                { "@idClaim", selectedClaimId }
            };
            data.Update(queryUpdate, parameters);
        }
    }
}
