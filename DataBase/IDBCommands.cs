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
        List<T> Select(string query, Func<IDataRecord, T>mapObject);

        bool Insert(string query, Dictionary<string, object> parameters = null);

        bool Update(string query, Dictionary<string, object> parameters = null);

        bool Delete(T item);
    }
}
