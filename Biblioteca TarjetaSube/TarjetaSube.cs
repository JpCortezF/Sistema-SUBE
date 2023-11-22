using MySql.Data.MySqlClient;
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
    public class TarjetaSube : IMapeableTarjetaSube<TarjetaSube>
    {
        string _cardNumber;
        float _balance;
        ETarifaSocial tarifaSocial;

        public TarjetaSube()
        {
            this._balance = 0;
            this.tarifaSocial = ETarifaSocial.Ninguna;
        }
        public TarjetaSube(string cardNumber) : this()
        {
            this._cardNumber = cardNumber;
        }
        public TarjetaSube(string cardNumber, float balance, int socialRate):this()
        {
            this._cardNumber = cardNumber;
            this._balance = balance;
            this.tarifaSocial = (ETarifaSocial)Enum.ToObject(typeof(ETarifaSocial), socialRate);           
        }
        public string CardNumber { get => _cardNumber; set => _cardNumber = value; }
        public float Balance { get => _balance; set => _balance = value; }
        public ETarifaSocial TarifaSocial { get => tarifaSocial; set => tarifaSocial = value; }

        public TarjetaSube Map(MySqlDataReader reader)
        {
            string id = reader["id"].ToString() ?? "";
            float balance = Convert.ToSingle(reader["balance"]);
            int socialRate = Convert.ToInt32(reader["socialRate"]);

            return new TarjetaSube(id, balance, socialRate);
        }
    }
}
