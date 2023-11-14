using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Biblioteca_Usuarios;
using Biblioteca_TarjetaSube;

namespace Biblioteca_DataBase
{
    public class DataBase<T>
    {
        public static MySqlConnection connectionMySql;
        public static MySqlCommand commandMySql;

        static DataBase()
        {
            var mySqlStringConnection = @"Server=localhost;Port=3307;Database=proyectosube;Uid=root;Pwd=;";

            connectionMySql = new MySqlConnection(mySqlStringConnection);

            commandMySql = new MySqlCommand();
            commandMySql.CommandType = System.Data.CommandType.Text;
            commandMySql.Connection = connectionMySql;
        }
        public static List<T> Select(string query)
        {
            List<T> lista = new List<T>();
            try
            {
                connectionMySql.Open();

                commandMySql.CommandText = query;

                using (MySqlDataReader reader = commandMySql.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        lista.Add
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connectionMySql.Close();
            }
            return lista;
        }
        public static void Insert(Pasajero passenger, TarjetaSube mySube)
        {
            try
            {
                connectionMySql.Open();
                string query = $"INSERT INTO pasajeros (dni, name, lastname, email, password, idGender, idSube)" +
                    $" VALUES({22222223}, '{passenger.Name}', '{passenger.LastName}', '{passenger.Email}', '{passenger.Password}', {1}, {6061103047601010})";

                Console.WriteLine($"Filas afectadas: {ExecuteNonQuery(query)}");

                string querySube = $"INSERT INTO tarjetas (CardNumber, Balance, TarifaSocial)" +
                    $" VALUES('{mySube.CardNumber}', {0}, {1})";

                Console.WriteLine($"Filas afectadas: {ExecuteNonQuery(querySube)}");    
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
            finally
            {
                connectionMySql.Close();
            }
        }
        public static int ExecuteNonQuery(string query)
        {
            commandMySql.CommandText = query;
            return commandMySql.ExecuteNonQuery();
        }
    }
}