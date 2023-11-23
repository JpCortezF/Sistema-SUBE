using Biblioteca_DataBase;
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
        List<Tramites> listTramites = new List<Tramites>();
        DataBase<object> data = new DataBase<object>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();
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
