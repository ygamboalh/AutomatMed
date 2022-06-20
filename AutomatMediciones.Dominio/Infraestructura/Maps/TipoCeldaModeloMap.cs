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
    class TipoCeldaModeloMap : IEntityTypeConfiguration<TipoCeldaModelo>
    {
        public void Configure(EntityTypeBuilder<TipoCeldaModelo> builder)
        {
            builder.ToTable("tipos_celda_modelo");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.ModeloId).HasColumnName("modelo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TipoCeldaId).HasColumnName("tipo_celda_id").HasColumnType("INT").IsRequired();
        }
    }
}
