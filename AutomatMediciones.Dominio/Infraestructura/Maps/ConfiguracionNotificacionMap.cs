﻿using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class ConfiguracionNotificacionMap : IEntityTypeConfiguration<ConfiguracionNotificacion>
    {
        public void Configure(EntityTypeBuilder<ConfiguracionNotificacion> builder)
        {
            builder.ToTable("configuraciones_notificaciones");

            builder.HasKey(x => x.ConfiguracionId);
            builder.Property(x => x.ConfiguracionId).HasColumnName("configuracion_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Servidor).HasColumnName("servidor").HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(x => x.Puerto).HasColumnName("puerto").HasColumnType("INT").IsRequired();
            builder.Property(x => x.CorreoOrigen).HasColumnName("correo_origen").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.Password).HasColumnName("password").HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(x => x.Nombre).HasColumnName("nombre").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.Asunto).HasColumnName("asunto").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
        }
    }
}
