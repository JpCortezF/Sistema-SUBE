using Newtonsoft.Json;
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
        EnumTarifaSocial tarifaSocial;

        public TarjetaSube(string cardNumber, EnumTarifaSocial tarifaSocial)
        {
            this._cardNumber = cardNumber;
            this._balance = 0;
            this.tarifaSocial = tarifaSocial;
        }

        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public float Balance { get => _balance; set => _balance = value; }
        public EnumTarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }
    }
}
