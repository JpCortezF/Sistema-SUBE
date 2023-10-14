
namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario
    {
        public Administrador(string email, string password, string name, string lastname) : base(email, password, name, lastname)
        {
        }

        public Usuario Usuario { get; set; }

    }
}