using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    internal class PresupuestoControlMap : IEntityTypeConfiguration<PresupuestoControl>
    {
        public void Configure(EntityTypeBuilder<PresupuestoControl> builder)
        {
            builder.ToTable("presupuesto_control");


            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(p => p.FechaRegistro).HasColumnName("fecha_registro").HasColumnType("DATETIME");
        }
    }
}
