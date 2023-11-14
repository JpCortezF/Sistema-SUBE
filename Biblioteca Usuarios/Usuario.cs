﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public abstract class Usuario<T> : IComparator<Usuario<T>>
    {
        protected string email;
        protected string password;
        protected string name;
        protected string lastname;

        public T MyType { get; protected set; }

        public Usuario()
        {
            this.password = string.Empty;
            this.email = string.Empty;
        }
        protected Usuario(string email, string password, string name, string lastname, T userType)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.lastname = lastname;
            MyType = userType;
        }
        [JsonProperty("Email")]
        public string Email { get => email; set => email = value; }
        [JsonProperty("Password")]
        public string Password { get => password; set => password = value; }
        [JsonProperty("Name")]
        public string Name { get => name; set => name = value; }
        [JsonProperty("Lastname")]
        public string LastName { get => lastname; set => lastname = value; }

        public virtual bool CompareUser(Usuario<T> user, Usuario<T> user2)
        {
            return user?.Email == user2?.Email;
        }

    }
}
