using System;
using System.Collections.Generic;

namespace ArtGen.Models
{
    public partial class PROVEEDOR
    {
        public PROVEEDOR()
        {
            this.OFERTAs = new List<OFERTA>();
        }

        public int RUT { get; set; }
        public string INFORMACION_ADICIONAL { get; set; }
        public virtual ICollection<OFERTA> OFERTAs { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}
