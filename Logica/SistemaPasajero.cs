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
using System.Data;
using System.Collections;
using System.Xml.Linq;

namespace Logica
{
    public class SistemaPasajero
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<Pasajero> data = new DataBase<Pasajero>();

        /// <summary>
        /// Obtiene una lista de todos los pasajeros registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Pasajero con la información de todos los pasajeros.</returns>
        public List<Pasajero> GetAllPasajeros()
        {
            List<Pasajero> listaPasajeros;
            Pasajero pasajero = new Pasajero();
            string query = "SELECT * FROM pasajeros";
            listaPasajeros = data.Select(query, parameters, pasajero.Map);
            return listaPasajeros;
        }
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
        /// Obtiene la información de un pasajero mediante su número de DNI.
        /// </summary>
        /// <param name="dniPassenger">Número de DNI del pasajero a buscar.</param>
        /// <returns>Objeto Pasajero con la información del pasajero correspondiente al número de DNI proporcionado.</returns>
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

        /// <summary>
        /// Carga un DataTable con información de pasajeros basada en una búsqueda por número de DNI.
        /// </summary>
        /// <param name="dni">Número de DNI a buscar.</param>
        /// <returns>DataTable con información de pasajeros que coinciden con la búsqueda de número de DNI.</returns>
        public DataTable LoadDataTableWithDniSearch(int dni)
        {
            DataTable dt;
            parameters.Clear();
            string query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                    FROM pasajeros
                    INNER JOIN
                        generos ON generos.id = pasajeros.idGender
                    LEFT JOIN
                       tarjetas ON tarjetas.id = pasajeros.idSube
                    WHERE 
                    pasajeros.dni LIKE @dniSearch";
            parameters.Add("@dniSearch", "%" + dni + "%");
            dt = data.Data(query, parameters);
            return dt;
        }
        /// <summary>
        /// Carga un DataTable con información de pasajeros basada en una búsqueda por nombre y apellido.
        /// </summary>
        /// <param name="name">Nombre a buscar.</param>
        /// <param name="lastName">Apellido a buscar.</param>
        /// <returns>DataTable con información de pasajeros que coinciden con la búsqueda de nombre y apellido.</returns>
        public DataTable LoadDataTableWithNameSearch(string name, string lastName)
        {
            DataTable dt;
            parameters.Clear();
            string query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                    FROM pasajeros
                    INNER JOIN
                        generos ON generos.id = pasajeros.idGender
                    LEFT JOIN
                       tarjetas ON tarjetas.id = pasajeros.idSube
                    WHERE 
                    pasajeros.name LIKE @Name OR pasajeros.lastname LIKE @LastName";
            parameters.Add("@Name", "%" + name + "%");
            parameters.Add("@LastName", "%" + lastName + "%");
            dt = data.Data(query, parameters);
            return dt;
        }
        /// <summary>
        /// Carga un DataTable con información de pasajeros basada en una búsqueda por número de tarjeta SUBE.
        /// </summary>
        /// <param name="subeId">Número de tarjeta SUBE a buscar.</param>
        /// <returns>DataTable con información de pasajeros que coinciden con la búsqueda por número de tarjeta SUBE.</returns>
        public DataTable LoadDataTableWithSubeSearch(string subeId)
        {
            DataTable dt;
            parameters.Clear();
            string query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                    FROM pasajeros
                    INNER JOIN
                        generos ON generos.id = pasajeros.idGender
                    LEFT JOIN
                       tarjetas ON tarjetas.id = pasajeros.idSube
                    WHERE
                    pasajeros.idSube LIKE @Sube";
            parameters.Add("@Sube", "%" + subeId + "%");
            dt = data.Data(query, parameters);
            return dt;
        }
        /// <summary>
        /// Carga un DataTable con información de todos los pasajeros registrados.
        /// </summary>
        /// <returns>DataTable con información de todos los pasajeros registrados.</returns>
        public DataTable LoadDataTableWithAllPassengers()
        {
            DataTable dt;
            parameters.Clear();
            string query = @"SELECT pasajeros.dni AS DNI, pasajeros.name AS Nombre, pasajeros.lastname AS Apellido, pasajeros.email AS Email, generos.gender AS Genero, pasajeros.idSube AS SUBE, tarjetas.balance AS Saldo
                            FROM pasajeros 
                            INNER JOIN 
                                generos ON generos.id = pasajeros.idGender 
                            LEFT JOIN 
                                tarjetas ON tarjetas.id = pasajeros.idSube";
            dt = data.Data(query, parameters);
            return dt;
        }

    }
}
