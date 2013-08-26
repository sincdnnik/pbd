using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class PRODUCTOMap : EntityTypeConfiguration<PRODUCTO>
    {
        public PRODUCTOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_PRODUCTO);

            // Properties
            this.Property(t => t.DETALLE_PRODUCTO)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("PRODUCTO");
            this.Property(t => t.ID_PRODUCTO).HasColumnName("ID_PRODUCTO");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.ID_REPORTE_PRODUCCION).HasColumnName("ID_REPORTE_PRODUCCION");
            this.Property(t => t.DETALLE_PRODUCTO).HasColumnName("DETALLE_PRODUCTO");
        }
    }
}
