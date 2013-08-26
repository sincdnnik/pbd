using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class PUESTO_TRABAJOMap : EntityTypeConfiguration<PUESTO_TRABAJO>
    {
        public PUESTO_TRABAJOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_PUESTO_DE_TRABAJO);

            // Properties
            this.Property(t => t.NOMBRE_PUESTO)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.DESCRIPCION_PUESTO)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("PUESTO_TRABAJO");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.NOMBRE_PUESTO).HasColumnName("NOMBRE_PUESTO");
            this.Property(t => t.DESCRIPCION_PUESTO).HasColumnName("DESCRIPCION_PUESTO");
        }
    }
}
