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
        Tramites tramite = new Tramites();
        List<Tramites> tramites = new List<Tramites>();
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
        /// <summary>
        /// Elimina la asociación de una tarjeta SUBE con un pasajero, y borra registros asociados en las tablas de viajes, tarjetas y trámites.
        /// </summary>
        /// <param name="pasajero">Objeto Pasajero con información relacionada.</param>
        public void TramiteDeleteSube(Pasajero pasajero)
        {
            parameters.Clear();
            string update = @"UPDATE pasajeros SET idSube = @idSubeNull WHERE idSube = @idSubeNotNull";

            parameters.Add("@idSubeNull", DBNull.Value);
            parameters.Add("@idSubeNotNull", pasajero.IdSube);
            data.Update(update, parameters);
            parameters.Clear();
            string delete = @"DELETE FROM viajes WHERE idCard = @idSube;
                    DELETE FROM tarjetas WHERE id = @CardNumber;
                    DELETE FROM tramites WHERE dniClaimer = @Dni";
            parameters.Add("@idSube", pasajero.IdSube);
            parameters.Add("@CardNumber", pasajero.IdSube);
            parameters.Add("@Dni", pasajero.Dni);
            data.Delete(delete, parameters);
        }
        /// <summary>
        /// Actualiza el valor de la tarifa social en la tabla de tarjetas SUBE y actualiza el estado de un trámite en la tabla de trámites.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube con la información de la tarjeta SUBE.</param>
        /// <param name="claimId">ID del trámite asociado.</param>
        /// <param name="status">Nuevo estado del trámite.</param>
        public void UpdateSocialRateSube(TarjetaSube sube, int claimId, EClaimStatus status)
        {
            parameters.Clear();
            UpdateTramiteStatus(claimId, status);
            string update = @"UPDATE tarjetas SET socialRate =  @IdSocialRate";
            parameters.Add("@IdSocialRate", sube.TarifaSocial);
            data.Update(update, parameters);
        }
        /// <summary>
        /// Actualiza el estado de un trámite en la tabla de trámites.
        /// </summary>
        /// <param name="claimId">ID del trámite a actualizar.</param>
        /// <param name="status">Nuevo estado del trámite.</param>
        public void UpdateTramiteStatus(int claimId, EClaimStatus status)
        {
            parameters.Clear();
            string update = @"
            UPDATE tramites SET idClaimStatus = @UpdateClaimStatus WHERE idClaim = @IdClaim";
            parameters.Add("@IdClaim", claimId);
            parameters.Add("@UpdateClaimStatus", status);
            data.Update(update, parameters);
        }
        /// <summary>
        /// Actualiza el tipo de tarifa social a "SUBE Gold" en la tabla de tarjetas SUBE.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube con la información de la tarjeta SUBE.</param>
        public void UpdateSubeGold(TarjetaSube sube)
        {
            parameters.Clear();
            string update = @"
            UPDATE tarjetas SET idSocialRate = @SubeGold WHERE id = @CardNumber";
            parameters.Add("@CardNumber", sube.CardNumber);
            parameters.Add("@SubeGold", ETarifaSocial.SubeGold);
            data.Update(update, parameters);
        }
        /// <summary>
        /// Obtiene todos los registros de trámites desde la tabla de trámites.
        /// </summary>
        /// <returns>Lista de objetos Tramites con la información de los trámites.</returns>
        public List<Tramites> GetAllTramites()
        {
            DataBase<Tramites> data = new DataBase<Tramites>();
            parameters.Clear();
            string query = @"SELECT * FROM tramites";
            this.tramites = data.Select(query, parameters, tramite.Map);
            return tramites;
        }
    }
}
