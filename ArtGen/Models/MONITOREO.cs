using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class MONITOREO
    {
        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public int ID_REPORTE_PRODUCCION { get; set; }
        public string INFORMACION_TRABAJO_REALIZADO { get; set; }
        public virtual PUESTO_TRABAJO PUESTO_TRABAJO { get; set; }
        public virtual REPORTE_PRODUCCION REPORTE_PRODUCCION { get; set; }
    }
}
