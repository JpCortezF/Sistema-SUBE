using MySql.Data.MySqlClient;
using Biblioteca_Usuarios;
using Biblioteca_TarjetaSube;
using NPOI.OpenXmlFormats.Spreadsheet;
using System.Diagnostics;
using System.Data;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Vml;
using static NPOI.HSSF.Util.HSSFColor;
using System.Collections;

namespace Biblioteca_DataBase
{
    public class DataBase<T> : IDBCommands<T>
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
             
        public static int ExecuteNonQuery(string query)
        {
            commandMySql.CommandText = query;
            return commandMySql.ExecuteNonQuery();
        }

        public List<T> Select(string query, Dictionary<string, object> parameters, Func<MySqlDataReader, T> mapObject)
        {
            List<T> list = new List<T>();
            try
            {
                connectionMySql.Open();

                commandMySql.CommandText = query;

                commandMySql.Parameters.Clear();

                // Verificar si hay parámetros y agregarlos a la consulta
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        commandMySql.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                using (MySqlDataReader reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(mapObject(reader));
                    }
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connectionMySql.Close();
            }
        }
        public bool Insert(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                connectionMySql.Open();

                commandMySql.CommandText = query;

                commandMySql.Parameters.Clear();

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        commandMySql.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                commandMySql.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la actualización de MySQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general en la actualización de MySQL: " + ex.Message);
                return false;
            }
            finally
            {
                if (connectionMySql.State == ConnectionState.Open)
                {
                    connectionMySql.Close();
                }
            }
        }
        public bool Update(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                connectionMySql.Open();

                commandMySql.CommandText = query;

                commandMySql.Parameters.Clear();

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        commandMySql.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                commandMySql.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la actualización de MySQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general en la actualización de MySQL: " + ex.Message);
                return false;
            }
            finally
            {
                if (connectionMySql.State == ConnectionState.Open)
                {
                    connectionMySql.Close();
                }
            }
        }
        public bool Delete(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                connectionMySql.Open();

                commandMySql.CommandText = query;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        commandMySql.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                commandMySql.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la eliminación de MySQL: " + ex.Message);
                Console.WriteLine("Número de error MySQL: " + ex.Number);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general en la eliminación de MySQL: " + ex.Message);
                return false;
            }
            finally
            {
                if (connectionMySql.State == ConnectionState.Open)
                {
                    connectionMySql.Close();
                }
            }
            
        }

        public DataTable Data(string query, Dictionary<string, object> parameters = null)
        {
            DataTable table = new DataTable();
            var mySqlStringConnection = @"Server=localhost;Port=3307;Database=proyectosube;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(mySqlStringConnection))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    // Asigna el comando a la variable cmd
                    using (MySqlDataAdapter data = new MySqlDataAdapter(cmd))
                    {
                        cmd.CommandText = query;

                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Llena la tabla con los datos obtenidos
                            table.Load(reader);
                        }
                    }
                }
            }

            return table;
        }

    }
}