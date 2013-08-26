using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class REPORTE_PRODUCCIONMap : EntityTypeConfiguration<REPORTE_PRODUCCION>
    {
        public REPORTE_PRODUCCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_REPORTE_PRODUCCION);

            // Properties
            this.Property(t => t.INFORMACION_PRODUCCION)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("REPORTE_PRODUCCION");
            this.Property(t => t.ID_REPORTE_PRODUCCION).HasColumnName("ID_REPORTE_PRODUCCION");
            this.Property(t => t.ID_OS).HasColumnName("ID_OS");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");
            this.Property(t => t.ID_MENSAJE).HasColumnName("ID_MENSAJE");
            this.Property(t => t.INFORMACION_PRODUCCION).HasColumnName("INFORMACION_PRODUCCION");
            this.Property(t => t.PORCENTAJE_AVANCE).HasColumnName("PORCENTAJE_AVANCE");

            // Relationships
            this.HasRequired(t => t.INCLUSION)
                .WithMany(t => t.REPORTE_PRODUCCION)
                .HasForeignKey(d => new { d.ID_OS, d.ID_DISENO });

        }
    }
}
