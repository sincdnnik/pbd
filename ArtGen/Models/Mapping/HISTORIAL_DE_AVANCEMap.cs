using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class HISTORIAL_DE_AVANCEMap : EntityTypeConfiguration<HISTORIAL_DE_AVANCE>
    {
        public HISTORIAL_DE_AVANCEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_OS, t.ID_REGISTRO });

            // Properties
            this.Property(t => t.ID_OS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_REGISTRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("HISTORIAL_DE_AVANCE");
            this.Property(t => t.ID_OS).HasColumnName("ID_OS");
            this.Property(t => t.ID_REGISTRO).HasColumnName("ID_REGISTRO");
            this.Property(t => t.ID_ESTADO).HasColumnName("ID_ESTADO");
            this.Property(t => t.FECHA_DE_AVANCE).HasColumnName("FECHA_DE_AVANCE");

            // Relationships
            this.HasRequired(t => t.ORDEN_DE_SERVICIO)
                .WithMany(t => t.HISTORIAL_DE_AVANCE)
                .HasForeignKey(d => d.ID_OS);

        }
    }
}
