using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Biblioteca_Usuarios
{
    public class Serializador
    {
        public static void WriteJson(string path, Dictionary<string, Pasajero> dictionaryPassengers)
        {
            try
            {   
                string json = JsonConvert.SerializeObject(dictionaryPassengers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static Dictionary<string, Pasajero> ReadJson(string path)
        {
            Dictionary<string, Pasajero> dictionary = new Dictionary<string, Pasajero>();

            try
            {
                string json = File.ReadAllText(path);
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, Pasajero>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dictionary;
        }
    }
}
