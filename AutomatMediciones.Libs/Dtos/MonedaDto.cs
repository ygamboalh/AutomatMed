﻿using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class MonedaDto
    {
        public string RecID { get; set; }
        public int Numero { get; set; }
        public string Simbolo { get; set; }
        public string Descripcion { get; set; }

        public List<PresupuestoDto> Presupuestos { get; set; }
    }
}
