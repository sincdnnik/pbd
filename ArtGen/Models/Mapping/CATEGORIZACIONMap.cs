using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class CATEGORIZACIONMap : EntityTypeConfiguration<CATEGORIZACION>
    {
        public CATEGORIZACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_CATEGORIA, t.ID_DISENO });

            // Properties
            this.Property(t => t.ID_CATEGORIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_DISENO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CATEGORIZACION");
            this.Property(t => t.ID_CATEGORIA).HasColumnName("ID_CATEGORIA");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");

            // Relationships
            this.HasRequired(t => t.DISENO)
                .WithMany(t => t.CATEGORIZACIONs)
                .HasForeignKey(d => d.ID_DISENO);

        }
    }
}
