﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class TipoInstrumentoVariable
    {
        public int TipoInstrumentoVariableId { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int VariableMedicionId { get; set; }
    }
}
