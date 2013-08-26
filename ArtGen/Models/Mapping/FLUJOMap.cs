using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class FLUJOMap : EntityTypeConfiguration<FLUJO>
    {
        public FLUJOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_PUESTO_ANTERIOR, t.ID_PUESTO_SIGUIENTE });

            // Properties
            this.Property(t => t.ID_PUESTO_ANTERIOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_PUESTO_SIGUIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FLUJO");
            this.Property(t => t.ID_PUESTO_ANTERIOR).HasColumnName("ID_PUESTO_ANTERIOR");
            this.Property(t => t.ID_PUESTO_SIGUIENTE).HasColumnName("ID_PUESTO_SIGUIENTE");
        }
    }
}
