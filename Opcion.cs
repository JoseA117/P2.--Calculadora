using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO
{
    internal class Opcion
    {
        public string Mensaje { get; set; }
        public Action Accion { get; set; }

        public Opcion(string mensaje, Action accion)
        {
            Mensaje = mensaje;
            Accion = accion;
        }
    }
}
