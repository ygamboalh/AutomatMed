using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    class TipoCeldaMap : IEntityTypeConfiguration<TipoCelda>
    {
        public void Configure(EntityTypeBuilder<TipoCelda> builder)
        {
            builder.ToTable("tipos_celda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.VariableMedicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(45)").IsRequired();
        
       

        }
    }
}
