using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.TIEMPO_REAL = new List<TIEMPO_REAL>();
        }

        public int ID_PRODUCTO { get; set; }
        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public int ID_REPORTE_PRODUCCION { get; set; }
        public string DETALLE_PRODUCTO { get; set; }
        public virtual ICollection<TIEMPO_REAL> TIEMPO_REAL { get; set; }
    }
}
