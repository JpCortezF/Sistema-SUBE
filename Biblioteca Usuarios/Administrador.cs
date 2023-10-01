
namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario
    {
        List<Pasajero> listaPasajeros;

        public Administrador(List<Pasajero> listaPasajeros, string email, string password)
            : base(email, password)
        {
            this.listaPasajeros = listaPasajeros;
        }

        public List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }


    }
}