using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class TIEMPO_REALMap : EntityTypeConfiguration<TIEMPO_REAL>
    {
        public TIEMPO_REALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_PUESTO_DE_TRABAJO, t.ID_PRODUCTO });

            // Properties
            this.Property(t => t.ID_PUESTO_DE_TRABAJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_PRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TIEMPO_REAL");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.ID_PRODUCTO).HasColumnName("ID_PRODUCTO");
            this.Property(t => t.TIEMPO_LLEGADA).HasColumnName("TIEMPO_LLEGADA");
            this.Property(t => t.TIEMPO_SALIDA).HasColumnName("TIEMPO_SALIDA");

            // Relationships
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.TIEMPO_REAL)
                .HasForeignKey(d => d.ID_PRODUCTO);

        }
    }
}
