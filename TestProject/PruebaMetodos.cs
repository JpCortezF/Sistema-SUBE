using Logica;
using Biblioteca_TarjetaSube;
using Biblioteca_Serializadora;
using MyExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPOI.SS.Formula.Functions;
using Biblioteca_Usuarios;
using System.IO;
using System.IdentityModel.Tokens.Jwt;

namespace TestProject

{
    public class Tests
    {

        [Test]
        public void CostByKilometresDeberiaCalcularCostoCorrecto()
        {
            // Arrange
            Viajes miViaje = new Viajes { Kilometres = 5 }; // Kilómetros dentro del rango 3-6 km

            // Act
            float costoCalculado = miViaje.CostByKilometres(miViaje);

            // Assert
            float costoEsperado = PrecioViajes.ValorColectivo3To6Km;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(costoEsperado, costoCalculado, "El costo calculado no coincide con el esperado para 5 km.");
        }

        [Test]
        [ExpectedException(typeof(KilometrosException))]
        public void CostByKilometres_DeberiaLanzarExcepcionKilometrosCero()
        {
            // Arrange
            Viajes miViaje = new Viajes { Kilometres = 0 }; // Kilómetros 0

            // Act & Assert
            miViaje.CostByKilometres(miViaje); // Debería lanzar una excepción KilometrosException
        }

        [Test]
        [ExpectedException(typeof(KilometrosException))]
        public void CostByKilometres_DeberiaLanzarExcepcionKilometrosExcedidos()
        {
            // Arrange
            Viajes miViaje = new Viajes { Kilometres = 25 }; // Kilómetros exceden el límite

            // Act & Assert
            miViaje.CostByKilometres(miViaje); // Debería lanzar una excepción KilometrosException
        }


        [Test]
        public void Serialize_ShouldSerializeObjectToJsonFile()
        {
            // Arrange
            SerializadorJSON<List<string>> serializer = new SerializadorJSON<List<string>>(); // Reemplaza YourSerializerClass con el nombre de tu clase que contiene el método Serialize
            string ruta = @"..\..\..\Data";
            string nombre = "Prueba.Json";
            string path = Path.Combine(ruta, nombre);
            List<string> myList = new List<string> { "item1", "item2", "item3" }; // Objeto de ejemplo que se va a serializar

            // Act
            bool result = serializer.Serialize(path, myList);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "La serialización debería ser exitosa");

            // Verificar si el archivo se ha creado en la ruta especificada
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(File.Exists(path), "El archivo debería ser creado después de la serialización");

            // Opcional: verificar el contenido del archivo si es necesario
            string jsonContent = File.ReadAllText(path);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(string.IsNullOrEmpty(jsonContent), "El archivo JSON no debería estar vacío");
        }

        [Test]
        public void EncriptarClaveYDesencriptarClave_DeverianEncriptarYDesencriptarCorrectamente()
        {
            // Arrange
            string claveOriginal = Administrador.KeyToEncrypt();
            string textoOriginal = "megustaelarte";

            // Act
            string textoEncriptado = Administrador.EncriptarClave(textoOriginal, claveOriginal);
            string textoDesencriptado = Administrador.DesencriptarClave(textoEncriptado, claveOriginal);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(textoOriginal, textoEncriptado, "El texto encriptado debe ser diferente al original");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(textoOriginal, textoDesencriptado, "El texto desencriptado debe ser igual al original");
        }

        [Test]
        public void Serialize_ShouldSerializeObjectToXml()
        {
            // Arrange
            SerializadorXML<List<string>> serializer = new SerializadorXML<List<string>>();
            string ruta = @"..\..\..\Data";
            string nombre = "Prueba.xml";
            string path = Path.Combine(ruta, nombre);
            List<string> myList = new List<string> { "item1", "item2", "item3" };


            // Act
            bool result = serializer.Serialize(path, myList);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "La serializacion deberia ser correcta");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(File.Exists(path), "Se deberia crear el archivo despues de la serializacion");
        }

    }




}
