using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class PUESTO_TRABAJO
    {
        public PUESTO_TRABAJO()
        {
            this.MONITOREOs = new List<MONITOREO>();
        }

        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public string NOMBRE_PUESTO { get; set; }
        public string DESCRIPCION_PUESTO { get; set; }
        public virtual ICollection<MONITOREO> MONITOREOs { get; set; }
    }
}
