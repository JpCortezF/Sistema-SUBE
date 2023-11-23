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

        public TarifaSocialPasajero(ETarifaSocial miTarifa)
        {
            this.tarifaSocial = miTarifa;
        }
        public TarifaSocialPasajero(float kilometres, DateTime date, ETransporte tipoTransporte, ETarifaSocial miTarifa, int lineasTransporte, float ticketCost) 
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

            cost = CostByTarifa(cost);
            return cost;
        }
        /// <summary>
        /// Calcula el costo de un boleto de transporte público en base al tipo de transporte especificado.
        /// </summary>
        /// <param name="transporte">El tipo de transporte, que puede ser Colectivo, Subte o Tren.</param>
        /// <returns>El costo del boleto calculado.</returns>
        public float ReturnTicketCost(ETransporte transporte)
        {
            float ticket = 0;

            switch (transporte)
            {
                case ETransporte.Colectivo:
                    ticket = CostByKilometres();
                    break;
                case ETransporte.Subte:
                    ticket = CostByTarifa(PrecioViajes.ValorSubte);
                    break;
                case ETransporte.Tren:
                    ticket = CostByTarifa(PrecioViajes.ValorTren);
                    break;
            }
            return ticket;
        }
        /// <summary>
        /// Calcula el costo de un boleto de transporte público en base a una tarifa social específica.
        /// </summary>
        /// <param name="ticket">El costo base del boleto antes de aplicar la tarifa social.</param>
        /// <returns>El costo del boleto después de aplicar la tarifa social correspondiente.</returns>
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
                    ticket = PrecioViajes.ValorSinSubsidio;
                    break;
            }
            return ticket;
        }
    }
}
