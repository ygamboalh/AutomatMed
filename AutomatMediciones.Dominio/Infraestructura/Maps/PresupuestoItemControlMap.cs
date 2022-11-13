using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class PresupuestoItemControlMap : IEntityTypeConfiguration<PresupuestoItemControl>
    {
        public void Configure(EntityTypeBuilder<PresupuestoItemControl> builder)
        {
            builder.ToTable("presupuesto_item_control");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.FechaRegistro).HasColumnName("fecha_registro").HasColumnType("DATETIME").IsRequired();
          
        }
    }
}
