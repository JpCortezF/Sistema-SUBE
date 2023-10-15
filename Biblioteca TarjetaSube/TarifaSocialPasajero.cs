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

        public float CostoBoleto { get { return CostByTarifaSocial(); } }

        public TarifaSocialPasajero(float kilometres, DateTime date, ETransporte tipoTransporte, ETarifaSocial miTarifa, List<string> lineasTransporte) 
            : base(kilometres, date, tipoTransporte, lineasTransporte)
        {
            this.tarifaSocial = miTarifa;
        }
        //public TarifaSocialPasajero(ETarifaSocial tarifaSocial, Viajes viaje)
        //    :this(viaje.Kilometres, viaje.Date, viaje.TipoTransporte, tarifaSocial)
        //{
        //}

        private float CostByTarifaSocial()
        {
            float cost = 0;

            switch (tarifaSocial)
            {
                case ETarifaSocial.Ninguna:
                    cost = TicketCost;
                    break;
                case ETarifaSocial.Jubilado:
                    cost = TicketCost * 0.55f;
                    break;
                case ETarifaSocial.Estudiantil:
                    cost = TicketCost * 0.80f;
                    break;
                case ETarifaSocial.ExComatienteDeMalvinas:
                    cost = 0;
                    break;
                case ETarifaSocial.Discapacitado:
                    cost = 0;
                    break;
                default:
                    break;
            }
            return cost;
        }
    }
}
