
namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario
    {
        public Administrador(string email, string password) : base(email, password)
        {
        }

        public Usuario Usuario { get; set; }
    }
}