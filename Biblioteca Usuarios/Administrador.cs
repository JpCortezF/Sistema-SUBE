
namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario
    {
        public Administrador(string email, string password, string name, string lastname) : base(email, password, name, lastname)
        {
        }

        public bool AdminExist(Administrador admin, Dictionary<string, Administrador> dictionaryAdmins, string document)
        {
            bool exists = false;

            foreach (KeyValuePair<string, Administrador> kvp in dictionaryAdmins)
            {
                if (kvp.Key.ToString() == document)
                {
                    foreach (Administrador adminToCompare in dictionaryAdmins.Values)
                    {
                        exists = CompareAdmins(admin, adminToCompare);
                        break;
                    }
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        private bool CompareAdmins(Administrador admin1, Administrador admin2)
        {
            return admin1.Email == admin2.Email;
        }
    }
}