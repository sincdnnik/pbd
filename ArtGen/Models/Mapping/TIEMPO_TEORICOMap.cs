using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class TIEMPO_TEORICOMap : EntityTypeConfiguration<TIEMPO_TEORICO>
    {
        public TIEMPO_TEORICOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_DISENO, t.ID_PUESTO_DE_TRABAJO });

            // Properties
            this.Property(t => t.ID_DISENO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_PUESTO_DE_TRABAJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TIEMPO_TEORICO");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.TIEMPO_ESTIMADO).HasColumnName("TIEMPO_ESTIMADO");

            // Relationships
            this.HasRequired(t => t.DISENO)
                .WithMany(t => t.TIEMPO_TEORICO)
                .HasForeignKey(d => d.ID_DISENO);

        }
    }
}
