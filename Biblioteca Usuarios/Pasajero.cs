using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public class Pasajero : Usuario
    {
        Dictionary<string, Usuario> dictionaryPassengers;
        string document;
        string gender;
        string cardNumber;

        public Pasajero(string email, string password) : base(email, password)
        {
            this.DictionaryPassengers = new Dictionary<string, Usuario>();
            this.document = string.Empty;
            this.gender = string.Empty;
            this.cardNumber = string.Empty;
        }
        public Pasajero(string document, string gender, string cardNumber, string email, string password) : this(email, password)
        {
            this.document = document;
            this.gender = gender;
            this.cardNumber = cardNumber;
        }


        public string Document { get => document; set => document = value; }
        public string Gender { get => gender; set => gender = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public Dictionary<string, Usuario> DictionaryPassengers { get => dictionaryPassengers; set => dictionaryPassengers = value; }

        /// <summary>
        /// Si la Key ya existe en el Dictionary, significa que ya hay un pasajero con ese número de documento.
        ///  Si la Key no existe, se agrega el pasajero al Dictionary usando el número de documento como clave.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="passenger"></param>
        /// <returns>  y se establece result en false. </returns>
        public static bool operator +(Dictionary<string, Usuario> dictionary, Pasajero passenger)
        {
            bool result = true;

            if (dictionary != null)
            {
                if (dictionary.ContainsKey(passenger.document))
                {
                    result = false; 
                }
                else
                {
                    dictionary[passenger.document] = passenger; 
                }
            }

            return result;
        }
        /// <summary>
        /// Compara los atributos de 2 pasajeros, si encuentra alguna coincidencia entre sus atributos, retorna true.
        /// </summary>
        /// <param name="pasajero1"></param>
        /// <param name="pasajero2"></param>
        /// <returns> Retorna true si coincide algun atributo de los pasajeros. False si no encuentra coincidencia. </returns>
        private bool ComparePassengers(Pasajero pasajero1, Pasajero pasajero2)
        {
            return pasajero1.Document == pasajero2.Document
                || pasajero1.CardNumber == pasajero2.CardNumber
                || pasajero1.Email == pasajero2.Email;
        }
        /// <summary>
        /// Recorre todos los valores dentro del Dictionary, y en cada iteracion guarda el valor en PassengerToCompare
        /// </summary>
        /// <param name="passenger"></param>
        /// <returns> Retorna True si el pasajero se encuentra en el Dictionary. False si se encuentra. </returns>
        public bool PassengerExist(Pasajero passenger, Dictionary<string, Usuario> dictionaryPassengers)
        {
            foreach (Pasajero passengerToCompare in dictionaryPassengers.Values)
            {
                if (ComparePassengers(passenger, passengerToCompare))
                {
                    return true;
                }
            }
            return false;
        }
        public override string ShowUsers(Dictionary<string, Usuario> dictionaryPassengers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, Usuario> kvp in dictionaryPassengers)
            {
                if (kvp.Value is Pasajero pasajero)
                {
                    sb.AppendLine(base.ShowUsers(dictionaryPassengers));
                    sb.AppendLine($"DNI: {pasajero.document}");
                    sb.AppendLine($"Gender: {pasajero.gender}");
                    sb.AppendLine($"Card Number: {pasajero.cardNumber}");
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        public override string ShowUser()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowUser());

            sb.AppendLine($"DNI: {this.document}");
            sb.AppendLine($"Gender: {this.gender}");
            sb.AppendLine($"Card Number: {this.cardNumber}");              
            
            return sb.ToString();
        }
    }
}
