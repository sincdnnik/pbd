using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ArtGen.Models.Mapping;

namespace ArtGen.Models
{
    public partial class arte_generoContext : DbContext
    {
        static arte_generoContext()
        {
            Database.SetInitializer<arte_generoContext>(null);
        }

        public arte_generoContext()
            : base("Name=arte_generoContext")
        {
        }

        public DbSet<AUDITORIA> AUDITORIAs { get; set; }
        public DbSet<CATEGORIA> CATEGORIAs { get; set; }
        public DbSet<CATEGORIZACION> CATEGORIZACIONs { get; set; }
        public DbSet<CLIENTE> CLIENTEs { get; set; }
        public DbSet<DISENO> DISENOes { get; set; }
        public DbSet<ESTADO> ESTADOes { get; set; }
        public DbSet<FLUJO> FLUJOes { get; set; }
        public DbSet<FOTOGRAFIA> FOTOGRAFIAs { get; set; }
        public DbSet<HISTORIAL_DE_AVANCE> HISTORIAL_DE_AVANCE { get; set; }
        public DbSet<INCLUSION> INCLUSIONs { get; set; }
        public DbSet<MATERIAL> MATERIALs { get; set; }
        public DbSet<MENSAJE_DE_AVANCE> MENSAJE_DE_AVANCE { get; set; }
        public DbSet<MONITOREO> MONITOREOs { get; set; }
        public DbSet<OFERTA> OFERTAs { get; set; }
        public DbSet<ORDEN_DE_SERVICIO> ORDEN_DE_SERVICIO { get; set; }
        public DbSet<PERSONA> PERSONAs { get; set; }
        public DbSet<PRODUCTO> PRODUCTOes { get; set; }
        public DbSet<PROGRAMACION> PROGRAMACIONs { get; set; }
        public DbSet<PROVEEDOR> PROVEEDORs { get; set; }
        public DbSet<PUESTO_TRABAJO> PUESTO_TRABAJO { get; set; }
        public DbSet<REPORTE_PRODUCCION> REPORTE_PRODUCCION { get; set; }
        public DbSet<TIEMPO_REAL> TIEMPO_REAL { get; set; }
        public DbSet<TIEMPO_TEORICO> TIEMPO_TEORICO { get; set; }
        public DbSet<TRANSICIONES_POSIBLES> TRANSICIONES_POSIBLES { get; set; }
        public DbSet<USO_REAL> USO_REAL { get; set; }
        public DbSet<USO_TEORICO> USO_TEORICO { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
        public DbSet<DISENOS_POR_CATEGORIA> DISENOS_POR_CATEGORIA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AUDITORIAMap());
            modelBuilder.Configurations.Add(new CATEGORIAMap());
            modelBuilder.Configurations.Add(new CATEGORIZACIONMap());
            modelBuilder.Configurations.Add(new CLIENTEMap());
            modelBuilder.Configurations.Add(new DISENOMap());
            modelBuilder.Configurations.Add(new ESTADOMap());
            modelBuilder.Configurations.Add(new FLUJOMap());
            modelBuilder.Configurations.Add(new FOTOGRAFIAMap());
            modelBuilder.Configurations.Add(new HISTORIAL_DE_AVANCEMap());
            modelBuilder.Configurations.Add(new INCLUSIONMap());
            modelBuilder.Configurations.Add(new MATERIALMap());
            modelBuilder.Configurations.Add(new MENSAJE_DE_AVANCEMap());
            modelBuilder.Configurations.Add(new MONITOREOMap());
            modelBuilder.Configurations.Add(new OFERTAMap());
            modelBuilder.Configurations.Add(new ORDEN_DE_SERVICIOMap());
            modelBuilder.Configurations.Add(new PERSONAMap());
            modelBuilder.Configurations.Add(new PRODUCTOMap());
            modelBuilder.Configurations.Add(new PROGRAMACIONMap());
            modelBuilder.Configurations.Add(new PROVEEDORMap());
            modelBuilder.Configurations.Add(new PUESTO_TRABAJOMap());
            modelBuilder.Configurations.Add(new REPORTE_PRODUCCIONMap());
            modelBuilder.Configurations.Add(new TIEMPO_REALMap());
            modelBuilder.Configurations.Add(new TIEMPO_TEORICOMap());
            modelBuilder.Configurations.Add(new TRANSICIONES_POSIBLESMap());
            modelBuilder.Configurations.Add(new USO_REALMap());
            modelBuilder.Configurations.Add(new USO_TEORICOMap());
            modelBuilder.Configurations.Add(new USUARIOMap());
            modelBuilder.Configurations.Add(new DISENOS_POR_CATEGORIAMap());
        }
    }
}
