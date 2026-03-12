using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1
{
    internal class Estudiante
    {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Estudiante(string dpi, string nombre, string direccion)
        {
            DPI = dpi;
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
