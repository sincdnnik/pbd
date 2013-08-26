using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class FOTOGRAFIAMap : EntityTypeConfiguration<FOTOGRAFIA>
    {
        public FOTOGRAFIAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_FOTOGRAFIA);

            // Properties
            this.Property(t => t.URL_FOTOGRAFIA)
                .IsRequired()
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("FOTOGRAFIA");
            this.Property(t => t.ID_FOTOGRAFIA).HasColumnName("ID_FOTOGRAFIA");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");
            this.Property(t => t.URL_FOTOGRAFIA).HasColumnName("URL_FOTOGRAFIA");

            // Relationships
            this.HasRequired(t => t.DISENO)
                .WithMany(t => t.FOTOGRAFIAs)
                .HasForeignKey(d => d.ID_DISENO);

        }
    }
}
