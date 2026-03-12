using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial1
{
    internal class Inscripcion
    {
        public string DPI { get; set; }
        public string CodigoTaller { get; set; }
        public DateTime Fecha { get; set; }

        public Inscripcion(string dpi, string codigoTaller, DateTime fecha)
        {
            DPI = dpi;
            CodigoTaller = codigoTaller;
            Fecha = fecha;
        }
    }
}
