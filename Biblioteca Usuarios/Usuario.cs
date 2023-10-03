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

        public virtual string ShowUser()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Email: {this.Email}");
            sb.AppendLine($"Password: {this.Password}");

            return sb.ToString();
        }
        public virtual string ShowUsers(Dictionary<string, Usuario> dictionaryPassengers)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Email: {this.Email}");
            sb.Append($"Password: {this.Password}");

            return sb.ToString();
        }
    }
}
