using System;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class Instrumento
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
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public bool Activo { get; set; }

        public bool EsValido(out string mensaje)
        {
            if (string.IsNullOrEmpty(NombreEmpresa))
            {
                mensaje = "Es necesario ingresar un nombre de empresa para guardar el ingreso.";
                return false;
            }

            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Es necesario ingresar una descripcion para el instrumento.";
                return false;
            }
            
             if (TipoInstrumentoId == 0)
            {
                mensaje = "Es necesario ingresar un tipo de instrumento para el nuevo instrumento.";
                return false;
            }

            if (MarcaId == 0)
            {
                mensaje = "Es necesario ingresar una marca para el instrumento.";
                return false;
            }

            if (ModeloId == 0)
            {
                mensaje = "Es necesario ingresar un modelo para el instrumento.";
                return false;
            }

           
            mensaje = "Ok";
            return true;
        }
    }
}
