using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public class LineasTransporte
    {
        int id;
        string line;

        public LineasTransporte(int id, string line)
        {
            this.id = id;
            this.line = line;
        }

        public int Id { get => id; set => id = value; }
        public string Line { get => line; set => line = value; }

        public static LineasTransporte MapLineas(MySqlDataReader reader)
        {
            return (LineasTransporte)reader;
        }

        public static explicit operator LineasTransporte(MySqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string line = reader["line"].ToString() ?? "";

            return new LineasTransporte(id, line);
        }
    }
}
