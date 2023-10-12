using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca_TarjetaSube
{
    public class TarjetaSube
    {
        string _cardNumber;
        float _balance;
        EnumTarifaSocial tarifaSocial;
        Queue<Viajes> queueTravels;

        public TarjetaSube(string cardNumber, EnumTarifaSocial tarifaSocial)
        {
            this._cardNumber = cardNumber;
            this._balance = 0;
            this.tarifaSocial = tarifaSocial;
            queueTravels = new Queue<Viajes>();
        }

        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public float Balance { get => _balance; set => _balance = value; }
        public EnumTarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }
        public Queue<Viajes> QueueTravels { get => queueTravels; }
        public float CostoTicketPorColectivo { get { return ReturnTicketCost(EnumTransporte.Colectivo); } }

        public float ReturnTicketCost(EnumTransporte transporte)
        {
            float ticket = 0;

            switch (transporte)
            {
                case EnumTransporte.Colectivo:
                    ticket = 6.25f;
                    break;
                case EnumTransporte.Subte:
                    ticket = 5.50f;
                    break;
                case EnumTransporte.Tren:
                    ticket = 5.25f;
                    break;
            }
                       
            return ticket;
        }

        public Queue<Viajes> historialViajes(Viajes viaje)
        {
            Queue<Viajes> miQueue = new Queue<Viajes>();

            miQueue.Enqueue(viaje);

            return miQueue;
        }




    }
}
