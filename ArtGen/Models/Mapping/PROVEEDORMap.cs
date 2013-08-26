using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class PROVEEDORMap : EntityTypeConfiguration<PROVEEDOR>
    {
        public PROVEEDORMap()
        {
            // Primary Key
            this.HasKey(t => t.RUT);

            // Properties
            this.Property(t => t.RUT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INFORMACION_ADICIONAL)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("PROVEEDOR");
            this.Property(t => t.RUT).HasColumnName("RUT");
            this.Property(t => t.INFORMACION_ADICIONAL).HasColumnName("INFORMACION_ADICIONAL");

            // Relationships
            this.HasRequired(t => t.PERSONA)
                .WithOptional(t => t.PROVEEDOR);

        }
    }
}
