using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca_TarjetaSube
{
    public class TarjetaSube
    {
        string _cardNumber;
        float _balance;
        Queue<Viajes> queueTravels;
        ETarifaSocial tarifaSocial;

        public TarjetaSube()
        {
            queueTravels = new Queue<Viajes>();
        }
        public TarjetaSube(string cardNumber) : this()
        {
            this.tarifaSocial = ETarifaSocial.Ninguna;
            this._cardNumber = cardNumber;
            this._balance = 0;
        }

        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public float Balance { get => _balance; set => _balance = value; }
        public Queue<Viajes> QueueTravels { get => queueTravels; set => queueTravels = value; }
        public ETarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }





        public Queue<Viajes> historialViajes(Viajes viaje)
        {
            Queue<Viajes> miQueue = new Queue<Viajes>();

            miQueue.Enqueue(viaje);

            return miQueue;
        }
    }
}
