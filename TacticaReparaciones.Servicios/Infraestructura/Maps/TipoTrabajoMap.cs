using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class TipoTrabajoMap : IEntityTypeConfiguration<TipoTrabajo>
    {
        public void Configure(EntityTypeBuilder<TipoTrabajo> builder)
        {
            builder.ToTable("tipos_de_trabajo");

            builder.HasKey(x => x.TipoTrabajoId);
            builder.Property(x => x.TipoTrabajoId).HasColumnName("tipo_trabajo_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR").HasMaxLength(200);
        }
    }
}
