using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using NPOI.POIFS.Crypt.Dsig;

namespace Biblioteca_Usuarios
{
    public class Pasajero : Usuario<string>, IMapeableUser<Pasajero>
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

        public int Gender { get => gender;}
        public string IdSube { get => idSube; set => idSube = value; }
        public Pasajero Map(MySqlDataReader reader)
        {
            int dni = Convert.ToInt32(reader["dni"]);
            string name = reader["name"].ToString() ?? "";
            string lastName = reader["lastname"].ToString() ?? "";
            string email = reader["email"].ToString() ?? "";
            string password = reader["password"].ToString() ?? "";
            int idGender = Convert.ToInt32(reader["idGender"]);
            string idSube = reader["idSube"].ToString() ?? "";

            return new Pasajero(dni, idGender, email, password, name, lastName, idSube);
        }
    }
}



/// <summary>
/// Determina si un pasajero dado ya existe en una lista de pasajeros, ya sea por clave directa o mediante la comparación de información.
/// </summary>
/// <param name="passenger">El pasajero que se desea verificar.</param>
/// <param name="listPassengers">La lista de pasajeros en la que se realizará la búsqueda.</param>
/// <returns>True si el pasajero existe en la lista, ya sea por la clave o por comparación de información. False si no existe.</returns>
/*
public bool PassengerExist(Pasajero passenger, List<Pasajero> listPassengers)
{
    bool exists = listPassengers.Contains(passenger);
    if (!exists)
    {
        foreach (Pasajero passengerToCompare in listPassengers)
        {
            if(base.CompareUser(passengerToCompare, passenger) || passenger.IdSube == passengerToCompare.IdSube)
            {
                exists = true;
                break;
            }
        }
    }
    return exists;
}
*/