using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Serializadora
{
    public class Configuracion
    {
        string configuracionProg;
        string dato;

        public Configuracion() { }

        public Configuracion(string configuracionProg, string dato)
        {
            this.configuracionProg = configuracionProg;
            this.dato = dato;
        }

        public string ConfiguracionProg { get => configuracionProg; set => configuracionProg = value; }
        public string Dato { get => dato; set => dato = value; }


    }
}
