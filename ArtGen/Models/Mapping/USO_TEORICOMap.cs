using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class USO_TEORICOMap : EntityTypeConfiguration<USO_TEORICO>
    {
        public USO_TEORICOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_DISENO, t.ID_PUESTO_DE_TRABAJO, t.ID_MATERIAL });

            // Properties
            this.Property(t => t.ID_DISENO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_PUESTO_DE_TRABAJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_MATERIAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UNIDAD_TEORICA)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("USO_TEORICO");
            this.Property(t => t.ID_DISENO).HasColumnName("ID_DISENO");
            this.Property(t => t.ID_PUESTO_DE_TRABAJO).HasColumnName("ID_PUESTO_DE_TRABAJO");
            this.Property(t => t.ID_MATERIAL).HasColumnName("ID_MATERIAL");
            this.Property(t => t.CANTIDAD_ESTIMADA).HasColumnName("CANTIDAD_ESTIMADA");
            this.Property(t => t.UNIDAD_TEORICA).HasColumnName("UNIDAD_TEORICA");

            // Relationships
            this.HasRequired(t => t.DISENO)
                .WithMany(t => t.USO_TEORICO)
                .HasForeignKey(d => d.ID_DISENO);

        }
    }
}
