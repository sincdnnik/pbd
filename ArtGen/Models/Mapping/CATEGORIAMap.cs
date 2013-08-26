using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class CATEGORIAMap : EntityTypeConfiguration<CATEGORIA>
    {
        public CATEGORIAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_CATEGORIA);

            // Properties
            this.Property(t => t.NOMBRE_CATEGORIA)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.DESCRIPCION_CATEGORIA)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("CATEGORIA");
            this.Property(t => t.ID_CATEGORIA).HasColumnName("ID_CATEGORIA");
            this.Property(t => t.NOMBRE_CATEGORIA).HasColumnName("NOMBRE_CATEGORIA");
            this.Property(t => t.DESCRIPCION_CATEGORIA).HasColumnName("DESCRIPCION_CATEGORIA");
        }
    }
}
