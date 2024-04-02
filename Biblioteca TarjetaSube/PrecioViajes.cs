using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TarjetaSube
{
    public static class PrecioViajes
    {
        public static float ValorColectivo0To3Km { get; private set; }
        public static float ValorColectivo3To6Km { get; private set; }
        public static float ValorColectivo6To12Km { get; private set; }
        public static float ValorColectivo12To27Km { get; private set; }
        public static float ValorSubte { get; private set; }
        public static float ValorTren { get; private set; }
        public static float ValorSinSubsidio { get; private set; }

        static PrecioViajes()
        {
            ValorColectivo0To3Km = 270.00f;
            ValorColectivo3To6Km = 300.78f;
            ValorColectivo6To12Km = 323.95f;
            ValorColectivo12To27Km = 347.15f;
            ValorSubte = 125f;
            ValorTren = 208f;
            ValorSinSubsidio = 700;
        }
    }
}
