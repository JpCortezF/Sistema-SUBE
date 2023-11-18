using MySql.Data.MySqlClient;
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
        string idSube;
        public Pasajero()
        {
            
        }
        public Pasajero(int dni, int gender, string email, string password,string name, string lastname, string sube) : base(dni, email, password, name, lastname)
        {
            this.gender = gender;
            this.idSube = sube;
        }

        public int Gender { get => gender; set => gender = value; }
        public string IdSube { get => idSube; set => idSube = value; }

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

        public static Pasajero MapPasajero(MySqlDataReader reader)
        {
            return (Pasajero)reader;
        }

        public static explicit operator Pasajero(MySqlDataReader reader)        
        {
            int dni = Convert.ToInt32(reader["dni"]);
            string name = reader["name"].ToString() ?? "";
            string lastName = reader["lastname"].ToString() ?? "";
            string email = reader["email"].ToString() ?? "";
            string password = reader["password"].ToString() ?? "";
            int idGender = Convert.ToInt32(reader["idGender"]);
            string idSube = reader["idSube"].ToString() ?? "";
            //int dni, int gender, string email, string password,string name, string lastname, TarjetaSube sube
            return new Pasajero(dni, idGender, email, password, name, lastName, idSube);
        }

    }
}
