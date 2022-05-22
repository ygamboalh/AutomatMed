﻿using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class PatronMap : IEntityTypeConfiguration<Patron>
    {
        public void Configure(EntityTypeBuilder<Patron> builder)
        {
            builder.ToTable("patrones");

            builder.HasKey(x => x.PatronId);
            builder.Property(x => x.PatronId).HasColumnName("patron_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.FechaCaducidad).HasColumnName("fecha_caducidad").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.Nombre).HasColumnName("nombre").HasColumnType("VARCHAR(120)").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Link).HasColumnName("link").HasColumnType("VARCHAR(100)").IsRequired();

            builder.HasMany(x => x.VariablesPatrones).WithOne(x => x.Patron).HasForeignKey(x => x.PatronId);
            builder.HasMany(x => x.VariablesCertificado).WithOne(x => x.Patron).HasForeignKey(x => x.PatronId);
        }
    }
}
