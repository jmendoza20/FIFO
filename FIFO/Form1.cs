using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random probabilidad = new Random();
        Procesador procesador = new Procesador();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int prob, cont = 1, emp = 0;

            while (cont <= 200)
            {
                prob = probabilidad.Next(1, 5);
                if (procesador.inicio != null)
                    procesador.eliminarProceso();
                if (prob == 4)
                    procesador.crearProceso();
                if (procesador.inicio == null)
                    emp++;
                cont++;
            }
            procesador.pendientesSuma();
            txtReporte.Text = "Ciclos vacios: " + emp + Environment.NewLine + "Procesos pendientes: " + procesador.pendientes + Environment.NewLine + "Ciclos restantes: " + procesador.suma;
            emp = 0;
            procesador.pendientes = 0;
            procesador.suma = 0;
            procesador = new Procesador();
        }
    }
}
