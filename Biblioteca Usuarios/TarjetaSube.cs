using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca_Usuarios
{
    public class TarjetaSube
    {
        string _cardNumber;
        float _balance;
        EnumTarifaSocial tarifaSocial;
        Queue<Viajes> travels;

        public TarjetaSube(string cardNumber, EnumTarifaSocial tarifaSocial)
        {
            this._cardNumber = cardNumber;
            this._balance = 0;
            this.tarifaSocial = tarifaSocial;
        }

        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public float Balance { get => _balance; set => _balance = value; }
        public EnumTarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }
        public Queue<Viajes> Travels { get => travels; set => travels = value; }


        public Queue<Viajes> historialViajes(Viajes viaje)
        {
            Queue<Viajes> miQueue = new Queue<Viajes>();

            miQueue.Enqueue(viaje);

            return miQueue;
        }




    }
}
