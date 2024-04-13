using Clase_13_04_2024.Clase_padre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_04_2024.ClaseHija
{
    internal class Playstation:ClsConsola 
    {
        public string ModeloControlador { get; set; }
        public string MostrarDetalleplay()
        {
            return MostrarDetalles() + "Controlador:"+ ModeloControlador;

        }
    }
}
