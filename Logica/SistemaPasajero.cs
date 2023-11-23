using Biblioteca_Usuarios;
using Biblioteca_DataBase;
using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_TarjetaSube;
using System.Net;
using Org.BouncyCastle.Asn1.X509;

namespace Logica
{
    public class SistemaPasajero
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<Pasajero> data = new DataBase<Pasajero>();

        public bool PassengerExist(Pasajero passenger)
        {
            bool exist = true;
            string query = @"SELECT * FROM pasajeros WHERE dni = @dniPasajero OR idSube = @idSubePasajero OR email = @emailPasajero";

            parameters.Add("@dniPasajero", passenger.Dni);
            parameters.Add("@idSubePasajero", passenger.IdSube);
            parameters.Add("@emailPasajero", passenger.Email);
            
            if (data.Select(query, parameters, passenger.Map).Count == 0)
            {
                exist = false;
            }

            return exist;
        }
        public void InsertPassenger(Pasajero passenger)
        {
            string query = @"
            INSERT INTO pasajeros(dni, name, lastname, email, password, idGender, idSube)
            VALUES(@dniPasajero, @nombrePasajero, @apellidoPasajero, @emailPasajero, @contraPasajero, @generoPasajero, @idSubePasajero)";
            parameters.Clear();
            InsertSube(passenger);
            parameters.Add("@dniPasajero", passenger.Dni);
            parameters.Add("@nombrePasajero", passenger.Name);
            parameters.Add("@apellidoPasajero", passenger.LastName);
            parameters.Add("@emailPasajero", passenger.Email);
            parameters.Add("@contraPasajero", passenger.Password);
            parameters.Add("@generoPasajero", passenger.Gender);
            parameters.Add("@idSubePasajero", passenger.IdSube);
            data.Insert(query, parameters);
        }
        public void InsertSube(Pasajero passenger)
        {
            string query = @"INSERT INTO tarjetas(id, balance, socialRate) VALUES(@tarjeta, @balance, @tarifaSocial)";
            parameters.Clear();
            parameters.Add("@tarjeta", passenger.IdSube);
            parameters.Add("@balance", 0);
            parameters.Add("@tarifaSocial", 1);
            data.Insert(query, parameters);
        }
        public Pasajero LogPassenger(Pasajero passenger)
        {
            string query = "SELECT * FROM pasajeros WHERE dni = @dni AND password = @password";
            parameters.Clear();
            parameters.Add("@dni", passenger.Dni);
            parameters.Add("@password", passenger.Password);

            List<Pasajero>listPassengers = data.Select(query, parameters, passenger.Map);
            passenger = listPassengers.FirstOrDefault();

            return passenger;
        }
        public Pasajero PassengerNullSube(int dni)
        {
            string query = "SELECT * FROM pasajeros WHERE dni = @dni AND idSube IS NULL";
            parameters.Clear();
            parameters.Add("@dni", dni);
            Pasajero passenger = new Pasajero();
            List<Pasajero> listPassengers = data.Select(query, parameters, passenger.Map);
            passenger = listPassengers.FirstOrDefault();

            return passenger;
        }

        public Pasajero GetPasajeroByDni(int dniPassenger)
        {
            string query = "SELECT * FROM pasajeros WHERE dni = @selectedDni";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@selectedDni", dniPassenger }
            };
            Pasajero passenger = new Pasajero();
            List<Pasajero> listPassengers = data.Select(query, parameters, passenger.Map);
            return listPassengers.FirstOrDefault();
        }

        public string NewCardNumberToPassenger()
        {
            Pasajero passenger = new Pasajero();
            Random rnd = new Random();
            int _rnd = rnd.Next(1000, 9999);
            int _rnd2 = rnd.Next(1000, 9999);
            int _rnd3 = rnd.Next(1000, 9999);                      
            return passenger.IdSube = $"6061{_rnd}{_rnd2}{_rnd3}";
        }
        public void SetNewCardNumber(Pasajero passenger)
        {
            string query = @"UPDATE pasajeros SET idSube = @newCardNumber WHERE dni = @Dni";
            parameters.Clear();
            parameters.Add("@newCardNumber", passenger.IdSube);
            parameters.Add("@Dni", passenger.Dni);
            data.Update(query, parameters);
        }
    }
}
