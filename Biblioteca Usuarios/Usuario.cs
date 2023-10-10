using Newtonsoft.Json;
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
        protected string name;
        protected string lastname;
        public Usuario()
        {
            this.password = string.Empty;
            this.email = string.Empty;
        }
        protected Usuario(string email, string password, string name, string lastname)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.lastname = lastname;
        }
        [JsonProperty("Email")]
        protected string Email { get => email; set => email = value; }
        [JsonProperty("Password")]
        protected string Password { get => password; set => password = value; }
        [JsonProperty("Name")]
        protected string Name { get => name; set => name = value; }
        [JsonProperty("Lastname")]
        protected string LastName { get => lastname; set => lastname = value; }

        public abstract string DevolverClave();
    }
}
