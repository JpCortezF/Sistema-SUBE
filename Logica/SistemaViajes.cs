using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using NPOI.POIFS.Crypt.Dsig;

namespace Logica
{
    public class SistemaViajes
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<Viajes> data = new DataBase<Viajes>();

        public DataTable SearchDataGridFromDataTable(TarjetaSube sube, string search, int option)
        {
            parameters.Clear();
            if (option == 2)
            {
                string query = @"
                SELECT transportes.transport AS Transporte, lineas.line AS Linea, tarifassociales.rate AS TarifaSocial, viajes.ticketCost AS Boleto, viajes.kilometres AS Kilometros, viajes.date AS Fecha
                FROM viajes
                INNER JOIN
                    tarifassociales ON tarifassociales.id = viajes.idSocialRate
                INNER JOIN
                    transportes ON transportes.id = viajes.idTransport
                LEFT JOIN
                    lineas ON lineas.id = viajes.idLine
                WHERE viajes.idCard = @idCardNumber AND lineas.line = @linea";
                parameters.Add("@idCardNumber", sube.CardNumber);
                parameters.Add("@linea", search);

                return data.Data(query, parameters);
            }
            else
            {
                string query = @"
                SELECT transportes.transport AS Transporte, lineas.line AS Linea, tarifassociales.rate AS TarifaSocial, viajes.ticketCost AS Boleto, viajes.kilometres AS Kilometros, viajes.date AS Fecha
                FROM viajes
                INNER JOIN
                    tarifassociales ON tarifassociales.id = viajes.idSocialRate
                INNER JOIN
                    transportes ON transportes.id = viajes.idTransport
                LEFT JOIN
                    lineas ON lineas.id = viajes.idLine
                WHERE viajes.idCard = @idCardNumber";
                parameters.Add("@idCardNumber", sube.CardNumber);

                return data.Data(query, parameters);
            }
        }
    }
}
