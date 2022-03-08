﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("ingresos");

            builder.HasKey(x => x.IngresoId);
            builder.Property(x => x.IngresoId).HasColumnName("ingreso_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.EmpresaId).HasColumnName("empresa_id").HasColumnType("VARCHAR").HasMaxLength(12).IsRequired();
            builder.Property(x => x.NombreEmpresa).HasColumnName("nombre_empresa").HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(x => x.ContactoId).HasColumnName("contacto_id").HasColumnType("VARCHAR").HasMaxLength(12).IsRequired();
            builder.Property(x => x.NombreContacto).HasColumnName("nombre_contacto").HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(x => x.CorreoElectronicoId).HasColumnName("correo_electronico_id").HasColumnType("VARCHAR").HasMaxLength(12).IsRequired();
            builder.Property(x => x.DireccionCorreoElectronico).HasColumnName("direccion_correo").HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(x => x.EstadoId).HasColumnName("estado_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TipoTrabajoId).HasColumnName("tipo_trabajo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Prioridad).HasColumnName("prioridad").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Comentarios).HasColumnName("comentarios").HasColumnType("VARCHAR").HasMaxLength(3000);
            builder.Property(x => x.FechaRegistro).HasColumnName("fecha_registro").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.UsuarioRegistro).HasColumnName("usuario_registro").HasColumnType("INT");
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
        }
    }
}
