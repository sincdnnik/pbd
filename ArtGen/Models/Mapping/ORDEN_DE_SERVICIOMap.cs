using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class ORDEN_DE_SERVICIOMap : EntityTypeConfiguration<ORDEN_DE_SERVICIO>
    {
        public ORDEN_DE_SERVICIOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_OS);

            // Properties
            this.Property(t => t.COMENTARIO_OS)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("ORDEN_DE_SERVICIO");
            this.Property(t => t.ID_OS).HasColumnName("ID_OS");
            this.Property(t => t.ID_ESTADO).HasColumnName("ID_ESTADO");
            this.Property(t => t.RUT).HasColumnName("RUT");
            this.Property(t => t.COMENTARIO_OS).HasColumnName("COMENTARIO_OS");
            this.Property(t => t.FECHA_INICIO).HasColumnName("FECHA_INICIO");
            this.Property(t => t.FECHA_FINALIZACION).HasColumnName("FECHA_FINALIZACION");
        }
    }
}
