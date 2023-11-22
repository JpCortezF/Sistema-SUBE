using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_DataBase
{
    public interface IDBCommands<T>
    {
        public List<T> Select(string query, Dictionary<string, object> parameters, Func<MySqlDataReader, T> mapObject);

        bool Insert(string query, Dictionary<string, object> parameters = null);

        bool Update(string query, Dictionary<string, object> parameters = null);

        bool Delete(string query, Dictionary<string, object> parameters = null);

        DataTable Data(string query, Dictionary<string, object> parameters = null);
    }
}