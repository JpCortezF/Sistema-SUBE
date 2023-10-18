using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class KilometrosExcedeLimiteException : MyExceptions
    {
        public KilometrosExcedeLimiteException() : base("La cantidad de kilómetros excede el límite permitido (27 km).")
        {
        }
    }
}
