using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class PERSONAMap : EntityTypeConfiguration<PERSONA>
    {
        public PERSONAMap()
        {
            // Primary Key
            this.HasKey(t => t.RUT);

            // Properties
            this.Property(t => t.RUT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOMBRE)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.REGION)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.CIUDAD)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.DIRECCION)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.MAIL)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("PERSONA");
            this.Property(t => t.RUT).HasColumnName("RUT");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.REGION).HasColumnName("REGION");
            this.Property(t => t.CIUDAD).HasColumnName("CIUDAD");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.MAIL).HasColumnName("MAIL");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
        }
    }
}
