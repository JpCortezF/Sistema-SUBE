using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExceptions;
using MySql.Data.MySqlClient;

namespace Biblioteca_TarjetaSube
{
    public class Viajes : IMapeableTarjetaSube<Viajes>
    {
        int idTravel;
        ETransporte tipoTransporte;
        int lineasTransporte;
        ETarifaSocial tarifaSocial;
        float ticketCost;
        float kilometres;
        DateTime date;

        public Viajes(){}
        public Viajes(float kilometres, ETransporte tipoTransporte)
        {
            this.kilometres = kilometres;
            this.tipoTransporte = tipoTransporte;
        }
        public Viajes(int idTravel, int tipoTransporte, int lineasTransporte, int tarifaSocial, float ticketCost, float kilometres, DateTime date)
        {
            this.idTravel = idTravel;
            this.tipoTransporte = (ETransporte)Enum.ToObject(typeof(ETransporte), tipoTransporte);
            this.lineasTransporte = lineasTransporte;
            this.tarifaSocial = (ETarifaSocial)Enum.ToObject(typeof(ETarifaSocial), tarifaSocial);
            this.ticketCost = ticketCost;
            this.kilometres = kilometres;
            this.date = date;
        }

        public float TicketCost { get => ticketCost; set => ticketCost = value; }
        public float Kilometres { get => kilometres; set => kilometres = value; }
        public DateTime Date { get => date; set => date = value; }
        public ETransporte TipoTransporte { get => tipoTransporte; set => tipoTransporte = value; }
        public int LineasTransporte { get => lineasTransporte; set => lineasTransporte = value; }
        public ETarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }
        public int IdTravel { get => idTravel; }

        /// <summary>
        /// Calcula el costo de un servicio basado en la distancia en kilómetros.
        /// </summary>
        /// <returns>El costo del servicio calculado en función de la cantidad de kilómetros. Si la cantidad de kilómetros no está dentro de los rangos especificados, se lanza una excepción.</returns>

        public virtual float CostByKilometres(Viajes miViaje)
        {
            float cost = 0;

            switch (miViaje.Kilometres)
            {
                case 0:
                    throw new KilometrosException("El viaje no pueden ser 0km");
                case float k when k > 0 && k <= 3:
                    cost = PrecioViajes.ValorColectivo0To3Km;
                    break;
                case float k when k > 3 && k <= 6:
                    cost = PrecioViajes.ValorColectivo3To6Km;
                    break;
                case float k when k > 6 && k <= 12:
                    cost = PrecioViajes.ValorColectivo6To12Km;
                    break;
                case float k when k > 12 && k < 27:
                    cost = PrecioViajes.ValorColectivo12To27Km;
                    break;
                default:
                    throw new KilometrosException("La cantidad de kilómetros excede el límite permitido (27 km).");
            }
            return cost;
        }


        public Viajes Map(MySqlDataReader reader)
        {
            int idTravel = Convert.ToInt32(reader["idTravel"]);
            int tipoTransporte = Convert.ToInt32(reader["idTransport"]);
            int idLine = Convert.ToInt32(reader["idLine"]);
            int socialRate = Convert.ToInt32(reader["idSocialRate"]);
            float ticketcost = Convert.ToSingle(reader["ticketcost"]);
            float kilometres = Convert.ToSingle(reader["kilometres"]);
            DateTime date = Convert.ToDateTime(reader["date"]);

            return new Viajes(idTravel, tipoTransporte, idLine, socialRate, ticketcost, kilometres, date);
        }
    }
}
