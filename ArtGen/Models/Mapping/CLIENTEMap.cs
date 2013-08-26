using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class CLIENTEMap : EntityTypeConfiguration<CLIENTE>
    {
        public CLIENTEMap()
        {
            // Primary Key
            this.HasKey(t => t.RUT);

            // Properties
            this.Property(t => t.RUT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ORGANIZACION)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("CLIENTE");
            this.Property(t => t.RUT).HasColumnName("RUT");
            this.Property(t => t.ORGANIZACION).HasColumnName("ORGANIZACION");

            // Relationships
            this.HasRequired(t => t.PERSONA)
                .WithOptional(t => t.CLIENTE);

        }
    }
}
