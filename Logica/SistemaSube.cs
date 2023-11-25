using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using MyExceptions;
using System.Data;

namespace Logica
{
    public class SistemaSube
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();

        /// <summary>
        /// Retorna la información de la tarjeta SUBE asociada a un pasajero específico.
        /// </summary>
        /// <param name="passenger">Objeto Pasajero con la información del pasajero.</param>
        /// <returns>Objeto TarjetaSube con la información de la tarjeta SUBE asociada al pasajero.</returns>
        public TarjetaSube ReturnSubePassenger(Pasajero passenger)
        {
            parameters.Clear();
            TarjetaSube sube = new TarjetaSube();
            string query = @"SELECT * FROM pasajeros INNER JOIN tarjetas ON tarjetas.id = pasajeros.idSube WHERE idSube = @IdSube AND id = @IdCardNumber";
            parameters.Add("@IdSube", passenger.IdSube);
            parameters.Add("@IdCardNumber", passenger.IdSube);
            List<TarjetaSube> listSube = data.Select(query, parameters, sube.Map);

            return listSube.FirstOrDefault();
        }
        /// <summary>
        /// Actualiza el saldo de una tarjeta SUBE en la base de datos.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube con la información de la tarjeta a actualizar.</param>
        /// <returns>Un diccionario con los parámetros utilizados en la actualización.</returns>
        public Dictionary<string, object> UpdateSubeBalance(TarjetaSube sube)
        {
            parameters.Clear();
            string queryUpdate = @"UPDATE tarjetas SET balance = @balanceUpdate WHERE id = @idSube";
            parameters.Add("@balanceUpdate", sube.Balance);
            parameters.Add("@idSube", sube.CardNumber);
            data.Update(queryUpdate, parameters);

            return parameters;
        }
        /// <summary>
        /// Genera un nuevo registro de viaje en la base de datos, asociado a una tarjeta SUBE, transporte, línea y detalles del viaje.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube asociado al viaje.</param>
        /// <param name="miTransporte">Tipo de transporte del viaje.</param>
        /// <param name="miLinea">Línea de transporte utilizada en el viaje.</param>
        /// <param name="miViaje">Detalles del viaje a registrar.</param>
        /// <returns>Un diccionario con los parámetros utilizados en la inserción del viaje.</returns>
        public Dictionary<string, object> GenerarViaje(TarjetaSube sube, ETransporte miTransporte, LineasTransporte miLinea, Viajes miViaje)
        {
            parameters.Clear();
            string queryInsert = @"INSERT INTO viajes(idCard, idTransport, idLine, idSocialRate, ticketCost, kilometres, date) VALUES(@IdCard, @IdTransport, @IdLine, @IdSocialRate, @TicketCost, @Kilometres, @Date)";
            parameters.Add("@IdCard", sube.CardNumber);
            parameters.Add("@IdTransport", miTransporte);
            parameters.Add("@IdLine", miLinea.Id);
            parameters.Add("@IdSocialRate", sube.TarifaSocial);
            parameters.Add("@TicketCost", miViaje.TicketCost);
            parameters.Add("@Kilometres", miViaje.Kilometres);
            parameters.Add("@Date", DateTime.Now);
            data.Insert(queryInsert, parameters);

            return parameters;
        }
        /// <summary>
        /// Obtiene la información de una tarjeta SUBE asociada a un pasajero específico.
        /// </summary>
        /// <param name="pasajero">Objeto Pasajero con la información del pasajero.</param>
        /// <returns>Objeto TarjetaSube con la información de la tarjeta SUBE asociada al pasajero.</returns>
        public TarjetaSube GetSubeFromPasajero(Pasajero pasajero)
        {
            parameters.Clear();
            string querySube = @"SELECT * FROM pasajeros INNER JOIN tarjetas ON tarjetas.id = pasajeros.idSube WHERE idSube = @IdSube AND id = @IdCardNumber";
            parameters.Add("@IdSube", pasajero.IdSube);
            parameters.Add("@IdCardNumber", pasajero.IdSube);
            List<TarjetaSube> listSube = new List<TarjetaSube>();
            TarjetaSube sube = new TarjetaSube();
            listSube = data.Select(querySube, parameters, sube.Map);
            sube = listSube.FirstOrDefault();

            return sube;
        }

