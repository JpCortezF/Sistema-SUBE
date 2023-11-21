using Biblioteca_TarjetaSube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Usuarios
{
    public class SerializadorXML<T> : ISerializable<T> where T : new()
    {
        public SerializadorXML()
        {
            
        }
        public bool Serialize(string path, T Lista)
        {
            bool success = false;
            using (StreamWriter sw = new StreamWriter(path))
            {
                if(sw != null)
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                    ser.Serialize(sw, Lista);
                    success = true;
                }
            }
            return success;
        }

        public T Deserialize(string path, Func<T> factoryMethod)
        {
            T lista = default(T);
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader stream = new StreamReader(path))
                    {
                        if (stream != null)
                        {
                            XmlSerializer des = new XmlSerializer(typeof(T));
                            lista = (T)des.Deserialize(stream);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El archivo XML no existe.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar el archivo XML:");
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
