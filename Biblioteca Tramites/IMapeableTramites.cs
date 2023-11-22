using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tramites
{
    public interface IMapeableTramites<T>
    {
        public T Map(MySqlDataReader reader);
    }
}
