using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class KilometrosException : MyExceptions
    {
        string message;
        public KilometrosException(string message) : base(message)
        {
            this.message = message;
        }

    }
}
