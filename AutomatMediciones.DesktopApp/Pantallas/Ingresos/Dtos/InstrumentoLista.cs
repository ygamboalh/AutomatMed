﻿using AutomatMediciones.Libs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos
{
    public class InstrumentoLista : InstrumentoDto
    {
        public bool Seleccionado { get; set; }
        public string Comentarios { get; set; }
    }
}
