﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class InstrumentoMap : IEntityTypeConfiguration<Instrumento>
    {
        public void Configure(EntityTypeBuilder<Instrumento> builder)
        {
            builder.ToTable("instrumentos");

            builder.HasKey(x => x.InstrumentoId);
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.MarcaId).HasColumnName("marca_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ModeloId).HasColumnName("modelo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.NumeroSerie).HasColumnName("numero_serie").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.FechaCompraFabricante).HasColumnName("fecha_compra_fabricante").HasColumnType("DATETIME");
            builder.Property(x => x.FechaCompraCliente).HasColumnName("fecha_compra_cliente").HasColumnType("DATETIME");
            builder.Property(x => x.FechaUltimaCalibracion).HasColumnName("fecha_ultima_calibracion").HasColumnType("DATETIME");
            builder.Property(x => x.PeriodoCalibracionId).HasColumnName("periodo_calibracion_id").HasColumnType("INT");
            builder.Property(x => x.FechaProximaCalibracion).HasColumnName("fecha_proxima_calibracion").HasColumnType("DATETIME");
            builder.Property(x => x.GarantiaId).HasColumnName("garantia_id").HasColumnType("INT");
            builder.Property(x => x.EmpresaId).HasColumnName("empresa_id").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.NombreEmpresa).HasColumnName("nombre_empresa").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.FechaRegistro).HasColumnName("fecha_registro").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.UsuarioRegistro).HasColumnName("usuario_registro").HasColumnType("INT");
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
        }
    }
}
