using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public abstract class Usuario<T> : IComparator<Usuario<T>>
    {
        protected int dni;
        protected string email;
        protected string password;
        protected string name;
        protected string lastname;

        public Usuario()
        {
            
        }
        public Usuario(int dni, string password)
        {
            this.dni = dni;
            this.password = password;
        }
        protected Usuario(int dni, string email, string password, string name, string lastname)
        {
            this.dni = dni;
            this.email = email;
            this.password = password;
            this.name = name;
            this.lastname = lastname;
        }
        [JsonProperty("Email")]
        public string Email { get => email;}
        [JsonProperty("Password")]
        public string Password { get => password;}
        [JsonProperty("Name")]
        public string Name { get => name; }
        [JsonProperty("Lastname")]
        public string LastName { get => lastname; }
        [JsonProperty("Dni")]
        public int Dni { get => dni; }

        public virtual bool CompareUser(Usuario<T> user, Usuario<T> user2)
        {
            return user?.Email == user2?.Email || user?.Dni == user2?.Dni;
        }

    }
}
