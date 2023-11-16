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
        int gender;
        TarjetaSube mySube;
        public Pasajero()
        {
            
        }
        public Pasajero(int dni, int gender, string email, string password,string name, string lastname, TarjetaSube sube) : base(dni, email, password, name, lastname)
        {
            this.gender = gender;
            this.mySube = sube;
        }

        public int Gender { get => gender; set => gender = value; }
        public TarjetaSube MySube { get => mySube; set => mySube = value; }

        /// <summary>
        /// Determina la existencia de un pasajero en una lista dada.
        /// </summary>
        /// <param name="passenger">El pasajero que se desea verificar.</param>
        /// <param name="listPassengers">La lista de pasajeros en el que se realizará la búsqueda.</param>
        /// <returns>True si el pasajero existe en la lista, ya sea por la clave o por comparación de información. False si no existe.</returns>
        public bool PassengerExist(Pasajero passenger, List<Pasajero> listPassengers)
        {
            bool exists = listPassengers.Contains(passenger);
            if (!exists)
            {
                foreach (Pasajero passengerToCompare in listPassengers)
                {
                    if (CompareUser(passenger, passengerToCompare))
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
        /// <param name="listPassengers">El diccionario de pasajeros en el que se realizará la búsqueda.</param>
        /// <param name="email">La dirección de correo electrónico del pasajero que se desea encontrar.</param>
        /// <returns>El objeto Pasajero que coincide con la dirección de correo electrónico especificada. Si no se encuentra, devuelve null.</returns>

        public Pasajero FindPassengerByEmail(List<Pasajero> listPassengers, string email)
        {
            Pasajero pasajero = null;
            foreach (Pasajero passengerToCompare in listPassengers)
            {  
                if(passengerToCompare.Email == email)
                {
                    pasajero = passengerToCompare;
                    break;
                }            
            }
            return pasajero;
        }
        public bool CardNumberExist(List<Pasajero> listPassengers, string newCardNumber)
        {
            bool exist = false;
            foreach (Pasajero passengerToCompare in listPassengers)
            {
                if (passengerToCompare.MySube.CardNumber == newCardNumber)
                {
                    exist = true;
                    break;
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