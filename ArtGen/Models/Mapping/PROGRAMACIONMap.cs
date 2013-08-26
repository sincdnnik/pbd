using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class PROGRAMACIONMap : EntityTypeConfiguration<PROGRAMACION>
    {
        public PROGRAMACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_PUESTO_ANTERIOR, t.ID_PUESTO_SIGUIENTE, t.ID_DISENO });

            // Properties
            this.Property(t => t.ID_PUESTO_ANTERIOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_PUESTO_SIGUIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_DISENO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PROGRAMACION");
            this.Property(t => t.ID_PUESTO_ANTERIOR).HasColumnName("ID_PUESTO_ANTERIOR");
            this.Property(t => t.ID_PUESTO_SIGUIENTE).HasColumnName("ID_PUESTO_SIGUIENTE");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");

            // Relationships
            this.HasRequired(t => t.DISENO)
                .WithMany(t => t.PROGRAMACIONs)
                .HasForeignKey(d => d.ID_DISENO);

        }
    }
}
