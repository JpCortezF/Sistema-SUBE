using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using SubeEvent;
using Biblioteca_Usuarios;
using NPOI.POIFS.Crypt.Dsig;

namespace Logica
{
        public delegate void SubeGoldSuscription(Viajes viaje, SubeEvento e);
    public class SistemaViajes
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<Viajes> data = new DataBase<Viajes>();
        public event SubeGoldSuscription DiscountGoldEvent;


        /// <summary>
        /// Busca y filtra información de viajes asociados a una tarjeta SUBE en un DataTable.
        /// La búsqueda puede ser por línea de transporte específica o todos los viajes de la tarjeta.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube asociado a los viajes.</param>
        /// <param name="search">Criterio de búsqueda, como la línea de transporte (puede ser nulo).</param>
        /// <param name="option">Opción que indica si se filtra por línea de transporte (2) o no (cualquier otro valor).</param>
        /// <returns>Un DataTable con la información de los viajes filtrados.</returns>
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
        public int CountTravels(TarjetaSube sube)
        {
            int totalTravels = 0;

            Viajes viaje = new Viajes();
            string query = @"SELECT * FROM viajes
            WHERE viajes.idCard = @idCardNumber";
            parameters.Clear();
            parameters.Add("@idCardNumber", sube.CardNumber);
            List<Viajes> listaViajes = data.Select(query, parameters, viaje.Map);
            totalTravels = listaViajes.Count + 1;
            return totalTravels;
        }
        public Viajes CountTravelsWithSubeGold(TarjetaSube sube, Viajes viaje, int travels)
        {
            if (sube.TarifaSocial == ETarifaSocial.SubeGold)
            {
                SubeEvento evento = new SubeEvento();
                evento.TravelsCount = travels;
                DiscountGoldEvent?.Invoke(viaje, evento);
            }
            return viaje; 
        }
        public void HandleDiscountGoldEvent(Viajes viaje, SubeEvento e)
        {
            if (e.TravelsCount >= 5 && e.TravelsCount <= 10)
            {
                viaje.TicketCost = 0;
            }
        }
        public void DeleteTravels(TarjetaSube sube)
        {
            parameters.Clear();
            string delete = @"DELETE FROM viajes WHERE idCard = @idSube";
            parameters.Add("@CardNumber", sube.CardNumber);
            data.Delete(delete, parameters);
        }
    }
}
