using Biblioteca_DataBase;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class SistemaAdmin
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        List<Administrador> admins = new List<Administrador>();
        DataBase<Administrador> data = new DataBase<Administrador>();

        /// <summary>
        /// Carga la información de un administrador basado en su correo electrónico y número de DNI.
        /// </summary>
        /// <param name="email">Correo electrónico del administrador.</param>
        /// <param name="dni">Número de DNI del administrador.</param>
        /// <returns>Objeto Administrador con la información del administrador.</returns>
        public Administrador cargarAdmin(string email, string dni)
        {
            Administrador admin = new Administrador();
            string query1 = "SELECT * FROM admins WHERE dni = @dni AND email = @email";
            parameters.Add("@dni", dni);
            parameters.Add("@email", email);         
            admins = data.Select(query1, parameters, admin.Map);
            admin = admins.FirstOrDefault();

            return admin;
        }
        /// <summary>
        /// Verifica si ya existe un administrador con el mismo número de DNI o correo electrónico.
        /// </summary>
        /// <param name="admin">Objeto Administrador a verificar.</param>
        /// <returns>True si el administrador ya existe, False si no.</returns>
        public bool AdminExists(Administrador admin)
        {
            parameters.Clear();
            bool exists = false;
            string query1 = @"SELECT * FROM admins WHERE dni = @dniAdmin OR email = @emailAdmin";
            parameters.Add("@dniAdmin", admin.Dni);
            parameters.Add("@emailAdmin", admin.Email);
            if (data.Select(query1, parameters, admin.Map).Count == 0)
            {
                exists = true;
            }
            return exists;
        }
        /// <summary>
        /// Genera un nuevo administrador y lo agrega a la base de datos si no existe otro con el mismo número de DNI o correo electrónico.
        /// </summary>
        /// <param name="admin">Objeto Administrador a agregar.</param>
        /// <returns>True si se generó y agregó el nuevo administrador, False si no.</returns>
        public bool GenerateNewAdmin(Administrador admin)
        {
            bool created = false;
            if (AdminExists(admin) == false)
            {
                parameters.Clear();
                string claveSecreta = Administrador.KeyToEncrypt();
                string claveEncriptada = Administrador.EncriptarClave(admin.Password, claveSecreta);
                string query = @"INSERT INTO admins(dni, name, lastname, email, password) VALUES(@dniAdmin, @nombreAdmin, @apellidoAdmin, @emailAdmin, @contraAdmin)";
                parameters.Add("@dniAdmin", admin.Dni);
                parameters.Add("@nombreAdmin", admin.Name);
                parameters.Add("@apellidoAdmin", admin.LastName);
                parameters.Add("@emailAdmin", admin.Email);
                parameters.Add("@contraAdmin", claveEncriptada);
                data.Insert(query, parameters);
                created = true;
            }
            return created;
        }
        /// <summary>
        /// Muestra los viajes de un pasajero específico en un DataTable.
        /// </summary>
        /// <param name="pasajero">Objeto Pasajero con la información del pasajero.</param>
        /// <returns>DataTable con la información de los viajes del pasajero.</returns>
        public DataTable ShowPassengerTravels(Pasajero pasajero)
        {
            DataTable dt;
            parameters.Clear();
            string query = @"
                SELECT transportes.transport AS Transporte, lineas.line AS Linea, tarifassociales.rate AS TarifaSocial, viajes.ticketCost AS Boleto, viajes.kilometres AS Kilometros, viajes.date AS Fecha
                FROM viajes
                INNER JOIN
                    tarifassociales ON tarifassociales.id = viajes.idSocialRate
                INNER JOIN
                    transportes ON transportes.id = viajes.idTransport
                LEFT JOIN
                    lineas ON lineas.id = viajes.idLine
                WHERE viajes.idCard = @idSube";
            parameters.Add("@idSube", pasajero.IdSube);
            dt = data.Data(query, parameters);
            return dt;
        }
    }
}
