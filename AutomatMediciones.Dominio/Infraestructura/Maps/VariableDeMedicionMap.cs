﻿using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class VariableDeMedicionMap : IEntityTypeConfiguration<VariableDeMedicion>
    {
        public void Configure(EntityTypeBuilder<VariableDeMedicion> builder)
        {
            builder.ToTable("variables_de_medicion");

            builder.HasKey(x => x.VariableMedicionId);
            builder.Property(x => x.VariableMedicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(x => x.DescripcionCorta).HasColumnName("descripcion_corta").HasColumnType("VARCHAR(80)");
            builder.Property(x => x.Nombre).HasColumnName("nombre").HasColumnType("VARCHAR(100)");
            builder.Property(x => x.PrimerValorRango).HasColumnName("primer_valor_rango").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.SegundoValorRango).HasColumnName("segundo_valor_rango").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.Tolerancia).HasColumnName("tolerancia").HasColumnType("DECIMAL").IsRequired();

            builder.HasMany(x => x.TiposDeInstrumentoVariables).WithOne(x => x.VariableDeMedicion).HasForeignKey(x => x.VariableMedicionId);
            builder.HasMany(x => x.VariablesInstrumentos).WithOne(x => x.VariableDeMedicion).HasForeignKey(x => x.VariableMedicionId);
            builder.HasMany(x => x.VariablesPatrones).WithOne(x => x.VariableDeMedicion).HasForeignKey(x => x.VariableMeicionId);
            builder.HasMany(x => x.TiposDeCeldas).WithOne(x => x.VariableDeMedicion).HasForeignKey(x => x.VariableMedicionId);
        }
    }
}
