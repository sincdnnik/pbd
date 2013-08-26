using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class TIEMPO_TEORICO
    {
        public int ID_DISENO { get; set; }
        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public int TIEMPO_ESTIMADO { get; set; }
        public virtual DISENO DISENO { get; set; }
    }
}
