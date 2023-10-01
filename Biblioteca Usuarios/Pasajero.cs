using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public class Pasajero : Usuario
    {
        int document;
        string gender;

        public Pasajero(int document, string gender, string email, string password)
            : base(email, password)
        {
            this.document = document;
            this.gender = gender;
        }

        public int Document { get => document; set => document = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
