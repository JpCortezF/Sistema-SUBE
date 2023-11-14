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
    public class Pasajero : Usuario<string>
    {
        string gender;
        TarjetaSube mySube;

        public Pasajero()
        {
            
        }
        public Pasajero(string gender, string email, string password,string name, string lastname, TarjetaSube sube) : base(email, password, name, lastname, "Pasajero")
        {
            this.gender = gender;
            this.mySube = sube;
        }

        public string Gender { get => gender; set => gender = value; }
        public TarjetaSube MySube { get => mySube; set => mySube = value; }

        /// <summary>
        /// Determina la existencia de un pasajero en un diccionario dado.
        /// </summary>
        /// <param name="passenger">El pasajero que se desea verificar.</param>
        /// <param name="dictionaryPassengers">El diccionario de pasajeros en el que se realizará la búsqueda.</param>
        /// <param name="document">La clave del pasajero que se utilizará para la verificación.</param>
        /// <returns>True si el pasajero existe en el diccionario, ya sea por la clave o por comparación de información. False si no existe.</returns>
        public bool PassengerExist(Pasajero passenger, Dictionary<string, Pasajero> dictionaryPassengers, string document)
        {
            bool exists = dictionaryPassengers.ContainsKey(document);

            if (!exists)
            {
                foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
                {
                    if (CompareUser(passenger, kvp.Value))
                    {
                        exists = true;
                        break;
                    }
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
        public bool CardNumberExist(Dictionary<string, Pasajero> dictionaryPassengers, string newCardNumber)
        {
            bool exist = false;
            foreach (KeyValuePair<string, Pasajero> kvp in dictionaryPassengers)
            {
                if (kvp.Value is Pasajero passenger)
                {
                    if (passenger.MySube.CardNumber == newCardNumber)
                    {
                        exist = true;
                        break;
                    }
                }
            }
            return exist;
        }
        public bool CompareUser(Pasajero user1, Pasajero user2)
        {
            bool exist = false;
            if (user1 != null && user2 != null)
            {
                exist = base.CompareUser(user1, user2) || user1.MySube.CardNumber == user2.MySube.CardNumber;
            }
            return exist;
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