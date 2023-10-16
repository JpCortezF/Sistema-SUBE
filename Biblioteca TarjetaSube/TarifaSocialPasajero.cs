using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public class TarifaSocialPasajero : Viajes
    {
        ETarifaSocial tarifaSocial;
        public TarifaSocialPasajero(float kilometres, DateTime date, ETransporte tipoTransporte, ETarifaSocial miTarifa, string lineasTransporte, float ticketCost) 
            : base(kilometres, date, tipoTransporte, lineasTransporte, ticketCost)
        {
            this.tarifaSocial = miTarifa;
        }
        public TarifaSocialPasajero(ETarifaSocial tarifaSocial, Viajes viaje)
            : this(viaje.Kilometres, viaje.Date, viaje.TipoTransporte, tarifaSocial, viaje.LineasTransporte, viaje.TicketCost)
        {
        }

        public override float CostByKilometres()
        {
            float cost = base.CostByKilometres();

            CostByTarifa(cost);
            return cost;
        }
        public float ReturnTicketCost(ETransporte transporte)
        {
            float ticket = 0;

            switch (transporte)
            {
                case ETransporte.Colectivo:
                    ticket = CostByKilometres();
                    break;
                case ETransporte.Subte:
                    ticket = CostByTarifa(80);
                    break;
                case ETransporte.Tren:
                    ticket = CostByTarifa(90);
                    break;
            }
            TicketCost = ticket;
            return ticket;
        }
        public float CostByTarifa(float ticket)
        {            
            switch (tarifaSocial)
            {
                case ETarifaSocial.Ninguna:
                    break;
                case ETarifaSocial.Jubilado:
                    ticket = ticket * 0.55f;
                    break;
                case ETarifaSocial.Estudiantil:
                    ticket = ticket * 0.80f;
                    break;
                case ETarifaSocial.ExComatienteDeMalvinas:
                    ticket = 0;
                    break;
                case ETarifaSocial.Discapacitado:
                    ticket = 0;
                    break;
                default:
                    break;
            }
            return ticket;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tarifa Social: {this.tarifaSocial}");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Boleto: {ReturnTicketCost(TipoTransporte)}");

            return sb.ToString();
        }
    }
}
