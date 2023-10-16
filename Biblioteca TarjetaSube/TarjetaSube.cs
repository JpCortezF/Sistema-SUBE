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


        public string MostrarQueue(Queue<Viajes> queueViajes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mis viajes: ");
            foreach (Viajes viaje in queueViajes)
            {
                 sb.Append($"{viaje}, "); 
            }
            if (queueViajes.Count > 0)
            {
                sb.Length -= 2;
            }
            return sb.ToString();
        }
    }
}
