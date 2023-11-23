using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using MyExceptions;

namespace Logica
{
    public class SistemaSube
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();

        public Dictionary<string, object> UpdateSubeBalance(TarjetaSube sube)
        {
            parameters.Clear();
            string queryUpdate = @"UPDATE tarjetas SET balance = @balanceUpdate WHERE id = @idSube";
            parameters.Add("@balanceUpdate", sube.Balance);
            parameters.Add("@idSube", sube.CardNumber);
            parameters.Add("queryUpdate", queryUpdate);
            data.Update(queryUpdate, parameters);

            return parameters;
        }
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
            parameters.Add("queryInsert", queryInsert);
            data.Insert(queryInsert, parameters);

            return parameters;
        }
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
    }
}