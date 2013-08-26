using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class USUARIOMap : EntityTypeConfiguration<USUARIO>
    {
        public USUARIOMap()
        {
            // Primary Key
            this.HasKey(t => t.USERNAME);

            // Properties
            this.Property(t => t.USERNAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PASSWORD)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.NOMBRE)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.MAIL)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FONO)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("USUARIO");
            this.Property(t => t.USERNAME).HasColumnName("USERNAME");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.MAIL).HasColumnName("MAIL");
            this.Property(t => t.FONO).HasColumnName("FONO");
            this.Property(t => t.CARGO).HasColumnName("CARGO");
        }
    }
}
