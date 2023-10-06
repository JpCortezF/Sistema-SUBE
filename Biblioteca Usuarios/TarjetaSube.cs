using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public class TarjetaSube
    {
        string _cardNumber;
        float _balance;
        private Enum tipoPasajero;

        public TarjetaSube(string cardNumber, Enum tipoPasajero)
        {
            _cardNumber = cardNumber;
            _balance = 0;
            this.tipoPasajero = tipoPasajero;
        }

        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public float Balance { get => _balance; set => _balance = value; }
        public Enum TipoPasajero { get => tipoPasajero; set => tipoPasajero = value; }


    }
}
