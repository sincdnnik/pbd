using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class TRANSICIONES_POSIBLESMap : EntityTypeConfiguration<TRANSICIONES_POSIBLES>
    {
        public TRANSICIONES_POSIBLESMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_ESTADO_LLEGADA, t.ID_ESTADO_SIGUIENTE });

            // Properties
            this.Property(t => t.ID_ESTADO_LLEGADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_ESTADO_SIGUIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TRANSICIONES_POSIBLES");
            this.Property(t => t.ID_ESTADO_LLEGADA).HasColumnName("ID_ESTADO_LLEGADA");
            this.Property(t => t.ID_ESTADO_SIGUIENTE).HasColumnName("ID_ESTADO_SIGUIENTE");
        }
    }
}
