using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class REPORTE_PRODUCCION
    {
        public REPORTE_PRODUCCION()
        {
            this.MONITOREOs = new List<MONITOREO>();
        }

        public int ID_REPORTE_PRODUCCION { get; set; }
        public int ID_OS { get; set; }
        public int ID_DISENO { get; set; }
        public int ID_MENSAJE { get; set; }
        public string INFORMACION_PRODUCCION { get; set; }
        public int PORCENTAJE_AVANCE { get; set; }
        public virtual INCLUSION INCLUSION { get; set; }
        public virtual ICollection<MONITOREO> MONITOREOs { get; set; }
    }
}
