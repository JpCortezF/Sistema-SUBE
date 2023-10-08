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
        public string _cardNumber;
        public float _balance;
        public EnumTarifaSocial tarifaSocial;

        public TarjetaSube(string cardNumber, EnumTarifaSocial tarifaSocial)
        {
            this._cardNumber = cardNumber;
            this._balance = 0;
            this.tarifaSocial = tarifaSocial;
        }
        [JsonIgnore]
        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        [JsonIgnore]
        public float Balance { get => _balance; set => _balance = value; }
        [JsonIgnore]
        public EnumTarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }
    }
}
