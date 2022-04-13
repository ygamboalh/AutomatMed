using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("ingresos");

            builder.HasKey(x => x.IngresoId);
            builder.Property(x => x.IngresoId).HasColumnName("ingreso_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.EmpresaId).HasColumnName("empresa_id").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.NombreEmpresa).HasColumnName("nombre_empresa").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.ContactoId).HasColumnName("contacto_id").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.NombreContacto).HasColumnName("nombre_contacto").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.CorreoElectronicoId).HasColumnName("correo_electronico_id").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.DireccionCorreoElectronico).HasColumnName("direccion_correo").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.EstadoId).HasColumnName("estado_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TipoTrabajoId).HasColumnName("tipo_trabajo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Prioridad).HasColumnName("prioridad").HasColumnType("INT").IsRequired();
            builder.Property(x => x.CuerpoCorreo).HasColumnName("cuerpo_correo").HasColumnType("VARCHAR(3000)");
            builder.Property(x => x.FechaRegistro).HasColumnName("fecha_registro").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.UsuarioRegistro).HasColumnName("usuario_registro").HasColumnType("INT");
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();

            builder.HasMany(x => x.IngresosInstrumentos).WithOne(x => x.Ingreso).HasForeignKey(x => x.IngresoId);
        }
    }
}
