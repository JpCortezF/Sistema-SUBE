﻿using System;
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
    public class Serializador
    {
        public static void WriteJsonPassenger(string path, Dictionary<string, Pasajero> dictionaryPassengers)
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

        public static Dictionary<string, Pasajero> ReadJsonPassenger(string path)
        {
            Dictionary<string, Pasajero> dictionary = new Dictionary<string, Pasajero>();

            try
            {
                if(File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    dictionary = JsonConvert.DeserializeObject<Dictionary<string, Pasajero>>(json);
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

        public static void WriteJsonAdmin(string path, Dictionary<string, Administrador> dictionaryAdmins)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = JsonConvert.SerializeObject(dictionaryAdmins, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(path, json);
                }
                else
                {
                    Console.WriteLine("El archivo JSON no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static Dictionary<string, Administrador> ReadJsonAdmin(string path)
        {
            Dictionary<string, Administrador> dictionary = new Dictionary<string, Administrador>();

            try
            {
                string json = File.ReadAllText(path);
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, Administrador>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dictionary;
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
            List<Tramites> lista = null;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Tramites>));

                lista = (List<Tramites>)des.Deserialize(sr);
            }

            return lista;
        }
    }
}
