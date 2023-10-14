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
        public string Email { get => email; set => email = value; }
        [JsonProperty("Password")]
        public string Password { get => password; set => password = value; }
        [JsonProperty("Name")]
        public string Name { get => name; set => name = value; }
        [JsonProperty("Lastname")]
        public string LastName { get => lastname; set => lastname = value; }

        //public abstract string DevolverClave(Usuario user);
    }
}
