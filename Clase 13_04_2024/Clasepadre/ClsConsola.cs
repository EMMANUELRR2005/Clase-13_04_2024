﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_04_2024.Clase_padre
{
    internal class ClsConsola
    {
        public int anioLanzamiento { get; set; }
        public string Marca { get; set; }

        public string MostrarDetalles()
        {
            return ($"Marca: {Marca} Año: {anioLanzamiento}");
        }
    }
}
