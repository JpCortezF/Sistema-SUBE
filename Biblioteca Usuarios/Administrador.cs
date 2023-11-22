
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Biblioteca_Usuarios
{
    public class Administrador : Usuario<string>, IMapeableUser<Administrador>
    {
        public Administrador()
        {
            
        }
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

        public static string EncriptarClave(string key, string secretKey)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(secretKey);
                aesAlg.IV = new byte[16]; // Inicialización del Vector de Inicialización (IV)

                // Crear un encriptador para realizar la transformación
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Crear los streams necesarios para la transformación
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Escribir datos encriptados
                            swEncrypt.Write(key);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        
        public static string DesencriptarClave(string textoEncriptado, string clave)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(clave);
                aesAlg.IV = new byte[16]; // Vector de inicialización, debe coincidir con el usado en la encriptación

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                try
                {
                    byte[] textoEnBytes = Convert.FromBase64String(textoEncriptado);

                    using (MemoryStream msDecrypt = new MemoryStream(textoEnBytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error de formato: {ex.Message}");
                    throw;
                }
            }
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

        public static string KeyToEncrypt()
        {
            return "UnaClaveDe16Char";
        }

        public Administrador Map(MySqlDataReader reader)
        {
            int dni = Convert.ToInt32(reader["dni"]);
            string name = reader["name"].ToString() ?? "";
            string lastName = reader["lastname"].ToString() ?? "";
            string email = reader["email"].ToString() ?? "";
            string password = reader["password"].ToString() ?? "";

            return new Administrador(dni, email, password, name, lastName);
        }
    }
}