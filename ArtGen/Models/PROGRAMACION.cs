using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class PROGRAMACION
    {
        public int ID_PUESTO_ANTERIOR { get; set; }
        public int ID_PUESTO_SIGUIENTE { get; set; }
        public int ID_DISENO { get; set; }
        public virtual DISENO DISENO { get; set; }
    }
}
