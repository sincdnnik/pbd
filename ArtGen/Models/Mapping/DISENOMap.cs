using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class DISENOMap : EntityTypeConfiguration<DISENO>
    {
        public DISENOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DISENO);

            // Properties
            this.Property(t => t.NOMBRE_DISENO)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.DESCRIPCION_DISENO)
                .HasMaxLength(512);

            this.Property(t => t.GENERO_DISENO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TALLAJE)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DESCRIPCION_TALLAJE)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("DISENO");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");
            this.Property(t => t.ID_FOTOGRAFIA).HasColumnName("ID_FOTOGRAFIA");
            this.Property(t => t.NOMBRE_DISENO).HasColumnName("NOMBRE_DISENO");
            this.Property(t => t.DESCRIPCION_DISENO).HasColumnName("DESCRIPCION_DISENO");
            this.Property(t => t.GENERO_DISENO).HasColumnName("GENERO_DISENO");
            this.Property(t => t.TALLAJE).HasColumnName("TALLAJE");
            this.Property(t => t.DESCRIPCION_TALLAJE).HasColumnName("DESCRIPCION_TALLAJE");
        }
    }
}
