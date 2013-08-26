using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class MONITOREOMap : EntityTypeConfiguration<MONITOREO>
    {
        public MONITOREOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_PUESTO_DE_TRABAJO, t.ID_REPORTE_PRODUCCION });

            // Properties
            this.Property(t => t.ID_PUESTO_DE_TRABAJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_REPORTE_PRODUCCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INFORMACION_TRABAJO_REALIZADO)
                .IsRequired()
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("MONITOREO");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.ID_REPORTE_PRODUCCION).HasColumnName("ID_REPORTE_PRODUCCION");
            this.Property(t => t.INFORMACION_TRABAJO_REALIZADO).HasColumnName("INFORMACION_TRABAJO_REALIZADO");

            // Relationships
            this.HasRequired(t => t.PUESTO_TRABAJO)
                .WithMany(t => t.MONITOREOs)
                .HasForeignKey(d => d.ID_PUESTO_DE_TRABAJO);
            this.HasRequired(t => t.REPORTE_PRODUCCION)
                .WithMany(t => t.MONITOREOs)
                .HasForeignKey(d => d.ID_REPORTE_PRODUCCION);

        }
    }
}
