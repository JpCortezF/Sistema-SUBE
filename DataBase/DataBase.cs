using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Biblioteca_Usuarios;
using Biblioteca_TarjetaSube;
using NPOI.OpenXmlFormats.Spreadsheet;
using System.Diagnostics;

namespace Biblioteca_DataBase
{
    public class DataBase
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
        /*
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
                        //lista.Add
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
        */
        public static void Insert(Pasajero passenger, TarjetaSube mySube, int method)
        {
            try
            {
                connectionMySql.Open();
                switch (method)
                {
                    case 1:                 
                        string querySube = $"INSERT INTO tarjetas (id, balance, socialRate) VALUES('{mySube.CardNumber}', '{0}', '{1}')";
                        Debug.WriteLine($"Filas afectadas: {ExecuteNonQuery(querySube)}");

                        string query = $"INSERT INTO pasajeros (dni, name, lastname, email, password, idGender, idSube) VALUES('{22222227}', '{passenger.Name}', '{passenger.LastName}', '{passenger.Email}', '{passenger.Password}', '{1}', '{mySube.CardNumber}')";
                        Debug.WriteLine($"Filas afectadas: {ExecuteNonQuery(query)}");
                        break;
                    case 2:
                        DateTime dt = DateTime.Now;
                        string queryViaje = $"INSERT INTO viajes (idCard, idTransport, idLine, idSocialRate, ticketCost, kilometres, date) VALUES('{6061103047609000}', '{1}', '{1025}', '{4}', '{59}', '{4}', '{dt}')";
                        Debug.WriteLine($"Filas afectadas: {ExecuteNonQuery(queryViaje)}");
                        break;
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
        }
        
        public static int ExecuteNonQuery(string query)
        {
            commandMySql.CommandText = query;
            return commandMySql.ExecuteNonQuery();
        }
        
    }
}