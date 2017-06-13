using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Procesador
    {
        private int nProceso = 0;
        public int pendientes, suma;
        public Proceso inicio { get; set; }
        private Proceso final;
        private Proceso actual;
        private static Random ciclos = new Random();

        public void crearProceso()
        {
            Proceso nuevo = new Proceso();
            nuevo.nombre = Convert.ToString("Proceso " + nProceso);
            nuevo.ciclos = ciclos.Next(4, 15);

            if (inicio == null)
            {
                inicio = nuevo;
                final = nuevo;
            }
            else
            {
                actual = inicio;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
                nuevo.anterior = actual;
                final = nuevo;
            }
            nProceso++;
        }

        public void eliminarProceso()
        {
            if (inicio == final && inicio.ciclos == 0)
            {
                inicio = null;
                final = null;
            }
            else
            {
                if (inicio.ciclos == 0)
                {
                    inicio.siguiente.anterior = null;
                    inicio = inicio.siguiente;
                }
                else
                {
                    inicio.ciclos--;
                }
            }
        }

        public void pendientesSuma()
        {
            if (inicio == null)
            {
                pendientes = 0;
                suma = 0;
            }
            else
            {
                actual = inicio;
                while (actual != null)
                {
                    pendientes++;
                    suma = suma + actual.ciclos;
                    actual = actual.siguiente;
                }
            }
        }
    }
}
