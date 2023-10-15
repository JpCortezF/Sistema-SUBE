using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public class Viajes
    {
        List<string> lineasTransporte;
        ETransporte tipoTransporte;
        static int cantidadViajes;
        float ticketCost;
        float kilometres;
        DateTime date;

        public static int CantidadViajes()
        {
            return cantidadViajes++;
        }
        public Viajes(float kilometres, DateTime date, ETransporte tipoTransporte, List<string> lineasTransporte)
        {
            this.kilometres = kilometres;
            this.date = date;
            this.tipoTransporte = tipoTransporte;
            this.lineasTransporte = lineasTransporte;
        }
        public Viajes(float ticketCost, float kilometres, DateTime date, ETransporte tipoTransporte, List<string> lineasTransporte)
            : this(kilometres, date, tipoTransporte, lineasTransporte)
        {
            this.ticketCost = ticketCost;
        }

        public float TicketCost { get => ticketCost; set => ticketCost = value; }
        public float Kilometres { get => kilometres; set => kilometres = value; }
        public DateTime Date { get => date; set => date = value; }
        public ETransporte TipoTransporte { get => tipoTransporte; set => tipoTransporte = value; }
        public List<string> LineasTransporte { get => lineasTransporte; set => lineasTransporte = value; }
    }
}
