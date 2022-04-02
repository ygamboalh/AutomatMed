using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class VariableDeMedicionMap : IEntityTypeConfiguration<VariableDeMedicion>
    {
        public void Configure(EntityTypeBuilder<VariableDeMedicion> builder)
        {
            builder.ToTable("variables_de_medicion");

            builder.HasKey(x => x.VariableMedicionId);
            builder.Property(x => x.VariableMedicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.PrimerValorRango).HasColumnName("primer_valor_rango").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.SegundoValorRango).HasColumnName("segundo_valor_rango").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.Tolerancia).HasColumnName("tolerancia").HasColumnType("DECIMAL").IsRequired();
        }
    }
}
