using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public class LineasTransporte : IMapeableTarjetaSube<LineasTransporte>
    {
        int id;
        string line;

        public LineasTransporte()
        {
            
        }
        public LineasTransporte(int id, string line)
        {
            this.id = id;
            this.line = line;
        }

        public int Id { get => id; set => id = value; }
        public string Line { get => line; set => line = value; }

        public LineasTransporte Map(MySqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string line = reader["line"].ToString() ?? "";

            return new LineasTransporte(id, line);
        }
    }
}
