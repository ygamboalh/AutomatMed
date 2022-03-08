using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
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
        public int EstadoId { get; set; }
        public int TipoTrabajoId { get; set; }
        public int Prioridad { get; set; }
        public string Comentarios { get; set; }
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

            if (TipoTrabajoId == 0)
            {
                mensaje = "Es necesario ingresar un tipo de trabajo para guardar el el ingreso.";
                return false;
            }

            if (Prioridad == 0)
            {
                mensaje = "Es necesario ingresar una prioridad para guardar el ingreso.";
                return false;
            }

           

            mensaje = "Ok";
            return true;
        }
    }
}
