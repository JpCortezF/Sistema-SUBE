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

        private string GetInsertQueryPasajero(Pasajero passenger, TarjetaSube mySube)
        {
            return $"INSERT INTO pasajeros (dni, name, lastname, email, password, idGender, idSube) " +
                   $"VALUES('{passenger.Dni}', '{passenger.Name}', '{passenger.LastName}', '{passenger.Email}', '{passenger.Password}', '{passenger.Gender}', '{mySube.CardNumber}')";
        }

        private string GetInsertQuerySube(TarjetaSube mySube)
        {
            return $"INSERT INTO tarjetas (id, balance, socialRate) VALUES('{mySube.CardNumber}', '{0}', '{1}')";
        }
       
        private string GetInsertQueryViaje(Viajes travel)
        {
            return $"INSERT INTO viajes (idCard, idTransport, idLine, idSocialRate, ticketCost, kilometres, date) VALUES('{travel.TarjetaSube.CardNumber}', '{travel.TipoTransporte}', '{travel.LineasTransporte}', '{travel.TarjetaSube.TarifaSocial}', '{travel.TicketCost}', '{travel.Kilometres}', '{DateTime.Now}')";
        }

        private string GetInsertQueryTramite(Tramites claim)
        {
            return $"INSERT INTO tramites (dniClaimer, claimMessage, claimTime, idClaimStatus) VALUES('{claim.Passenger.Dni}','{claim.ClaimMessage}','{DateTime.Now}','{claim.ClaimComplete}')";
        }
        /*
        private string GetUpdateQueryPasajero(Pasajero passenger, int estado)
        {
            string query = "";
            switch (estado)
            {
                case 1:
                    query = $"UPDATE pasajeros SET idSube = NULL WHERE {passenger.MySube.CardNumber} = idSube";
                break;
                case 2:
                    query = $"UPDATE pasajeros SET idSube = {passenger.MySube.CardNumber}";
                break;
            }
            return query ;
        }
        */
    }
}