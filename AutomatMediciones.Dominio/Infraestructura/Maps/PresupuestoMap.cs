using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class PresupuestoMap : IEntityTypeConfiguration<Presupuesto>
    {
        public void Configure(EntityTypeBuilder<Presupuesto> builder)
        {
            builder.ToTable("presupuestos");

            builder.HasKey(x => x.RecID);
            builder.Property(x => x.RecID).HasColumnName("RecID").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.IDRef).HasColumnName("IDRef").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDCampania).HasColumnName("IDCampania").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.FechaCreacion).HasColumnName("FechaCreacion").HasColumnType("DATETIME");
            builder.Property(x => x.Nombre).HasColumnName("Nombre").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.ID).HasColumnName("ID").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Revision).HasColumnName("Revision").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Estado).HasColumnName("Estado").HasColumnType("TINYINT");
            builder.Property(x => x.NroMoneda).HasColumnName("NroMoneda").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("DATETIME");
            builder.Property(x => x.IDContrato).HasColumnName("IDContrato").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.MostrarImpuestos).HasColumnName("MostrarImpuestos").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.MotivoCierre).HasColumnName("MotivoCierre").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Introduccion).HasColumnName("Introduccion").HasColumnType("MEDIUMTEXT").IsRequired();
            builder.Property(x => x.Cierre).HasColumnName("Cierre").HasColumnType("MEDIUMTEXT").IsRequired();
            builder.Property(x => x.IDConsulta).HasColumnName("IDConsulta").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Subtotal).HasColumnName("Subtotal").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.SubTotal2).HasColumnName("SubTotal2").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.Impuesto).HasColumnName("Impuesto").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImpuestosInternos).HasColumnName("ImpuestosInternos").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.Descuento).HasColumnName("Descuento").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.Total).HasColumnName("Total").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.Validez).HasColumnName("Validez").HasColumnType("INT");
            builder.Property(x => x.EmbalajeIM).HasColumnName("EmbalajeIM").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.EmbalajeIF).HasColumnName("EmbalajeIF").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.GastosIM).HasColumnName("GastosIM").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.GastosIF).HasColumnName("GastosIF").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.TransPuertoIM).HasColumnName("TransPuertoIM").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.TransPuertoIF).HasColumnName("TransPuertoIF").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.FleteIntIF).HasColumnName("FleteIntIF").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.FleteIntIM).HasColumnName("FleteIntIM").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.SeguroIM).HasColumnName("SeguroIM").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.SeguroIF).HasColumnName("SeguroIF").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.TipoEW).HasColumnName("TipoEW").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.IDFormula).HasColumnName("IDFormula").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.TipoComision).HasColumnName("TipoComision").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.PorcentajeComision).HasColumnName("PorcentajeComision").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ImporteComision).HasColumnName("ImporteComision").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.NroMonedaComision).HasColumnName("NroMonedaComision").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Escenario).HasColumnName("Escenario").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.FechaCierre).HasColumnName("FechaCierre").HasColumnType("DATETIME");
            builder.Property(x => x.Origen).HasColumnName("Origen").HasColumnType("TINYINT");
            builder.Property(x => x.ExcluirAnalisis).HasColumnName("ExcluirAnalisis").HasColumnType("TINYINT");
            builder.Property(x => x.IDUsuario).HasColumnName("IDUsuario").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDUsuarioAutorizacion).HasColumnName("IDUsuarioAutorizacion").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDUsuarioCreacion).HasColumnName("IDUsuarioCreacion").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Tipo).HasColumnName("Tipo").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.ModalidadCliente).HasColumnName("ModalidadCliente").HasColumnType("TINYINT");
            builder.Property(x => x.Auditoria).HasColumnName("Auditoria").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.CustomID).HasColumnName("CustomID").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.ActualizarAuto).HasColumnName("ActualizarAuto").HasColumnType("TINYINT");
        }
    }
}
