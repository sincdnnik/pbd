using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class USO_REALMap : EntityTypeConfiguration<USO_REAL>
    {
        public USO_REALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_PRODUCTO, t.ID_MATERIAL, t.ID_PUESTO_DE_TRABAJO });

            // Properties
            this.Property(t => t.ID_PRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_MATERIAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_PUESTO_DE_TRABAJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UNIDAD)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("USO_REAL");
            this.Property(t => t.ID_PRODUCTO).HasColumnName("ID_PRODUCTO");
            this.Property(t => t.ID_MATERIAL).HasColumnName("ID_MATERIAL");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.CANTIDAD_CONSUMIDA).HasColumnName("CANTIDAD_CONSUMIDA");
            this.Property(t => t.UNIDAD).HasColumnName("UNIDAD");
        }
    }
}
