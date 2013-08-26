using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class MATERIALMap : EntityTypeConfiguration<MATERIAL>
    {
        public MATERIALMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_MATERIAL);

            // Properties
            this.Property(t => t.NOMBRE_MATERIAL)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ESPECIFICACION)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("MATERIAL");
            this.Property(t => t.ID_MATERIAL).HasColumnName("ID_MATERIAL");
            this.Property(t => t.NOMBRE_MATERIAL).HasColumnName("NOMBRE_MATERIAL");
            this.Property(t => t.ESPECIFICACION).HasColumnName("ESPECIFICACION");
        }
    }
}
