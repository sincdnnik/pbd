using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class FOTOGRAFIA
    {
        public int ID_FOTOGRAFIA { get; set; }
        public int ID_DISENO { get; set; }
        public string URL_FOTOGRAFIA { get; set; }
        public virtual DISENO DISENO { get; set; }
    }
}