        /// <summary>
        /// Carga las líneas de transporte disponibles para un tipo específico de transporte.
        /// </summary>
        /// <param name="tipoTransporte">Tipo de transporte del cual cargar las líneas.</param>
        /// <returns>Una lista de objetos LineasTransporte ordenada según el tipo de transporte.</returns>
        public List<LineasTransporte> CargarLineasTransporte(ETransporte tipoTransporte)
        {
            DataBase<LineasTransporte> data = new DataBase<LineasTransporte>();
            LineasTransporte lineaCtor = new LineasTransporte();
            List<LineasTransporte> lineas = new List<LineasTransporte>();
            lineas.Clear();
            parameters.Clear();
            string query = @"SELECT * FROM lineas WHERE idTransport = @idTransport";
            parameters.Add("@idTransport", tipoTransporte);
            lineas = data.Select(query, parameters, lineaCtor.Map);
            
            if (tipoTransporte == ETransporte.Colectivo)
            {
                lineas.Sort((a, b) =>
                {
                    try
                    {
                        if (int.TryParse(a.Line, out int numA) && int.TryParse(b.Line, out int numB))
                        {
                            return numA.CompareTo(numB);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                });
            }
            else
            {
                lineas.Sort((a, b) => string.Compare(a.Line, b.Line, StringComparison.OrdinalIgnoreCase));
            }                     
            return lineas;
        }
        /// <summary>
        /// Inicia un temporizador para simular la carga de saldo y la generación de un viaje después de un tiempo determinado.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube asociado al viaje.</param>
        /// <param name="miTransporte">Tipo de transporte del viaje.</param>
        /// <param name="miLinea">Línea de transporte utilizada en el viaje.</param>
        /// <param name="miViaje">Detalles del viaje a registrar.</param>
        public void LoadTravelWithTimer(TarjetaSube sube, ETransporte miTransporte, LineasTransporte miLinea, Viajes miViaje)
        {
            int time = 0;
            switch (miViaje.Kilometres)
            {
                case float k when k >= 0 && k <= 3:
                    time = 5000;
                    break;
                case float k when k >= 3 && k <= 6:
                    time = 10000;
                    break;
                case float k when k >= 6 && k <= 12:
                    time = 13500;
                    break;
                case float k when k >= 12 && k <= 27:
                    time = 16500;
                    break;
            }
            Task task1 = new Task((object tiempoParam) =>
            {
                int time = (int)tiempoParam;

                Thread.Sleep(time);
                UpdateSubeBalance(sube);
                GenerarViaje(sube, miTransporte, miLinea, miViaje);

            }, time);
            task1.Start();        
        }
        /// <summary>
        /// Verifica si un número de tarjeta SUBE ya existe en la base de datos.
        /// </summary>
        /// <param name="cardnumber">Número de tarjeta SUBE a verificar.</param>
        /// <returns>True si la tarjeta ya existe, False si no.</returns>
        public bool CardNumberExits(string cardnumber)
        {
            bool exist = true;
            string query = "SELECT * FROM tarjetas WHERE id = @subeRandom";
            parameters.Clear();
            parameters.Add("@subeRandom", cardnumber);
            TarjetaSube sube = new TarjetaSube();
            if (data.Select(query, parameters, sube.Map).Count == 0)
            {
                exist = false;
            }
            return exist;
        }
        /// <summary>
        /// Obtiene una tarjeta SUBE que tenga una tarifa social específica.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube con la información de la tarjeta SUBE, incluida la tarifa social a buscar.</param>
        /// <returns>Objeto TarjetaSube con la información de la tarjeta que tiene la tarifa social especificada.</returns>
        public TarjetaSube GetSocialRateFromSube(TarjetaSube sube)
        {
            List<TarjetaSube> listSube = new List<TarjetaSube>();

            string queryTarjeta = @"
                SELECT tarifassociales.rate
                FROM tarjetas
                INNER JOIN 
                    tarifassociales ON tarifassociales.id = tarjetas.id
                WHERE 
                    tarifassociales.rate = @SocialRate";
            parameters.Add("@SocialRate", sube.TarifaSocial);

            listSube = data.Select(queryTarjeta, parameters, sube.Map);
            sube = listSube.FirstOrDefault();
            return sube;
        }
        /// <summary>
        /// Actualiza el valor de la tarifa social a "SUBE Gold" en la tabla de tarjetas SUBE.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube con la información de la tarjeta SUBE.</param>
        public void UpdateSubeGold(TarjetaSube sube)
        {
            parameters.Clear();
            string update = @"
            UPDATE tarjetas SET socialRate = @SubeGold WHERE id = @CardNumber";
            parameters.Add("@CardNumber", sube.CardNumber);
            parameters.Add("@SubeGold", ETarifaSocial.SubeGold);
            data.Update(update, parameters);
        }
        /// <summary>
        /// Restablece el valor de la tarifa social a "Ninguna" en la tabla de tarjetas SUBE.
        /// </summary>
        /// <param name="sube">Objeto TarjetaSube con la información de la tarjeta SUBE.</param>
        public void ResetSocialRate(TarjetaSube sube)
        {
            parameters.Clear();
            string update = @"
            UPDATE tarjetas SET socialRate = @updateSocialRate WHERE id = @CardNumber";
            parameters.Add("@CardNumber", sube.CardNumber);
            parameters.Add("@updateSocialRate", ETarifaSocial.Ninguna);
            data.Update(update, parameters);
        }
    }
}