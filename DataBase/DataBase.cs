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
using System.Net.Sockets;

namespace Biblioteca_DataBase
{
    public class DataBase<T> : IDBCommands<T>
    {
        public static MySqlConnection connectionMySql;
        public static MySqlCommand commandMySql;
        string localhost = @"Server=localhost;Port=3307;Database=proyectosube;Uid=root;Pwd=;";

        static DataBase()
        {

            var mySqlStringConnection = @"Server=localhost;Port=3307;Database=proyectosube;Uid=root;Pwd=;";

            using (connectionMySql = new MySqlConnection(mySqlStringConnection))
            {
                commandMySql = new MySqlCommand();
                commandMySql.CommandType = System.Data.CommandType.Text;
                commandMySql.Connection = connectionMySql;
            }
        }
             
        public static void OpenConection()
        {
            try
            {
                connectionMySql.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message + "\nPrimero deberias abrir la base de datos!");
            }
            catch(SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<T> Select(string query, Dictionary<string, object> parameters, Func<MySqlDataReader, T> mapObject)
        {
            List<T> list = new List<T>();
            Exception x = null;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(localhost))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Clear();

                        // Verificar si hay parámetros y agregarlos a la consulta
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                            }
                        }

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(mapObject(reader));
                            }
                        }
                    }
                }

                return list;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                x = ex;
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if(x != null)
                {

                }
                if (connectionMySql.State == ConnectionState.Open)
                {
                    connectionMySql.Close();
                }
            }
        }

        public bool Insert(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                OpenConection();

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
                Console.WriteLine("Error al insertar a MySQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al insertar el elemento a MySQL: " + ex.Message);
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
                OpenConection();

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
                OpenConection();

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
            var mySqlStringConnection = localhost;

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