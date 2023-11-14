using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public interface IComparator<T>
    {
        bool CompareUser(T user, T user2);
    }
}
