using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class INCLUSIONMap : EntityTypeConfiguration<INCLUSION>
    {
        public INCLUSIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_OS, t.ID_DISENO });

            // Properties
            this.Property(t => t.ID_OS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_DISENO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COLOR)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.DETALLES_ADICIONALES)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("INCLUSION");
            this.Property(t => t.ID_OS).HasColumnName("ID_OS");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");
            this.Property(t => t.ID_REPORTE_PRODUCCION).HasColumnName("ID_REPORTE_PRODUCCION");
            this.Property(t => t.COLOR).HasColumnName("COLOR");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.DETALLES_ADICIONALES).HasColumnName("DETALLES_ADICIONALES");

            // Relationships
            this.HasRequired(t => t.ORDEN_DE_SERVICIO)
                .WithMany(t => t.INCLUSIONs)
                .HasForeignKey(d => d.ID_OS);

        }
    }
}
