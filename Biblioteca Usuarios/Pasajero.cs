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
        public Pasajero(int dni, string password) : base(dni, password)
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
