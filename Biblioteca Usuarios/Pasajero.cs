using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;

namespace Biblioteca_Usuarios
{
    public class Pasajero : Usuario
    {
        string gender;
        TarjetaSube mySube;

        public Pasajero()
        {

        }
        public Pasajero(string gender, string email, string password,string name, string lastname, TarjetaSube sube) : base(email, password, name, lastname)
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
        /// <returns> Retorna True si el pasajero se encuentra en el Dictionary. False si no se encuentra. </returns>
        public bool PassengerExist(Pasajero passenger, Dictionary<string, Pasajero> dictionaryPassengers, string document)
        {
            bool exists = false;

            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            {
                if(kvp.Key.ToString() != document)
                {
                    foreach (Pasajero passengerToCompare in dictionaryPassengers.Values)
                    {
                        exists = ComparePassengers(passenger, passengerToCompare);
                        if(exists)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }
        /// <summary>
        /// Busca un pasajero por su dirección de correo electrónico en un diccionario de pasajeros y devuelve el pasajero encontrado.
        /// </summary>
        /// <param name="dictionaryPassengers">El diccionario de pasajeros en el que se realizará la búsqueda.</param>
        /// <param name="email">La dirección de correo electrónico del pasajero que se desea encontrar.</param>
        /// <returns>El objeto Pasajero que coincide con la dirección de correo electrónico especificada. Si no se encuentra, devuelve null.</returns>

        public Pasajero FindPassengerByEmail(Dictionary<string, Pasajero> dictionaryPassengers, string email)
        {
            Pasajero pasajero = null;
            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            {
                if (kvp.Value is Pasajero passenger)
                {
                    if(passenger.Email == email)
                    {
                        pasajero = passenger;
                        break;
                    }
                }
            }
            return pasajero;
        }
        /// <summary>
        /// Busca una clave en un diccionario que corresponde a un objeto Pasajero específico y la devuelve.
        /// </summary>
        /// <param name="dictionaryPassengers">El diccionario de pasajeros en el que se realizará la búsqueda.</param>
        /// <param name="pasajero">El objeto Pasajero que se desea encontrar en el diccionario.</param>
        /// <returns>La clave del diccionario que se asocia con el objeto Pasajero especificado. Si el pasajero no se encuentra, devuelve null.</returns>

        public string ReturnrKey(Dictionary<string, Pasajero> dictionaryPassengers, Pasajero pasajero)
        {
            string keyPasajero = null;
            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            {
                if (kvp.Value == pasajero)
                {
                    keyPasajero = kvp.Key;
                    break;
                }
            }
            return keyPasajero;
        }
    }
}



//public string ShowUsers(Dictionary<string, Pasajero> dictionaryPassengers)
//{
//    StringBuilder sb = new StringBuilder();

//    foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
//    {
//        if (kvp.Value is Pasajero passenger)
//        {
//            sb.AppendLine($"Name: {passenger.name}");
//            sb.AppendLine($"Lastname: {passenger.lastname}");
//            sb.AppendLine($"Email: {passenger.email}");
//            sb.AppendLine($"Password: {passenger.password}");
//            sb.AppendLine($"Gender: {passenger.gender}");
//            sb.AppendLine($"Sube id: {passenger.MySube.CardNumber}");
//            sb.AppendLine($"Tarifa social: {passenger.MySube.TarifaSocial}");
//            sb.AppendLine();
//        }
//    }
//    return sb.ToString();
//}

//public string ShowUser(Pasajero passenger)
//{
//    StringBuilder sb = new StringBuilder();

//    sb.AppendLine($"Name: {passenger.name}");
//    sb.AppendLine($"Lastname: {passenger.lastname}");
//    sb.AppendLine($"Email: {passenger.email}");
//    sb.AppendLine($"Password: {passenger.password}");
//    sb.AppendLine($"Gender: {passenger.gender}");
//    sb.AppendLine($"Sube id: {passenger.MySube.CardNumber}");
//    sb.AppendLine($"Tarifa social: {passenger.MySube.TarifaSocial}");
//    sb.AppendLine();

//    return sb.ToString();
//}