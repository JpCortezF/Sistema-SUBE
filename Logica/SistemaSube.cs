using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using MyExceptions;

namespace Logica
{
    public class SistemaSube
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();

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
    }
}