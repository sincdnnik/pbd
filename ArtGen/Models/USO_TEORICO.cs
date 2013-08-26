using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class USO_TEORICO
    {
        public int ID_DISENO { get; set; }
        public int ID_PUESTO_DE_TRABAJO { get; set; }
        public int ID_MATERIAL { get; set; }
        public int CANTIDAD_ESTIMADA { get; set; }
        public string UNIDAD_TEORICA { get; set; }
        public virtual DISENO DISENO { get; set; }
    }
}
