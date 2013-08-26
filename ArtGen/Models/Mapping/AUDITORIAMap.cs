using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ArtGen.Models.Mapping
{
    public class AUDITORIAMap : EntityTypeConfiguration<AUDITORIA>
    {
        public AUDITORIAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_ENTRADA);

            // Properties
            this.Property(t => t.NOMBRE_TABLA)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.OPERACION)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.INSTRUCCION_SQL)
                .IsRequired();

            this.Property(t => t.DATOS_ANTES)
                .HasMaxLength(1024);

            this.Property(t => t.DATOS_DESPUES)
                .HasMaxLength(1024);

            this.Property(t => t.USUARIO)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("AUDITORIA");
            this.Property(t => t.ID_ENTRADA).HasColumnName("ID_ENTRADA");
            this.Property(t => t.NOMBRE_TABLA).HasColumnName("NOMBRE_TABLA");
            this.Property(t => t.OPERACION).HasColumnName("OPERACION");
            this.Property(t => t.INSTRUCCION_SQL).HasColumnName("INSTRUCCION_SQL");
            this.Property(t => t.FECHA_Y_HORA).HasColumnName("FECHA_Y_HORA");
            this.Property(t => t.DATOS_ANTES).HasColumnName("DATOS_ANTES");
            this.Property(t => t.DATOS_DESPUES).HasColumnName("DATOS_DESPUES");
            this.Property(t => t.USUARIO).HasColumnName("USUARIO");
        }
    }
}
