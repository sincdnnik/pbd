using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class ESTADOMap : EntityTypeConfiguration<ESTADO>
    {
        public ESTADOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_ESTADO);

            // Properties
            this.Property(t => t.NOMBRE_ESTADO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.DESCRIPCION_ESTADO)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("ESTADO");
            this.Property(t => t.ID_ESTADO).HasColumnName("ID_ESTADO");
            this.Property(t => t.NOMBRE_ESTADO).HasColumnName("NOMBRE_ESTADO");
            this.Property(t => t.DESCRIPCION_ESTADO).HasColumnName("DESCRIPCION_ESTADO");
        }
    }
}
