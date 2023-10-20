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
            ValorColectivo0To3Km = 52.96f;
            ValorColectivo3To6Km = 59.00f;
            ValorColectivo6To12Km = 63.54f;
            ValorColectivo12To27Km = 68.09f;
            ValorSubte = 80f;
            ValorTren = 90f;
            ValorSinSubsidio = 700;
        }
    }
}
