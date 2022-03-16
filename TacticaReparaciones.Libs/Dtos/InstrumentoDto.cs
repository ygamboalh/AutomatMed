using System;
using System.Collections.Generic;
using System.Text;

namespace TacticaReparaciones.Libs.Dtos
{
    public class InstrumentoDto
    {
        public int InstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? FechaCompraFabricante { get; set; }
        public DateTime? FechaCompraCliente { get; set; }
        public DateTime? FechaUltimaCalibracion { get; set; }
        public int? PeriodoCalibracionId { get; set; }
        public DateTime? FechaProximaCalibracion { get; set; }
        public int? GarantiaId { get; set; }
        public string EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
    }
}
