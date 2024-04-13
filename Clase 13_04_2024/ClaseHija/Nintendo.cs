using Clase_13_04_2024.Clase_padre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_04_2024.Clase_hija
{
    internal class Nintendo:ClsConsola 
    {
        public bool esportable { get; set; }
        public string MostrarDetallesNintendo();
        {
            string detallespadre = MostrarDetallesNintendo();
            return mostrardetalles + "Es portable" + esportable;

        }


}
}
