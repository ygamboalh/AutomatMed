using System;
using System.Collections.Generic;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Ingreso
    {
        public int IngresoId { get; set; }
        public string EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public string ContactoId { get; set; }
        public string NombreContacto { get; set; }
        public string CorreoElectronicoId { get; set; }
        public string DireccionCorreoElectronico { get; set; }    
        public string CuerpoCorreo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioResponsableId { get; set; }
        public bool Activo { get; set; }
        public ICollection<IngresoInstrumento> IngresosInstrumentos { get; set; }

        public bool EsValido(out string mensaje)
        {
            if (string.IsNullOrEmpty(NombreEmpresa))
            {
                mensaje = "Es necesario ingresar un nombre de empresa para guardar el ingreso.";
                return false;
            }

            if (string.IsNullOrEmpty(NombreContacto))
            {
                mensaje = "Es necesario ingresar un nombre de contacto para guardar el ingreso.";
                return false;
            }

            if (string.IsNullOrEmpty(DireccionCorreoElectronico))
            {
                mensaje = "Es necesario ingresar una dirección de correo electrónico para guaardar el ingreso.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }
    }
}
