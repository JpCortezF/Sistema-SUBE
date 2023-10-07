using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public abstract class Usuario
    {
        protected string email;
        protected string password;

        public Usuario()
        {
            this.password = string.Empty;
            this.email = string.Empty;
        }
        protected Usuario(string email):this()
        {
            this.email = email;
        }
        protected Usuario(string email, string password):this(email)
        {
            this.password = password;
        }
        protected string Email { get => email; set => email = value; }
        protected string Password { get => password; set => password = value; }


    }
}
