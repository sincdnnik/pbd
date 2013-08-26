using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class INCLUSION
    {
        public INCLUSION()
        {
            this.REPORTE_PRODUCCION = new List<REPORTE_PRODUCCION>();
        }

        public int ID_OS { get; set; }
        public int ID_DISENO { get; set; }
        public Nullable<int> ID_REPORTE_PRODUCCION { get; set; }
        public string COLOR { get; set; }
        public int CANTIDAD { get; set; }
        public string DETALLES_ADICIONALES { get; set; }
        public virtual ORDEN_DE_SERVICIO ORDEN_DE_SERVICIO { get; set; }
        public virtual ICollection<REPORTE_PRODUCCION> REPORTE_PRODUCCION { get; set; }
    }
}
