using System;
using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int MenuPadre { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAgrega { get; set; }
        public int Posicion { get; set; }
        public string Icono { get; set; }
        public string Color { get; set; }
        public int IndiceMenu { get; set; }

        public List<MenuDto> Items { get; set; }
    }
}
