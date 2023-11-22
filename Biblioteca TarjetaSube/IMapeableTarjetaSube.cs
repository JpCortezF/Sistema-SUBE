using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public interface IMapeableTarjetaSube<T>
    {
        public T Map(MySqlDataReader reader);
    }
}
