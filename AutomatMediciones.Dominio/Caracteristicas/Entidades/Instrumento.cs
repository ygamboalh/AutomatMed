using System;
using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Instrumento
    {
        public int InstrumentoId { get; set; }
        public string Descripcion { get; set; }
        public int ClasificacionId { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? FechaCompraFabricante { get; set; }
        public DateTime? FechaCompraCliente { get; set; }
        public DateTime? FechaUltimaCalibracion { get; set; }
        public DateTime? FechaProximaCalibracion { get; set; }
        public string EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public bool Activo { get; set; }
        public string Garantia { get; set; }
        public string Comentarios { get; set; }
        public ClasificacionInstrumento Clasificacion { get; set; }
        public ICollection<IngresoInstrumento> IngresosInstrumentos { get; set; }


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

            mensaje = "Ok";
            return true;
        }
    }
}
