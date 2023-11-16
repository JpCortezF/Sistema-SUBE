
namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario<string>
    {

        public Administrador(int dni, string email, string password, string name, string lastname) : base(dni, email, password, name, lastname)
        {
        }
        /// <summary>
        /// Verifica si un administrador ya existe en un diccionario de administradores, utilizando su documento como referencia.
        /// </summary>
        /// <param name="admin">El administrador a verificar.</param>
        /// <param name="listAdmins">El diccionario que contiene a los administradores existentes.</param>
        /// <returns>True si un administrador con el mismo documento ya existe en el diccionario, de lo contrario, False.</returns>
        public bool AdminExist(Administrador admin, List<Administrador> listAdmins)
        {
            bool exists = listAdmins.Contains(admin);

            if(!exists)
            {
                foreach (Administrador adminToCompare in listAdmins)
                {
                    exists = CompareUser(admin, adminToCompare);
                    break;
                }
            }                  
            return exists;
        }
        /// <summary>
        /// Compara dos administradores por su dirección de correo electrónico.
        /// </summary>
        /// <param name="admin1">El primer administrador a comparar.</param>
        /// <param name="admin2">El segundo administrador a comparar.</param>
        /// <returns>True si ambos administradores tienen la misma dirección de correo electrónico, de lo contrario, False.</returns>
        private bool CompareUser(Administrador admin1, Administrador admin2)
        {
            return base.CompareUser(admin1, admin2);
        }
    }
}