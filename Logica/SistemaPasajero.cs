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

        /// <summary>
        /// Verifica si un pasajero ya existe en la base de datos, comparando el DNI, el ID de la tarjeta SUBE y el correo electrónico.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero con la información a verificar.</param>
        /// <returns>True si el pasajero ya existe, False si no.</returns>
        /// 
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
        /// <summary>
        /// Inserta un nuevo pasajero en la base de datos, incluyendo su información básica y generando una nueva tarjeta SUBE para él.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero con la información a insertar.</param>
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
        /// <summary>
        /// Inserta una nueva tarjeta SUBE para un pasajero en la base de datos.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero para el cual se insertará la tarjeta SUBE.</param>
        public void InsertSube(Pasajero passenger)
        {
            string query = @"INSERT INTO tarjetas(id, balance, socialRate) VALUES(@tarjeta, @balance, @tarifaSocial)";
            parameters.Clear();
            parameters.Add("@tarjeta", passenger.IdSube);
            parameters.Add("@balance", 0);
            parameters.Add("@tarifaSocial", 1);
            data.Insert(query, parameters);
        }
        /// <summary>
        /// Verifica las credenciales de inicio de sesión de un pasajero en la base de datos.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero con las credenciales a verificar.</param>
        /// <returns>Objeto Pasajero con la información del pasajero si las credenciales son correctas, o null si no son válidas.</returns>
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
        /// <summary>
        /// Busca un pasajero por su DNI y verifica si no tiene asignada una tarjeta SUBE.
        /// </summary>
        /// <param name="dni">DNI del pasajero a buscar.</param>
        /// <returns>Objeto Pasajero si se encuentra uno con el DNI proporcionado y sin tarjeta SUBE, o null si no se cumple la condición.</returns>
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
        /// <summary>
        /// Genera y devuelve un nuevo número de tarjeta SUBE aleatorio para un pasajero.
        /// </summary>
        /// <returns>Nuevo número de tarjeta SUBE generado.</returns>
        public string NewCardNumberToPassenger()
        {
            Pasajero passenger = new Pasajero();
            Random rnd = new Random();
            int _rnd = rnd.Next(1000, 9999);
            int _rnd2 = rnd.Next(1000, 9999);
            int _rnd3 = rnd.Next(1000, 9999);                      
            return passenger.IdSube = $"6061{_rnd}{_rnd2}{_rnd3}";
        }
        /// <summary>
        /// Asigna un nuevo número de tarjeta SUBE a un pasajero en la base de datos.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero al cual se le asignará el nuevo número de tarjeta SUBE.</param>
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
