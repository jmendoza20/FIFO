using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Proceso
    {
        public string nombre { get; set; }
        public int ciclos { get; set; }
        public Proceso siguiente { get; set; }
        public Proceso anterior { get; set; }

        public override string ToString()
        {
            string cadena = "Proceso: " + nombre + Environment.NewLine + "No. ciclos: " + ciclos + Environment.NewLine;
            return cadena;
        }
    }
}
