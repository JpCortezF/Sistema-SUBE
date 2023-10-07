using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Biblioteca_Usuarios
{
    public class Serializador
    {
        public static void EscribirJson(string ruta, Dictionary<string, Usuario> dictionaryPassengers)
        {
            try
            {
                string json = JsonConvert.SerializeObject(dictionaryPassengers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
