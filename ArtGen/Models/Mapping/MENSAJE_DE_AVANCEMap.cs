using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class MENSAJE_DE_AVANCEMap : EntityTypeConfiguration<MENSAJE_DE_AVANCE>
    {
        public MENSAJE_DE_AVANCEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_MENSAJE);

            // Properties
            this.Property(t => t.MENSAJE)
                .IsRequired()
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("MENSAJE_DE_AVANCE");
            this.Property(t => t.ID_MENSAJE).HasColumnName("ID_MENSAJE");
            this.Property(t => t.MENSAJE).HasColumnName("MENSAJE");
        }
    }
}
