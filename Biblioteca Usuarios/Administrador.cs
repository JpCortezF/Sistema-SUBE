
namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario<string>
    {
        public Administrador(string email, string password, string name, string lastname) : base(email, password, name, lastname)
        {
        }
        /// <summary>
        /// Verifica si un administrador ya existe en un diccionario de administradores, utilizando su documento como referencia.
        /// </summary>
        /// <param name="admin">El administrador a verificar.</param>
        /// <param name="dictionaryAdmins">El diccionario que contiene a los administradores existentes.</param>
        /// <param name="document">El documento de identificación del administrador a comparar.</param>
        /// <returns>True si un administrador con el mismo documento ya existe en el diccionario, de lo contrario, False.</returns>
        public bool AdminExist(Administrador admin, Dictionary<string, Administrador> dictionaryAdmins, string document)
        {
            bool exists = false;

            foreach (KeyValuePair<string, Administrador> kvp in dictionaryAdmins)
            {
                if (kvp.Key.ToString() != document)
                {
                    foreach(Administrador adminToCompare in dictionaryAdmins.Values)
                    {
                        exists = CompareUser(admin, adminToCompare);
                        if (exists)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    exists = true;
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