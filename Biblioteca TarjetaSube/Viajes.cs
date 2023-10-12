using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public class Viajes
    {
        EnumTransporte tipoTransporte;
        double cantidadViajes;
        float ticketCost;
        float kilometres;
        DateTime date;

        public Viajes(float ticketCost, float kilometres, DateTime date, EnumTransporte tipoTransporte)
        {
            this.cantidadViajes = 0;
            this.ticketCost = ticketCost;
            this.kilometres = kilometres;
            this.date = date;
            this.tipoTransporte = tipoTransporte;
        }

        public float TicketCost { get => ticketCost; set => ticketCost = value; }
        public float Kilometres { get => kilometres; set => kilometres = value; }
        public DateTime Date { get => date; set => date = value; }
        public double CantidadViajes { get => cantidadViajes; set => cantidadViajes = value; }
        public EnumTransporte TipoTransporte { get => tipoTransporte; set => tipoTransporte = value; }

    }
}
