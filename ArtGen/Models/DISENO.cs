using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class DISENO
    {
        public DISENO()
        {
            this.CATEGORIZACIONs = new List<CATEGORIZACION>();
            this.FOTOGRAFIAs = new List<FOTOGRAFIA>();
            this.PROGRAMACIONs = new List<PROGRAMACION>();
            this.TIEMPO_TEORICO = new List<TIEMPO_TEORICO>();
            this.USO_TEORICO = new List<USO_TEORICO>();
        }

        public int ID_DISENO { get; set; }
        public Nullable<int> ID_FOTOGRAFIA { get; set; }
        public string NOMBRE_DISENO { get; set; }
        public string DESCRIPCION_DISENO { get; set; }
        public string GENERO_DISENO { get; set; }
        public string TALLAJE { get; set; }
        public string DESCRIPCION_TALLAJE { get; set; }
        public virtual ICollection<CATEGORIZACION> CATEGORIZACIONs { get; set; }
        public virtual ICollection<FOTOGRAFIA> FOTOGRAFIAs { get; set; }
        public virtual ICollection<PROGRAMACION> PROGRAMACIONs { get; set; }
        public virtual ICollection<TIEMPO_TEORICO> TIEMPO_TEORICO { get; set; }
        public virtual ICollection<USO_TEORICO> USO_TEORICO { get; set; }
    }
}
