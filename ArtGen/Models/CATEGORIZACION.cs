using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class CATEGORIZACION
    {
        public int ID_CATEGORIA { get; set; }
        public int ID_DISENO { get; set; }
        public virtual DISENO DISENO { get; set; }
    }
}
