using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class DISENOS_POR_CATEGORIAMap : EntityTypeConfiguration<DISENOS_POR_CATEGORIA>
    {
        public DISENOS_POR_CATEGORIAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Categoria, t.Traje });

            // Properties
            this.Property(t => t.Categoria)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Traje)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("DISENOS_POR_CATEGORIA");
            this.Property(t => t.Categoria).HasColumnName("Categoria");
            this.Property(t => t.Traje).HasColumnName("Traje");
        }
    }
}
