using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class ORDEN_DE_SERVICIO
    {
        public ORDEN_DE_SERVICIO()
        {
            this.HISTORIAL_DE_AVANCE = new List<HISTORIAL_DE_AVANCE>();
            this.INCLUSIONs = new List<INCLUSION>();
        }

        public int ID_OS { get; set; }
        public int ID_ESTADO { get; set; }
        public int RUT { get; set; }
        public string COMENTARIO_OS { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public Nullable<System.DateTime> FECHA_FINALIZACION { get; set; }
        public virtual ICollection<HISTORIAL_DE_AVANCE> HISTORIAL_DE_AVANCE { get; set; }
        public virtual ICollection<INCLUSION> INCLUSIONs { get; set; }
    }
}
