using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Biblioteca_TarjetaSube;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Biblioteca_Usuarios
{
    public abstract class Serializador
    {
        /*
        public static void WriteJsonPassenger(string path, List<Pasajero> listaPassengers)
        {
            try
            {
                string json = JsonConvert.SerializeObject(listaPassengers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static List<Pasajero> ReadJsonPassenger(string path)
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                if(File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    lista = JsonConvert.DeserializeObject<List<Pasajero>>(json);
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
            return lista;
        }

        public static void WriteJsonAdmin(string path, List<Administrador> listAdmins)
        {
            try
            {                           
                string json = JsonConvert.SerializeObject(listAdmins, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static List<Administrador> ReadJsonAdmin(string path)
        {
            List<Administrador> listAdmin = new List<Administrador>();

            try
            {
                string json = File.ReadAllText(path);
                listAdmin = JsonConvert.DeserializeObject<List<Administrador>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return listAdmin;
        }

        public static void WriteXMLTramites(string path, List<Tramites> Lista)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Tramites>));
                ser.Serialize(sw, Lista);
            }
        }

        public static List<Tramites> ReadXMLTramites(string path)
        {
            List<Tramites> lista = new List<Tramites>();
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        XmlSerializer des = new XmlSerializer(typeof(List<Tramites>));

                        lista = (List<Tramites>)des.Deserialize(sr);
                    }
                }
                else
                {
                    Console.WriteLine("El archivo XML está vacío o no existe.");
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);

                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                    Console.WriteLine("Inner Exception StackTrace: " + ex.InnerException.StackTrace);
                }
            }

            return lista;
        }
        */
    }
}
