using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1
{
    internal class Taller
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }

        public Taller(string codigo, string nombre, double costo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Costo = costo;
        }
    }
}
