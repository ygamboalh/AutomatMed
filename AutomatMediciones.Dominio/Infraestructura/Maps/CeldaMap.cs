﻿using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class CeldaMap : IEntityTypeConfiguration<Celda>
    {
        public void Configure(EntityTypeBuilder<Celda> builder)
        {
            builder.ToTable("celdas");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroSerie).HasColumnName("numero_serie").HasColumnType("VARCHAR(45)").IsRequired();
            builder.Property(x => x.FechaAdquisicion).HasColumnName("fecha_adquisicion").HasColumnType("DATETIME");
            builder.Property(x => x.FechaFabricacion).HasColumnName("fecha_fabricacion").HasColumnType("DATETIME");
            builder.Property(x => x.Estado).HasColumnName("estado").HasColumnType("VARCHAR(45)");
            builder.Property(x => x.TipoCeldaId).HasColumnName("tipo_celda_id").HasColumnType("INT").IsRequired();
          
        }
    }
}
