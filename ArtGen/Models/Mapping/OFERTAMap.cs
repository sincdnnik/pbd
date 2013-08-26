using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class OFERTAMap : EntityTypeConfiguration<OFERTA>
    {
        public OFERTAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_MATERIAL, t.RUT });

            // Properties
            this.Property(t => t.ID_MATERIAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RUT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UNIDAD_OFERTA)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("OFERTA");
            this.Property(t => t.ID_MATERIAL).HasColumnName("ID_MATERIAL");
            this.Property(t => t.RUT).HasColumnName("RUT");
            this.Property(t => t.UNIDAD_OFERTA).HasColumnName("UNIDAD_OFERTA");
            this.Property(t => t.PRECIO_UNIDAD).HasColumnName("PRECIO_UNIDAD");

            // Relationships
            this.HasRequired(t => t.MATERIAL)
                .WithMany(t => t.OFERTAs)
                .HasForeignKey(d => d.ID_MATERIAL);
            this.HasRequired(t => t.PROVEEDOR)
                .WithMany(t => t.OFERTAs)
                .HasForeignKey(d => d.RUT);

        }
    }
}
