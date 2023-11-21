using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public interface ISerializable<T>
    {
        bool Serialize(string path, T datos);

        T Deserialize(string path, Func<T> factoryMethod);
    }
}
