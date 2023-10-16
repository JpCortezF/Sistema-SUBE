using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public class Viajes
    {
        ETransporte tipoTransporte;
        string lineasTransporte;
        float ticketCost;
        float kilometres;
        DateTime date;

        public Viajes()
        {

        }
        public Viajes(float kilometres, DateTime date, ETransporte tipoTransporte, string lineasTransporte) : this()
        {
            this.kilometres = kilometres;
            this.date = date;
            this.tipoTransporte = tipoTransporte;
            this.lineasTransporte = lineasTransporte;
        }

        public float TicketCost { get => ticketCost; set => ticketCost = value; }
        public float Kilometres { get => kilometres; set => kilometres = value; }
        public DateTime Date { get => date; set => date = value; }
        public ETransporte TipoTransporte { get => tipoTransporte; set => tipoTransporte = value; }
        public string LineasTransporte { get => lineasTransporte; set => lineasTransporte = value; }

        public virtual float CostByKilometres()
        {
            float cost = 0;

            switch (Kilometres)
            {
                case float k when k>=0 && k<=3:
                    cost = 52.96f;
                    break;
                case float k when k >= 3 && k <= 6:
                    cost = 59.00f;
                    break;
                case float k when k >= 6 && k <= 12:
                    cost = 63.54f;
                    break;
                case float k when k >= 12 && k <= 27:
                    cost = 68.09f;
                    break;
            }
            return cost;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {this.date}");
            sb.AppendLine($"Linea: {this.lineasTransporte}");
            sb.AppendLine($"Transporte: {this.tipoTransporte}");
            sb.AppendLine($"Km: {this.kilometres}");

            return sb.ToString();
        }
    }
}
