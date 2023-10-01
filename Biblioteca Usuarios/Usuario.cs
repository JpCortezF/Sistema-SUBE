using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public abstract class Usuario
    {
        private string email;
        private string password;

        protected Usuario(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        protected string Email { get => email; set => email = value; }
        protected string Password { get => password; set => password = value; }
    }
}
