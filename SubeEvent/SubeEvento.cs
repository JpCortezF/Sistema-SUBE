using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca_TarjetaSube;
namespace SubeEvent
{
    public class SubeEvento : EventArgs
    {
        int travelsCount;

        public int TravelsCount { get => travelsCount; set => travelsCount = value; }

        public SubeEvento()
        {

        }
    }
}