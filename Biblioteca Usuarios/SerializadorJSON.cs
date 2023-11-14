using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Usuarios
{
    public class SerializadorJSON<T> : ISerializable<T>
    {
        public SerializadorJSON()
        {
            
        }
        public bool Serialize(string path, T dictionary)
        {
            bool success = false;
            try
            {
                string json = JsonConvert.SerializeObject(dictionary, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }

        public T Deserialize(string path)
        {
            T dictionary = default(T);

            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    dictionary = JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    Console.WriteLine("El archivo JSON no existe.");
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al trabajar con el archivo:");
                Console.WriteLine(ex.Message);
            }
            return dictionary;
        }
    }
}
