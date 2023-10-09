using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_TarjetaSube;

namespace Biblioteca_Usuarios
{
    public class Pasajero : Usuario
    {
        string gender;
        TarjetaSube mySube;

        public Pasajero(string gender, string email, string password,TarjetaSube sube) : base(email, password)
        {
            this.gender = gender;
            this.mySube = sube;
        }

        public string Gender { get => gender; set => gender = value; }
        public TarjetaSube MySube { get => mySube; set => mySube = value; }

        /// <summary>
        /// Compara los atributos de 2 pasajeros, si encuentra alguna coincidencia entre sus atributos, retorna true.
        /// </summary>
        /// <param name="pasajero1"></param>
        /// <param name="pasajero2"></param>
        /// <returns> Retorna true si coincide algun atributo de los pasajeros. False si no encuentra coincidencia. </returns>
        private bool ComparePassengers(Pasajero pasajero1, Pasajero pasajero2)
        {
            return pasajero1.Email == pasajero2.Email
                || pasajero1.MySube.CardNumber == pasajero2.MySube.CardNumber;
        }
        /// <summary>
        /// Recorre todos los valores dentro del Dictionary, y en cada iteracion guarda el valor en PassengerToCompare
        /// </summary>
        /// <param name="passenger"></param>
        /// <returns> Retorna True si el pasajero se encuentra en el Dictionary. False si se encuentra. </returns>
        public bool PassengerExist(Pasajero passenger, Dictionary<string, Pasajero> dictionaryPassengers, string document)
        {
            bool exists = false;

            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            { 
                if(kvp.Key.ToString() == document)
                {
                    foreach (Pasajero passengerToCompare in dictionaryPassengers.Values)
                    {
                        exists = ComparePassengers(passenger, passengerToCompare);
                        break;
                    }
                    exists = true;
                    break;
                }
            }
            return exists;
        }
        public string ShowUsers(Dictionary<string, Pasajero> dictionaryPassengers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            {
                if (kvp.Value is Pasajero passenger)
                {
                    sb.AppendLine($"Email: {passenger.email}");
                    sb.AppendLine($"Password: {passenger.password}");
                    sb.AppendLine($"Gender: {passenger.gender}");
                    sb.AppendLine($"Sube id: {passenger.MySube.CardNumber}");
                    sb.AppendLine($"Tarifa social: {passenger.MySube.TarifaSocial}");
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        public string ShowUser(Pasajero passenger)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Email: {passenger.email}");
            sb.AppendLine($"Password: {passenger.password}");
            sb.AppendLine($"Gender: {passenger.gender}");
            sb.AppendLine($"Sube id: {passenger.MySube.CardNumber}");
            sb.AppendLine($"Tarifa social: {passenger.MySube.TarifaSocial}");
            sb.AppendLine();

            return sb.ToString();
        }

        public string PassengerPassword(Pasajero passenger)
        {
            return passenger.password;
        }

        public override string DevolverClave()
        {
            throw new NotImplementedException();
        }
    }
}
